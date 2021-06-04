namespace MovieRental_V1
{
    partial class UserForm
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
            this.button3 = new System.Windows.Forms.Button();
            this.movieRentalDataSet = new MovieRental_V1.MovieRentalDataSet1();
            this.movieRentalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gENERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gENERTableAdapter = new MovieRental_V1.MovieRentalDataSet1TableAdapters.GENERTableAdapter();
            this.mAINACTORSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mAINACTORSTableAdapter = new MovieRental_V1.MovieRentalDataSet1TableAdapters.MAINACTORSTableAdapter();
            this.nEWUSERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nEW_USERTableAdapter = new MovieRental_V1.MovieRentalDataSet1TableAdapters.NEW_USERTableAdapter();
            this.movieRentalDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
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
            this.dataTable1TableAdapter = new MovieRental_V1.MovieRentalDataSet1TableAdapters.DataTable1TableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.movieRentalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRentalDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gENERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAINACTORSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWUSERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRentalDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRentalDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Teal;
            this.button1.Location = new System.Drawing.Point(360, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Edit Profile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Teal;
            this.button2.Location = new System.Drawing.Point(490, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Browse Movies";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Teal;
            this.button3.Location = new System.Drawing.Point(774, 261);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 35);
            this.button3.TabIndex = 3;
            this.button3.Text = "Sign Out";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // movieRentalDataSet
            // 
            this.movieRentalDataSet.DataSetName = "MovieRentalDataSet";
            this.movieRentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movieRentalDataSetBindingSource
            // 
            this.movieRentalDataSetBindingSource.DataSource = this.movieRentalDataSet;
            this.movieRentalDataSetBindingSource.Position = 0;
            // 
            // gENERBindingSource
            // 
            this.gENERBindingSource.DataMember = "GENER";
            this.gENERBindingSource.DataSource = this.movieRentalDataSetBindingSource;
            // 
            // gENERTableAdapter
            // 
            this.gENERTableAdapter.ClearBeforeFill = true;
            // 
            // mAINACTORSBindingSource
            // 
            this.mAINACTORSBindingSource.DataMember = "MAINACTORS";
            this.mAINACTORSBindingSource.DataSource = this.movieRentalDataSetBindingSource;
            // 
            // mAINACTORSTableAdapter
            // 
            this.mAINACTORSTableAdapter.ClearBeforeFill = true;
            // 
            // nEWUSERBindingSource
            // 
            this.nEWUSERBindingSource.DataMember = "NEW_USER";
            this.nEWUSERBindingSource.DataSource = this.movieRentalDataSetBindingSource;
            // 
            // nEW_USERTableAdapter
            // 
            this.nEW_USERTableAdapter.ClearBeforeFill = true;
            // 
            // movieRentalDataSetBindingSource1
            // 
            this.movieRentalDataSetBindingSource1.DataSource = this.movieRentalDataSet;
            this.movieRentalDataSetBindingSource1.Position = 0;
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
            this.dataGridView1.Location = new System.Drawing.Point(20, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1147, 212);
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
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.movieRentalDataSet1;
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
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Teal;
            this.button4.Location = new System.Drawing.Point(630, 261);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 35);
            this.button4.TabIndex = 4;
            this.button4.Text = "Rent Options";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1179, 324);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movieRentalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRentalDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gENERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAINACTORSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWUSERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRentalDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRentalDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource movieRentalDataSetBindingSource;
        private MovieRentalDataSet1 movieRentalDataSet;
        private System.Windows.Forms.BindingSource gENERBindingSource;
        private MovieRentalDataSet1TableAdapters.GENERTableAdapter gENERTableAdapter;
        private System.Windows.Forms.BindingSource mAINACTORSBindingSource;
        private MovieRentalDataSet1TableAdapters.MAINACTORSTableAdapter mAINACTORSTableAdapter;
        private System.Windows.Forms.BindingSource nEWUSERBindingSource;
        private MovieRentalDataSet1TableAdapters.NEW_USERTableAdapter nEW_USERTableAdapter;
        private System.Windows.Forms.BindingSource movieRentalDataSetBindingSource1;
        private MovieRentalDataSet1 movieRentalDataSet1;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private MovieRentalDataSet1TableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOVIEGEREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAINACTORSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDMINIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOVIEPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOVERSIONSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vIDEOQUALITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dURATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rELEASEYEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOVIEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
    }
}