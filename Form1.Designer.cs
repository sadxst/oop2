namespace ООП_ПР2_вар8
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
            label2 = new Label();
            label3 = new Label();
            btnArea = new Button();
            btnLength = new Button();
            btnSector = new Button();
            btnComp = new Button();
            btnAdd = new Button();
            btnMinus = new Button();
            btnMul = new Button();
            result = new Label();
            r1 = new TextBox();
            r2 = new TextBox();
            k = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "Радіус 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(236, 15);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 1;
            label2.Text = "Радіус 2:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 56);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 2;
            label3.Text = "Кут або множник:";
            // 
            // btnArea
            // 
            btnArea.Location = new Point(12, 95);
            btnArea.Name = "btnArea";
            btnArea.Size = new Size(133, 29);
            btnArea.TabIndex = 3;
            btnArea.Text = "Площа";
            btnArea.UseVisualStyleBackColor = true;
            btnArea.Click += btnArea_Click;
            // 
            // btnLength
            // 
            btnLength.Location = new Point(151, 95);
            btnLength.Name = "btnLength";
            btnLength.Size = new Size(133, 29);
            btnLength.TabIndex = 4;
            btnLength.Text = "Довжина";
            btnLength.UseVisualStyleBackColor = true;
            btnLength.Click += btnLength_Click;
            // 
            // btnSector
            // 
            btnSector.Location = new Point(290, 95);
            btnSector.Name = "btnSector";
            btnSector.Size = new Size(133, 29);
            btnSector.TabIndex = 5;
            btnSector.Text = "Сектор";
            btnSector.UseVisualStyleBackColor = true;
            btnSector.Click += btnSector_Click;
            // 
            // btnComp
            // 
            btnComp.Location = new Point(12, 165);
            btnComp.Name = "btnComp";
            btnComp.Size = new Size(411, 40);
            btnComp.TabIndex = 6;
            btnComp.Text = "Порівняти";
            btnComp.UseVisualStyleBackColor = true;
            btnComp.Click += btnComp_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 130);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(133, 29);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Додати";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(151, 130);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(133, 29);
            btnMinus.TabIndex = 8;
            btnMinus.Text = "Відняти";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnMul
            // 
            btnMul.Location = new Point(289, 130);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(133, 29);
            btnMul.TabIndex = 9;
            btnMul.Text = "Множення";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += btnMul_Click;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            result.Location = new Point(12, 219);
            result.Name = "result";
            result.Size = new Size(83, 20);
            result.TabIndex = 10;
            result.Text = "Результат:";
            // 
            // r1
            // 
            r1.Location = new Point(84, 12);
            r1.Name = "r1";
            r1.Size = new Size(114, 27);
            r1.TabIndex = 11;
            // 
            // r2
            // 
            r2.Location = new Point(308, 12);
            r2.Name = "r2";
            r2.Size = new Size(114, 27);
            r2.TabIndex = 12;
            // 
            // k
            // 
            k.Location = new Point(204, 53);
            k.Name = "k";
            k.Size = new Size(142, 27);
            k.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 256);
            Controls.Add(k);
            Controls.Add(r2);
            Controls.Add(r1);
            Controls.Add(result);
            Controls.Add(btnMul);
            Controls.Add(btnMinus);
            Controls.Add(btnAdd);
            Controls.Add(btnComp);
            Controls.Add(btnSector);
            Controls.Add(btnLength);
            Controls.Add(btnArea);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Практичне завдання 2. Варіант 8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnArea;
        private Button btnLength;
        private Button btnSector;
        private Button btnComp;
        private Button btnAdd;
        private Button btnMinus;
        private Button btnMul;
        private Label result;
        private TextBox r1;
        private TextBox r2;
        private TextBox k;
    }
}
