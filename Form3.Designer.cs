namespace ООП_ЛР1_вар3
{
    partial class Form3
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
            r = new TextBox();
            w = new TextBox();
            button1 = new Button();
            result1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "Речення:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 59);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 1;
            label2.Text = "Слово:";
            // 
            // r
            // 
            r.Location = new Point(88, 15);
            r.Name = "r";
            r.Size = new Size(254, 27);
            r.TabIndex = 2;
            // 
            // w
            // 
            w.Location = new Point(88, 59);
            w.Name = "w";
            w.Size = new Size(254, 27);
            w.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(88, 101);
            button1.Name = "button1";
            button1.Size = new Size(254, 29);
            button1.TabIndex = 4;
            button1.Text = "Перевірити";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // result1
            // 
            result1.AutoSize = true;
            result1.Location = new Point(12, 147);
            result1.Name = "result1";
            result1.Size = new Size(78, 20);
            result1.TabIndex = 5;
            result1.Text = "Результат:";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 182);
            Controls.Add(result1);
            Controls.Add(button1);
            Controls.Add(w);
            Controls.Add(r);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Варіант 3. Завдання 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox r;
        private TextBox w;
        private Button button1;
        private Label result1;
    }
}