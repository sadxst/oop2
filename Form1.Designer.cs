namespace ООП_ЛР2_вар7
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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            suma = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(223, 20);
            label1.TabIndex = 0;
            label1.Text = "Введіть 20 чисел через пробіл:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 51);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(384, 56);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(12, 122);
            button1.Name = "button1";
            button1.Size = new Size(384, 34);
            button1.TabIndex = 2;
            button1.Text = "Розрахувати суму";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // suma
            // 
            suma.AutoSize = true;
            suma.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            suma.Location = new Point(12, 171);
            suma.Name = "suma";
            suma.Size = new Size(195, 20);
            suma.TabIndex = 5;
            suma.Text = "Сума додатніх елементів:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 206);
            Controls.Add(suma);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Лабораторна робота 2. Варіант 7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label suma;
    }
}
