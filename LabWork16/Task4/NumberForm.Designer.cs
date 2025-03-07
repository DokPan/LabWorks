namespace Task4
{
    partial class NumberForm
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
            FirstButton = new Button();
            SecondButton = new Button();
            ThirdButton = new Button();
            FourthButton = new Button();
            FifthButton = new Button();
            SixthButton = new Button();
            SeventhButton = new Button();
            EighthButton = new Button();
            NinthButton = new Button();
            TenthButton = new Button();
            TextBox = new TextBox();
            ClearButton = new Button();
            SuspendLayout();
            // 
            // FirstButton
            // 
            FirstButton.Location = new Point(12, 156);
            FirstButton.Name = "FirstButton";
            FirstButton.Size = new Size(69, 59);
            FirstButton.TabIndex = 0;
            FirstButton.Text = "1";
            FirstButton.UseVisualStyleBackColor = true;
            FirstButton.Click += DigitButton_Click;
            // 
            // SecondButton
            // 
            SecondButton.Location = new Point(87, 156);
            SecondButton.Name = "SecondButton";
            SecondButton.Size = new Size(69, 59);
            SecondButton.TabIndex = 1;
            SecondButton.Text = "2";
            SecondButton.UseVisualStyleBackColor = true;
            SecondButton.Click += DigitButton_Click;
            // 
            // ThirdButton
            // 
            ThirdButton.Location = new Point(163, 156);
            ThirdButton.Name = "ThirdButton";
            ThirdButton.Size = new Size(69, 59);
            ThirdButton.TabIndex = 2;
            ThirdButton.Text = "3";
            ThirdButton.UseVisualStyleBackColor = true;
            ThirdButton.Click += DigitButton_Click;
            // 
            // FourthButton
            // 
            FourthButton.Location = new Point(12, 221);
            FourthButton.Name = "FourthButton";
            FourthButton.Size = new Size(69, 59);
            FourthButton.TabIndex = 3;
            FourthButton.Text = "4";
            FourthButton.UseVisualStyleBackColor = true;
            FourthButton.Click += DigitButton_Click;
            // 
            // FifthButton
            // 
            FifthButton.Location = new Point(87, 221);
            FifthButton.Name = "FifthButton";
            FifthButton.Size = new Size(69, 59);
            FifthButton.TabIndex = 4;
            FifthButton.Text = "5";
            FifthButton.UseVisualStyleBackColor = true;
            FifthButton.Click += DigitButton_Click;
            // 
            // SixthButton
            // 
            SixthButton.Location = new Point(162, 221);
            SixthButton.Name = "SixthButton";
            SixthButton.Size = new Size(69, 59);
            SixthButton.TabIndex = 5;
            SixthButton.Text = "6";
            SixthButton.UseVisualStyleBackColor = true;
            SixthButton.Click += DigitButton_Click;
            // 
            // SeventhButton
            // 
            SeventhButton.Location = new Point(12, 286);
            SeventhButton.Name = "SeventhButton";
            SeventhButton.Size = new Size(69, 59);
            SeventhButton.TabIndex = 6;
            SeventhButton.Text = "7";
            SeventhButton.UseVisualStyleBackColor = true;
            SeventhButton.Click += DigitButton_Click;
            // 
            // EighthButton
            // 
            EighthButton.Location = new Point(87, 286);
            EighthButton.Name = "EighthButton";
            EighthButton.Size = new Size(69, 59);
            EighthButton.TabIndex = 7;
            EighthButton.Text = "8";
            EighthButton.UseVisualStyleBackColor = true;
            EighthButton.Click += DigitButton_Click;
            // 
            // NinthButton
            // 
            NinthButton.Location = new Point(163, 286);
            NinthButton.Name = "NinthButton";
            NinthButton.Size = new Size(69, 59);
            NinthButton.TabIndex = 8;
            NinthButton.Text = "9";
            NinthButton.UseVisualStyleBackColor = true;
            NinthButton.Click += DigitButton_Click;
            // 
            // TenthButton
            // 
            TenthButton.Location = new Point(87, 351);
            TenthButton.Name = "TenthButton";
            TenthButton.Size = new Size(69, 59);
            TenthButton.TabIndex = 9;
            TenthButton.Text = "0";
            TenthButton.UseVisualStyleBackColor = true;
            TenthButton.Click += DigitButton_Click;
            // 
            // TextBox
            // 
            TextBox.Location = new Point(11, 60);
            TextBox.Name = "TextBox";
            TextBox.Size = new Size(220, 23);
            TextBox.TabIndex = 10;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(163, 369);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(68, 23);
            ClearButton.TabIndex = 11;
            ClearButton.Text = "Очистить";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // NumberForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 421);
            Controls.Add(ClearButton);
            Controls.Add(TextBox);
            Controls.Add(TenthButton);
            Controls.Add(NinthButton);
            Controls.Add(EighthButton);
            Controls.Add(SeventhButton);
            Controls.Add(SixthButton);
            Controls.Add(FifthButton);
            Controls.Add(FourthButton);
            Controls.Add(ThirdButton);
            Controls.Add(SecondButton);
            Controls.Add(FirstButton);
            Name = "NumberForm";
            Text = "Number Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button FirstButton;
        private Button SecondButton;
        private Button ThirdButton;
        private Button FourthButton;
        private Button FifthButton;
        private Button SixthButton;
        private Button SeventhButton;
        private Button EighthButton;
        private Button NinthButton;
        private Button TenthButton;
        private TextBox TextBox;
        private Button ClearButton;
    }
}
