namespace ООП_ЛР1_вар3
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
            s1 = new TextBox();
            s2 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            result = new Label();
            SuspendLayout();
            // 
            // s1
            // 
            s1.Location = new Point(12, 41);
            s1.Multiline = true;
            s1.Name = "s1";
            s1.Size = new Size(322, 57);
            s1.TabIndex = 0;
            // 
            // s2
            // 
            s2.Location = new Point(12, 140);
            s2.Multiline = true;
            s2.Name = "s2";
            s2.Size = new Size(322, 57);
            s2.TabIndex = 1;
            // 
            // label1
            // 
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 2;
            label1.Text = "Рядок 1";
            // 
            // button1
            // 
            button1.Location = new Point(12, 214);
            button1.Name = "button1";
            button1.Size = new Size(322, 31);
            button1.TabIndex = 4;
            button1.Text = "Перевірити";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Location = new Point(12, 112);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 5;
            label2.Text = "Рядок 2";
            // 
            // result
            // 
            result.Location = new Point(12, 263);
            result.Name = "result";
            result.Size = new Size(324, 25);
            result.TabIndex = 6;
            result.Text = "Результат:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 298);
            Controls.Add(result);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(s2);
            Controls.Add(s1);
            Name = "Form2";
            Text = "Варіант 3. Завдання 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox s1;
        private TextBox s2;
        private Label label1;
        private Button button1;
        private Label label2;
        private Label result;
    }
}