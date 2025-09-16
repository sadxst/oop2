namespace ООП_ПР1
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
            login = new TextBox();
            result = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Логін:";
            // 
            // login
            // 
            login.Location = new Point(68, 15);
            login.Name = "login";
            login.Size = new Size(222, 27);
            login.TabIndex = 1;
            login.TextChanged += login_TextChanged;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            result.Location = new Point(12, 54);
            result.Name = "result";
            result.Size = new Size(83, 20);
            result.TabIndex = 3;
            result.Text = "Результат:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 93);
            Controls.Add(result);
            Controls.Add(login);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Завдання 1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox login;
        private Label result;
    }
}
