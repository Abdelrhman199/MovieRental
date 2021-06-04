namespace MovieRental_V1
{
    partial class BrowseMovies
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
            this.movieRentalDataSet1 = new MovieRental_V1.MovieRentalDataSet1();
            this.dataTable1TableAdapter = new MovieRental_V1.MovieRentalDataSet1TableAdapters.DataTable1TableAdapter();
            this.tableAdapterManager = new MovieRental_V1.MovieRentalDataSet1TableAdapters.TableAdapterManager();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mOVIEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rELEASEYEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dURATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vIDEOQUALITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOVERSIONSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mOVIEPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDMINIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAINACTORSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mOVIEGEREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.movieRentalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // movieRentalDataSet1
            // 
            this.movieRentalDataSet1.DataSetName = "MovieRentalDataSet1";
            this.movieRentalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CUSTOMERTableAdapter = null;
            this.tableAdapterManager.GENERTableAdapter = null;
            this.tableAdapterManager.MAINACTORSTableAdapter = null;
            this.tableAdapterManager.MOVIETableAdapter = null;
            this.tableAdapterManager.NEW_USERTableAdapter = null;
            this.tableAdapterManager.NEWADMINTableAdapter = null;
            this.tableAdapterManager.PAYMENTTableAdapter = null;
            this.tableAdapterManager.RENTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MovieRental_V1.MovieRentalDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mOVIEIDDataGridViewTextBoxColumn,
            this.movieNAMEDataGridViewTextBoxColumn,
            this.rATEDataGridViewTextBoxColumn,
            this.rELEASEYEARDataGridViewTextBoxColumn,
            this.dURATIONDataGridViewTextBoxColumn,
            this.vIDEOQUALITYDataGridViewTextBoxColumn,
            this.nOVERSIONSDataGridViewTextBoxColumn,
            this.mOVIEPRICEDataGridViewTextBoxColumn,
            this.aDMINIDDataGridViewTextBoxColumn,
            this.mAINACTORSDataGridViewTextBoxColumn,
            this.mOVIEGEREDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataTable1BindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(24, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1143, 307);
            this.dataGridView1.TabIndex = 0;
            // 
            // mOVIEIDDataGridViewTextBoxColumn
            // 
            this.mOVIEIDDataGridViewTextBoxColumn.DataPropertyName = "MOVIE_ID";
            this.mOVIEIDDataGridViewTextBoxColumn.HeaderText = "MOVIE_ID";
            this.mOVIEIDDataGridViewTextBoxColumn.Name = "mOVIEIDDataGridViewTextBoxColumn";
            // 
            // movieNAMEDataGridViewTextBoxColumn
            // 
            this.movieNAMEDataGridViewTextBoxColumn.DataPropertyName = "Movie_NAME";
            this.movieNAMEDataGridViewTextBoxColumn.HeaderText = "Movie_NAME";
            this.movieNAMEDataGridViewTextBoxColumn.Name = "movieNAMEDataGridViewTextBoxColumn";
            // 
            // rATEDataGridViewTextBoxColumn
            // 
            this.rATEDataGridViewTextBoxColumn.DataPropertyName = "RATE";
            this.rATEDataGridViewTextBoxColumn.HeaderText = "RATE";
            this.rATEDataGridViewTextBoxColumn.Name = "rATEDataGridViewTextBoxColumn";
            // 
            // rELEASEYEARDataGridViewTextBoxColumn
            // 
            this.rELEASEYEARDataGridViewTextBoxColumn.DataPropertyName = "RELEASE_YEAR";
            this.rELEASEYEARDataGridViewTextBoxColumn.HeaderText = "RELEASE_YEAR";
            this.rELEASEYEARDataGridViewTextBoxColumn.Name = "rELEASEYEARDataGridViewTextBoxColumn";
            // 
            // dURATIONDataGridViewTextBoxColumn
            // 
            this.dURATIONDataGridViewTextBoxColumn.DataPropertyName = "DURATION";
            this.dURATIONDataGridViewTextBoxColumn.HeaderText = "DURATION";
            this.dURATIONDataGridViewTextBoxColumn.Name = "dURATIONDataGridViewTextBoxColumn";
            // 
            // vIDEOQUALITYDataGridViewTextBoxColumn
            // 
            this.vIDEOQUALITYDataGridViewTextBoxColumn.DataPropertyName = "VIDEO_QUALITY";
            this.vIDEOQUALITYDataGridViewTextBoxColumn.HeaderText = "VIDEO_QUALITY";
            this.vIDEOQUALITYDataGridViewTextBoxColumn.Name = "vIDEOQUALITYDataGridViewTextBoxColumn";
            // 
            // nOVERSIONSDataGridViewTextBoxColumn
            // 
            this.nOVERSIONSDataGridViewTextBoxColumn.DataPropertyName = "NO_VERSIONS";
            this.nOVERSIONSDataGridViewTextBoxColumn.HeaderText = "NO_VERSIONS";
            this.nOVERSIONSDataGridViewTextBoxColumn.Name = "nOVERSIONSDataGridViewTextBoxColumn";
            // 
            // mOVIEPRICEDataGridViewTextBoxColumn
            // 
            this.mOVIEPRICEDataGridViewTextBoxColumn.DataPropertyName = "MOVIE_PRICE";
            this.mOVIEPRICEDataGridViewTextBoxColumn.HeaderText = "MOVIE_PRICE";
            this.mOVIEPRICEDataGridViewTextBoxColumn.Name = "mOVIEPRICEDataGridViewTextBoxColumn";
            // 
            // aDMINIDDataGridViewTextBoxColumn
            // 
            this.aDMINIDDataGridViewTextBoxColumn.DataPropertyName = "ADMIN_ID";
            this.aDMINIDDataGridViewTextBoxColumn.HeaderText = "ADMIN_ID";
            this.aDMINIDDataGridViewTextBoxColumn.Name = "aDMINIDDataGridViewTextBoxColumn";
            // 
            // mAINACTORSDataGridViewTextBoxColumn
            // 
            this.mAINACTORSDataGridViewTextBoxColumn.DataPropertyName = "MAIN_ACTORS";
            this.mAINACTORSDataGridViewTextBoxColumn.HeaderText = "MAIN_ACTORS";
            this.mAINACTORSDataGridViewTextBoxColumn.Name = "mAINACTORSDataGridViewTextBoxColumn";
            // 
            // mOVIEGEREDataGridViewTextBoxColumn
            // 
            this.mOVIEGEREDataGridViewTextBoxColumn.DataPropertyName = "MOVIE_GERE";
            this.mOVIEGEREDataGridViewTextBoxColumn.HeaderText = "MOVIE_GERE";
            this.mOVIEGEREDataGridViewTextBoxColumn.Name = "mOVIEGEREDataGridViewTextBoxColumn";
            // 
            // dataTable1BindingSource1
            // 
            this.dataTable1BindingSource1.DataMember = "DataTable1";
            this.dataTable1BindingSource1.DataSource = this.movieRentalDataSet1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Gener",
            "Actor",
            "Year"});
            this.comboBox1.Location = new System.Drawing.Point(67, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Teal;
            this.button1.Location = new System.Drawing.Point(409, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(263, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Location = new System.Drawing.Point(209, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Teal;
            this.button2.Location = new System.Drawing.Point(529, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Choose";
            // 
            // BrowseMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1187, 434);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BrowseMovies";
            this.Text = "BrowseMovies";
            this.Load += new System.EventHandler(this.BrowseMovies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movieRentalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MovieRentalDataSet1 movieRentalDataSet1;
        private MovieRentalDataSet1TableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private MovieRentalDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOVIEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rELEASEYEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dURATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vIDEOQUALITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOVERSIONSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOVIEPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDMINIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAINACTORSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOVIEGEREDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}