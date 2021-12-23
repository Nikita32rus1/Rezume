namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtboxLogin = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.btn1Enter = new System.Windows.Forms.Button();
            this.btn2Exit = new System.Windows.Forms.Button();
            this.btn3Registration = new System.Windows.Forms.Button();
            this.lbAtt = new System.Windows.Forms.Label();
            this.lLogin = new System.Windows.Forms.Label();
            this.lPas = new System.Windows.Forms.Label();
            this.Apas = new System.Windows.Forms.Label();
            this.tableUsersNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new WindowsFormsApplication1.Database1DataSet1();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableUsersNTableAdapter = new WindowsFormsApplication1.Database1DataSet1TableAdapters.TableUsersNTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tableUsersNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogin.Location = new System.Drawing.Point(104, 61);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(112, 20);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Введите логин";
            this.lblLogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtboxLogin
            // 
            this.txtboxLogin.Location = new System.Drawing.Point(107, 90);
            this.txtboxLogin.Name = "txtboxLogin";
            this.txtboxLogin.Size = new System.Drawing.Size(243, 20);
            this.txtboxLogin.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassword.Location = new System.Drawing.Point(104, 138);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(121, 20);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Введите пароль";
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Location = new System.Drawing.Point(107, 168);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.Size = new System.Drawing.Size(243, 20);
            this.txtboxPassword.TabIndex = 3;
            this.txtboxPassword.TextChanged += new System.EventHandler(this.txtboxPassword_TextChanged);
            // 
            // btn1Enter
            // 
            this.btn1Enter.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn1Enter.Location = new System.Drawing.Point(107, 230);
            this.btn1Enter.Name = "btn1Enter";
            this.btn1Enter.Size = new System.Drawing.Size(73, 22);
            this.btn1Enter.TabIndex = 4;
            this.btn1Enter.Text = "Вход";
            this.btn1Enter.UseVisualStyleBackColor = true;
            this.btn1Enter.Click += new System.EventHandler(this.btn1Enter_Click);
            // 
            // btn2Exit
            // 
            this.btn2Exit.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn2Exit.Location = new System.Drawing.Point(275, 230);
            this.btn2Exit.Name = "btn2Exit";
            this.btn2Exit.Size = new System.Drawing.Size(75, 22);
            this.btn2Exit.TabIndex = 6;
            this.btn2Exit.Text = "Выход";
            this.btn2Exit.UseVisualStyleBackColor = true;
            this.btn2Exit.Click += new System.EventHandler(this.btn2Exit_Click);
            // 
            // btn3Registration
            // 
            this.btn3Registration.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn3Registration.Location = new System.Drawing.Point(184, 278);
            this.btn3Registration.Name = "btn3Registration";
            this.btn3Registration.Size = new System.Drawing.Size(88, 23);
            this.btn3Registration.TabIndex = 7;
            this.btn3Registration.Text = "Регистрация";
            this.btn3Registration.UseVisualStyleBackColor = true;
            this.btn3Registration.Click += new System.EventHandler(this.btn3Registration_Click);
            // 
            // lbAtt
            // 
            this.lbAtt.AutoSize = true;
            this.lbAtt.Location = new System.Drawing.Point(367, 206);
            this.lbAtt.Name = "lbAtt";
            this.lbAtt.Size = new System.Drawing.Size(0, 13);
            this.lbAtt.TabIndex = 8;
            // 
            // lLogin
            // 
            this.lLogin.AutoSize = true;
            this.lLogin.ForeColor = System.Drawing.Color.White;
            this.lLogin.Location = new System.Drawing.Point(567, 13);
            this.lLogin.Name = "lLogin";
            this.lLogin.Size = new System.Drawing.Size(35, 13);
            this.lLogin.TabIndex = 9;
            this.lLogin.Text = "label1";
            // 
            // lPas
            // 
            this.lPas.AutoSize = true;
            this.lPas.BackColor = System.Drawing.Color.Transparent;
            this.lPas.ForeColor = System.Drawing.Color.Orange;
            this.lPas.Location = new System.Drawing.Point(367, 18);
            this.lPas.Name = "lPas";
            this.lPas.Size = new System.Drawing.Size(35, 13);
            this.lPas.TabIndex = 10;
            this.lPas.Text = "label2";
            // 
            // Apas
            // 
            this.Apas.AutoSize = true;
            this.Apas.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tableUsersNBindingSource, "Pass", true));
            this.Apas.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Pass", true));
            this.Apas.ForeColor = System.Drawing.Color.Orange;
            this.Apas.Location = new System.Drawing.Point(367, 127);
            this.Apas.Name = "Apas";
            this.Apas.Size = new System.Drawing.Size(35, 13);
            this.Apas.TabIndex = 11;
            this.Apas.Text = "label1";
            // 
            // tableUsersNBindingSource
            // 
            this.tableUsersNBindingSource.DataMember = "TableUsersN";
            this.tableUsersNBindingSource.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "TableUsersN";
            this.bindingSource1.DataSource = this.database1DataSet1;
            // 
            // tableUsersNTableAdapter
            // 
            this.tableUsersNTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(412, 351);
            this.Controls.Add(this.Apas);
            this.Controls.Add(this.lPas);
            this.Controls.Add(this.lLogin);
            this.Controls.Add(this.lbAtt);
            this.Controls.Add(this.btn3Registration);
            this.Controls.Add(this.btn2Exit);
            this.Controls.Add(this.btn1Enter);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtboxLogin);
            this.Controls.Add(this.lblLogin);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableUsersNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtboxLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.Button btn1Enter;
        private System.Windows.Forms.Button btn2Exit;
        private System.Windows.Forms.Button btn3Registration;
        private System.Windows.Forms.Label lbAtt;
        private System.Windows.Forms.Label lLogin;
        private System.Windows.Forms.Label lPas;
        private System.Windows.Forms.Label Apas;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Database1DataSet1 database1DataSet1;
        private Database1DataSet1TableAdapters.TableUsersNTableAdapter tableUsersNTableAdapter;
        private System.Windows.Forms.BindingSource tableUsersNBindingSource;
    }
}

