namespace BaseballDatabase
{
    partial class playersTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playersTable));
            this.playersTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.playersTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.playerDataGridView = new System.Windows.Forms.DataGridView();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.findButton = new System.Windows.Forms.Button();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.filterGroupBox = new System.Windows.Forms.GroupBox();
            this.maximumLabel = new System.Windows.Forms.Label();
            this.mimimumLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.maximumTextBox = new System.Windows.Forms.TextBox();
            this.minimumTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playersTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.playersTableBindingNavigator)).BeginInit();
            this.playersTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            this.searchGroupBox.SuspendLayout();
            this.filterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // playersTableBindingNavigator
            // 
            this.playersTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.playersTableBindingNavigator.BindingSource = this.playersTableBindingSource;
            this.playersTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.playersTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.playersTableBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.playersTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.playersTableBindingNavigatorSaveItem});
            this.playersTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.playersTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.playersTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.playersTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.playersTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.playersTableBindingNavigator.Name = "playersTableBindingNavigator";
            this.playersTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.playersTableBindingNavigator.Size = new System.Drawing.Size(592, 27);
            this.playersTableBindingNavigator.TabIndex = 0;
            this.playersTableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // playersTableBindingNavigatorSaveItem
            // 
            this.playersTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.playersTableBindingNavigatorSaveItem.Enabled = false;
            this.playersTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("playersTableBindingNavigatorSaveItem.Image")));
            this.playersTableBindingNavigatorSaveItem.Name = "playersTableBindingNavigatorSaveItem";
            this.playersTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.playersTableBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // playerDataGridView
            // 
            this.playerDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerDataGridView.AutoGenerateColumns = false;
            this.playerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.playerDataGridView.DataSource = this.playerBindingSource;
            this.playerDataGridView.Location = new System.Drawing.Point(0, 27);
            this.playerDataGridView.Name = "playerDataGridView";
            this.playerDataGridView.RowTemplate.Height = 24;
            this.playerDataGridView.Size = new System.Drawing.Size(592, 198);
            this.playerDataGridView.TabIndex = 1;
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(Baseball.Player);
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.browseButton);
            this.searchGroupBox.Controls.Add(this.findButton);
            this.searchGroupBox.Controls.Add(this.lastNameLabel);
            this.searchGroupBox.Controls.Add(this.lastNameTextBox);
            this.searchGroupBox.Location = new System.Drawing.Point(12, 231);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(266, 100);
            this.searchGroupBox.TabIndex = 2;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search for Player";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(124, 71);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 3;
            this.browseButton.Text = "Reset";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(8, 71);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 2;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(5, 27);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(76, 17);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(124, 27);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.ShortcutsEnabled = false;
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.lastNameTextBox.TabIndex = 0;
            this.lastNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lastNameTextBox_KeyPress);
            // 
            // filterGroupBox
            // 
            this.filterGroupBox.Controls.Add(this.maximumLabel);
            this.filterGroupBox.Controls.Add(this.mimimumLabel);
            this.filterGroupBox.Controls.Add(this.searchButton);
            this.filterGroupBox.Controls.Add(this.maximumTextBox);
            this.filterGroupBox.Controls.Add(this.minimumTextBox);
            this.filterGroupBox.Location = new System.Drawing.Point(284, 231);
            this.filterGroupBox.Name = "filterGroupBox";
            this.filterGroupBox.Size = new System.Drawing.Size(296, 207);
            this.filterGroupBox.TabIndex = 3;
            this.filterGroupBox.TabStop = false;
            this.filterGroupBox.Text = "Batting Average Filter";
            // 
            // maximumLabel
            // 
            this.maximumLabel.AutoSize = true;
            this.maximumLabel.Location = new System.Drawing.Point(177, 32);
            this.maximumLabel.Name = "maximumLabel";
            this.maximumLabel.Size = new System.Drawing.Size(114, 17);
            this.maximumLabel.TabIndex = 4;
            this.maximumLabel.Text = "Maximum Batting";
            // 
            // mimimumLabel
            // 
            this.mimimumLabel.AutoSize = true;
            this.mimimumLabel.Location = new System.Drawing.Point(6, 31);
            this.mimimumLabel.Name = "mimimumLabel";
            this.mimimumLabel.Size = new System.Drawing.Size(111, 17);
            this.mimimumLabel.TabIndex = 3;
            this.mimimumLabel.Text = "Minimum Batting";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(84, 147);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // maximumTextBox
            // 
            this.maximumTextBox.Location = new System.Drawing.Point(180, 71);
            this.maximumTextBox.MaxLength = 5;
            this.maximumTextBox.Name = "maximumTextBox";
            this.maximumTextBox.ShortcutsEnabled = false;
            this.maximumTextBox.Size = new System.Drawing.Size(100, 22);
            this.maximumTextBox.TabIndex = 1;
            this.maximumTextBox.TextChanged += new System.EventHandler(this.maximumTextBox_TextChanged);
            // 
            // minimumTextBox
            // 
            this.minimumTextBox.Location = new System.Drawing.Point(6, 72);
            this.minimumTextBox.MaxLength = 5;
            this.minimumTextBox.Name = "minimumTextBox";
            this.minimumTextBox.ShortcutsEnabled = false;
            this.minimumTextBox.Size = new System.Drawing.Size(100, 22);
            this.minimumTextBox.TabIndex = 0;
            this.minimumTextBox.TextChanged += new System.EventHandler(this.minimumTextBox_TextChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PlayerID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PlayerID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BattingAverage";
            this.dataGridViewTextBoxColumn4.HeaderText = "BattingAverage";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // playersTableBindingSource
            // 
            this.playersTableBindingSource.DataSource = typeof(BaseballDatabase.playersTable);
            // 
            // playersTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.filterGroupBox);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.playerDataGridView);
            this.Controls.Add(this.playersTableBindingNavigator);
            this.Name = "playersTable";
            this.Text = "Players Look Up";
            this.Load += new System.EventHandler(this.playersTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playersTableBindingNavigator)).EndInit();
            this.playersTableBindingNavigator.ResumeLayout(false);
            this.playersTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.filterGroupBox.ResumeLayout(false);
            this.filterGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource playersTableBindingSource;
        private System.Windows.Forms.BindingNavigator playersTableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton playersTableBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private System.Windows.Forms.DataGridView playerDataGridView;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.GroupBox filterGroupBox;
        private System.Windows.Forms.Label maximumLabel;
        private System.Windows.Forms.Label mimimumLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox maximumTextBox;
        private System.Windows.Forms.TextBox minimumTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

