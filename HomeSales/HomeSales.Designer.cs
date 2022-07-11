namespace HomeSales
{
    partial class HomeSalesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeSalesForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.initialTextBox = new System.Windows.Forms.TextBox();
            this.salesTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.instructLabel = new System.Windows.Forms.Label();
            this.outputTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.danielleLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.edwardLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.francisLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grandTotalLabel = new System.Windows.Forms.Label();
            this.salesPersonWHighestTotalLabel = new System.Windows.Forms.Label();
            this.highestTotalLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.outputTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.instructLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.outputTableLayoutPanel, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1082, 503);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.initialTextBox);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.salesTextBox);
            this.flowLayoutPanel1.Controls.Add(this.submitButton);
            this.flowLayoutPanel1.Controls.Add(this.errorLabel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 173);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1076, 105);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // initialTextBox
            // 
            this.initialTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialTextBox.Location = new System.Drawing.Point(293, 13);
            this.initialTextBox.MaxLength = 1;
            this.initialTextBox.Name = "initialTextBox";
            this.initialTextBox.Size = new System.Drawing.Size(100, 51);
            this.initialTextBox.TabIndex = 0;
            // 
            // salesTextBox
            // 
            this.salesTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesTextBox.Location = new System.Drawing.Point(621, 13);
            this.salesTextBox.Name = "salesTextBox";
            this.salesTextBox.Size = new System.Drawing.Size(170, 51);
            this.salesTextBox.TabIndex = 1;
            // 
            // submitButton
            // 
            this.submitButton.AutoSize = true;
            this.submitButton.Location = new System.Drawing.Point(797, 13);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(133, 48);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // instructLabel
            // 
            this.instructLabel.AutoSize = true;
            this.instructLabel.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructLabel.Location = new System.Drawing.Point(3, 0);
            this.instructLabel.Name = "instructLabel";
            this.instructLabel.Size = new System.Drawing.Size(1069, 170);
            this.instructLabel.TabIndex = 1;
            this.instructLabel.Text = resources.GetString("instructLabel.Text");
            this.instructLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // outputTableLayoutPanel
            // 
            this.outputTableLayoutPanel.ColumnCount = 2;
            this.outputTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.outputTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.outputTableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.outputTableLayoutPanel.Controls.Add(this.label2, 1, 0);
            this.outputTableLayoutPanel.Controls.Add(this.label3, 0, 1);
            this.outputTableLayoutPanel.Controls.Add(this.danielleLabel, 1, 1);
            this.outputTableLayoutPanel.Controls.Add(this.label5, 0, 2);
            this.outputTableLayoutPanel.Controls.Add(this.edwardLabel, 1, 2);
            this.outputTableLayoutPanel.Controls.Add(this.label7, 0, 3);
            this.outputTableLayoutPanel.Controls.Add(this.francisLabel, 1, 3);
            this.outputTableLayoutPanel.Controls.Add(this.label9, 0, 4);
            this.outputTableLayoutPanel.Controls.Add(this.grandTotalLabel, 1, 4);
            this.outputTableLayoutPanel.Controls.Add(this.salesPersonWHighestTotalLabel, 0, 5);
            this.outputTableLayoutPanel.Controls.Add(this.highestTotalLabel, 1, 5);
            this.outputTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputTableLayoutPanel.Location = new System.Drawing.Point(3, 284);
            this.outputTableLayoutPanel.Name = "outputTableLayoutPanel";
            this.outputTableLayoutPanel.RowCount = 6;
            this.outputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.outputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.outputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.outputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.outputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.outputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.outputTableLayoutPanel.Size = new System.Drawing.Size(1076, 216);
            this.outputTableLayoutPanel.TabIndex = 2;
            this.outputTableLayoutPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salesperson";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(772, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salesperson\'s Total ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Danielle";
            // 
            // danielleLabel
            // 
            this.danielleLabel.AutoSize = true;
            this.danielleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.danielleLabel.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danielleLabel.Location = new System.Drawing.Point(772, 38);
            this.danielleLabel.Name = "danielleLabel";
            this.danielleLabel.Size = new System.Drawing.Size(301, 39);
            this.danielleLabel.TabIndex = 3;
            this.danielleLabel.Text = "danielleLabel";
            this.danielleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "Edward";
            // 
            // edwardLabel
            // 
            this.edwardLabel.AutoSize = true;
            this.edwardLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edwardLabel.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edwardLabel.Location = new System.Drawing.Point(772, 77);
            this.edwardLabel.Name = "edwardLabel";
            this.edwardLabel.Size = new System.Drawing.Size(301, 39);
            this.edwardLabel.TabIndex = 5;
            this.edwardLabel.Text = "edwardLabel";
            this.edwardLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 36);
            this.label7.TabIndex = 6;
            this.label7.Text = "Francis";
            // 
            // francisLabel
            // 
            this.francisLabel.AutoSize = true;
            this.francisLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.francisLabel.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.francisLabel.Location = new System.Drawing.Point(772, 116);
            this.francisLabel.Name = "francisLabel";
            this.francisLabel.Size = new System.Drawing.Size(301, 39);
            this.francisLabel.TabIndex = 7;
            this.francisLabel.Text = "francisLabel";
            this.francisLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 38);
            this.label9.TabIndex = 8;
            this.label9.Text = "Grand Total";
            // 
            // grandTotalLabel
            // 
            this.grandTotalLabel.AutoSize = true;
            this.grandTotalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grandTotalLabel.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandTotalLabel.Location = new System.Drawing.Point(772, 155);
            this.grandTotalLabel.Name = "grandTotalLabel";
            this.grandTotalLabel.Size = new System.Drawing.Size(301, 39);
            this.grandTotalLabel.TabIndex = 9;
            this.grandTotalLabel.Text = "grandTotalLabel";
            this.grandTotalLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // salesPersonWHighestTotalLabel
            // 
            this.salesPersonWHighestTotalLabel.AutoSize = true;
            this.salesPersonWHighestTotalLabel.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesPersonWHighestTotalLabel.Location = new System.Drawing.Point(3, 194);
            this.salesPersonWHighestTotalLabel.Name = "salesPersonWHighestTotalLabel";
            this.salesPersonWHighestTotalLabel.Size = new System.Drawing.Size(431, 38);
            this.salesPersonWHighestTotalLabel.TabIndex = 10;
            this.salesPersonWHighestTotalLabel.Text = "Salesperson w/ Highest Total";
            // 
            // highestTotalLabel
            // 
            this.highestTotalLabel.AutoSize = true;
            this.highestTotalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.highestTotalLabel.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highestTotalLabel.Location = new System.Drawing.Point(772, 194);
            this.highestTotalLabel.Name = "highestTotalLabel";
            this.highestTotalLabel.Size = new System.Drawing.Size(301, 39);
            this.highestTotalLabel.TabIndex = 11;
            this.highestTotalLabel.Text = "highestTotalLabel";
            this.highestTotalLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.flowLayoutPanel1.SetFlowBreak(this.errorLabel, true);
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(3, 67);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(536, 38);
            this.errorLabel.TabIndex = 3;
            this.errorLabel.Text = "Wrong salesperson, please try again";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.errorLabel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 38);
            this.label4.TabIndex = 4;
            this.label4.Text = "Salesperson Initial";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(399, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 38);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sales Amount";
            // 
            // HomeSalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1082, 503);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(1100, 550);
            this.MinimumSize = new System.Drawing.Size(1100, 550);
            this.Name = "HomeSalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Sales";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.outputTableLayoutPanel.ResumeLayout(false);
            this.outputTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox initialTextBox;
        private System.Windows.Forms.TextBox salesTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label instructLabel;
        private System.Windows.Forms.TableLayoutPanel outputTableLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label danielleLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label edwardLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label francisLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label grandTotalLabel;
        private System.Windows.Forms.Label salesPersonWHighestTotalLabel;
        private System.Windows.Forms.Label highestTotalLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}

