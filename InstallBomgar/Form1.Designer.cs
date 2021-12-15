namespace InstallBomgar
{
    partial class FormInstallBomgar
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
            this.textBoxBomgar = new System.Windows.Forms.TextBox();
            this.labelBomgar = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.labelDestination = new System.Windows.Forms.Label();
            this.buttonInstall = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxBomgar
            // 
            this.textBoxBomgar.Location = new System.Drawing.Point(103, 30);
            this.textBoxBomgar.Name = "textBoxBomgar";
            this.textBoxBomgar.Size = new System.Drawing.Size(342, 22);
            this.textBoxBomgar.TabIndex = 0;
            this.textBoxBomgar.TextChanged += new System.EventHandler(this.TextBoxBomgar_TextChanged);
            // 
            // labelBomgar
            // 
            this.labelBomgar.AutoSize = true;
            this.labelBomgar.Location = new System.Drawing.Point(13, 35);
            this.labelBomgar.Name = "labelBomgar";
            this.labelBomgar.Size = new System.Drawing.Size(57, 17);
            this.labelBomgar.TabIndex = 1;
            this.labelBomgar.Text = "Bomgar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxDestination);
            this.groupBox1.Controls.Add(this.labelDestination);
            this.groupBox1.Controls.Add(this.labelBomgar);
            this.groupBox1.Controls.Add(this.textBoxBomgar);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 104);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Location = new System.Drawing.Point(103, 66);
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.Size = new System.Drawing.Size(342, 22);
            this.textBoxDestination.TabIndex = 8;
            this.textBoxDestination.TextChanged += new System.EventHandler(this.TextBoxDestination_TextChanged);
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(13, 69);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(79, 17);
            this.labelDestination.TabIndex = 7;
            this.labelDestination.Text = "Destination";
            // 
            // buttonInstall
            // 
            this.buttonInstall.Enabled = false;
            this.buttonInstall.Location = new System.Drawing.Point(13, 122);
            this.buttonInstall.Name = "buttonInstall";
            this.buttonInstall.Size = new System.Drawing.Size(85, 34);
            this.buttonInstall.TabIndex = 8;
            this.buttonInstall.Text = "Install";
            this.buttonInstall.UseVisualStyleBackColor = true;
            this.buttonInstall.Click += new System.EventHandler(this.ButtonInstall_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(395, 122);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(85, 34);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // FormInstallBomgar
            // 
            this.AcceptButton = this.buttonInstall;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(495, 167);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonInstall);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FormInstallBomgar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Install Bomgar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBomgar;
        private System.Windows.Forms.Label labelBomgar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxDestination;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.Button buttonInstall;
        private System.Windows.Forms.Button buttonExit;
    }
}

