namespace MovieRental_V1
{
    partial class AdminRenting
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sTARTRENTDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rETURNDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mOVIEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rELEASEYEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dURATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vIDEOQUALITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable2TableAdapter = new MovieRental_V1.MovieRentalDataSet1TableAdapters.DataTable2TableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.movieRentalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // movieRentalDataSet1
            // 
            this.movieRentalDataSet1.DataSetName = "MovieRentalDataSet1";
            this.movieRentalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTARTRENTDATEDataGridViewTextBoxColumn,
            this.rETURNDATEDataGridViewTextBoxColumn,
            this.rentPriceDataGridViewTextBoxColumn,
            this.mOVIEIDDataGridViewTextBoxColumn,
            this.movieNAMEDataGridViewTextBoxColumn,
            this.rATEDataGridViewTextBoxColumn,
            this.rELEASEYEARDataGridViewTextBoxColumn,
            this.dURATIONDataGridViewTextBoxColumn,
            this.vIDEOQUALITYDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataTable2BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(108, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(946, 191);
            this.dataGridView1.TabIndex = 0;
            // 
            // sTARTRENTDATEDataGridViewTextBoxColumn
            // 
            this.sTARTRENTDATEDataGridViewTextBoxColumn.DataPropertyName = "START_RENT_DATE";
            this.sTARTRENTDATEDataGridViewTextBoxColumn.HeaderText = "START_RENT_DATE";
            this.sTARTRENTDATEDataGridViewTextBoxColumn.Name = "sTARTRENTDATEDataGridViewTextBoxColumn";
            // 
            // rETURNDATEDataGridViewTextBoxColumn
            // 
            this.rETURNDATEDataGridViewTextBoxColumn.DataPropertyName = "RETURN_DATE";
            this.rETURNDATEDataGridViewTextBoxColumn.HeaderText = "RETURN_DATE";
            this.rETURNDATEDataGridViewTextBoxColumn.Name = "rETURNDATEDataGridViewTextBoxColumn";
            // 
            // rentPriceDataGridViewTextBoxColumn
            // 
            this.rentPriceDataGridViewTextBoxColumn.DataPropertyName = "RentPrice";
            this.rentPriceDataGridViewTextBoxColumn.HeaderText = "RentPrice";
            this.rentPriceDataGridViewTextBoxColumn.Name = "rentPriceDataGridViewTextBoxColumn";
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
            // dataTable2BindingSource
            // 
            this.dataTable2BindingSource.DataMember = "DataTable2";
            this.dataTable2BindingSource.DataSource = this.movieRentalDataSet1;
            // 
            // dataTable2TableAdapter
            // 
            this.dataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Teal;
            this.button1.Location = new System.Drawing.Point(283, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Renting New Movie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Teal;
            this.button2.Location = new System.Drawing.Point(470, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Extend Renting";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Teal;
            this.button3.Location = new System.Drawing.Point(629, 242);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "Return Movie";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Teal;
            this.button4.Location = new System.Drawing.Point(775, 242);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 30);
            this.button4.TabIndex = 4;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // AdminRenting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1137, 299);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminRenting";
            this.Text = "AdminRenting";
            this.Load += new System.EventHandler(this.AdminRenting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movieRentalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MovieRentalDataSet1 movieRentalDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataTable2BindingSource;
        private MovieRentalDataSet1TableAdapters.DataTable2TableAdapter dataTable2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTARTRENTDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rETURNDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOVIEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rELEASEYEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dURATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vIDEOQUALITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}