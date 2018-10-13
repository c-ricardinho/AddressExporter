namespace AddressExporter
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
            this.buttonLoadJSON = new System.Windows.Forms.Button();
            this.textBoxLoadJSON = new System.Windows.Forms.TextBox();
            this.buttonExportFolder = new System.Windows.Forms.Button();
            this.textBoxExportFolder = new System.Windows.Forms.TextBox();
            this.buttonLoadCSV = new System.Windows.Forms.Button();
            this.textBoxLoadCSV = new System.Windows.Forms.TextBox();
            this.dataSetJSON = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetJSON)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLoadJSON
            // 
            this.buttonLoadJSON.Location = new System.Drawing.Point(12, 12);
            this.buttonLoadJSON.Name = "buttonLoadJSON";
            this.buttonLoadJSON.Size = new System.Drawing.Size(150, 23);
            this.buttonLoadJSON.TabIndex = 0;
            this.buttonLoadJSON.Text = "Load JSON";
            this.buttonLoadJSON.UseVisualStyleBackColor = true;
            this.buttonLoadJSON.Click += new System.EventHandler(this.buttonLoadJSON_Click);
            // 
            // textBoxLoadJSON
            // 
            this.textBoxLoadJSON.Location = new System.Drawing.Point(168, 14);
            this.textBoxLoadJSON.Name = "textBoxLoadJSON";
            this.textBoxLoadJSON.Size = new System.Drawing.Size(500, 20);
            this.textBoxLoadJSON.TabIndex = 1;
            // 
            // buttonExportFolder
            // 
            this.buttonExportFolder.Location = new System.Drawing.Point(12, 41);
            this.buttonExportFolder.Name = "buttonExportFolder";
            this.buttonExportFolder.Size = new System.Drawing.Size(150, 23);
            this.buttonExportFolder.TabIndex = 2;
            this.buttonExportFolder.Text = "Export Folder";
            this.buttonExportFolder.UseVisualStyleBackColor = true;
            this.buttonExportFolder.Click += new System.EventHandler(this.buttonExportFolder_Click);
            // 
            // textBoxExportFolder
            // 
            this.textBoxExportFolder.Location = new System.Drawing.Point(168, 43);
            this.textBoxExportFolder.Name = "textBoxExportFolder";
            this.textBoxExportFolder.Size = new System.Drawing.Size(500, 20);
            this.textBoxExportFolder.TabIndex = 3;
            // 
            // buttonLoadCSV
            // 
            this.buttonLoadCSV.Location = new System.Drawing.Point(12, 70);
            this.buttonLoadCSV.Name = "buttonLoadCSV";
            this.buttonLoadCSV.Size = new System.Drawing.Size(150, 23);
            this.buttonLoadCSV.TabIndex = 4;
            this.buttonLoadCSV.Text = "Load CSV";
            this.buttonLoadCSV.UseVisualStyleBackColor = true;
            this.buttonLoadCSV.Click += new System.EventHandler(this.buttonLoadCSV_Click);
            // 
            // textBoxLoadCSV
            // 
            this.textBoxLoadCSV.Location = new System.Drawing.Point(168, 72);
            this.textBoxLoadCSV.Name = "textBoxLoadCSV";
            this.textBoxLoadCSV.Size = new System.Drawing.Size(500, 20);
            this.textBoxLoadCSV.TabIndex = 5;
            // 
            // dataSetJSON
            // 
            this.dataSetJSON.DataSetName = "DataSetJSON";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 231);
            this.Controls.Add(this.textBoxLoadCSV);
            this.Controls.Add(this.buttonLoadCSV);
            this.Controls.Add(this.textBoxExportFolder);
            this.Controls.Add(this.buttonExportFolder);
            this.Controls.Add(this.textBoxLoadJSON);
            this.Controls.Add(this.buttonLoadJSON);
            this.Name = "Form1";
            this.Text = "Address Exporter";
            ((System.ComponentModel.ISupportInitialize)(this.dataSetJSON)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadJSON;
        private System.Windows.Forms.TextBox textBoxLoadJSON;
        private System.Windows.Forms.Button buttonExportFolder;
        private System.Windows.Forms.TextBox textBoxExportFolder;
        private System.Windows.Forms.Button buttonLoadCSV;
        private System.Windows.Forms.TextBox textBoxLoadCSV;
        private System.Data.DataSet dataSetJSON;
    }
}

