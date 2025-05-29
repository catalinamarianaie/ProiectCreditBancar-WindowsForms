using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace Proiect
{
    public partial class FormAutentificare : Form
    {
        public FormAutentificare()
        {
            InitializeComponent();
            CreeazaBazaDacaNuExista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCreareCont creareCont = new FormCreareCont();
            creareCont.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string parola = txtParola.Text.Trim();

            string connString = "Data Source=utilizatori.db;Version=3;";
            using (var conn = new SQLiteConnection(connString))
            {
                conn.Open();
                string query = "SELECT TipCont FROM Utilizatori WHERE Username = @u AND Parola = @p";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", parola);

                var result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string tipCont = result.ToString();
                    MessageBox.Show("Autentificare reușită!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                    if (tipCont.ToLower() == "admin")
                    {
                        new FormAdmin().ShowDialog();
                    }
                    else
                    {
                        new FormCerere().ShowDialog();
                    }

                    this.Show();
                }
                else
                {
                    MessageBox.Show("Username sau parolă incorectă.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CreeazaBazaDacaNuExista()
        {
            string path = "utilizatori.db";
            if (!File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
            }

            string connString = $"Data Source={path};Version=3;";
            using (var conn = new SQLiteConnection(connString))
            {
                conn.Open();
                string query = @"CREATE TABLE IF NOT EXISTS Utilizatori (
                                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                    Username TEXT NOT NULL UNIQUE,
                                    Parola TEXT NOT NULL,
                                    TipCont TEXT
                                )";
                var cmd = new SQLiteCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
