using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;



namespace Proiect
{
    public partial class FormCerere : Form
    {
        public FormCerere()
        {
            InitializeComponent();
        }

        private void GenereazaDocumentWord(string nume, double suma, double rata, string decizie, string moneda)
        {
            var wordApp = new Word.Application();
            var doc = wordApp.Documents.Add();
            wordApp.Visible = false;

            Word.Paragraph p1 = doc.Content.Paragraphs.Add();
            p1.Range.Text = $"Stimate {nume},\n";
            p1.Range.Font.Size = 12;
            p1.Range.Font.Name = "Calibri";
            p1.Range.InsertParagraphAfter();

            Word.Paragraph p2 = doc.Content.Paragraphs.Add();
            p2.Range.Text = "În urma analizei solicitării dumneavoastră pentru un credit bancar, banca noastră a luat următoarea decizie:";
            p2.Range.Font.Size = 12;
            p2.Range.Font.Name = "Calibri";
            p2.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
            p2.Range.InsertParagraphAfter();

            
            Word.Paragraph p3 = doc.Content.Paragraphs.Add();
            p3.Range.Text = $"- Rezultat evaluare: {decizie}";
            p3.Range.Font.Size = 12;
            p3.Range.Font.Name = "Calibri";
            p3.Range.InsertParagraphAfter();

            Word.Paragraph p4 = doc.Content.Paragraphs.Add();
            p4.Range.Text = $"- Suma: {suma} {moneda}";
            p4.Range.Font.Size = 12;
            p4.Range.Font.Name = "Calibri";
            p4.Range.InsertParagraphAfter();

            Word.Paragraph p5 = doc.Content.Paragraphs.Add();
            p5.Range.Text = $"- Rată lunară estimată: {rata:F2} {moneda}";
            p5.Range.Font.Size = 12;
            p5.Range.Font.Name = "Calibri";
            p5.Range.InsertParagraphAfter();

            Word.Paragraph p6 = doc.Content.Paragraphs.Add();
            p6.Range.Text = "Vă mulțumim pentru încrederea acordată.";
            p6.Range.Font.Size = 12;
            p6.Range.Font.Name = "Calibri";
            p6.Range.InsertParagraphAfter();

            Word.Paragraph p7 = doc.Content.Paragraphs.Add();
            p7.Range.Text = "\n\nCu stimă, Echipa CreditBanc.";
            p7.Range.Font.Size = 12;
            p7.Range.Font.Name = "Calibri";
            p7.Range.Font.Italic = 1;
            p7.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
            p7.Range.InsertParagraphAfter();

            string caleFisier = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $@"\CerereCredit_{nume}_{DateTime.Now:yyyyMMdd_HHmmss}.docx";
            doc.SaveAs2(caleFisier);
            doc.Close();
            wordApp.Quit();

            MessageBox.Show($"Document Word salvat pe Desktop:\n{caleFisier}", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void ScrieInExcel(string nume, double venit, double suma, int luni, string decizie, string moneda, int scor )
        {
            
            string caleFisier = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\CereriCredite.xlsx";

            var excelApp = new Excel.Application();
            Excel.Workbook workbook;
            Excel._Worksheet worksheet;

            if (System.IO.File.Exists(caleFisier))
            {
                workbook = excelApp.Workbooks.Open(caleFisier, ReadOnly: false);
                worksheet = workbook.Sheets[1];
            }
            else
            {
                workbook = excelApp.Workbooks.Add();
                worksheet = workbook.Sheets[1];

                worksheet.Cells[1, 1] = "Nume";
                worksheet.Cells[1, 2] = "Venit";
                worksheet.Cells[1, 3] = "Suma Ceruta";
                worksheet.Cells[1, 4] = "Luni";
                worksheet.Cells[1, 5] = "Decizie";
                worksheet.Cells[1, 6] = "Moneda";
                worksheet.Cells[1, 7] = "Scor";

            }

            int row = worksheet.UsedRange.Rows.Count + 1;

            worksheet.Cells[row, 1] = nume;
            worksheet.Cells[row, 2] = venit;
            worksheet.Cells[row, 3] = suma;
            worksheet.Cells[row, 4] = luni;
            worksheet.Cells[row, 5] = decizie;
            worksheet.Cells[row, 6] = moneda;
            worksheet.Cells[row, 7] = scor;

            workbook.SaveAs(caleFisier);
            workbook.Close();
            excelApp.Quit();
        }
        private void GenereazaGraficExcel()
        {
            string caleFisier = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\CereriCredite.xlsx";

            if (!System.IO.File.Exists(caleFisier))
            {
                MessageBox.Show("Fișierul IstoricCredite.xlsx nu există!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var excelApp = new Microsoft.Office.Interop.Excel.Application();
            var workbook = excelApp.Workbooks.Open(caleFisier);
            var worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];

            int rowCount = worksheet.UsedRange.Rows.Count;

            int aprobati = 0;
            int respinsi = 0;
            int analiza = 0;
            double scorTotal = 0;
            int nrScoruri = 0;


            for (int row = 2; row <= rowCount; row++)
            {
                var decizie = worksheet.Cells[row, 5].Value?.ToString().ToLower().Trim();
                if (decizie == "aprobat")
                    aprobati++;
                else if (decizie == "respins")
                    respinsi++;
                else if (decizie.Contains("analiz"))
                    analiza++;

                var valoareScor = worksheet.Cells[row, 7]?.Value;
                double scor = 0;

                if (valoareScor != null && double.TryParse(valoareScor.ToString(), out scor))
                {
                    scorTotal += scor;
                    nrScoruri++;
                }

            }

            worksheet.Cells[1, 11] = "Status";
            worksheet.Cells[1, 12] = "Număr";
            worksheet.Cells[2, 11] = "Aprobați";
            worksheet.Cells[2, 12] = aprobati;
            worksheet.Cells[3, 11] = "Respinsi";
            worksheet.Cells[3, 12] = respinsi;
            worksheet.Cells[4, 11] = "In analiza";
            worksheet.Cells[4, 12] = analiza;


            foreach (Microsoft.Office.Interop.Excel.ChartObject existingChart in worksheet.ChartObjects())
            {
                existingChart.Delete();
            }

            var charts = (Microsoft.Office.Interop.Excel.ChartObjects)worksheet.ChartObjects();
            var chartObj = charts.Add(300, 50, 400, 300);
            var chart = chartObj.Chart;

            var dataRange = worksheet.Range["K1", "L4"];
            chart.SetSourceData(dataRange);
            chart.ChartType = Microsoft.Office.Interop.Excel.XlChartType.xlColumnClustered;

            chart.HasTitle = true;
            chart.ChartTitle.Text = "Statistici Credite (Aprobați vs Respinsi vs In analiza)";

            if (chart.SeriesCollection().Count > 0)
            {
                var serie = chart.SeriesCollection(1);


                var point1 = serie.Points(1);
                point1.Format.Fill.ForeColor.RGB = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LimeGreen);

                
                var point2 = serie.Points(2);
                point2.Format.Fill.ForeColor.RGB = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);

               
                var point3 = serie.Points(3);
                point3.Format.Fill.ForeColor.RGB = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Orange);
            }
            worksheet.Cells[6, 11] = "Media scor:";
            worksheet.Cells[6, 12] = nrScoruri > 0 ? (scorTotal / nrScoruri).ToString("F1") : "N/A";

            workbook.Save();
            workbook.Close();
            excelApp.Quit();

            MessageBox.Show("Graficul colorat a fost creat cu succes în IstoricCredite.xlsx!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new object[] { "Persoane fizice", "Prima casă", "Nevoi personale" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtNume.Text) ||
                string.IsNullOrWhiteSpace(txtVenit.Text) ||
                string.IsNullOrWhiteSpace(txtDatorii.Text) ||
                string.IsNullOrWhiteSpace(txtSuma.Text) ||
                comboBox1.SelectedIndex == -1 ||
                comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Te rog completează toate câmpurile corect!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            string nume = txtNume.Text;
            int varsta = int.Parse(numVarsta.Text);
            double venit = double.Parse(txtVenit.Text);
            double datorii = double.Parse(txtDatorii.Text);
            double suma = double.Parse(txtSuma.Text);
            int luni = int.Parse(comboBox1.Text);

           
            if (varsta < 18)
            {
                MessageBox.Show("Trebuie să ai cel puțin 18 ani pentru a aplica la un credit.", "Eroare Vârstă", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            double dobandaAnuala = 0.07;
            if (comboBox2.Text == "Prima casă")
                dobandaAnuala = 0.05;
            else if (comboBox2.Text == "Nevoi personale")
                dobandaAnuala = 0.08;
            else if (comboBox2.Text == "Persoane fizice")
                dobandaAnuala = 0.07;

            if (varsta < 25)
                dobandaAnuala += 0.01; // Penalizare tineri sub 25 ani (dobândă +1%)
            if (varsta > 60)
                dobandaAnuala += 0.02; // Penalizare vârstnici (dobândă +2%)

            double dobandaLunara = dobandaAnuala / 12;

            double rata = suma * (dobandaLunara * Math.Pow(1 + dobandaLunara, luni)) / (Math.Pow(1 + dobandaLunara, luni) - 1);

            double cursEUR = 5.0;  
            double cursUSD = 4.5; 
            string monedaSelectata = comboMoneda.SelectedItem.ToString();

            double sumaConvertita = suma;
            double rataConvertita = rata;

            if (monedaSelectata == "EUR")
            {
                sumaConvertita = suma / cursEUR;
                rataConvertita = rata / cursEUR;
            }
            else if (monedaSelectata == "USD")
            {
                sumaConvertita = suma / cursUSD;
                rataConvertita = rata / cursUSD;
            }

            int scor = 100;

            if (venit < 2000) scor -= 30;
            if (datorii > 0.5 * venit) scor -= 40;
            if (suma > 50000) scor -= 30;
            if (varsta < 22 || varsta > 60) scor -= 20;
            if (rata > 0.4 * venit) scor -= 30; 

            string decizie = "In analiza";

            if (scor >= 70)
                decizie = "APROBAT";
            else if (scor < 50)
                decizie = "RESPINS";

            lblRezultat.Text = $"{decizie}\n, Scor: {scor}/100\n, Rată lunară: {rataConvertita:F2} {monedaSelectata}";

            if (decizie == "RESPINS")
                lblRezultat.ForeColor = Color.Red;
            else if (decizie == "APROBAT")
                lblRezultat.ForeColor = Color.LimeGreen;
            else
                lblRezultat.ForeColor = Color.Orange;


            GenereazaDocumentWord(nume, suma, rata, decizie, monedaSelectata);
            ScrieInExcel(nume, venit, suma, luni, decizie, monedaSelectata, scor);
            GenereazaGraficExcel();

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new object[] { 12, 24, 36, 48, 60 });

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            comboBox1.Items.AddRange(new object[] { 12, 24, 36, 48, 60 });
            comboBox2.Items.AddRange(new object[] { "Persoane fizice", "Prima casă", "Nevoi personale" });
            comboMoneda.Items.AddRange(new object[] { "RON", "EUR", "USD" });
            comboMoneda.SelectedIndex = 0;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            txtNume.Text = "";
            numVarsta.Text = "";

            txtVenit.Text = "";
            txtDatorii.Text = "";
            txtSuma.Text = "";

            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

            lblRezultat.Text = "";
            lblRezultat.ForeColor = Color.White;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }

}
