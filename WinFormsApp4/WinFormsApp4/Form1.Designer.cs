namespace WinFormsApp4
{
    partial class MemoryGameForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemoryGameForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            button2 = new Button();
            label17 = new Label();
            bestScoreLabel = new Label();
            button3 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Red;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(label16, 3, 3);
            tableLayoutPanel1.Controls.Add(label15, 2, 3);
            tableLayoutPanel1.Controls.Add(label14, 1, 3);
            tableLayoutPanel1.Controls.Add(label13, 0, 3);
            tableLayoutPanel1.Controls.Add(label12, 3, 2);
            tableLayoutPanel1.Controls.Add(label11, 2, 2);
            tableLayoutPanel1.Controls.Add(label10, 1, 2);
            tableLayoutPanel1.Controls.Add(label9, 0, 2);
            tableLayoutPanel1.Controls.Add(label8, 3, 1);
            tableLayoutPanel1.Controls.Add(label7, 2, 1);
            tableLayoutPanel1.Controls.Add(label6, 1, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 3, 0);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Location = new Point(330, 180);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(591, 572);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label16
            // 
            label16.Dock = DockStyle.Fill;
            label16.Font = new Font("Webdings", 72F, FontStyle.Bold, GraphicsUnit.Point, 2);
            label16.ForeColor = Color.Red;
            label16.Location = new Point(446, 428);
            label16.Name = "label16";
            label16.Size = new Size(140, 142);
            label16.TabIndex = 15;
            label16.Text = "f";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            label16.Click += lable_Click;
            // 
            // label15
            // 
            label15.Dock = DockStyle.Fill;
            label15.Font = new Font("Webdings", 72F, FontStyle.Bold, GraphicsUnit.Point, 2);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(299, 428);
            label15.Name = "label15";
            label15.Size = new Size(139, 142);
            label15.TabIndex = 14;
            label15.Text = "f";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            label15.Click += lable_Click;
            // 
            // label14
            // 
            label14.Dock = DockStyle.Fill;
            label14.Font = new Font("Webdings", 72F, FontStyle.Bold, GraphicsUnit.Point, 2);
            label14.ForeColor = Color.Red;
            label14.Location = new Point(152, 428);
            label14.Name = "label14";
            label14.Size = new Size(139, 142);
            label14.TabIndex = 13;
            label14.Text = "f";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            label14.Click += lable_Click;
            // 
            // label13
            // 
            label13.Dock = DockStyle.Fill;
            label13.Font = new Font("Webdings", 72F, FontStyle.Bold, GraphicsUnit.Point, 2);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(5, 428);
            label13.Name = "label13";
            label13.Size = new Size(139, 142);
            label13.TabIndex = 12;
            label13.Text = "f";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            label13.Click += lable_Click;
            // 
            // label12
            // 
            label12.Dock = DockStyle.Fill;
            label12.Font = new Font("Webdings", 72F, FontStyle.Bold, GraphicsUnit.Point, 2);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(446, 286);
            label12.Name = "label12";
            label12.Size = new Size(140, 140);
            label12.TabIndex = 11;
            label12.Text = "f";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            label12.Click += lable_Click;
            // 
            // label11
            // 
            label11.Dock = DockStyle.Fill;
            label11.Font = new Font("Webdings", 72F, FontStyle.Bold, GraphicsUnit.Point, 2);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(299, 286);
            label11.Name = "label11";
            label11.Size = new Size(139, 140);
            label11.TabIndex = 10;
            label11.Text = "f";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            label11.Click += lable_Click;
            // 
            // label10
            // 
            label10.Dock = DockStyle.Fill;
            label10.Font = new Font("Webdings", 72F, FontStyle.Bold, GraphicsUnit.Point, 2);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(152, 286);
            label10.Name = "label10";
            label10.Size = new Size(139, 140);
            label10.TabIndex = 9;
            label10.Text = "f";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            label10.Click += lable_Click;
            // 
            // label9
            // 
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Webdings", 72F, FontStyle.Bold, GraphicsUnit.Point, 2);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(5, 286);
            label9.Name = "label9";
            label9.Size = new Size(139, 140);
            label9.TabIndex = 8;
            label9.Text = "f";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            label9.Click += lable_Click;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Webdings", 72F, FontStyle.Bold, GraphicsUnit.Point, 2);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(446, 144);
            label8.Name = "label8";
            label8.Size = new Size(140, 140);
            label8.TabIndex = 7;
            label8.Text = "f";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            label8.Click += lable_Click;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Webdings", 72F, FontStyle.Bold, GraphicsUnit.Point, 2);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(299, 144);
            label7.Name = "label7";
            label7.Size = new Size(139, 140);
            label7.TabIndex = 6;
            label7.Text = "f";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            label7.Click += lable_Click;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Webdings", 72F, FontStyle.Bold, GraphicsUnit.Point, 2);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(152, 144);
            label6.Name = "label6";
            label6.Size = new Size(139, 140);
            label6.TabIndex = 5;
            label6.Text = "f";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Click += lable_Click;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Webdings", 72F, FontStyle.Bold, GraphicsUnit.Point, 2);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(5, 144);
            label5.Name = "label5";
            label5.Size = new Size(139, 140);
            label5.TabIndex = 4;
            label5.Text = "f";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += lable_Click;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Webdings", 72F, FontStyle.Bold, GraphicsUnit.Point, 2);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(446, 2);
            label4.Name = "label4";
            label4.Size = new Size(140, 140);
            label4.TabIndex = 3;
            label4.Text = "f";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += lable_Click;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Webdings", 72F, FontStyle.Bold, GraphicsUnit.Point, 2);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(299, 2);
            label3.Name = "label3";
            label3.Size = new Size(139, 140);
            label3.TabIndex = 2;
            label3.Text = "f";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += lable_Click;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Webdings", 72F, FontStyle.Bold, GraphicsUnit.Point, 2);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(152, 2);
            label2.Name = "label2";
            label2.Size = new Size(139, 140);
            label2.TabIndex = 1;
            label2.Text = "f";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += lable_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Webdings", 72F, FontStyle.Bold, GraphicsUnit.Point, 2);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(5, 2);
            label1.Name = "label1";
            label1.Size = new Size(139, 140);
            label1.TabIndex = 0;
            label1.Text = "f";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += lable_Click;
            // 
            // timer2
            // 
            timer2.Interval = 750;
            timer2.Tick += timer2_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(45, 271);
            button1.Name = "button1";
            button1.Size = new Size(227, 100);
            button1.TabIndex = 2;
            button1.Text = "Продолжить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(45, 411);
            button2.Name = "button2";
            button2.Size = new Size(227, 100);
            button2.TabIndex = 3;
            button2.Text = "Сохранить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label17
            // 
            label17.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label17.Location = new Point(464, 781);
            label17.Name = "label17";
            label17.Size = new Size(100, 23);
            label17.TabIndex = 8;
            label17.Text = "Ходы";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bestScoreLabel
            // 
            bestScoreLabel.AutoSize = true;
            bestScoreLabel.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bestScoreLabel.Location = new Point(686, 783);
            bestScoreLabel.Name = "bestScoreLabel";
            bestScoreLabel.Size = new Size(155, 21);
            bestScoreLabel.TabIndex = 6;
            bestScoreLabel.Text = "Прошлый рекорд";
            bestScoreLabel.Click += bestScoreLabel_Click;
            // 
            // button3
            // 
            button3.Location = new Point(45, 556);
            button3.Name = "button3";
            button3.Size = new Size(227, 100);
            button3.TabIndex = 7;
            button3.Text = "Выход";
            button3.UseVisualStyleBackColor = true;
            button3.Click += exitButton_Click;
            // 
            // MemoryGameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1158, 825);
            Controls.Add(button3);
            Controls.Add(bestScoreLabel);
            Controls.Add(label17);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MemoryGameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Memory";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private System.Windows.Forms.Timer timer2;
        private Button button1;
        private Button button2;
        private Label label17;
        private Label bestScoreLabel;
        private Button button3;
    }
}
