namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.TXt_regLogin = new System.Windows.Forms.TextBox();
            this.TXt_regPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Registr = new System.Windows.Forms.Button();
            this.richTBRegists = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXt_regLogin
            // 
            this.TXt_regLogin.Location = new System.Drawing.Point(172, 32);
            this.TXt_regLogin.Name = "TXt_regLogin";
            this.TXt_regLogin.Size = new System.Drawing.Size(194, 20);
            this.TXt_regLogin.TabIndex = 0;
            // 
            // TXt_regPass
            // 
            this.TXt_regPass.Location = new System.Drawing.Point(172, 84);
            this.TXt_regPass.Name = "TXt_regPass";
            this.TXt_regPass.Size = new System.Drawing.Size(194, 20);
            this.TXt_regPass.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(169, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(169, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите пароль";
            // 
            // btn_Registr
            // 
            this.btn_Registr.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Registr.ForeColor = System.Drawing.Color.Black;
            this.btn_Registr.Location = new System.Drawing.Point(201, 132);
            this.btn_Registr.Name = "btn_Registr";
            this.btn_Registr.Size = new System.Drawing.Size(165, 23);
            this.btn_Registr.TabIndex = 5;
            this.btn_Registr.Text = "Зарегестрироваться";
            this.btn_Registr.UseVisualStyleBackColor = true;
            this.btn_Registr.Click += new System.EventHandler(this.btn_Registr_Click);
            // 
            // richTBRegists
            // 
            this.richTBRegists.BackColor = System.Drawing.SystemColors.HotTrack;
            this.richTBRegists.Location = new System.Drawing.Point(172, 161);
            this.richTBRegists.Name = "richTBRegists";
            this.richTBRegists.Size = new System.Drawing.Size(219, 89);
            this.richTBRegists.TabIndex = 6;
            this.richTBRegists.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(56, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Вернуться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(547, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTBRegists);
            this.Controls.Add(this.btn_Registr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXt_regPass);
            this.Controls.Add(this.TXt_regLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXt_regLogin;
        private System.Windows.Forms.TextBox TXt_regPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Registr;
        private System.Windows.Forms.RichTextBox richTBRegists;
        private System.Windows.Forms.Button button1;
    }
}