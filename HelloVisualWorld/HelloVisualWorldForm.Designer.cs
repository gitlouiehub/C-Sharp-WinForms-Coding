namespace HelloVisualWorld
{
    partial class HelloForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.displayOutputButton = new System.Windows.Forms.Button();
            this.helloLabel = new System.Windows.Forms.Label();
            this.changeOutputButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.displayOutputButton);
            this.flowLayoutPanel1.Controls.Add(this.helloLabel);
            this.flowLayoutPanel1.Controls.Add(this.changeOutputButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(776, 426);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // displayOutputButton
            // 
            this.displayOutputButton.Location = new System.Drawing.Point(3, 3);
            this.displayOutputButton.Name = "displayOutputButton";
            this.displayOutputButton.Size = new System.Drawing.Size(93, 23);
            this.displayOutputButton.TabIndex = 0;
            this.displayOutputButton.Text = "Click here";
            this.displayOutputButton.UseVisualStyleBackColor = true;
            this.displayOutputButton.Click += new System.EventHandler(this.DisplayOutputButton_Click);
            // 
            // helloLabel
            // 
            this.helloLabel.AutoSize = true;
            this.helloLabel.Location = new System.Drawing.Point(102, 0);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(130, 17);
            this.helloLabel.TabIndex = 1;
            this.helloLabel.Text = "Hello, Visual World!";
            this.helloLabel.Visible = false;
            // 
            // changeOutputButton
            // 
            this.changeOutputButton.Location = new System.Drawing.Point(238, 3);
            this.changeOutputButton.Name = "changeOutputButton";
            this.changeOutputButton.Size = new System.Drawing.Size(135, 23);
            this.changeOutputButton.TabIndex = 2;
            this.changeOutputButton.Text = "Click me last";
            this.changeOutputButton.UseVisualStyleBackColor = true;
            this.changeOutputButton.Click += new System.EventHandler(this.ChangeOutputButton_Click);
            // 
            // HelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 123);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "HelloForm";
            this.Text = "Hello Visual World";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button displayOutputButton;
        private System.Windows.Forms.Label helloLabel;
        private System.Windows.Forms.Button changeOutputButton;
    }
}

