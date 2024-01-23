namespace NSF2SQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bGetDatabases = new System.Windows.Forms.Button();
            this.bExportDocuments = new System.Windows.Forms.Button();
            this.bBrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnBrowseAttachmentsFolder = new System.Windows.Forms.Button();
            this.gpbAttachments = new System.Windows.Forms.GroupBox();
            this.txbAttachmentsFolder = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.bFilterBox = new System.Windows.Forms.GroupBox();
            this.pFrom = new System.Windows.Forms.Panel();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.lFrom = new System.Windows.Forms.Label();
            this.pFieldName = new System.Windows.Forms.Panel();
            this.tbFieldName = new System.Windows.Forms.TextBox();
            this.lFieldName = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.lTo = new System.Windows.Forms.Label();
            this.pTo = new System.Windows.Forms.Panel();
            this.ttFieldName = new System.Windows.Forms.ToolTip(this.components);
            this.gpbAttachments.SuspendLayout();
            this.bFilterBox.SuspendLayout();
            this.pFrom.SuspendLayout();
            this.pFieldName.SuspendLayout();
            this.pTo.SuspendLayout();
            this.SuspendLayout();
            // 
            // bGetDatabases
            // 
            this.bGetDatabases.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bGetDatabases.Location = new System.Drawing.Point(16, 629);
            this.bGetDatabases.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bGetDatabases.Name = "bGetDatabases";
            this.bGetDatabases.Size = new System.Drawing.Size(184, 35);
            this.bGetDatabases.TabIndex = 2;
            this.bGetDatabases.Text = "Search Server";
            this.bGetDatabases.UseVisualStyleBackColor = true;
            this.bGetDatabases.Click += new System.EventHandler(this.bSearchServer_Click);
            // 
            // bExportDocuments
            // 
            this.bExportDocuments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bExportDocuments.Location = new System.Drawing.Point(404, 629);
            this.bExportDocuments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bExportDocuments.Name = "bExportDocuments";
            this.bExportDocuments.Size = new System.Drawing.Size(184, 35);
            this.bExportDocuments.TabIndex = 4;
            this.bExportDocuments.Text = "Export Documents";
            this.bExportDocuments.UseVisualStyleBackColor = true;
            this.bExportDocuments.Click += new System.EventHandler(this.bExportDocuments_Click);
            // 
            // bBrowse
            // 
            this.bBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bBrowse.Location = new System.Drawing.Point(210, 629);
            this.bBrowse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.Size = new System.Drawing.Size(184, 35);
            this.bBrowse.TabIndex = 3;
            this.bBrowse.Text = "Search Computer";
            this.bBrowse.UseVisualStyleBackColor = true;
            this.bBrowse.Click += new System.EventHandler(this.bSearchComputer_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "nsf";
            this.openFileDialog1.Filter = "Lotus Notes Database|*.nsf";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Open Lotus Notes Databases (.nsf)";
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.HideSelection = false;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(18, 39);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.ShowNodeToolTips = true;
            this.treeView1.ShowPlusMinus = false;
            this.treeView1.ShowRootLines = false;
            this.treeView1.Size = new System.Drawing.Size(568, 323);
            this.treeView1.TabIndex = 1;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "database");
            this.imageList1.Images.SetKeyName(1, "folder");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "NSF Databases";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "sql";
            this.saveFileDialog1.FileName = "export.sql";
            this.saveFileDialog1.Filter = "SQL File|*.sql";
            // 
            // btnBrowseAttachmentsFolder
            // 
            this.btnBrowseAttachmentsFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBrowseAttachmentsFolder.Location = new System.Drawing.Point(9, 37);
            this.btnBrowseAttachmentsFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBrowseAttachmentsFolder.Name = "btnBrowseAttachmentsFolder";
            this.btnBrowseAttachmentsFolder.Size = new System.Drawing.Size(60, 35);
            this.btnBrowseAttachmentsFolder.TabIndex = 7;
            this.btnBrowseAttachmentsFolder.Text = "...";
            this.btnBrowseAttachmentsFolder.UseVisualStyleBackColor = true;
            this.btnBrowseAttachmentsFolder.Click += new System.EventHandler(this.btnBrowseAttachmentsFolder_Click);
            // 
            // gpbAttachments
            // 
            this.gpbAttachments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbAttachments.Controls.Add(this.txbAttachmentsFolder);
            this.gpbAttachments.Controls.Add(this.btnBrowseAttachmentsFolder);
            this.gpbAttachments.Location = new System.Drawing.Point(18, 536);
            this.gpbAttachments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbAttachments.Name = "gpbAttachments";
            this.gpbAttachments.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbAttachments.Size = new System.Drawing.Size(568, 82);
            this.gpbAttachments.TabIndex = 8;
            this.gpbAttachments.TabStop = false;
            this.gpbAttachments.Text = "Select directory for attachments";
            // 
            // txbAttachmentsFolder
            // 
            this.txbAttachmentsFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbAttachmentsFolder.Location = new System.Drawing.Point(80, 40);
            this.txbAttachmentsFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbAttachmentsFolder.Name = "txbAttachmentsFolder";
            this.txbAttachmentsFolder.ReadOnly = true;
            this.txbAttachmentsFolder.Size = new System.Drawing.Size(477, 26);
            this.txbAttachmentsFolder.TabIndex = 8;
            // 
            // bFilterBox
            // 
            this.bFilterBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bFilterBox.Controls.Add(this.pTo);
            this.bFilterBox.Controls.Add(this.pFrom);
            this.bFilterBox.Controls.Add(this.pFieldName);
            this.bFilterBox.Location = new System.Drawing.Point(18, 369);
            this.bFilterBox.Name = "bFilterBox";
            this.bFilterBox.Size = new System.Drawing.Size(568, 157);
            this.bFilterBox.TabIndex = 9;
            this.bFilterBox.TabStop = false;
            this.bFilterBox.Text = "Filter Documents";
            // 
            // pFrom
            // 
            this.pFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pFrom.Controls.Add(this.dtFrom);
            this.pFrom.Controls.Add(this.lFrom);
            this.pFrom.Location = new System.Drawing.Point(6, 84);
            this.pFrom.Name = "pFrom";
            this.pFrom.Size = new System.Drawing.Size(284, 69);
            this.pFrom.TabIndex = 1;
            // 
            // dtFrom
            // 
            this.dtFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFrom.Checked = false;
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(2, 31);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.ShowCheckBox = true;
            this.dtFrom.Size = new System.Drawing.Size(270, 26);
            this.dtFrom.TabIndex = 1;
            this.ttFieldName.SetToolTip(this.dtFrom, "Optional, inclusive date to retrieve documents after");
            // 
            // lFrom
            // 
            this.lFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lFrom.AutoSize = true;
            this.lFrom.Location = new System.Drawing.Point(4, 6);
            this.lFrom.Name = "lFrom";
            this.lFrom.Size = new System.Drawing.Size(46, 20);
            this.lFrom.TabIndex = 0;
            this.lFrom.Text = "From";
            // 
            // pFieldName
            // 
            this.pFieldName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pFieldName.Controls.Add(this.tbFieldName);
            this.pFieldName.Controls.Add(this.lFieldName);
            this.pFieldName.Location = new System.Drawing.Point(6, 24);
            this.pFieldName.Name = "pFieldName";
            this.pFieldName.Size = new System.Drawing.Size(556, 54);
            this.pFieldName.TabIndex = 0;
            this.ttFieldName.SetToolTip(this.pFieldName, "Date field in Lotus Notes to query against");
            // 
            // tbFieldName
            // 
            this.tbFieldName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbFieldName.Location = new System.Drawing.Point(2, 23);
            this.tbFieldName.Name = "tbFieldName";
            this.tbFieldName.Size = new System.Drawing.Size(549, 26);
            this.tbFieldName.TabIndex = 1;
            this.ttFieldName.SetToolTip(this.tbFieldName, "Date field in LN to query on. ");
            // 
            // lFieldName
            // 
            this.lFieldName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lFieldName.AutoSize = true;
            this.lFieldName.Location = new System.Drawing.Point(4, 0);
            this.lFieldName.Name = "lFieldName";
            this.lFieldName.Size = new System.Drawing.Size(89, 20);
            this.lFieldName.TabIndex = 0;
            this.lFieldName.Text = "Field Name";
            // 
            // dtTo
            // 
            this.dtTo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtTo.Checked = false;
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.Location = new System.Drawing.Point(2, 31);
            this.dtTo.Name = "dtTo";
            this.dtTo.ShowCheckBox = true;
            this.dtTo.Size = new System.Drawing.Size(252, 26);
            this.dtTo.TabIndex = 1;
            this.ttFieldName.SetToolTip(this.dtTo, "Optional, inclusive date to retrieve documents before");
            // 
            // lTo
            // 
            this.lTo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lTo.AutoSize = true;
            this.lTo.Location = new System.Drawing.Point(4, 8);
            this.lTo.Name = "lTo";
            this.lTo.Size = new System.Drawing.Size(27, 20);
            this.lTo.TabIndex = 0;
            this.lTo.Text = "To";
            // 
            // pTo
            // 
            this.pTo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pTo.Controls.Add(this.dtTo);
            this.pTo.Controls.Add(this.lTo);
            this.pTo.Location = new System.Drawing.Point(296, 84);
            this.pTo.Name = "pTo";
            this.pTo.Size = new System.Drawing.Size(266, 69);
            this.pTo.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 678);
            this.Controls.Add(this.gpbAttachments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.bBrowse);
            this.Controls.Add(this.bExportDocuments);
            this.Controls.Add(this.bGetDatabases);
            this.Controls.Add(this.bFilterBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(619, 227);
            this.Name = "Form1";
            this.Text = "NSF 2 SQL";
            this.gpbAttachments.ResumeLayout(false);
            this.gpbAttachments.PerformLayout();
            this.bFilterBox.ResumeLayout(false);
            this.pFrom.ResumeLayout(false);
            this.pFrom.PerformLayout();
            this.pFieldName.ResumeLayout(false);
            this.pFieldName.PerformLayout();
            this.pTo.ResumeLayout(false);
            this.pTo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bGetDatabases;
        private System.Windows.Forms.Button bExportDocuments;
        private System.Windows.Forms.Button bBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnBrowseAttachmentsFolder;
        private System.Windows.Forms.GroupBox gpbAttachments;
        private System.Windows.Forms.TextBox txbAttachmentsFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox bFilterBox;
        private System.Windows.Forms.Panel pFieldName;
        private System.Windows.Forms.TextBox tbFieldName;
        private System.Windows.Forms.Label lFieldName;
        private System.Windows.Forms.Panel pFrom;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label lFrom;
        private System.Windows.Forms.Panel pTo;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label lTo;
        private System.Windows.Forms.ToolTip ttFieldName;
    }
}

