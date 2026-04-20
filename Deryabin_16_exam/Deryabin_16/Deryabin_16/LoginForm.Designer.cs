namespace Deryabin_16
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReg = new System.Windows.Forms.Button();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnGoust = new System.Windows.Forms.Button();
            this.lnk = new System.Windows.Forms.LinkLabel();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(355, 286);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(87, 23);
            this.btnReg.TabIndex = 0;
            this.btnReg.Text = "Регистрация";
            this.btnReg.UseVisualStyleBackColor = true;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(108, 286);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(75, 23);
            this.btnSignIn.TabIndex = 1;
            this.btnSignIn.Text = "Войти";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnGoust
            // 
            this.btnGoust.Location = new System.Drawing.Point(189, 286);
            this.btnGoust.Name = "btnGoust";
            this.btnGoust.Size = new System.Drawing.Size(104, 23);
            this.btnGoust.TabIndex = 2;
            this.btnGoust.Text = "Войти как гость";
            this.btnGoust.UseVisualStyleBackColor = true;
            // 
            // lnk
            // 
            this.lnk.AutoSize = true;
            this.lnk.Location = new System.Drawing.Point(12, 291);
            this.lnk.Name = "lnk";
            this.lnk.Size = new System.Drawing.Size(90, 13);
            this.lnk.TabIndex = 3;
            this.lnk.TabStop = true;
            this.lnk.Text = "Нужна помощь?";
           
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(70, 59);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(100, 20);
            this.txtLogin.TabIndex = 4;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(67, 43);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(38, 13);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "Логин";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(67, 103);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(45, 13);
            this.lbl2.TabIndex = 7;
            this.lbl2.Text = "Пароль";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(70, 119);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 6;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 321);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lnk);
            this.Controls.Add(this.btnGoust);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.btnReg);
            this.Name = "LoginForm";
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnGoust;
        private System.Windows.Forms.LinkLabel lnk;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtPassword;
    }
}

