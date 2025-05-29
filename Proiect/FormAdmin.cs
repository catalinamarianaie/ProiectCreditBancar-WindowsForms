using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Proiect
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Nu există date de exportat.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog.Title = "Salvează ca CSV";
            saveFileDialog.FileName = "CereriExport.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
                {
                    
                    var header = string.Join(",", dataGridView1.Columns.Cast<DataGridViewColumn>().Select(c => c.HeaderText));
                    sw.WriteLine(header);

                    
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            var values = row.Cells.Cast<DataGridViewCell>().Select(cell => $"\"{cell.Value?.ToString()}\"");
                            sw.WriteLine(string.Join(",", values));
                        }
                    }
                }

                MessageBox.Show("Exportul a fost realizat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string caleFisier = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\CereriCredite.xlsx";

            if (!System.IO.File.Exists(caleFisier))
            {
                MessageBox.Show("Fișierul CereriCredite.xlsx nu există pe Desktop.");
                return;
            }

            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(caleFisier);
            Excel.Worksheet worksheet = workbook.Sheets[1];

            DataTable dt = new DataTable();

            
            for (int i = 1; i <= worksheet.UsedRange.Columns.Count; i++)
            {
                dt.Columns.Add(worksheet.Cells[1, i].Value?.ToString() ?? $"Coloana{i}");
            }

            
            for (int row = 2; row <= worksheet.UsedRange.Rows.Count; row++)
            {
                DataRow dataRow = dt.NewRow();
                for (int col = 1; col <= worksheet.UsedRange.Columns.Count; col++)
                {
                    dataRow[col - 1] = worksheet.Cells[row, col].Value?.ToString() ?? "";
                }
                dt.Rows.Add(dataRow);
            }

            workbook.Close(false);
            excelApp.Quit();

            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string caleFisier = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\CereriCredite.xlsx";

            if (!File.Exists(caleFisier))
            {
                MessageBox.Show("Fișierul cu cererile nu a fost găsit.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var excelApp = new Excel.Application();
            var workbook = excelApp.Workbooks.Open(caleFisier);
            var worksheet = (Excel.Worksheet)workbook.Sheets[1];
            int rowCount = worksheet.UsedRange.Rows.Count;

            int nrCereri = 0;
            double sumaTotala = 0;
            double scorTotal = 0;

            for (int row = 2; row <= rowCount; row++)
            {
                nrCereri++;

                double suma = 0;
                double scor = 0;

                double.TryParse(worksheet.Cells[row, 3]?.Value?.ToString(), out suma);
                string valoareScor = worksheet.Cells[row, 7]?.Value?.ToString();
                double.TryParse(valoareScor, out scor);

                sumaTotala += suma;
                scorTotal += scor;
            }

            workbook.Close(false);
            excelApp.Quit();

            label4.Text = nrCereri.ToString();
            label5.Text = $"{sumaTotala:N0} lei";
            label6.Text = nrCereri > 0 ? $"{(scorTotal / nrCereri):F1} / 100" : "N/A";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=utilizatori.db;Version=3;";

            dataGridViewConturi.Rows.Clear();
            dataGridViewConturi.Columns.Clear();

            dataGridViewConturi.Columns.Add("TipCont", "Tip Cont");
            dataGridViewConturi.Columns.Add("Username", "Username");
            dataGridViewConturi.Columns.Add("Parola", "Parolă");

            using (var conn = new SQLiteConnection(connString))
            {
                conn.Open();
                string query = "SELECT TipCont, Username, Parola FROM Utilizatori";
                var cmd = new SQLiteCommand(query, conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string tip = reader["TipCont"].ToString();
                    string user = reader["Username"].ToString();
                    string parola = reader["Parola"].ToString();

                    dataGridViewConturi.Rows.Add(tip, user, parola);
                }
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridViewConturi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectează un cont de șters!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = dataGridViewConturi.SelectedRows[0].Cells["Username"].Value.ToString();

            DialogResult result = MessageBox.Show($"Ești sigur că vrei să ștergi contul '{username}'?",
                                                  "Confirmare ștergere",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string connString = "Data Source=utilizatori.db;Version=3;";
                using (var conn = new SQLiteConnection(connString))
                {
                    conn.Open();
                    string deleteQuery = "DELETE FROM Utilizatori WHERE Username = @username";
                    var cmd = new SQLiteCommand(deleteQuery, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.ExecuteNonQuery();
                }

                // Ștergem și din DataGridView
                dataGridViewConturi.Rows.RemoveAt(dataGridViewConturi.SelectedRows[0].Index);

                MessageBox.Show("Cont șters cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            var creareCont = new FormCreareCont();
            creareCont.ShowDialog();

            button6_Click(sender, e);
        }

        private void dataGridViewConturi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
