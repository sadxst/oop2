namespace ООП_ПР1
{
    partial class Form2
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
            textBox1 = new TextBox();
            before = new Label();
            after = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(400, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // before
            // 
            before.AutoSize = true;
            before.Location = new Point(12, 78);
            before.Name = "before";
            before.Size = new Size(96, 20);
            before.TabIndex = 3;
            before.Text = "Початковий:";
            // 
            // after
            // 
            after.AutoSize = true;
            after.Location = new Point(12, 108);
            after.Name = "after";
            after.Size = new Size(77, 20);
            after.TabIndex = 4;
            after.Text = "Кінцевий:\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 5;
            label1.Text = "Результат:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 156);
            Controls.Add(label1);
            Controls.Add(after);
            Controls.Add(before);
            Controls.Add(textBox1);
            Name = "Form2";
            Text = "Завдання 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Label before;
        private Label after;
        private Label label1;
    }
}