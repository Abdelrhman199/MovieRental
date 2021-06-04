namespace MovieRental_V1
{
    partial class AdminForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieRentalDataSet1 = new MovieRental_V1.MovieRentalDataSet1();
            this.mOVIEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mOVIETableAdapter = new MovieRental_V1.MovieRentalDataSet1TableAdapters.MOVIETableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.movieRentalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager1 = new MovieRental_V1.MovieRentalDataSet1TableAdapters.TableAdapterManager();
            this.dataTable1TableAdapter = new MovieRental_V1.MovieRentalDataSet1TableAdapters.DataTable1TableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRentalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRentalDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(125, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Movie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(561, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "Update Movie";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.dataGridView1.DataSource = this.dataTable1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1142, 188);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.movieRentalDataSet1;
            // 
            // movieRentalDataSet1
            // 
            this.movieRentalDataSet1.DataSetName = "MovieRentalDataSet";
            this.movieRentalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mOVIEBindingSource
            // 
            this.mOVIEBindingSource.DataMember = "MOVIE";
            this.mOVIEBindingSource.DataSource = this.movieRentalDataSet1;
            // 
            // mOVIETableAdapter
            // 
            this.mOVIETableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(864, 258);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 38);
            this.button4.TabIndex = 5;
            this.button4.Text = "Sign Out";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // movieRentalDataSetBindingSource
            // 
            this.movieRentalDataSetBindingSource.DataSource = this.movieRentalDataSet1;
            this.movieRentalDataSetBindingSource.Position = 0;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CUSTOMERTableAdapter = null;
            this.tableAdapterManager1.GENERTableAdapter = null;
            this.tableAdapterManager1.MAINACTORSTableAdapter = null;
            this.tableAdapterManager1.MOVIETableAdapter = this.mOVIETableAdapter;
            this.tableAdapterManager1.NEW_USERTableAdapter = null;
            this.tableAdapterManager1.NEWADMINTableAdapter = null;
            this.tableAdapterManager1.PAYMENTTableAdapter = null;
            this.tableAdapterManager1.RENTTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = MovieRental_V1.MovieRentalDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(266, 258);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 38);
            this.button3.TabIndex = 6;
            this.button3.Text = "Edit Profile";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(709, 257);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 38);
            this.button5.TabIndex = 7;
            this.button5.Text = "Browse Movies";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(414, 257);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(93, 38);
            this.button6.TabIndex = 8;
            this.button6.Text = "Renting Options";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1166, 353);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.Teal;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRentalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRentalDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource mOVIEBindingSource;
        private MovieRentalDataSet1TableAdapters.MOVIETableAdapter mOVIETableAdapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource movieRentalDataSetBindingSource;
        private MovieRentalDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private MovieRentalDataSet1 movieRentalDataSet1;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private MovieRentalDataSet1TableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}