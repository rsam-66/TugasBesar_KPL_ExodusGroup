namespace GUI_Jo
{
    partial class DetailPayment
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(179, 26);
            label1.Name = "label1";
            label1.Size = new Size(139, 25);
            label1.TabIndex = 0;
            label1.Text = "Pembayaran QR";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 51);
            label2.Name = "label2";
            label2.Size = new Size(240, 25);
            label2.TabIndex = 1;
            label2.Text = "30/12/2024 - 10:41:22 - WIB";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(207, 136);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 2;
            label3.Text = "Berhasil";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(190, 224);
            label4.Name = "label4";
            label4.Size = new Size(119, 25);
            label4.TabIndex = 3;
            label4.Text = "Ayam Geprek";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(190, 249);
            label5.Name = "label5";
            label5.Size = new Size(114, 25);
            label5.TabIndex = 4;
            label5.Text = "Jakarta Pusat";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(168, 309);
            label6.Name = "label6";
            label6.Size = new Size(150, 25);
            label6.TabIndex = 5;
            label6.Text = "Nominal - 32.000";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(190, 334);
            label7.Name = "label7";
            label7.Size = new Size(105, 25);
            label7.TabIndex = 6;
            label7.Text = "Tips - 5.000";
            label7.Click += label7_Click;
            // 
            // button1
            // 
            button1.Location = new Point(183, 493);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 7;
            button1.Text = "OKE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(126, 414);
            label8.Name = "label8";
            label8.Size = new Size(222, 25);
            label8.TabIndex = 8;
            label8.Text = "Total Pembayaran - 38.000";
            label8.Click += label8_Click;
            // 
            // DetailPayment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 558);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DetailPayment";
            Text = "DetailPayment";
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
        private Button button1;
        private Label label8;
    }
}