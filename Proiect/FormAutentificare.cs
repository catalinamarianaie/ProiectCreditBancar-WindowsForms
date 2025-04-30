using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proiect
{
    public partial class FormAutentificare : Form
    {
        public FormAutentificare()
        {
            InitializeComponent();
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
            string caleFisier = "conturi.csv";

            if (!File.Exists(caleFisier))
            {
                MessageBox.Show("Nu există conturi salvate.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var linii = File.ReadAllLines(caleFisier);
            foreach (var linie in linii)
            {
                var date = linie.Split(',');
                if (date.Length >= 6 && date[4] == username && date[5] == parola)
                {
                    string tipCont = date[3];
                    MessageBox.Show("Autentificare reușită!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide(); 

                    if (tipCont.ToLower() == "admin")
                    {
                        FormAdmin adminForm = new FormAdmin();
                        adminForm.ShowDialog();
                    }
                    else
                    {
                        FormCerere cerereForm = new FormCerere();
                        cerereForm.ShowDialog();
                    }

                    this.Show(); 
                    return;
                }
            }

            MessageBox.Show("Username sau parolă incorectă.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
