namespace Task3
{
    partial class ReplaceForm
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
            oldText = new TextBox();
            newText = new TextBox();
            ButtonReplace = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // oldText
            // 
            oldText.Location = new Point(59, 38);
            oldText.Name = "oldText";
            oldText.Size = new Size(252, 23);
            oldText.TabIndex = 0;
            // 
            // newText
            // 
            newText.Location = new Point(59, 104);
            newText.Name = "newText";
            newText.Size = new Size(252, 23);
            newText.TabIndex = 1;
            // 
            // ButtonReplace
            // 
            ButtonReplace.Location = new Point(97, 156);
            ButtonReplace.Name = "ButtonReplace";
            ButtonReplace.Size = new Size(166, 23);
            ButtonReplace.TabIndex = 2;
            ButtonReplace.Text = "Нажмите для изменения";
            ButtonReplace.UseVisualStyleBackColor = true;
            ButtonReplace.Click += ButtonReplace_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 20);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 3;
            label1.Text = "Старый текст";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 86);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 4;
            label2.Text = "Новый текст";
            // 
            // TextForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 216);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ButtonReplace);
            Controls.Add(newText);
            Controls.Add(oldText);
            Name = "ReplaceForm";
            Text = "ReplaceForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox oldText;
        private TextBox newText;
        private Button ButtonReplace;
        private Label label1;
        private Label label2;
    }
}
