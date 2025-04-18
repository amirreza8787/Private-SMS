namespace Private_SMS
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btn_2 = new Button();
            textBox3 = new TextBox();
            btn_1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(12, 36);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(641, 52);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(12, 132);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(641, 53);
            textBox2.TabIndex = 0;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_2
            // 
            btn_2.BackColor = Color.White;
            btn_2.BackgroundImageLayout = ImageLayout.Center;
            btn_2.FlatAppearance.BorderColor = Color.White;
            btn_2.FlatAppearance.BorderSize = 0;
            btn_2.FlatAppearance.MouseDownBackColor = Color.Black;
            btn_2.FlatAppearance.MouseOverBackColor = Color.FromArgb(189, 189, 189);
            btn_2.FlatStyle = FlatStyle.Flat;
            btn_2.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold);
            btn_2.Location = new Point(578, 191);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(75, 32);
            btn_2.TabIndex = 1;
            btn_2.Text = "Compile";
            btn_2.UseVisualStyleBackColor = false;
            btn_2.Click += btn_2_Click_1;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 16F);
            textBox3.Location = new Point(12, 229);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.ScrollBars = ScrollBars.Vertical;
            textBox3.Size = new Size(641, 94);
            textBox3.TabIndex = 0;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_1
            // 
            btn_1.BackColor = Color.White;
            btn_1.BackgroundImageLayout = ImageLayout.Center;
            btn_1.FlatAppearance.BorderColor = Color.White;
            btn_1.FlatAppearance.BorderSize = 0;
            btn_1.FlatAppearance.MouseDownBackColor = Color.Black;
            btn_1.FlatAppearance.MouseOverBackColor = Color.FromArgb(189, 189, 189);
            btn_1.FlatStyle = FlatStyle.Flat;
            btn_1.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold);
            btn_1.Location = new Point(578, 94);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(75, 32);
            btn_1.TabIndex = 1;
            btn_1.Text = "Compile";
            btn_1.UseVisualStyleBackColor = false;
            btn_1.Click += btn_1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 2;
            label1.Text = "Normal Text";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(12, 100);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 2;
            label2.Text = "Chenged Text";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(509, 9);
            label3.Name = "label3";
            label3.Size = new Size(144, 22);
            label3.TabIndex = 3;
            label3.Text = "Amirreza Abedini";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(665, 335);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_1);
            Controls.Add(btn_2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(681, 374);
            MinimumSize = new Size(681, 374);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Private SMS";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button btn_2;
        private TextBox textBox3;
        private Button btn_1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
