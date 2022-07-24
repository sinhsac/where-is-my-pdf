using System.Windows.Forms;
using System;

namespace TimHoaDonTuFilePDF
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.clmFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.tsmenuGeneral = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenuScanPDF = new System.Windows.Forms.ToolStripMenuItem();
            this.txtKeyword = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(1070, 40);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(144, 40);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmFilePath,
            this.clmContent,
            this.clmStatus});
            this.dgvMain.Location = new System.Drawing.Point(11, 96);
            this.dgvMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersWidth = 62;
            this.dgvMain.RowTemplate.Height = 33;
            this.dgvMain.Size = new System.Drawing.Size(1203, 408);
            this.dgvMain.TabIndex = 6;
            this.dgvMain.VirtualMode = true;
            // 
            // clmFilePath
            // 
            this.clmFilePath.DataPropertyName = "pdf_path";
            this.clmFilePath.HeaderText = "Đường dẫn";
            this.clmFilePath.MinimumWidth = 8;
            this.clmFilePath.Name = "clmFilePath";
            this.clmFilePath.Width = 500;
            // 
            // clmContent
            // 
            this.clmContent.DataPropertyName = "pdf_text_content";
            this.clmContent.HeaderText = "Nội dung";
            this.clmContent.MinimumWidth = 8;
            this.clmContent.Name = "clmContent";
            this.clmContent.Width = 450;
            // 
            // clmStatus
            // 
            this.clmStatus.DataPropertyName = "status";
            this.clmStatus.HeaderText = "Trạng thái";
            this.clmStatus.MinimumWidth = 8;
            this.clmStatus.Name = "clmStatus";
            this.clmStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmStatus.Width = 150;
            // 
            // menuMain
            // 
            this.menuMain.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmenuGeneral});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuMain.Size = new System.Drawing.Size(1224, 33);
            this.menuMain.TabIndex = 7;
            this.menuMain.Text = "menuStrip1";
            // 
            // tsmenuGeneral
            // 
            this.tsmenuGeneral.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmenuScanPDF});
            this.tsmenuGeneral.Name = "tsmenuGeneral";
            this.tsmenuGeneral.Size = new System.Drawing.Size(54, 29);
            this.tsmenuGeneral.Text = "File";
            // 
            // tsmenuScanPDF
            // 
            this.tsmenuScanPDF.Name = "tsmenuScanPDF";
            this.tsmenuScanPDF.Size = new System.Drawing.Size(190, 34);
            this.tsmenuScanPDF.Text = "Quét PDF";
            this.tsmenuScanPDF.Click += new System.EventHandler(this.tsmenuScanPDF_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKeyword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtKeyword.FormattingEnabled = true;
            this.txtKeyword.Location = new System.Drawing.Point(11, 40);
            this.txtKeyword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(1053, 40);
            this.txtKeyword.TabIndex = 8;
            this.txtKeyword.SelectedIndexChanged += new System.EventHandler(this.txtKeyword_SelectedIndexChanged);
            this.txtKeyword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKeyword_KeyDown);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 513);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.menuMain);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.btnSearch);
            this.MainMenuStrip = this.menuMain;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm file PDF";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnSearch;
        private DataGridView dgvMain;
        private MenuStrip menuMain;
        private ToolStripMenuItem tsmenuGeneral;
        private ToolStripMenuItem tsmenuScanPDF;
        private DataGridViewTextBoxColumn clmFilePath;
        private DataGridViewTextBoxColumn clmContent;
        private DataGridViewTextBoxColumn clmStatus;
        private ComboBox txtKeyword;
    }
}