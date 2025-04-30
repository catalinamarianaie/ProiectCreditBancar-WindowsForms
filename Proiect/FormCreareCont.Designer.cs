namespace Proiect
{
    partial class FormCreareCont
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreareCont));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            txtNume = new TextBox();
            txtPrenume = new TextBox();
            txtVarsta = new TextBox();
            txtUsername = new TextBox();
            txtParola = new TextBox();
            cmbTipCont = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.WindowFrame;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(200, 177);
            label1.Name = "label1";
            label1.Size = new Size(54, 21);
            label1.TabIndex = 0;
            label1.Text = "Nume";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.WindowFrame;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(180, 212);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 1;
            label2.Text = "Prenume";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.WindowFrame;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(201, 247);
            label3.Name = "label3";
            label3.Size = new Size(54, 21);
            label3.TabIndex = 2;
            label3.Text = "Varsta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.WindowFrame;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(185, 280);
            label4.Name = "label4";
            label4.Size = new Size(70, 21);
            label4.TabIndex = 3;
            label4.Text = "Tip cont";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.WindowFrame;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(172, 315);
            label5.Name = "label5";
            label5.Size = new Size(83, 21);
            label5.TabIndex = 4;
            label5.Text = "Username";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.WindowFrame;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(200, 353);
            label6.Name = "label6";
            label6.Size = new Size(55, 21);
            label6.TabIndex = 5;
            label6.Text = "Parola";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(304, 421);
            button1.Name = "button1";
            button1.Size = new Size(173, 46);
            button1.TabIndex = 6;
            button1.Text = "Creeaza cont";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtNume
            // 
            txtNume.BackColor = SystemColors.WindowFrame;
            txtNume.BorderStyle = BorderStyle.FixedSingle;
            txtNume.Location = new Point(289, 175);
            txtNume.Name = "txtNume";
            txtNume.Size = new Size(335, 23);
            txtNume.TabIndex = 7;
            // 
            // txtPrenume
            // 
            txtPrenume.BackColor = SystemColors.WindowFrame;
            txtPrenume.BorderStyle = BorderStyle.FixedSingle;
            txtPrenume.Location = new Point(289, 210);
            txtPrenume.Name = "txtPrenume";
            txtPrenume.Size = new Size(335, 23);
            txtPrenume.TabIndex = 8;
            // 
            // txtVarsta
            // 
            txtVarsta.BackColor = SystemColors.WindowFrame;
            txtVarsta.BorderStyle = BorderStyle.FixedSingle;
            txtVarsta.Location = new Point(289, 245);
            txtVarsta.Name = "txtVarsta";
            txtVarsta.Size = new Size(335, 23);
            txtVarsta.TabIndex = 9;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.WindowFrame;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Location = new Point(289, 315);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(335, 23);
            txtUsername.TabIndex = 11;
            // 
            // txtParola
            // 
            txtParola.BackColor = SystemColors.WindowFrame;
            txtParola.BorderStyle = BorderStyle.FixedSingle;
            txtParola.Location = new Point(289, 351);
            txtParola.Name = "txtParola";
            txtParola.Size = new Size(335, 23);
            txtParola.TabIndex = 12;
            // 
            // cmbTipCont
            // 
            cmbTipCont.BackColor = SystemColors.WindowFrame;
            cmbTipCont.FlatStyle = FlatStyle.Flat;
            cmbTipCont.ForeColor = SystemColors.Window;
            cmbTipCont.FormattingEnabled = true;
            cmbTipCont.Location = new Point(289, 282);
            cmbTipCont.Name = "cmbTipCont";
            cmbTipCont.Size = new Size(335, 23);
            cmbTipCont.TabIndex = 21;
            cmbTipCont.SelectedIndexChanged += cmbTipCont_SelectedIndexChanged;
            // 
            // FormCreareCont
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 585);
            Controls.Add(cmbTipCont);
            Controls.Add(txtParola);
            Controls.Add(txtUsername);
            Controls.Add(txtVarsta);
            Controls.Add(txtPrenume);
            Controls.Add(txtNume);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCreareCont";
            Text = "FormLogin";
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
        private Button button1;
        private TextBox txtNume;
        private TextBox txtPrenume;
        private TextBox txtVarsta;
        private TextBox txtUsername;
        private TextBox txtParola;
        private ComboBox cmbTipCont;
    }
}