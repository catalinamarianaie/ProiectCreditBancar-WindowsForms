using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Proiect
{
    public partial class FormCreareCont : Form
    {
        public FormCreareCont()
        {
            InitializeComponent();
            cmbTipCont.Items.Add("admin");
            cmbTipCont.Items.Add("utilizator");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nume = txtNume.Text.Trim();
            string prenume = txtPrenume.Text.Trim();
            string varsta = txtVarsta.Text.Trim();
            string tipCont = cmbTipCont.Text.Trim();
            string username = txtUsername.Text.Trim();
            string parola = txtParola.Text.Trim();

            if (string.IsNullOrWhiteSpace(nume) || string.IsNullOrWhiteSpace(prenume) ||
                string.IsNullOrWhiteSpace(varsta) || string.IsNullOrWhiteSpace(tipCont) ||
                string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(parola))
            {
                MessageBox.Show("Completează toate câmpurile!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connString = "Data Source=utilizatori.db;Version=3;";
            using (var conn = new SQLiteConnection(connString))
            {
                conn.Open();

                
                string checkQuery = "SELECT COUNT(*) FROM Utilizatori WHERE Username = @u";
                var checkCmd = new SQLiteCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@u", username);

                int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Username-ul există deja!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Inserăm contul
                string insertQuery = "INSERT INTO Utilizatori (Username, Parola, TipCont) VALUES (@u, @p, @t)";
                var insertCmd = new SQLiteCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@u", username);
                insertCmd.Parameters.AddWithValue("@p", parola);
                insertCmd.Parameters.AddWithValue("@t", tipCont);

                try
                {
                    insertCmd.ExecuteNonQuery();
                    MessageBox.Show("Cont creat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la salvare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbTipCont_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
