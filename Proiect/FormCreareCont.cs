using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class FormCreareCont : Form
    {
        private string caleFisier = "conturi.csv";
        public FormCreareCont()
        {
            InitializeComponent();
            cmbTipCont.Items.Add("admin");
            cmbTipCont.Items.Add("utilizator");
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

            if (File.Exists(caleFisier))
            {
                var linii = File.ReadAllLines(caleFisier);
                foreach (var linie in linii)
                {
                    var date = linie.Split(',');
                    if (date.Length >= 5 && date[4] == username)
                    {
                        MessageBox.Show("Username-ul există deja!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }


            string linieNoua = $"{nume},{prenume},{varsta},{tipCont},{username},{parola}";
            File.AppendAllText(caleFisier, linieNoua + Environment.NewLine);

            MessageBox.Show("Cont creat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); 
        }

        private void cmbTipCont_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                
        }
}
}
