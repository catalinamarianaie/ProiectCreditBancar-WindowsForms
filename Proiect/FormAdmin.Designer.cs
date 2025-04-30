using Proiect.Properties;

namespace Proiect
{
    partial class FormAdmin
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
            tabControl1 = new TabControl();
            CereriPrimite = new TabPage();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            button5 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel5 = new Panel();
            label4 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            label3 = new Label();
            tabPage1 = new TabPage();
            button6 = new Button();
            button4 = new Button();
            button3 = new Button();
            dataGridViewConturi = new DataGridView();
            colorDialog1 = new ColorDialog();
            tabControl1.SuspendLayout();
            CereriPrimite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConturi).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(CereriPrimite);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(60, 32);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(690, 505);
            tabControl1.TabIndex = 0;
            // 
            // CereriPrimite
            // 
            CereriPrimite.BackColor = Color.Black;
            CereriPrimite.Controls.Add(button2);
            CereriPrimite.Controls.Add(button1);
            CereriPrimite.Controls.Add(dataGridView1);
            CereriPrimite.Cursor = Cursors.Cross;
            CereriPrimite.Location = new Point(4, 24);
            CereriPrimite.Name = "CereriPrimite";
            CereriPrimite.Padding = new Padding(3);
            CereriPrimite.Size = new Size(682, 477);
            CereriPrimite.TabIndex = 0;
            CereriPrimite.Text = "CereriPrimite";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.Location = new Point(440, 404);
            button2.Name = "button2";
            button2.Size = new Size(216, 36);
            button2.TabIndex = 2;
            button2.Text = "Exporta CSV";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(27, 404);
            button1.Name = "button1";
            button1.Size = new Size(216, 36);
            button1.TabIndex = 1;
            button1.Text = "Reincarca datele";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(629, 355);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Black;
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(flowLayoutPanel1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(682, 477);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Statistici&Grafic";
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button5.Location = new Point(225, 374);
            button5.Name = "button5";
            button5.Size = new Size(216, 36);
            button5.TabIndex = 4;
            button5.Text = "Incarca Statistici";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.DimGray;
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Location = new Point(32, 148);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(621, 139);
            flowLayoutPanel1.TabIndex = 3;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Silver;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 132);
            panel5.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(79, 54);
            label4.Name = "label4";
            label4.Size = new Size(0, 47);
            label4.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(75, 7);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 0;
            label1.Text = "Cereri";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(209, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 132);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(19, 54);
            label5.Name = "label5";
            label5.Size = new Size(0, 47);
            label5.TabIndex = 1;
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(60, 7);
            label2.Name = "label2";
            label2.Size = new Size(93, 21);
            label2.TabIndex = 0;
            label2.Text = "Suma totala";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(415, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 132);
            panel2.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(46, 54);
            label6.Name = "label6";
            label6.Size = new Size(0, 47);
            label6.TabIndex = 1;
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(64, 7);
            label3.Name = "label3";
            label3.Size = new Size(86, 21);
            label3.TabIndex = 0;
            label3.Text = "Medie scor";
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Black;
            tabPage1.Controls.Add(button6);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(dataGridViewConturi);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(682, 477);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Conturi";
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button6.Location = new Point(21, 408);
            button6.Name = "button6";
            button6.Size = new Size(156, 36);
            button6.TabIndex = 4;
            button6.Text = "Incarca datele";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.Location = new Point(507, 408);
            button4.Name = "button4";
            button4.Size = new Size(156, 36);
            button4.TabIndex = 3;
            button4.Text = "Sterge cont";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.Location = new Point(259, 408);
            button3.Name = "button3";
            button3.Size = new Size(156, 36);
            button3.TabIndex = 2;
            button3.Text = "Adauga Cont";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridViewConturi
            // 
            dataGridViewConturi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewConturi.Location = new Point(21, 31);
            dataGridViewConturi.Name = "dataGridViewConturi";
            dataGridViewConturi.Size = new Size(642, 348);
            dataGridViewConturi.TabIndex = 0;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            //BackgroundImage = (Image)Resources.ResourceManager.GetObject("$this.BackgroundImage");
            ClientSize = new Size(799, 576);
            Controls.Add(tabControl1);
            Name = "FormAdmin";
            Text = "FormAdmin";
            tabControl1.ResumeLayout(false);
            CereriPrimite.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewConturi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage CereriPrimite;
        private TabPage tabPage2;
        private Button button2;
        private Button button1;
        private ColorDialog colorDialog1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dataGridView1;
        private TabPage tabPage1;
        private Button button4;
        private Button button3;
        private DataGridView dataGridViewConturi;
        private Button button5;
        private Button button6;
    }
}