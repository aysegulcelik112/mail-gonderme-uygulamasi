namespace Mail_Gönderme_Uygulaması
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            richTextBox1 = new RichTextBox();
            label4 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            openFileDialog1 = new OpenFileDialog();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(234, 27);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(176, 37);
            label1.TabIndex = 0;
            label1.Text = "Mail Gönder";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(71, 103);
            label2.Name = "label2";
            label2.Size = new Size(187, 28);
            label2.TabIndex = 1;
            label2.Text = "Gönderilecek Kişi: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(116, 168);
            label3.Name = "label3";
            label3.Size = new Size(66, 28);
            label3.TabIndex = 2;
            label3.Text = "Konu:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(264, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(254, 34);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(264, 162);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(254, 34);
            textBox2.TabIndex = 4;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(264, 230);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(254, 144);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(116, 262);
            label4.Name = "label4";
            label4.Size = new Size(79, 28);
            label4.TabIndex = 6;
            label4.Text = "Mesaj: ";
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(481, 415);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(173, 45);
            button1.TabIndex = 7;
            button1.Text = "Gönder                ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Fuchsia;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(424, 9);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = SystemColors.Window;
            linkLabel1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            linkLabel1.ForeColor = Color.DarkGreen;
            linkLabel1.LinkColor = Color.Blue;
            linkLabel1.Location = new Point(580, 103);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(96, 23);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Dosya Ekle";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(545, 162);
            label5.Name = "label5";
            label5.Size = new Size(0, 28);
            label5.TabIndex = 10;
            // 
            // label6
            // 
            label6.Location = new Point(524, 142);
            label6.Name = "label6";
            label6.Size = new Size(264, 85);
            label6.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(800, 500);
            ControlBox = false;
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(richTextBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private RichTextBox richTextBox1;
        private Label label4;
        private Button button1;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private OpenFileDialog openFileDialog1;
        private Label label5;
        private Label label6;
    }
}
