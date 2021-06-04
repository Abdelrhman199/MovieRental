namespace MovieRental_V1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.fontDialog2 = new System.Windows.Forms.FontDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uSERNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERPAssDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zIPCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOUNTRYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERROLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nEWUSERBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.movieRentalDataSet1 = new MovieRental_V1.MovieRentalDataSet1();
            this.nEWUSERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieRentalDataSet = new MovieRental_V1.MovieRentalDataSet1();
            this.button4 = new System.Windows.Forms.Button();
            this.nEWUSERBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mOVIEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mOVIETableAdapter = new MovieRental_V1.MovieRentalDataSet1TableAdapters.MOVIETableAdapter();
            this.nEW_USERTableAdapter = new MovieRental_V1.MovieRentalDataSet1TableAdapters.NEW_USERTableAdapter();
            this.fontDialog3 = new System.Windows.Forms.FontDialog();
            this.fKCUSTOMERISCUSTOMUSERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUSTOMERTableAdapter = new MovieRental_V1.MovieRentalDataSet1TableAdapters.CUSTOMERTableAdapter();
            this.nEW_USERTableAdapter1 = new MovieRental_V1.MovieRentalDataSet1TableAdapters.NEW_USERTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWUSERBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRentalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWUSERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRentalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWUSERBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCUSTOMERISCUSTOMUSERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Teal;
            this.button1.Location = new System.Drawing.Point(58, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 41);
            this.button1.TabIndex = 24;
            this.button1.Text = "Create New Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Teal;
            this.button2.Location = new System.Drawing.Point(58, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 37);
            this.button2.TabIndex = 25;
            this.button2.Text = "Sign In";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uSERNAMEDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.uSERPAssDataGridViewTextBoxColumn,
            this.aGEDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.pHONEDataGridViewTextBoxColumn,
            this.sTADDRESSDataGridViewTextBoxColumn,
            this.cITYDataGridViewTextBoxColumn,
            this.zIPCODEDataGridViewTextBoxColumn,
            this.cOUNTRYDataGridViewTextBoxColumn,
            this.uSERROLEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nEWUSERBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(259, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(582, 203);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // uSERNAMEDataGridViewTextBoxColumn
            // 
            this.uSERNAMEDataGridViewTextBoxColumn.DataPropertyName = "USERNAME";
            this.uSERNAMEDataGridViewTextBoxColumn.HeaderText = "USERNAME";
            this.uSERNAMEDataGridViewTextBoxColumn.Name = "uSERNAMEDataGridViewTextBoxColumn";
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.MaxInputLength = 5000;
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            this.eMAILDataGridViewTextBoxColumn.Width = 64;
            // 
            // uSERPAssDataGridViewTextBoxColumn
            // 
            this.uSERPAssDataGridViewTextBoxColumn.DataPropertyName = "USERPAss";
            this.uSERPAssDataGridViewTextBoxColumn.HeaderText = "USERPAss";
            this.uSERPAssDataGridViewTextBoxColumn.Name = "uSERPAssDataGridViewTextBoxColumn";
            // 
            // aGEDataGridViewTextBoxColumn
            // 
            this.aGEDataGridViewTextBoxColumn.DataPropertyName = "AGE";
            this.aGEDataGridViewTextBoxColumn.HeaderText = "AGE";
            this.aGEDataGridViewTextBoxColumn.Name = "aGEDataGridViewTextBoxColumn";
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "Fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "Fname";
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "Lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "Lname";
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            // 
            // pHONEDataGridViewTextBoxColumn
            // 
            this.pHONEDataGridViewTextBoxColumn.DataPropertyName = "PHONE";
            this.pHONEDataGridViewTextBoxColumn.HeaderText = "PHONE";
            this.pHONEDataGridViewTextBoxColumn.Name = "pHONEDataGridViewTextBoxColumn";
            // 
            // sTADDRESSDataGridViewTextBoxColumn
            // 
            this.sTADDRESSDataGridViewTextBoxColumn.DataPropertyName = "ST_ADDRESS";
            this.sTADDRESSDataGridViewTextBoxColumn.HeaderText = "ST_ADDRESS";
            this.sTADDRESSDataGridViewTextBoxColumn.Name = "sTADDRESSDataGridViewTextBoxColumn";
            // 
            // cITYDataGridViewTextBoxColumn
            // 
            this.cITYDataGridViewTextBoxColumn.DataPropertyName = "CITY";
            this.cITYDataGridViewTextBoxColumn.HeaderText = "CITY";
            this.cITYDataGridViewTextBoxColumn.Name = "cITYDataGridViewTextBoxColumn";
            // 
            // zIPCODEDataGridViewTextBoxColumn
            // 
            this.zIPCODEDataGridViewTextBoxColumn.DataPropertyName = "ZIPCODE";
            this.zIPCODEDataGridViewTextBoxColumn.HeaderText = "ZIPCODE";
            this.zIPCODEDataGridViewTextBoxColumn.Name = "zIPCODEDataGridViewTextBoxColumn";
            // 
            // cOUNTRYDataGridViewTextBoxColumn
            // 
            this.cOUNTRYDataGridViewTextBoxColumn.DataPropertyName = "COUNTRY";
            this.cOUNTRYDataGridViewTextBoxColumn.HeaderText = "COUNTRY";
            this.cOUNTRYDataGridViewTextBoxColumn.Name = "cOUNTRYDataGridViewTextBoxColumn";
            // 
            // uSERROLEDataGridViewTextBoxColumn
            // 
            this.uSERROLEDataGridViewTextBoxColumn.DataPropertyName = "USER_ROLE";
            this.uSERROLEDataGridViewTextBoxColumn.HeaderText = "USER_ROLE";
            this.uSERROLEDataGridViewTextBoxColumn.Name = "uSERROLEDataGridViewTextBoxColumn";
            // 
            // nEWUSERBindingSource2
            // 
            this.nEWUSERBindingSource2.DataMember = "NEW_USER";
            this.nEWUSERBindingSource2.DataSource = this.movieRentalDataSet1;
            // 
            // movieRentalDataSet1
            // 
            this.movieRentalDataSet1.DataSetName = "MovieRentalDataSet1";
            this.movieRentalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nEWUSERBindingSource
            // 
            this.nEWUSERBindingSource.DataMember = "NEW_USER";
            this.nEWUSERBindingSource.DataSource = this.movieRentalDataSet;
            // 
            // movieRentalDataSet
            // 
            this.movieRentalDataSet.DataSetName = "MovieRentalDataSet";
            this.movieRentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Teal;
            this.button4.Location = new System.Drawing.Point(479, 240);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 29);
            this.button4.TabIndex = 33;
            this.button4.Text = "Show Data";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // nEWUSERBindingSource1
            // 
            this.nEWUSERBindingSource1.DataMember = "NEW_USER";
            this.nEWUSERBindingSource1.DataSource = this.movieRentalDataSet;
            // 
            // mOVIEBindingSource
            // 
            this.mOVIEBindingSource.DataMember = "MOVIE";
            this.mOVIEBindingSource.DataSource = this.movieRentalDataSet;
            // 
            // mOVIETableAdapter
            // 
            this.mOVIETableAdapter.ClearBeforeFill = true;
            // 
            // nEW_USERTableAdapter
            // 
            this.nEW_USERTableAdapter.ClearBeforeFill = true;
            // 
            // fKCUSTOMERISCUSTOMUSERBindingSource
            // 
            this.fKCUSTOMERISCUSTOMUSERBindingSource.DataMember = "FK_CUSTOMER_IS_CUSTOM_USER";
            this.fKCUSTOMERISCUSTOMUSERBindingSource.DataSource = this.nEWUSERBindingSource;
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // nEW_USERTableAdapter1
            // 
            this.nEW_USERTableAdapter1.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Teal;
            this.button3.Location = new System.Drawing.Point(58, 178);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 37);
            this.button3.TabIndex = 41;
            this.button3.Text = "Delete User";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(942, 289);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWUSERBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRentalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWUSERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRentalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWUSERBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCUSTOMERISCUSTOMUSERBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private MovieRentalDataSet1 movieRentalDataSet;
        private System.Windows.Forms.BindingSource mOVIEBindingSource;
        private MovieRentalDataSet1TableAdapters.MOVIETableAdapter mOVIETableAdapter;
        private System.Windows.Forms.BindingSource nEWUSERBindingSource;
        private MovieRentalDataSet1TableAdapters.NEW_USERTableAdapter nEW_USERTableAdapter;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.FontDialog fontDialog2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource nEWUSERBindingSource1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FontDialog fontDialog3;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fKCUSTOMERISCUSTOMUSERBindingSource;
        private MovieRentalDataSet1TableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERPAssDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zIPCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOUNTRYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERROLEDataGridViewTextBoxColumn;
        private MovieRentalDataSet1 movieRentalDataSet1;
        private System.Windows.Forms.BindingSource nEWUSERBindingSource2;
        private MovieRentalDataSet1TableAdapters.NEW_USERTableAdapter nEW_USERTableAdapter1;
        private System.Windows.Forms.Button button3;
    }
}

