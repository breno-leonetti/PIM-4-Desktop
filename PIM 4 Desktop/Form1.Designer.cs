namespace PIM_4_Desktop
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbMatriculaFunc = new PIM_4_Desktop.Controles_Personalizados.caixaTexPer();
            this.comboBoxPers2 = new PIM_4_Desktop.Controles_Personalizados.ComboBoxPers();
            this.comboBoxPers1 = new PIM_4_Desktop.Controles_Personalizados.ComboBoxPers();
            this.btnEntrar = new PIM_4_Desktop.Controles_Personalizados.botaoPers();
            this.txbSenhaLogin = new PIM_4_Desktop.Controles_Personalizados.caixaTexPer();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(312, 296);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(117, 31);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "Gerente";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione Uma das Opções Abaixo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(795, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Matrícula de Funcionário:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(796, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Senha:";
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(312, 333);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(133, 31);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.Text = "Vendedor";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(314, 370);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(138, 31);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.Text = "Secretário";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(314, 407);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(115, 31);
            this.radioButton4.TabIndex = 11;
            this.radioButton4.Text = "Lavador";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1326, 117);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::PIM_4_Desktop.Properties.Resources.Tentativa_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(445, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(436, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txbMatriculaFunc
            // 
            this.txbMatriculaFunc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbMatriculaFunc.BackColor = System.Drawing.SystemColors.Window;
            this.txbMatriculaFunc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txbMatriculaFunc.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txbMatriculaFunc.BorderRadius = 5;
            this.txbMatriculaFunc.BorderSize = 2;
            this.txbMatriculaFunc.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMatriculaFunc.ForeColor = System.Drawing.Color.Black;
            this.txbMatriculaFunc.Location = new System.Drawing.Point(796, 275);
            this.txbMatriculaFunc.Margin = new System.Windows.Forms.Padding(4);
            this.txbMatriculaFunc.Multiline = false;
            this.txbMatriculaFunc.Name = "txbMatriculaFunc";
            this.txbMatriculaFunc.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbMatriculaFunc.PasswordChar = false;
            this.txbMatriculaFunc.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbMatriculaFunc.PlaceholderText = "Ex: 123456789";
            this.txbMatriculaFunc.Size = new System.Drawing.Size(372, 39);
            this.txbMatriculaFunc.TabIndex = 18;
            this.txbMatriculaFunc.Texts = "";
            this.txbMatriculaFunc.UnderlinedStyle = false;
            this.txbMatriculaFunc._TextChanged += new System.EventHandler(this.txbMatriculaFunc__TextChanged);
            // 
            // comboBoxPers2
            // 
            this.comboBoxPers2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPers2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxPers2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.comboBoxPers2.BorderRadius = 0;
            this.comboBoxPers2.BorderSize = 2;
            this.comboBoxPers2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboBoxPers2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxPers2.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxPers2.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.comboBoxPers2.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comboBoxPers2.ListTextColor = System.Drawing.Color.DimGray;
            this.comboBoxPers2.Location = new System.Drawing.Point(796, 519);
            this.comboBoxPers2.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboBoxPers2.Name = "comboBoxPers2";
            this.comboBoxPers2.Padding = new System.Windows.Forms.Padding(2);
            this.comboBoxPers2.Size = new System.Drawing.Size(372, 30);
            this.comboBoxPers2.TabIndex = 16;
            this.comboBoxPers2.Texts = "";
            // 
            // comboBoxPers1
            // 
            this.comboBoxPers1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPers1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxPers1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.comboBoxPers1.BorderRadius = 10;
            this.comboBoxPers1.BorderSize = 2;
            this.comboBoxPers1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboBoxPers1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxPers1.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxPers1.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.comboBoxPers1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comboBoxPers1.ListTextColor = System.Drawing.Color.DimGray;
            this.comboBoxPers1.Location = new System.Drawing.Point(796, 574);
            this.comboBoxPers1.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboBoxPers1.Name = "comboBoxPers1";
            this.comboBoxPers1.Padding = new System.Windows.Forms.Padding(2);
            this.comboBoxPers1.Size = new System.Drawing.Size(372, 30);
            this.comboBoxPers1.TabIndex = 15;
            this.comboBoxPers1.Texts = "";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(254)))), ((int)(((byte)(40)))));
            this.btnEntrar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(254)))), ((int)(((byte)(40)))));
            this.btnEntrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEntrar.BorderRadius = 5;
            this.btnEntrar.BorderSize = 0;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(796, 434);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(372, 39);
            this.btnEntrar.TabIndex = 14;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.TextColor = System.Drawing.Color.White;
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txbSenhaLogin
            // 
            this.txbSenhaLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSenhaLogin.BackColor = System.Drawing.SystemColors.Window;
            this.txbSenhaLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txbSenhaLogin.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txbSenhaLogin.BorderRadius = 5;
            this.txbSenhaLogin.BorderSize = 2;
            this.txbSenhaLogin.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenhaLogin.ForeColor = System.Drawing.Color.Black;
            this.txbSenhaLogin.Location = new System.Drawing.Point(796, 369);
            this.txbSenhaLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txbSenhaLogin.Multiline = false;
            this.txbSenhaLogin.Name = "txbSenhaLogin";
            this.txbSenhaLogin.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbSenhaLogin.PasswordChar = true;
            this.txbSenhaLogin.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbSenhaLogin.PlaceholderText = "Sua Senha de Login do Aplicativo";
            this.txbSenhaLogin.Size = new System.Drawing.Size(372, 39);
            this.txbSenhaLogin.TabIndex = 19;
            this.txbSenhaLogin.Texts = "";
            this.txbSenhaLogin.UnderlinedStyle = false;
            this.txbSenhaLogin._TextChanged += new System.EventHandler(this.txbSenhaLogin__TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.txbSenhaLogin);
            this.Controls.Add(this.txbMatriculaFunc);
            this.Controls.Add(this.comboBoxPers2);
            this.Controls.Add(this.comboBoxPers1);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "Form1";
            this.Text = "AluCar Locadora de Veículos";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Controles_Personalizados.botaoPers btnEntrar;
        private Controles_Personalizados.ComboBoxPers comboBoxPers1;
        private Controles_Personalizados.ComboBoxPers comboBoxPers2;
        private Controles_Personalizados.caixaTexPer txbMatriculaFunc;
        private Controles_Personalizados.caixaTexPer txbSenhaLogin;
    }
}

