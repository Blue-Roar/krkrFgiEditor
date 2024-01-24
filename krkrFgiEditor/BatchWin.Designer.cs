namespace krkrFgiEditor
{
    partial class BatchWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatchWin));
            this.layerPanel = new System.Windows.Forms.GroupBox();
            this.groupList = new krkrFgiEditor.ListBoxEx();
            this.deleteButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.addGroupButton = new System.Windows.Forms.Button();
            this.layerList = new krkrFgiEditor.ListBoxEx();
            this.layerBox = new System.Windows.Forms.ComboBox();
            this.layerLabel = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.ComboBox();
            this.groupLabel = new System.Windows.Forms.Label();
            this.savePanel = new System.Windows.Forms.GroupBox();
            this.savePath = new System.Windows.Forms.TextBox();
            this.openFolder = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.listBoxTip = new System.Windows.Forms.ToolTip(this.components);
            this.layerPanel.SuspendLayout();
            this.savePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // layerPanel
            // 
            this.layerPanel.Controls.Add(this.groupList);
            this.layerPanel.Controls.Add(this.deleteButton);
            this.layerPanel.Controls.Add(this.upButton);
            this.layerPanel.Controls.Add(this.downButton);
            this.layerPanel.Controls.Add(this.createButton);
            this.layerPanel.Controls.Add(this.addButton);
            this.layerPanel.Controls.Add(this.addGroupButton);
            this.layerPanel.Controls.Add(this.layerList);
            this.layerPanel.Controls.Add(this.layerBox);
            this.layerPanel.Controls.Add(this.layerLabel);
            this.layerPanel.Controls.Add(this.groupBox);
            this.layerPanel.Controls.Add(this.groupLabel);
            this.layerPanel.Location = new System.Drawing.Point(8, 8);
            this.layerPanel.Margin = new System.Windows.Forms.Padding(2);
            this.layerPanel.Name = "layerPanel";
            this.layerPanel.Padding = new System.Windows.Forms.Padding(2);
            this.layerPanel.Size = new System.Drawing.Size(366, 208);
            this.layerPanel.TabIndex = 0;
            this.layerPanel.TabStop = false;
            this.layerPanel.Text = "图层选择";
            // 
            // groupList
            // 
            this.groupList.AllowDrop = true;
            this.groupList.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupList.FormattingEnabled = true;
            this.groupList.ItemHeight = 15;
            this.groupList.Location = new System.Drawing.Point(11, 75);
            this.groupList.Margin = new System.Windows.Forms.Padding(2);
            this.groupList.Name = "groupList";
            this.groupList.Size = new System.Drawing.Size(138, 124);
            this.groupList.TabIndex = 6;
            this.groupList.ItemsChanged += new System.EventHandler(this.ListItemsChanged);
            this.groupList.SelectedIndexChanged += new System.EventHandler(this.GroupList_SelectedIndexChanged);
            this.groupList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GroupList_KeyPress);
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(151, 109);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(67, 23);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "删除";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // upButton
            // 
            this.upButton.Enabled = false;
            this.upButton.Location = new System.Drawing.Point(151, 137);
            this.upButton.Margin = new System.Windows.Forms.Padding(2);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(67, 23);
            this.upButton.TabIndex = 9;
            this.upButton.Text = "上移";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // downButton
            // 
            this.downButton.Enabled = false;
            this.downButton.Location = new System.Drawing.Point(151, 164);
            this.downButton.Margin = new System.Windows.Forms.Padding(2);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(67, 23);
            this.downButton.TabIndex = 10;
            this.downButton.Text = "下移";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(151, 82);
            this.createButton.Margin = new System.Windows.Forms.Padding(2);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(67, 23);
            this.createButton.TabIndex = 7;
            this.createButton.Text = "新建";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // addButton
            // 
            this.addButton.Enabled = false;
            this.addButton.Location = new System.Drawing.Point(279, 47);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(80, 24);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "添加";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // addGroupButton
            // 
            this.addGroupButton.Location = new System.Drawing.Point(279, 20);
            this.addGroupButton.Margin = new System.Windows.Forms.Padding(2);
            this.addGroupButton.Name = "addGroupButton";
            this.addGroupButton.Size = new System.Drawing.Size(80, 23);
            this.addGroupButton.TabIndex = 2;
            this.addGroupButton.Text = "添加组";
            this.addGroupButton.UseVisualStyleBackColor = true;
            this.addGroupButton.Click += new System.EventHandler(this.AddGroupButton_Click);
            // 
            // layerList
            // 
            this.layerList.AllowDrop = true;
            this.layerList.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.layerList.FormattingEnabled = true;
            this.layerList.ItemHeight = 15;
            this.layerList.Location = new System.Drawing.Point(222, 75);
            this.layerList.Margin = new System.Windows.Forms.Padding(2);
            this.layerList.Name = "layerList";
            this.layerList.Size = new System.Drawing.Size(138, 124);
            this.layerList.TabIndex = 11;
            this.layerList.ItemsChanged += new System.EventHandler(this.ListItemsChanged);
            this.layerList.SelectedIndexChanged += new System.EventHandler(this.LayerList_SelectedIndexChanged);
            this.layerList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LayerList_KeyPress);
            // 
            // layerBox
            // 
            this.layerBox.BackColor = System.Drawing.SystemColors.Window;
            this.layerBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.layerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.layerBox.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.layerBox.Location = new System.Drawing.Point(62, 47);
            this.layerBox.Margin = new System.Windows.Forms.Padding(2);
            this.layerBox.MaxDropDownItems = 40;
            this.layerBox.Name = "layerBox";
            this.layerBox.Size = new System.Drawing.Size(214, 24);
            this.layerBox.TabIndex = 4;
            this.layerBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.LayerBox_DrawItem);
            this.layerBox.SelectedIndexChanged += new System.EventHandler(this.LayerBox_SelectedIndexChanged);
            // 
            // layerLabel
            // 
            this.layerLabel.AutoSize = true;
            this.layerLabel.Location = new System.Drawing.Point(26, 51);
            this.layerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.layerLabel.Name = "layerLabel";
            this.layerLabel.Size = new System.Drawing.Size(32, 17);
            this.layerLabel.TabIndex = 3;
            this.layerLabel.Text = "图层";
            this.layerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox
            // 
            this.groupBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupBox.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox.FormattingEnabled = true;
            this.groupBox.Location = new System.Drawing.Point(62, 20);
            this.groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(214, 23);
            this.groupBox.TabIndex = 1;
            this.groupBox.SelectedIndexChanged += new System.EventHandler(this.GroupBox_SelectedIndexChanged);
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Location = new System.Drawing.Point(14, 23);
            this.groupLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(44, 17);
            this.groupLabel.TabIndex = 0;
            this.groupLabel.Text = "图层组";
            this.groupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // savePanel
            // 
            this.savePanel.Controls.Add(this.savePath);
            this.savePanel.Controls.Add(this.openFolder);
            this.savePanel.Location = new System.Drawing.Point(8, 220);
            this.savePanel.Margin = new System.Windows.Forms.Padding(2);
            this.savePanel.Name = "savePanel";
            this.savePanel.Padding = new System.Windows.Forms.Padding(2);
            this.savePanel.Size = new System.Drawing.Size(366, 55);
            this.savePanel.TabIndex = 1;
            this.savePanel.TabStop = false;
            this.savePanel.Text = "保存路径";
            // 
            // savePath
            // 
            this.savePath.Location = new System.Drawing.Point(11, 21);
            this.savePath.Margin = new System.Windows.Forms.Padding(2);
            this.savePath.Name = "savePath";
            this.savePath.ReadOnly = true;
            this.savePath.Size = new System.Drawing.Size(313, 23);
            this.savePath.TabIndex = 0;
            this.savePath.Click += new System.EventHandler(this.OpenFolder_Click);
            // 
            // openFolder
            // 
            this.openFolder.Location = new System.Drawing.Point(328, 21);
            this.openFolder.Margin = new System.Windows.Forms.Padding(2);
            this.openFolder.Name = "openFolder";
            this.openFolder.Size = new System.Drawing.Size(31, 23);
            this.openFolder.TabIndex = 1;
            this.openFolder.Text = "...";
            this.openFolder.UseVisualStyleBackColor = true;
            this.openFolder.Click += new System.EventHandler(this.OpenFolder_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Enabled = false;
            this.confirmButton.Location = new System.Drawing.Point(141, 289);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(2);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(100, 26);
            this.confirmButton.TabIndex = 2;
            this.confirmButton.Text = "开始合成";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // BatchWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(382, 326);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.savePanel);
            this.Controls.Add(this.layerPanel);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BatchWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "批量合成";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.BatchWin_HelpButtonClicked);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BatchWin_FormClosed);
            this.layerPanel.ResumeLayout(false);
            this.layerPanel.PerformLayout();
            this.savePanel.ResumeLayout(false);
            this.savePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox layerPanel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button addGroupButton;
        private ListBoxEx layerList;
        private System.Windows.Forms.ComboBox layerBox;
        private System.Windows.Forms.Label layerLabel;
        private System.Windows.Forms.ComboBox groupBox;
        private System.Windows.Forms.Label groupLabel;
        private ListBoxEx groupList;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.GroupBox savePanel;
        private System.Windows.Forms.TextBox savePath;
        private System.Windows.Forms.Button openFolder;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.ToolTip listBoxTip;
    }
}