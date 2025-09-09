namespace ООП_ЛР1_вар3
{
    partial class Form4
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
            txt = new TextBox();
            button1 = new Button();
            rs = new Label();
            SuspendLayout();
            // 
            // txt
            // 
            txt.Location = new Point(12, 12);
            txt.Name = "txt";
            txt.Size = new Size(304, 27);
            txt.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(322, 12);
            button1.Name = "button1";
            button1.Size = new Size(123, 29);
            button1.TabIndex = 1;
            button1.Text = "Сформувати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // rs
            // 
            rs.Location = new Point(12, 55);
            rs.Name = "rs";
            rs.Size = new Size(433, 25);
            rs.TabIndex = 2;
            rs.Text = "Результат:";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 96);
            Controls.Add(rs);
            Controls.Add(button1);
            Controls.Add(txt);
            Name = "Form4";
            Text = "Варіант 3. Завдання 4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt;
        private Button button1;
        private Label rs;
    }
}