namespace ООП_ЛР1_вар3
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
            s = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // s
            // 
            s.Location = new Point(12, 12);
            s.Multiline = true;
            s.Name = "s";
            s.Size = new Size(449, 64);
            s.TabIndex = 0;
            s.TextChanged += s_TextChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 90);
            label1.Name = "label1";
            label1.Size = new Size(449, 25);
            label1.TabIndex = 1;
            label1.Text = "Кількість цифр:";
            label1.TextAlign = ContentAlignment.TopRight;
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 130);
            Controls.Add(label1);
            Controls.Add(s);
            Name = "Form1";
            Text = "Варіант 3. Завдання 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox s;
        private Label label1;
    }
}
