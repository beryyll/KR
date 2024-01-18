namespace WinFormsApp4
{
    partial class MemoryGameForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemoryGameForm2));
            button1 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Viner Hand ITC", 25.8000011F, FontStyle.Bold);
            button1.Location = new Point(169, 145);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(492, 143);
            button1.TabIndex = 0;
            button1.Text = "Играть";
            button1.UseVisualStyleBackColor = true;
            button1.Click += PlayButton_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Viner Hand ITC", 25.8000011F, FontStyle.Bold);
            button3.Location = new Point(169, 351);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(492, 143);
            button3.TabIndex = 3;
            button3.Text = "Выйти";
            button3.UseVisualStyleBackColor = true;
            button3.Click += ExitButton_Click;
            // 
            // MemoryGameForm2
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(781, 591);
            Controls.Add(button3);
            Controls.Add(button1);
            Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "MemoryGameForm2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MemoryGame";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
      
        private Button button3;
    }
}