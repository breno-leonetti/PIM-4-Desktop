namespace PIM_4_Desktop
{
    partial class Form14
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idveiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renavamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroportasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmatualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valordiariaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fipeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_AlucarDataSet2 = new PIM_4_Desktop.BD_AlucarDataSet2();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botaoPers3 = new PIM_4_Desktop.Controles_Personalizados.botaoPers();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.botaoPers1 = new PIM_4_Desktop.Controles_Personalizados.botaoPers();
            this.label1 = new System.Windows.Forms.Label();
            this.veiculoId = new PIM_4_Desktop.Controles_Personalizados.caixaTexPer();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botaoPers2 = new PIM_4_Desktop.Controles_Personalizados.botaoPers();
            this.veiculosTableAdapter = new PIM_4_Desktop.BD_AlucarDataSet2TableAdapters.VeiculosTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_AlucarDataSet2)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 168);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1326, 549);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1318, 523);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Buscar e Excluir";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idveiculoDataGridViewTextBoxColumn,
            this.renavamDataGridViewTextBoxColumn,
            this.placaDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.anoDataGridViewTextBoxColumn,
            this.corDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.numeroportasDataGridViewTextBoxColumn,
            this.kmatualDataGridViewTextBoxColumn,
            this.valordiariaDataGridViewTextBoxColumn,
            this.fipeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.veiculosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(462, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(833, 485);
            this.dataGridView1.TabIndex = 0;
            // 
            // idveiculoDataGridViewTextBoxColumn
            // 
            this.idveiculoDataGridViewTextBoxColumn.DataPropertyName = "id_veiculo";
            this.idveiculoDataGridViewTextBoxColumn.HeaderText = "id_veiculo";
            this.idveiculoDataGridViewTextBoxColumn.Name = "idveiculoDataGridViewTextBoxColumn";
            this.idveiculoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // renavamDataGridViewTextBoxColumn
            // 
            this.renavamDataGridViewTextBoxColumn.DataPropertyName = "renavam";
            this.renavamDataGridViewTextBoxColumn.HeaderText = "renavam";
            this.renavamDataGridViewTextBoxColumn.Name = "renavamDataGridViewTextBoxColumn";
            // 
            // placaDataGridViewTextBoxColumn
            // 
            this.placaDataGridViewTextBoxColumn.DataPropertyName = "placa";
            this.placaDataGridViewTextBoxColumn.HeaderText = "placa";
            this.placaDataGridViewTextBoxColumn.Name = "placaDataGridViewTextBoxColumn";
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            // 
            // anoDataGridViewTextBoxColumn
            // 
            this.anoDataGridViewTextBoxColumn.DataPropertyName = "ano";
            this.anoDataGridViewTextBoxColumn.HeaderText = "ano";
            this.anoDataGridViewTextBoxColumn.Name = "anoDataGridViewTextBoxColumn";
            // 
            // corDataGridViewTextBoxColumn
            // 
            this.corDataGridViewTextBoxColumn.DataPropertyName = "cor";
            this.corDataGridViewTextBoxColumn.HeaderText = "cor";
            this.corDataGridViewTextBoxColumn.Name = "corDataGridViewTextBoxColumn";
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            // 
            // numeroportasDataGridViewTextBoxColumn
            // 
            this.numeroportasDataGridViewTextBoxColumn.DataPropertyName = "numeroportas";
            this.numeroportasDataGridViewTextBoxColumn.HeaderText = "numeroportas";
            this.numeroportasDataGridViewTextBoxColumn.Name = "numeroportasDataGridViewTextBoxColumn";
            // 
            // kmatualDataGridViewTextBoxColumn
            // 
            this.kmatualDataGridViewTextBoxColumn.DataPropertyName = "km_atual";
            this.kmatualDataGridViewTextBoxColumn.HeaderText = "km_atual";
            this.kmatualDataGridViewTextBoxColumn.Name = "kmatualDataGridViewTextBoxColumn";
            // 
            // valordiariaDataGridViewTextBoxColumn
            // 
            this.valordiariaDataGridViewTextBoxColumn.DataPropertyName = "valor_diaria";
            this.valordiariaDataGridViewTextBoxColumn.HeaderText = "valor_diaria";
            this.valordiariaDataGridViewTextBoxColumn.Name = "valordiariaDataGridViewTextBoxColumn";
            // 
            // fipeDataGridViewTextBoxColumn
            // 
            this.fipeDataGridViewTextBoxColumn.DataPropertyName = "fipe";
            this.fipeDataGridViewTextBoxColumn.HeaderText = "fipe";
            this.fipeDataGridViewTextBoxColumn.Name = "fipeDataGridViewTextBoxColumn";
            // 
            // veiculosBindingSource
            // 
            this.veiculosBindingSource.DataMember = "Veiculos";
            this.veiculosBindingSource.DataSource = this.bD_AlucarDataSet2;
            // 
            // bD_AlucarDataSet2
            // 
            this.bD_AlucarDataSet2.DataSetName = "BD_AlucarDataSet2";
            this.bD_AlucarDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.199661F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97.80034F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 181F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(612, 497);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.botaoPers3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 222);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // botaoPers3
            // 
            this.botaoPers3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoPers3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(254)))), ((int)(((byte)(40)))));
            this.botaoPers3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(254)))), ((int)(((byte)(40)))));
            this.botaoPers3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botaoPers3.BorderRadius = 5;
            this.botaoPers3.BorderSize = 0;
            this.botaoPers3.FlatAppearance.BorderSize = 0;
            this.botaoPers3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoPers3.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoPers3.ForeColor = System.Drawing.Color.White;
            this.botaoPers3.Location = new System.Drawing.Point(25, 90);
            this.botaoPers3.Name = "botaoPers3";
            this.botaoPers3.Size = new System.Drawing.Size(364, 40);
            this.botaoPers3.TabIndex = 21;
            this.botaoPers3.Text = "EXIBIR LISTA";
            this.botaoPers3.TextColor = System.Drawing.Color.White;
            this.botaoPers3.UseVisualStyleBackColor = false;
            this.botaoPers3.Click += new System.EventHandler(this.botaoPers3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.botaoPers1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.veiculoId);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 222);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exlcuir/Deletar";
            // 
            // botaoPers1
            // 
            this.botaoPers1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoPers1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.botaoPers1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.botaoPers1.BorderColor = System.Drawing.Color.PeachPuff;
            this.botaoPers1.BorderRadius = 5;
            this.botaoPers1.BorderSize = 0;
            this.botaoPers1.FlatAppearance.BorderSize = 0;
            this.botaoPers1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoPers1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoPers1.ForeColor = System.Drawing.Color.White;
            this.botaoPers1.Location = new System.Drawing.Point(25, 151);
            this.botaoPers1.Name = "botaoPers1";
            this.botaoPers1.Size = new System.Drawing.Size(364, 40);
            this.botaoPers1.TabIndex = 22;
            this.botaoPers1.Text = "EXCLUIR";
            this.botaoPers1.TextColor = System.Drawing.Color.White;
            this.botaoPers1.UseVisualStyleBackColor = false;
            this.botaoPers1.Click += new System.EventHandler(this.botaoPers1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 24);
            this.label1.TabIndex = 37;
            this.label1.Text = "ID do Veículo p/ Excluir:";
            // 
            // veiculoId
            // 
            this.veiculoId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.veiculoId.BackColor = System.Drawing.SystemColors.Window;
            this.veiculoId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.veiculoId.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.veiculoId.BorderRadius = 5;
            this.veiculoId.BorderSize = 2;
            this.veiculoId.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veiculoId.ForeColor = System.Drawing.Color.Black;
            this.veiculoId.Location = new System.Drawing.Point(25, 74);
            this.veiculoId.Margin = new System.Windows.Forms.Padding(4);
            this.veiculoId.Multiline = false;
            this.veiculoId.Name = "veiculoId";
            this.veiculoId.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.veiculoId.PasswordChar = false;
            this.veiculoId.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.veiculoId.PlaceholderText = "ID do Veículo. Ex: 01";
            this.veiculoId.Size = new System.Drawing.Size(364, 39);
            this.veiculoId.TabIndex = 36;
            this.veiculoId.Texts = "";
            this.veiculoId.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(379, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(609, 29);
            this.label3.TabIndex = 72;
            this.label3.Text = "Busca, Alteração e Exclusão de Cadastro de Veículo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1326, 117);
            this.tableLayoutPanel1.TabIndex = 71;
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
            // botaoPers2
            // 
            this.botaoPers2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.botaoPers2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.botaoPers2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botaoPers2.BorderRadius = 5;
            this.botaoPers2.BorderSize = 0;
            this.botaoPers2.FlatAppearance.BorderSize = 0;
            this.botaoPers2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoPers2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoPers2.ForeColor = System.Drawing.Color.White;
            this.botaoPers2.Location = new System.Drawing.Point(61, 67);
            this.botaoPers2.Name = "botaoPers2";
            this.botaoPers2.Size = new System.Drawing.Size(191, 34);
            this.botaoPers2.TabIndex = 73;
            this.botaoPers2.Text = "<- MENU ANTERIOR";
            this.botaoPers2.TextColor = System.Drawing.Color.White;
            this.botaoPers2.UseVisualStyleBackColor = false;
            this.botaoPers2.Click += new System.EventHandler(this.botaoPers2_Click);
            // 
            // veiculosTableAdapter
            // 
            this.veiculosTableAdapter.ClearBeforeFill = true;
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.botaoPers2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form14";
            this.Text = "Form14";
            this.Load += new System.EventHandler(this.Form14_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_AlucarDataSet2)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Controles_Personalizados.botaoPers botaoPers3;
        private Controles_Personalizados.botaoPers botaoPers1;
        private System.Windows.Forms.Label label1;
        private Controles_Personalizados.caixaTexPer veiculoId;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Controles_Personalizados.botaoPers botaoPers2;
        private BD_AlucarDataSet2 bD_AlucarDataSet2;
        private System.Windows.Forms.BindingSource veiculosBindingSource;
        private BD_AlucarDataSet2TableAdapters.VeiculosTableAdapter veiculosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idveiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn renavamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroportasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmatualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valordiariaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fipeDataGridViewTextBoxColumn;
    }
}