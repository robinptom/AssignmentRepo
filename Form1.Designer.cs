namespace Assignment_Sort_Search
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.lblSelectedFolders = new System.Windows.Forms.Label();
            this.lblTextFiles = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblBanner = new System.Windows.Forms.Label();
            this.FBD = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSelect.Location = new System.Drawing.Point(31, 59);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(410, 43);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Select Folder Here";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(489, 59);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 43);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(90, 143);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(300, 69);
            this.listBox1.TabIndex = 2;
            this.listBox1.Visible = false;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(90, 229);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(300, 82);
            this.listBox2.TabIndex = 3;
            this.listBox2.Visible = false;
            // 
            // lblSelectedFolders
            // 
            this.lblSelectedFolders.AutoSize = true;
            this.lblSelectedFolders.Location = new System.Drawing.Point(6, 160);
            this.lblSelectedFolders.Name = "lblSelectedFolders";
            this.lblSelectedFolders.Size = new System.Drawing.Size(78, 13);
            this.lblSelectedFolders.TabIndex = 4;
            this.lblSelectedFolders.Text = "Sorted Folders:";
            this.lblSelectedFolders.Visible = false;
            // 
            // lblTextFiles
            // 
            this.lblTextFiles.AllowDrop = true;
            this.lblTextFiles.AutoSize = true;
            this.lblTextFiles.Location = new System.Drawing.Point(6, 246);
            this.lblTextFiles.Name = "lblTextFiles";
            this.lblTextFiles.Size = new System.Drawing.Size(65, 13);
            this.lblTextFiles.TabIndex = 5;
            this.lblTextFiles.Text = "Sorted Files:";
            this.lblTextFiles.Visible = false;
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Uighur", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(34, 105);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(407, 35);
            this.lblMessage.TabIndex = 10;
            // 
            // lblBanner
            // 
            this.lblBanner.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblBanner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanner.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblBanner.Location = new System.Drawing.Point(0, -2);
            this.lblBanner.Name = "lblBanner";
            this.lblBanner.Size = new System.Drawing.Size(621, 52);
            this.lblBanner.TabIndex = 11;
            this.lblBanner.Text = "Sort && Search Application!";
            this.lblBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(620, 488);
            this.Controls.Add(this.lblBanner);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblTextFiles);
            this.Controls.Add(this.lblSelectedFolders);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSelect);
            this.Name = "Form1";
            this.Text = "Sorting App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label lblSelectedFolders;
        private System.Windows.Forms.Label lblTextFiles;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblBanner;
        private System.Windows.Forms.FolderBrowserDialog FBD;
    }
}

