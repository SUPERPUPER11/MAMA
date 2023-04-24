namespace Trenirovka
{
    partial class Form1
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
            this.Loginbox = new System.Windows.Forms.TextBox();
            this.Passwordbox = new System.Windows.Forms.TextBox();
            this.Oshibka = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.captcha = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.capBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Loginbox
            // 
            this.Loginbox.Location = new System.Drawing.Point(227, 112);
            this.Loginbox.Name = "Loginbox";
            this.Loginbox.Size = new System.Drawing.Size(243, 22);
            this.Loginbox.TabIndex = 0;
            // 
            // Passwordbox
            // 
            this.Passwordbox.Location = new System.Drawing.Point(227, 158);
            this.Passwordbox.Name = "Passwordbox";
            this.Passwordbox.Size = new System.Drawing.Size(243, 22);
            this.Passwordbox.TabIndex = 1;
            // 
            // Oshibka
            // 
            this.Oshibka.AutoSize = true;
            this.Oshibka.Location = new System.Drawing.Point(255, 210);
            this.Oshibka.Name = "Oshibka";
            this.Oshibka.Size = new System.Drawing.Size(192, 16);
            this.Oshibka.TabIndex = 2;
            this.Oshibka.Text = "Неверный логин или пароль";
            this.Oshibka.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пароль";
            // 
            // captcha
            // 
            this.captcha.AutoSize = true;
            this.captcha.BackColor = System.Drawing.Color.IndianRed;
            this.captcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.captcha.Location = new System.Drawing.Point(283, 238);
            this.captcha.Name = "captcha";
            this.captcha.Size = new System.Drawing.Size(148, 32);
            this.captcha.TabIndex = 5;
            this.captcha.Text = "CAPTCHA";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Авторизоваться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // capBox
            // 
            this.capBox.Location = new System.Drawing.Point(236, 273);
            this.capBox.Name = "capBox";
            this.capBox.Size = new System.Drawing.Size(243, 22);
            this.capBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 450);
            this.Controls.Add(this.capBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.captcha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Oshibka);
            this.Controls.Add(this.Passwordbox);
            this.Controls.Add(this.Loginbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Loginbox;
        private System.Windows.Forms.TextBox Passwordbox;
        private System.Windows.Forms.Label Oshibka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label captcha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox capBox;
    }
}

