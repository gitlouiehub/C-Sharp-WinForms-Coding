namespace MovieFinder
{
    partial class MovieFinderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.searchListBox = new System.Windows.Forms.ListBox();
            this.radioPanel = new System.Windows.Forms.Panel();
            this.radioTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.titleRadioButton = new System.Windows.Forms.RadioButton();
            this.directorRadioButton = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.moviesDataSet = new MovieFinder.MoviesDataSet();
            this.moviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moviesTableAdapter = new MovieFinder.MoviesDataSetTableAdapters.MoviesTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.radioPanel.SuspendLayout();
            this.radioTableLayout.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchListBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.radioPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1201, 480);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(680, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter part of the title or director name";
            // 
            // searchListBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.searchListBox, 2);
            this.searchListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchListBox.FormattingEnabled = true;
            this.searchListBox.ItemHeight = 46;
            this.searchListBox.Location = new System.Drawing.Point(3, 155);
            this.searchListBox.Name = "searchListBox";
            this.searchListBox.Size = new System.Drawing.Size(1195, 322);
            this.searchListBox.TabIndex = 3;
            // 
            // radioPanel
            // 
            this.radioPanel.Controls.Add(this.radioTableLayout);
            this.radioPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioPanel.Location = new System.Drawing.Point(3, 49);
            this.radioPanel.Name = "radioPanel";
            this.radioPanel.Size = new System.Drawing.Size(680, 100);
            this.radioPanel.TabIndex = 4;
            // 
            // radioTableLayout
            // 
            this.radioTableLayout.AutoSize = true;
            this.radioTableLayout.BackColor = System.Drawing.Color.White;
            this.radioTableLayout.ColumnCount = 1;
            this.radioTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.radioTableLayout.Controls.Add(this.titleRadioButton, 0, 0);
            this.radioTableLayout.Controls.Add(this.directorRadioButton, 0, 1);
            this.radioTableLayout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radioTableLayout.Location = new System.Drawing.Point(0, -12);
            this.radioTableLayout.Name = "radioTableLayout";
            this.radioTableLayout.RowCount = 2;
            this.radioTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.radioTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.radioTableLayout.Size = new System.Drawing.Size(680, 112);
            this.radioTableLayout.TabIndex = 0;
            // 
            // titleRadioButton
            // 
            this.titleRadioButton.AutoSize = true;
            this.titleRadioButton.Location = new System.Drawing.Point(3, 3);
            this.titleRadioButton.Name = "titleRadioButton";
            this.titleRadioButton.Size = new System.Drawing.Size(294, 50);
            this.titleRadioButton.TabIndex = 0;
            this.titleRadioButton.TabStop = true;
            this.titleRadioButton.Text = "Search by title";
            this.titleRadioButton.UseVisualStyleBackColor = true;
            // 
            // directorRadioButton
            // 
            this.directorRadioButton.AutoSize = true;
            this.directorRadioButton.Location = new System.Drawing.Point(3, 59);
            this.directorRadioButton.Name = "directorRadioButton";
            this.directorRadioButton.Size = new System.Drawing.Size(366, 50);
            this.directorRadioButton.TabIndex = 1;
            this.directorRadioButton.TabStop = true;
            this.directorRadioButton.Text = "Search by director";
            this.directorRadioButton.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.searchTextBox);
            this.flowLayoutPanel1.Controls.Add(this.searchButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(689, 49);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(509, 100);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.searchTextBox.Location = new System.Drawing.Point(3, 3);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(300, 53);
            this.searchTextBox.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchButton.AutoSize = true;
            this.searchButton.Location = new System.Drawing.Point(309, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(157, 56);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
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
            // MovieFinderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1201, 480);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "MovieFinderForm";
            this.Text = "Movie Finder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MovieFinderForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.radioPanel.ResumeLayout(false);
            this.radioPanel.PerformLayout();
            this.radioTableLayout.ResumeLayout(false);
            this.radioTableLayout.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox searchListBox;
        private System.Windows.Forms.Panel radioPanel;
        private System.Windows.Forms.TableLayoutPanel radioTableLayout;
        private System.Windows.Forms.RadioButton titleRadioButton;
        private System.Windows.Forms.RadioButton directorRadioButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox searchTextBox;
        private MoviesDataSet moviesDataSet;
        private System.Windows.Forms.BindingSource moviesBindingSource;
        private MoviesDataSetTableAdapters.MoviesTableAdapter moviesTableAdapter;
    }
}

