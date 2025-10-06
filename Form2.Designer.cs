namespace ООП_ЛР3_вар7
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
            label1 = new Label();
            label2 = new Label();
            txtn = new TextBox();
            txtm = new TextBox();
            label3 = new Label();
            dgvMass = new DataGridView();
            start = new Button();
            clear = new Button();
            result = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMass).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 0;
            label1.Text = "К-ть рядків (n):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 1;
            label2.Text = "К-ть стовпців (m):";
            // 
            // txtn
            // 
            txtn.Location = new Point(150, 9);
            txtn.Name = "txtn";
            txtn.Size = new Size(106, 27);
            txtn.TabIndex = 2;
            // 
            // txtm
            // 
            txtm.Location = new Point(150, 46);
            txtm.Name = "txtm";
            txtm.Size = new Size(106, 27);
            txtm.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 98);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 4;
            label3.Text = "Результат:";
            // 
            // dgvMass
            // 
            dgvMass.AllowUserToOrderColumns = true;
            dgvMass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMass.Location = new Point(271, 9);
            dgvMass.Name = "dgvMass";
            dgvMass.RowHeadersWidth = 51;
            dgvMass.Size = new Size(410, 230);
            dgvMass.TabIndex = 6;
            // 
            // start
            // 
            start.Location = new Point(12, 209);
            start.Name = "start";
            start.Size = new Size(111, 30);
            start.TabIndex = 7;
            start.Text = "Обчислити";
            start.UseVisualStyleBackColor = true;
            start.Click += start_Click;
            // 
            // clear
            // 
            clear.Location = new Point(136, 209);
            clear.Name = "clear";
            clear.Size = new Size(120, 30);
            clear.TabIndex = 8;
            clear.Text = "Очистити поля";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // result
            // 
            result.Location = new Point(12, 130);
            result.Name = "result";
            result.Size = new Size(244, 65);
            result.TabIndex = 9;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 248);
            Controls.Add(result);
            Controls.Add(clear);
            Controls.Add(start);
            Controls.Add(dgvMass);
            Controls.Add(label3);
            Controls.Add(txtm);
            Controls.Add(txtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Завдання 2. Двовимірні масиви";
            ((System.ComponentModel.ISupportInitialize)dgvMass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtn;
        private TextBox txtm;
        private Label label3;
        private DataGridView dgvMass;
        private Button start;
        private Button clear;
        private Label result;
    }
}