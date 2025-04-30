namespace Proiect
{
    partial class FormCerere
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCerere));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtNume = new TextBox();
            numVarsta = new TextBox();
            txtVenit = new TextBox();
            txtDatorii = new TextBox();
            txtSuma = new TextBox();
            lblRezultat = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            label9 = new Label();
            comboMoneda = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.WindowFrame;
            label1.Cursor = Cursors.No;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(159, 180);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 0;
            label1.Text = "Nume complet";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.WindowFrame;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(219, 211);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 1;
            label2.Text = "Varsta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.WindowFrame;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(179, 271);
            label3.Name = "label3";
            label3.Size = new Size(93, 21);
            label3.TabIndex = 2;
            label3.Text = "Venit Lunar ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.WindowFrame;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(180, 302);
            label4.Name = "label4";
            label4.Size = new Size(92, 21);
            label4.TabIndex = 3;
            label4.Text = "Alte Datorii ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.WindowFrame;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(177, 333);
            label5.Name = "label5";
            label5.Size = new Size(95, 21);
            label5.TabIndex = 4;
            label5.Text = "Suma dorita";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.WindowFrame;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(96, 364);
            label6.Name = "label6";
            label6.Size = new Size(176, 21);
            label6.TabIndex = 5;
            label6.Text = "Perioada de rambursare";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.WindowFrame;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = SystemColors.Window;
            label7.Location = new Point(198, 395);
            label7.Name = "label7";
            label7.Size = new Size(74, 21);
            label7.TabIndex = 6;
            label7.Text = "Tip credit";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.WindowFrame;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.ForeColor = SystemColors.Window;
            label8.Location = new Point(84, 493);
            label8.Name = "label8";
            label8.Size = new Size(73, 21);
            label8.TabIndex = 7;
            label8.Text = "Rezultat";
            label8.Click += label8_Click;
            // 
            // txtNume
            // 
            txtNume.BackColor = SystemColors.WindowFrame;
            txtNume.BorderStyle = BorderStyle.FixedSingle;
            txtNume.Font = new Font("Segoe UI", 10F);
            txtNume.ForeColor = SystemColors.Window;
            txtNume.Location = new Point(319, 176);
            txtNume.Name = "txtNume";
            txtNume.Size = new Size(295, 25);
            txtNume.TabIndex = 8;
            // 
            // numVarsta
            // 
            numVarsta.BackColor = SystemColors.WindowFrame;
            numVarsta.BorderStyle = BorderStyle.FixedSingle;
            numVarsta.Font = new Font("Segoe UI", 10F);
            numVarsta.ForeColor = SystemColors.Window;
            numVarsta.Location = new Point(319, 207);
            numVarsta.Name = "numVarsta";
            numVarsta.Size = new Size(295, 25);
            numVarsta.TabIndex = 9;
            // 
            // txtVenit
            // 
            txtVenit.BackColor = SystemColors.WindowFrame;
            txtVenit.BorderStyle = BorderStyle.FixedSingle;
            txtVenit.Font = new Font("Segoe UI", 10F);
            txtVenit.ForeColor = SystemColors.Window;
            txtVenit.Location = new Point(319, 267);
            txtVenit.Name = "txtVenit";
            txtVenit.Size = new Size(295, 25);
            txtVenit.TabIndex = 10;
            // 
            // txtDatorii
            // 
            txtDatorii.BackColor = SystemColors.WindowFrame;
            txtDatorii.BorderStyle = BorderStyle.FixedSingle;
            txtDatorii.Font = new Font("Segoe UI", 10F);
            txtDatorii.ForeColor = SystemColors.Window;
            txtDatorii.Location = new Point(319, 298);
            txtDatorii.Name = "txtDatorii";
            txtDatorii.Size = new Size(295, 25);
            txtDatorii.TabIndex = 11;
            // 
            // txtSuma
            // 
            txtSuma.BackColor = SystemColors.WindowFrame;
            txtSuma.BorderStyle = BorderStyle.FixedSingle;
            txtSuma.Font = new Font("Segoe UI", 10F);
            txtSuma.ForeColor = SystemColors.Window;
            txtSuma.Location = new Point(319, 329);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(295, 25);
            txtSuma.TabIndex = 12;
            // 
            // lblRezultat
            // 
            lblRezultat.BackColor = SystemColors.WindowFrame;
            lblRezultat.BorderStyle = BorderStyle.FixedSingle;
            lblRezultat.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblRezultat.ForeColor = Color.FromArgb(255, 128, 128);
            lblRezultat.Location = new Point(177, 487);
            lblRezultat.Name = "lblRezultat";
            lblRezultat.Size = new Size(545, 31);
            lblRezultat.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.WindowFrame;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI", 10F);
            comboBox1.ForeColor = SystemColors.Window;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(319, 360);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(295, 25);
            comboBox1.TabIndex = 15;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = SystemColors.WindowFrame;
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.Font = new Font("Segoe UI", 10F);
            comboBox2.ForeColor = SystemColors.Window;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(319, 391);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(295, 25);
            comboBox2.TabIndex = 16;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(84, 437);
            button1.Name = "button1";
            button1.Size = new Size(302, 31);
            button1.TabIndex = 17;
            button1.Text = "Calculeaza";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.Location = new Point(407, 437);
            button2.Name = "button2";
            button2.Size = new Size(302, 31);
            button2.TabIndex = 18;
            button2.Text = "Reseteaza";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.WindowFrame;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Window;
            label9.Location = new Point(205, 240);
            label9.Name = "label9";
            label9.Size = new Size(67, 21);
            label9.TabIndex = 19;
            label9.Text = "Moneda";
            label9.Click += label9_Click;
            // 
            // comboMoneda
            // 
            comboMoneda.BackColor = SystemColors.WindowFrame;
            comboMoneda.FlatStyle = FlatStyle.Flat;
            comboMoneda.ForeColor = SystemColors.Window;
            comboMoneda.FormattingEnabled = true;
            comboMoneda.Location = new Point(319, 238);
            comboMoneda.Name = "comboMoneda";
            comboMoneda.Size = new Size(295, 23);
            comboMoneda.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 586);
            Controls.Add(comboMoneda);
            Controls.Add(label9);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(lblRezultat);
            Controls.Add(txtSuma);
            Controls.Add(txtDatorii);
            Controls.Add(txtVenit);
            Controls.Add(numVarsta);
            Controls.Add(txtNume);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtNume;
        private TextBox numVarsta;
        private TextBox txtVenit;
        private TextBox txtDatorii;
        private TextBox txtSuma;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button1;
        public TextBox lblRezultat;
        private Button button2;
        private Label label9;
        private ComboBox comboMoneda;
    }
}
