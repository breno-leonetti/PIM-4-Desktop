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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbMatriculaFunc = new PIM_4_Desktop.Controles_Personalizados.caixaTexPer();
            this.btnEntrar = new PIM_4_Desktop.Controles_Personalizados.botaoPers();
            this.txbSenhaLogin = new PIM_4_Desktop.Controles_Personalizados.caixaTexPer();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(456, 234);
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
            this.label3.Location = new System.Drawing.Point(457, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Senha:";
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
            this.txbMatriculaFunc.Location = new System.Drawing.Point(457, 265);
            this.txbMatriculaFunc.Margin = new System.Windows.Forms.Padding(4);
            this.txbMatriculaFunc.Multiline = false;
            this.txbMatriculaFunc.Name = "txbMatriculaFunc";
            this.txbMatriculaFunc.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbMatriculaFunc.PasswordChar = false;
            this.txbMatriculaFunc.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbMatriculaFunc.PlaceholderText = "Ex: 123456789";
            this.txbMatriculaFunc.Size = new System.Drawing.Size(436, 39);
            this.txbMatriculaFunc.TabIndex = 18;
            this.txbMatriculaFunc.Texts = "";
            this.txbMatriculaFunc.UnderlinedStyle = false;
            this.txbMatriculaFunc._TextChanged += new System.EventHandler(this.txbMatriculaFunc__TextChanged);
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
            this.btnEntrar.Location = new System.Drawing.Point(457, 424);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(436, 78);
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
            this.txbSenhaLogin.Location = new System.Drawing.Point(457, 359);
            this.txbSenhaLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txbSenhaLogin.Multiline = false;
            this.txbSenhaLogin.Name = "txbSenhaLogin";
            this.txbSenhaLogin.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbSenhaLogin.PasswordChar = true;
            this.txbSenhaLogin.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbSenhaLogin.PlaceholderText = "Sua Senha de Login do Aplicativo";
            this.txbSenhaLogin.Size = new System.Drawing.Size(436, 39);
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
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "Form1";
            this.Text = "AluCar Locadora de Veículos";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Controles_Personalizados.botaoPers btnEntrar;
        private Controles_Personalizados.caixaTexPer txbMatriculaFunc;
        private Controles_Personalizados.caixaTexPer txbSenhaLogin;
    }
}

