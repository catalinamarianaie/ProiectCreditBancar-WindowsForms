using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                    // Scrie anteturile
                    var header = string.Join(",", dataGridView1.Columns.Cast<DataGridViewColumn>().Select(c => c.HeaderText));
                    sw.WriteLine(header);

                    // Scrie fiecare rând
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

            // Citim antetul
            for (int i = 1; i <= worksheet.UsedRange.Columns.Count; i++)
            {
                dt.Columns.Add(worksheet.Cells[1, i].Value?.ToString() ?? $"Coloana{i}");
            }

            // Citim toate datele
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
            string caleFisier = "conturi.csv";

            if (!File.Exists(caleFisier))
            {
                MessageBox.Show("Fișierul conturi.csv nu există!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var lines = File.ReadAllLines(caleFisier);
            dataGridViewConturi.Rows.Clear();
            dataGridViewConturi.Columns.Clear();

            dataGridViewConturi.Columns.Add("Nume", "Nume");
            dataGridViewConturi.Columns.Add("Prenume", "Prenume");
            dataGridViewConturi.Columns.Add("Varsta", "Vârstă");
            dataGridViewConturi.Columns.Add("TipCont", "Tip Cont");
            dataGridViewConturi.Columns.Add("Username", "Username");
            dataGridViewConturi.Columns.Add("Parola", "Parolă");

            foreach (var line in lines)
            {
                var values = line.Split(',');
                if (values.Length == 6)
                    dataGridViewConturi.Rows.Add(values);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridViewConturi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectează un cont de șters!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var username = dataGridViewConturi.SelectedRows[0].Cells["Username"].Value.ToString();

            
            string caleFisier = "conturi.csv";
            var linii = File.ReadAllLines(caleFisier).ToList();
            linii = linii.Where(l => !l.Contains(username)).ToList();
            File.WriteAllLines(caleFisier, linii);

            
            dataGridViewConturi.Rows.RemoveAt(dataGridViewConturi.SelectedRows[0].Index);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var creareCont = new FormCreareCont();
            creareCont.ShowDialog();

            button6_Click(sender, e);
        }
    }

}
