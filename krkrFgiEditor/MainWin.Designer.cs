namespace krkrFgiEditor
{
    partial class MainWin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWin));
            this.openFile = new System.Windows.Forms.Button();
            this.fgiBox = new System.Windows.Forms.PictureBox();
            this.filePath = new System.Windows.Forms.TextBox();
            this.openPanel = new System.Windows.Forms.GroupBox();
            this.fileLabel = new System.Windows.Forms.Label();
            this.encodingLabel = new System.Windows.Forms.Label();
            this.encodingBox = new System.Windows.Forms.ComboBox();
            this.detectEncoding = new System.Windows.Forms.Button();
            this.layerPanel = new System.Windows.Forms.GroupBox();
            this.autoSort = new System.Windows.Forms.CheckBox();
            this.selectedLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.layerLabel = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.ComboBox();
            this.groupLabel = new System.Windows.Forms.Label();
            this.batchButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.swapPreviewButton = new System.Windows.Forms.Button();
            this.savePanel = new System.Windows.Forms.Panel();
            this.previewButton = new System.Windows.Forms.Button();
            this.selectedBox = new krkrFgiEditor.ListBoxEx();
            this.layerBox = new krkrFgiEditor.ComboBoxEx();
            ((System.ComponentModel.ISupportInitialize)(this.fgiBox)).BeginInit();
            this.openPanel.SuspendLayout();
            this.layerPanel.SuspendLayout();
            this.savePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(280, 19);
            this.openFile.Margin = new System.Windows.Forms.Padding(2);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(31, 23);
            this.openFile.TabIndex = 2;
            this.openFile.Text = "...";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // fgiBox
            // 
            this.fgiBox.BackColor = System.Drawing.SystemColors.Control;
            this.fgiBox.Enabled = false;
            this.fgiBox.Location = new System.Drawing.Point(333, 8);
            this.fgiBox.Margin = new System.Windows.Forms.Padding(2);
            this.fgiBox.Name = "fgiBox";
            this.fgiBox.Size = new System.Drawing.Size(257, 363);
            this.fgiBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.fgiBox.TabIndex = 1;
            this.fgiBox.TabStop = false;
            this.mainToolTip.SetToolTip(this.fgiBox, "点击查看大图");
            this.fgiBox.Click += new System.EventHandler(this.FgiBox_Click);
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(62, 19);
            this.filePath.Margin = new System.Windows.Forms.Padding(2);
            this.filePath.Name = "filePath";
            this.filePath.ReadOnly = true;
            this.filePath.Size = new System.Drawing.Size(214, 23);
            this.filePath.TabIndex = 1;
            this.filePath.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // openPanel
            // 
            this.openPanel.Controls.Add(this.fileLabel);
            this.openPanel.Controls.Add(this.encodingLabel);
            this.openPanel.Controls.Add(this.encodingBox);
            this.openPanel.Controls.Add(this.detectEncoding);
            this.openPanel.Controls.Add(this.filePath);
            this.openPanel.Controls.Add(this.openFile);
            this.openPanel.Location = new System.Drawing.Point(8, 8);
            this.openPanel.Margin = new System.Windows.Forms.Padding(2);
            this.openPanel.Name = "openPanel";
            this.openPanel.Padding = new System.Windows.Forms.Padding(2);
            this.openPanel.Size = new System.Drawing.Size(315, 81);
            this.openPanel.TabIndex = 0;
            this.openPanel.TabStop = false;
            this.openPanel.Text = "坐标文件";
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(26, 22);
            this.fileLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(32, 17);
            this.fileLabel.TabIndex = 0;
            this.fileLabel.Text = "文件";
            // 
            // encodingLabel
            // 
            this.encodingLabel.AutoSize = true;
            this.encodingLabel.Enabled = false;
            this.encodingLabel.Location = new System.Drawing.Point(26, 50);
            this.encodingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.encodingLabel.Name = "encodingLabel";
            this.encodingLabel.Size = new System.Drawing.Size(32, 17);
            this.encodingLabel.TabIndex = 3;
            this.encodingLabel.Text = "编码";
            // 
            // encodingBox
            // 
            this.encodingBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.encodingBox.Enabled = false;
            this.encodingBox.FormattingEnabled = true;
            this.encodingBox.Items.AddRange(new object[] {
            "Shift JIS",
            "UTF-8",
            "UTF-16 LE"});
            this.encodingBox.Location = new System.Drawing.Point(62, 46);
            this.encodingBox.Margin = new System.Windows.Forms.Padding(2);
            this.encodingBox.Name = "encodingBox";
            this.encodingBox.Size = new System.Drawing.Size(147, 25);
            this.encodingBox.TabIndex = 4;
            this.encodingBox.SelectedIndexChanged += new System.EventHandler(this.EncodingBox_SelectedIndexChanged);
            // 
            // detectEncoding
            // 
            this.detectEncoding.Enabled = false;
            this.detectEncoding.Location = new System.Drawing.Point(213, 46);
            this.detectEncoding.Margin = new System.Windows.Forms.Padding(2);
            this.detectEncoding.Name = "detectEncoding";
            this.detectEncoding.Size = new System.Drawing.Size(98, 25);
            this.detectEncoding.TabIndex = 5;
            this.detectEncoding.Text = "自动检测";
            this.detectEncoding.UseVisualStyleBackColor = true;
            this.detectEncoding.Click += new System.EventHandler(this.DetectEncoding_Click);
            // 
            // layerPanel
            // 
            this.layerPanel.Controls.Add(this.autoSort);
            this.layerPanel.Controls.Add(this.selectedLabel);
            this.layerPanel.Controls.Add(this.cancelButton);
            this.layerPanel.Controls.Add(this.downButton);
            this.layerPanel.Controls.Add(this.upButton);
            this.layerPanel.Controls.Add(this.deleteButton);
            this.layerPanel.Controls.Add(this.addButton);
            this.layerPanel.Controls.Add(this.selectedBox);
            this.layerPanel.Controls.Add(this.layerBox);
            this.layerPanel.Controls.Add(this.layerLabel);
            this.layerPanel.Controls.Add(this.groupBox);
            this.layerPanel.Controls.Add(this.groupLabel);
            this.layerPanel.Enabled = false;
            this.layerPanel.Location = new System.Drawing.Point(8, 93);
            this.layerPanel.Margin = new System.Windows.Forms.Padding(2);
            this.layerPanel.Name = "layerPanel";
            this.layerPanel.Padding = new System.Windows.Forms.Padding(2);
            this.layerPanel.Size = new System.Drawing.Size(315, 243);
            this.layerPanel.TabIndex = 1;
            this.layerPanel.TabStop = false;
            this.layerPanel.Text = "图层选择";
            // 
            // autoSort
            // 
            this.autoSort.AutoSize = true;
            this.autoSort.Checked = true;
            this.autoSort.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoSort.Location = new System.Drawing.Point(62, 75);
            this.autoSort.Margin = new System.Windows.Forms.Padding(2);
            this.autoSort.Name = "autoSort";
            this.autoSort.Size = new System.Drawing.Size(75, 21);
            this.autoSort.TabIndex = 4;
            this.autoSort.Text = "自动排序";
            this.autoSort.UseVisualStyleBackColor = true;
            this.autoSort.CheckedChanged += new System.EventHandler(this.AutoSort_CheckedChanged);
            // 
            // selectedLabel
            // 
            this.selectedLabel.AutoSize = true;
            this.selectedLabel.Location = new System.Drawing.Point(26, 128);
            this.selectedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectedLabel.Name = "selectedLabel";
            this.selectedLabel.Size = new System.Drawing.Size(32, 51);
            this.selectedLabel.TabIndex = 7;
            this.selectedLabel.Text = "当前\r\n已选\r\n图层";
            // 
            // cancelButton
            // 
            this.cancelButton.Enabled = false;
            this.cancelButton.Location = new System.Drawing.Point(157, 72);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 25);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "清除";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // downButton
            // 
            this.downButton.Enabled = false;
            this.downButton.Location = new System.Drawing.Point(141, 212);
            this.downButton.Margin = new System.Windows.Forms.Padding(2);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(75, 25);
            this.downButton.TabIndex = 10;
            this.downButton.Text = "下移";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // upButton
            // 
            this.upButton.Enabled = false;
            this.upButton.Location = new System.Drawing.Point(62, 212);
            this.upButton.Margin = new System.Windows.Forms.Padding(2);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(75, 25);
            this.upButton.TabIndex = 9;
            this.upButton.Text = "上移";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(236, 212);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 25);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "删除";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Enabled = false;
            this.addButton.Location = new System.Drawing.Point(236, 72);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 25);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "添加";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // layerLabel
            // 
            this.layerLabel.AutoSize = true;
            this.layerLabel.Location = new System.Drawing.Point(26, 50);
            this.layerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.layerLabel.Name = "layerLabel";
            this.layerLabel.Size = new System.Drawing.Size(32, 17);
            this.layerLabel.TabIndex = 2;
            this.layerLabel.Text = "图层";
            // 
            // groupBox
            // 
            this.groupBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupBox.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox.FormattingEnabled = true;
            this.groupBox.Location = new System.Drawing.Point(62, 19);
            this.groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(249, 23);
            this.groupBox.TabIndex = 1;
            this.groupBox.SelectedIndexChanged += new System.EventHandler(this.GroupBox_SelectedIndexChanged);
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Location = new System.Drawing.Point(14, 22);
            this.groupLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(44, 17);
            this.groupLabel.TabIndex = 0;
            this.groupLabel.Text = "图层组";
            // 
            // batchButton
            // 
            this.batchButton.Enabled = false;
            this.batchButton.Location = new System.Drawing.Point(106, 2);
            this.batchButton.Margin = new System.Windows.Forms.Padding(2);
            this.batchButton.Name = "batchButton";
            this.batchButton.Size = new System.Drawing.Size(100, 25);
            this.batchButton.TabIndex = 1;
            this.batchButton.Text = "批量合成(&B)";
            this.batchButton.UseVisualStyleBackColor = true;
            this.batchButton.Click += new System.EventHandler(this.BatchButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(2, 2);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 25);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "保存结果(&S)";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // swapPreviewButton
            // 
            this.swapPreviewButton.Location = new System.Drawing.Point(286, 347);
            this.swapPreviewButton.Name = "swapPreviewButton";
            this.swapPreviewButton.Size = new System.Drawing.Size(37, 25);
            this.swapPreviewButton.TabIndex = 5;
            this.swapPreviewButton.TabStop = false;
            this.swapPreviewButton.Text = ">>";
            this.mainToolTip.SetToolTip(this.swapPreviewButton, "切换预览方式");
            this.swapPreviewButton.UseVisualStyleBackColor = true;
            this.swapPreviewButton.Click += new System.EventHandler(this.swapPreviewButton_Click);
            // 
            // savePanel
            // 
            this.savePanel.Controls.Add(this.saveButton);
            this.savePanel.Controls.Add(this.batchButton);
            this.savePanel.Location = new System.Drawing.Point(8, 345);
            this.savePanel.Margin = new System.Windows.Forms.Padding(2);
            this.savePanel.Name = "savePanel";
            this.savePanel.Size = new System.Drawing.Size(208, 29);
            this.savePanel.TabIndex = 2;
            // 
            // previewButton
            // 
            this.previewButton.Enabled = false;
            this.previewButton.Location = new System.Drawing.Point(221, 347);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(61, 25);
            this.previewButton.TabIndex = 3;
            this.previewButton.TabStop = false;
            this.previewButton.Text = "大图(&P)";
            this.previewButton.UseVisualStyleBackColor = true;
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // selectedBox
            // 
            this.selectedBox.AllowDrop = true;
            this.selectedBox.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.selectedBox.FormattingEnabled = true;
            this.selectedBox.ItemHeight = 15;
            this.selectedBox.Location = new System.Drawing.Point(62, 99);
            this.selectedBox.Margin = new System.Windows.Forms.Padding(2);
            this.selectedBox.Name = "selectedBox";
            this.selectedBox.Size = new System.Drawing.Size(249, 109);
            this.selectedBox.TabIndex = 8;
            this.mainToolTip.SetToolTip(this.selectedBox, "按退格键删除当前选中项");
            this.selectedBox.ItemsChanged += new System.EventHandler(this.SelectedBox_ItemsChanged);
            this.selectedBox.SelectedIndexChanged += new System.EventHandler(this.SelectedBox_SelectedIndexChanged);
            this.selectedBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SelectedBox_KeyPress);
            // 
            // layerBox
            // 
            this.layerBox.BackColor = System.Drawing.SystemColors.Window;
            this.layerBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.layerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.layerBox.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.layerBox.Location = new System.Drawing.Point(62, 46);
            this.layerBox.Margin = new System.Windows.Forms.Padding(2);
            this.layerBox.MaxDropDownItems = 40;
            this.layerBox.Name = "layerBox";
            this.layerBox.Size = new System.Drawing.Size(249, 24);
            this.layerBox.TabIndex = 3;
            this.layerBox.HoveredIndexChanged += new System.EventHandler(this.Layer_HoveredIndexChanged);
            this.layerBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.LayerBox_DrawItem);
            this.layerBox.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.LayerBox_MeasureItem);
            this.layerBox.SelectedIndexChanged += new System.EventHandler(this.LayerBox_SelectedIndexChanged);
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(598, 383);
            this.Controls.Add(this.previewButton);
            this.Controls.Add(this.swapPreviewButton);
            this.Controls.Add(this.savePanel);
            this.Controls.Add(this.layerPanel);
            this.Controls.Add(this.openPanel);
            this.Controls.Add(this.fgiBox);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "krkrFgiEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWin_FormClosing);
            this.Load += new System.EventHandler(this.MainWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fgiBox)).EndInit();
            this.openPanel.ResumeLayout(false);
            this.openPanel.PerformLayout();
            this.layerPanel.ResumeLayout(false);
            this.layerPanel.PerformLayout();
            this.savePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.PictureBox fgiBox;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.GroupBox openPanel;
        private System.Windows.Forms.GroupBox layerPanel;
        private System.Windows.Forms.Label groupLabel;
        private ComboBoxEx layerBox;
        private System.Windows.Forms.Label layerLabel;
        private System.Windows.Forms.ComboBox groupBox;
        private ListBoxEx selectedBox;
        private System.Windows.Forms.Button batchButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel savePanel;
        private System.Windows.Forms.Label encodingLabel;
        private System.Windows.Forms.ComboBox encodingBox;
        private System.Windows.Forms.Button detectEncoding;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Label selectedLabel;
        private System.Windows.Forms.CheckBox autoSort;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ToolTip mainToolTip;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.Button swapPreviewButton;
        private System.Windows.Forms.Button previewButton;
    }
}

