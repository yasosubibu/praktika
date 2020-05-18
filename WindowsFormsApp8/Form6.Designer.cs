namespace WindowsFormsApp8
{
    partial class Form6
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loginbox = new System.Windows.Forms.TextBox();
            this.passbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Buttonlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Location = new System.Drawing.Point(-5, 455);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 87);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSlateGray;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Форма авторизации ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.label3.Location = new System.Drawing.Point(86, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Пароль";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Location = new System.Drawing.Point(-4, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(543, 119);
            this.panel2.TabIndex = 4;
            // 
            // loginbox
            // 
            this.loginbox.Location = new System.Drawing.Point(187, 214);
            this.loginbox.Name = "loginbox";
            this.loginbox.Size = new System.Drawing.Size(257, 20);
            this.loginbox.TabIndex = 5;
            // 
            // passbox
            // 
            this.passbox.Location = new System.Drawing.Point(187, 277);
            this.passbox.Name = "passbox";
            this.passbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.passbox.Size = new System.Drawing.Size(257, 20);
            this.passbox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "Назад ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Buttonlogin
            // 
            this.Buttonlogin.Location = new System.Drawing.Point(364, 366);
            this.Buttonlogin.Name = "Buttonlogin";
            this.Buttonlogin.Size = new System.Drawing.Size(80, 26);
            this.Buttonlogin.TabIndex = 8;
            this.Buttonlogin.Text = "Войти ";
            this.Buttonlogin.UseVisualStyleBackColor = true;
            this.Buttonlogin.Click += new System.EventHandler(this.Buttonlogin_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 539);
            this.Controls.Add(this.Buttonlogin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passbox);
            this.Controls.Add(this.loginbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox loginbox;
        private System.Windows.Forms.TextBox passbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Buttonlogin;
    }
}