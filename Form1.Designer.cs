namespace ООП_ЛР3_вар7
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
            txtArray = new TextBox();
            label2 = new Label();
            txtNum = new TextBox();
            button1 = new Button();
            label3 = new Label();
            result = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(281, 20);
            label1.TabIndex = 0;
            label1.Text = "Масив (введіть 25 чисел через пробіл):";
            // 
            // txtArray
            // 
            txtArray.Location = new Point(13, 38);
            txtArray.Multiline = true;
            txtArray.Name = "txtArray";
            txtArray.Size = new Size(281, 93);
            txtArray.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 145);
            label2.Name = "label2";
            label2.Size = new Size(169, 20);
            label2.TabIndex = 2;
            label2.Text = "Число для порівняння:";
            // 
            // txtNum
            // 
            txtNum.Location = new Point(187, 142);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(106, 27);
            txtNum.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(13, 184);
            button1.Name = "button1";
            button1.Size = new Size(281, 36);
            button1.TabIndex = 4;
            button1.Text = "Обчислити";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(13, 232);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 5;
            label3.Text = "Результат:";
            // 
            // result
            // 
            result.Location = new Point(93, 232);
            result.Name = "result";
            result.Size = new Size(200, 25);
            result.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 271);
            Controls.Add(result);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(txtNum);
            Controls.Add(label2);
            Controls.Add(txtArray);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Завдання 1. Варіант 7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtArray;
        private Label label2;
        private TextBox txtNum;
        private Button button1;
        private Label label3;
        private Label result;
    }
}
