using Proiect.Properties;

namespace Proiect
{
    partial class FormAutentificare
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
            txtUsername = new TextBox();
            txtParola = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.WindowFrame;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.ForeColor = SystemColors.Window;
            txtUsername.Location = new Point(297, 225);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(295, 25);
            txtUsername.TabIndex = 9;
            // 
            // txtParola
            // 
            txtParola.BackColor = SystemColors.WindowFrame;
            txtParola.BorderStyle = BorderStyle.FixedSingle;
            txtParola.Font = new Font("Segoe UI", 10F);
            txtParola.ForeColor = SystemColors.Window;
            txtParola.Location = new Point(297, 299);
            txtParola.Name = "txtParola";
            txtParola.Size = new Size(295, 25);
            txtParola.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.WindowFrame;
            label1.Cursor = Cursors.No;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(180, 225);
            label1.Name = "label1";
            label1.Size = new Size(83, 21);
            label1.TabIndex = 11;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.WindowFrame;
            label2.Cursor = Cursors.No;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(208, 298);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 12;
            label2.Text = "Parola";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(416, 446);
            button1.Name = "button1";
            button1.Size = new Size(145, 40);
            button1.TabIndex = 13;
            button1.Text = "Creeaza cont";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(310, 360);
            button2.Name = "button2";
            button2.Size = new Size(173, 46);
            button2.TabIndex = 14;
            button2.Text = "Intra in cont";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.WindowFrame;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(243, 456);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 15;
            label3.Text = "Nu ai inca un cont?";
            // 
            // FormAutentificare
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Resources.Autentificare;
            ClientSize = new Size(800, 583);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtParola);
            Controls.Add(txtUsername);
            Name = "FormAutentificare";
            Text = "FormInregistrare";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUsername;
        private TextBox txtParola;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Label label3;
    }
}