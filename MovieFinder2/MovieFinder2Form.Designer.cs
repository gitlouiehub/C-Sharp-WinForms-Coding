namespace MovieFinder2
{
    partial class MovieFinder2Form
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.splitListBox1 = new System.Windows.Forms.ListBox();
            this.splitListBox2 = new System.Windows.Forms.ListBox();
            this.splitYearLabel1 = new System.Windows.Forms.Label();
            this.splitYearLabel2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.moviesDataSet = new MovieFinder2.MoviesDataSet();
            this.moviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moviesTableAdapter = new MovieFinder2.MoviesDataSetTableAdapters.MoviesTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.yearTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitListBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.splitListBox2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitYearLabel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.splitYearLabel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(8, 10, 8, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1924, 1055);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(644, 3);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(243, 58);
            this.yearTextBox.TabIndex = 0;
            this.yearTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.yearTextBox_KeyDown);
            // 
            // splitListBox1
            // 
            this.splitListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitListBox1.FormattingEnabled = true;
            this.splitListBox1.ItemHeight = 51;
            this.splitListBox1.Location = new System.Drawing.Point(3, 158);
            this.splitListBox1.Name = "splitListBox1";
            this.splitListBox1.Size = new System.Drawing.Size(500, 894);
            this.splitListBox1.TabIndex = 1;
            // 
            // splitListBox2
            // 
            this.splitListBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitListBox2.FormattingEnabled = true;
            this.splitListBox2.ItemHeight = 51;
            this.splitListBox2.Location = new System.Drawing.Point(644, 158);
            this.splitListBox2.Name = "splitListBox2";
            this.splitListBox2.Size = new System.Drawing.Size(1277, 894);
            this.splitListBox2.TabIndex = 2;
            // 
            // splitYearLabel1
            // 
            this.splitYearLabel1.AutoSize = true;
            this.splitYearLabel1.Location = new System.Drawing.Point(3, 84);
            this.splitYearLabel1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.splitYearLabel1.Name = "splitYearLabel1";
            this.splitYearLabel1.Size = new System.Drawing.Size(290, 51);
            this.splitYearLabel1.TabIndex = 4;
            this.splitYearLabel1.Text = "splitYearLabel1";
            this.splitYearLabel1.Visible = false;
            // 
            // splitYearLabel2
            // 
            this.splitYearLabel2.AutoSize = true;
            this.splitYearLabel2.Location = new System.Drawing.Point(644, 84);
            this.splitYearLabel2.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.splitYearLabel2.Name = "splitYearLabel2";
            this.splitYearLabel2.Size = new System.Drawing.Size(290, 51);
            this.splitYearLabel2.TabIndex = 5;
            this.splitYearLabel2.Text = "splitYearLabel2";
            this.splitYearLabel2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter year to split movies";
            // 
            // moviesDataSet
            // 
            this.moviesDataSet.DataSetName = "MoviesDataSet";
            this.moviesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moviesBindingSource
            // 
            this.moviesBindingSource.DataMember = "Movies";
            this.moviesBindingSource.DataSource = this.moviesDataSet;
            // 
            // moviesTableAdapter
            // 
            this.moviesTableAdapter.ClearBeforeFill = true;
            // 
            // MovieFinder2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 51F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.MaximizeBox = false;
            this.Name = "MovieFinder2Form";
            this.Text = "Movie Finder2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MovieFinder2Form_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.ListBox splitListBox1;
        private System.Windows.Forms.ListBox splitListBox2;
        private System.Windows.Forms.Label splitYearLabel1;
        private System.Windows.Forms.Label splitYearLabel2;
        private System.Windows.Forms.Label label1;
        private MoviesDataSet moviesDataSet;
        private System.Windows.Forms.BindingSource moviesBindingSource;
        private MoviesDataSetTableAdapters.MoviesTableAdapter moviesTableAdapter;
    }
}

