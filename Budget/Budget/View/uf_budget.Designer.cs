namespace Budget
{
    partial class uf_budget
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
            this.budgetTabs = new System.Windows.Forms.TabControl();
            this.cashFlowTab = new System.Windows.Forms.TabPage();
            this.cashFlowDGV = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.withdrawDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depositDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountBalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataSet = new System.Data.DataSet();
            this.cashFlowDataTable = new System.Data.DataTable();
            this.DTDate = new System.Data.DataColumn();
            this.DTObject = new System.Data.DataColumn();
            this.DTWithdraw = new System.Data.DataColumn();
            this.DTDeposit = new System.Data.DataColumn();
            this.DTAccountBal = new System.Data.DataColumn();
            this.DTTag = new System.Data.DataColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.incomeDGV = new System.Windows.Forms.DataGridView();
            this.incomes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.expensesDGV = new System.Windows.Forms.DataGridView();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFromCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.dgvContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.budgetTabs.SuspendLayout();
            this.cashFlowTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashFlowDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashFlowDataTable)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incomeDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesDGV)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.dgvContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // budgetTabs
            // 
            this.budgetTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.budgetTabs.Controls.Add(this.cashFlowTab);
            this.budgetTabs.Controls.Add(this.tabPage2);
            this.budgetTabs.Location = new System.Drawing.Point(12, 39);
            this.budgetTabs.Name = "budgetTabs";
            this.budgetTabs.SelectedIndex = 0;
            this.budgetTabs.Size = new System.Drawing.Size(927, 447);
            this.budgetTabs.TabIndex = 0;
            // 
            // cashFlowTab
            // 
            this.cashFlowTab.BackColor = System.Drawing.SystemColors.Control;
            this.cashFlowTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cashFlowTab.Controls.Add(this.cashFlowDGV);
            this.cashFlowTab.Location = new System.Drawing.Point(4, 25);
            this.cashFlowTab.Name = "cashFlowTab";
            this.cashFlowTab.Padding = new System.Windows.Forms.Padding(3);
            this.cashFlowTab.Size = new System.Drawing.Size(919, 418);
            this.cashFlowTab.TabIndex = 0;
            this.cashFlowTab.Text = "tabPage1";
            // 
            // cashFlowDGV
            // 
            this.cashFlowDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cashFlowDGV.AutoGenerateColumns = false;
            this.cashFlowDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cashFlowDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.objectDataGridViewTextBoxColumn,
            this.withdrawDataGridViewTextBoxColumn,
            this.depositDataGridViewTextBoxColumn,
            this.accountBalDataGridViewTextBoxColumn,
            this.tagDataGridViewTextBoxColumn});
            this.cashFlowDGV.DataMember = "cashFlowDataTable";
            this.cashFlowDGV.DataSource = this.dataSet;
            this.cashFlowDGV.Location = new System.Drawing.Point(6, 6);
            this.cashFlowDGV.Name = "cashFlowDGV";
            this.cashFlowDGV.RowTemplate.Height = 24;
            this.cashFlowDGV.Size = new System.Drawing.Size(905, 406);
            this.cashFlowDGV.TabIndex = 0;
            this.cashFlowDGV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cashFlowDGV_KeyDown);
            this.cashFlowDGV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cashFlowDGV_MouseClick);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // objectDataGridViewTextBoxColumn
            // 
            this.objectDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.objectDataGridViewTextBoxColumn.DataPropertyName = "object";
            this.objectDataGridViewTextBoxColumn.HeaderText = "Object";
            this.objectDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.objectDataGridViewTextBoxColumn.Name = "objectDataGridViewTextBoxColumn";
            // 
            // withdrawDataGridViewTextBoxColumn
            // 
            this.withdrawDataGridViewTextBoxColumn.DataPropertyName = "withdraw";
            this.withdrawDataGridViewTextBoxColumn.HeaderText = "Withdraw";
            this.withdrawDataGridViewTextBoxColumn.Name = "withdrawDataGridViewTextBoxColumn";
            // 
            // depositDataGridViewTextBoxColumn
            // 
            this.depositDataGridViewTextBoxColumn.DataPropertyName = "deposit";
            this.depositDataGridViewTextBoxColumn.HeaderText = "Deposit";
            this.depositDataGridViewTextBoxColumn.Name = "depositDataGridViewTextBoxColumn";
            // 
            // accountBalDataGridViewTextBoxColumn
            // 
            this.accountBalDataGridViewTextBoxColumn.DataPropertyName = "accountBal";
            this.accountBalDataGridViewTextBoxColumn.HeaderText = "Account Balance";
            this.accountBalDataGridViewTextBoxColumn.Name = "accountBalDataGridViewTextBoxColumn";
            // 
            // tagDataGridViewTextBoxColumn
            // 
            this.tagDataGridViewTextBoxColumn.DataPropertyName = "tag";
            this.tagDataGridViewTextBoxColumn.HeaderText = "Tag";
            this.tagDataGridViewTextBoxColumn.Name = "tagDataGridViewTextBoxColumn";
            this.tagDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tagDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "NewDataSet";
            this.dataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.cashFlowDataTable});
            // 
            // cashFlowDataTable
            // 
            this.cashFlowDataTable.Columns.AddRange(new System.Data.DataColumn[] {
            this.DTDate,
            this.DTObject,
            this.DTWithdraw,
            this.DTDeposit,
            this.DTAccountBal,
            this.DTTag});
            this.cashFlowDataTable.TableName = "cashFlowDataTable";
            // 
            // DTDate
            // 
            this.DTDate.Caption = "Date";
            this.DTDate.ColumnName = "date";
            this.DTDate.DataType = typeof(System.DateTime);
            // 
            // DTObject
            // 
            this.DTObject.Caption = "Object";
            this.DTObject.ColumnName = "object";
            // 
            // DTWithdraw
            // 
            this.DTWithdraw.ColumnName = "withdraw";
            this.DTWithdraw.DataType = typeof(double);
            // 
            // DTDeposit
            // 
            this.DTDeposit.Caption = "Deposit";
            this.DTDeposit.ColumnName = "deposit";
            this.DTDeposit.DataType = typeof(double);
            // 
            // DTAccountBal
            // 
            this.DTAccountBal.Caption = "Account Balance";
            this.DTAccountBal.ColumnName = "accountBal";
            this.DTAccountBal.DataType = typeof(double);
            // 
            // DTTag
            // 
            this.DTTag.Caption = "Tag";
            this.DTTag.ColumnName = "tag";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.incomeDGV);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.expensesDGV);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(919, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // incomeDGV
            // 
            this.incomeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incomeDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.incomes});
            this.incomeDGV.Location = new System.Drawing.Point(21, 252);
            this.incomeDGV.Name = "incomeDGV";
            this.incomeDGV.RowTemplate.Height = 24;
            this.incomeDGV.Size = new System.Drawing.Size(874, 148);
            this.incomeDGV.TabIndex = 0;
            // 
            // incomes
            // 
            this.incomes.HeaderText = "Income";
            this.incomes.Name = "incomes";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(21, 238);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(874, 148);
            this.dataGridView2.TabIndex = 0;
            // 
            // expensesDGV
            // 
            this.expensesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expensesDGV.Location = new System.Drawing.Point(21, 45);
            this.expensesDGV.Name = "expensesDGV";
            this.expensesDGV.RowTemplate.Height = 24;
            this.expensesDGV.Size = new System.Drawing.Size(874, 148);
            this.expensesDGV.TabIndex = 0;
            this.expensesDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.expensesDGV_CellDoubleClick);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(939, 28);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importFromCSVToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importFromCSVToolStripMenuItem
            // 
            this.importFromCSVToolStripMenuItem.Name = "importFromCSVToolStripMenuItem";
            this.importFromCSVToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.importFromCSVToolStripMenuItem.Text = "Import from CSV";
            this.importFromCSVToolStripMenuItem.Click += new System.EventHandler(this.importFromCSVToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assignationsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // assignationsToolStripMenuItem
            // 
            this.assignationsToolStripMenuItem.Name = "assignationsToolStripMenuItem";
            this.assignationsToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.assignationsToolStripMenuItem.Text = "Assignations";
            // 
            // dgvContextMenu
            // 
            this.dgvContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dgvContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasteMenuItem});
            this.dgvContextMenu.Name = "contextMenuStrip1";
            this.dgvContextMenu.Size = new System.Drawing.Size(170, 30);
            // 
            // pasteMenuItem
            // 
            this.pasteMenuItem.Name = "pasteMenuItem";
            this.pasteMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteMenuItem.Size = new System.Drawing.Size(169, 26);
            this.pasteMenuItem.Text = "Paste";
            this.pasteMenuItem.Click += new System.EventHandler(this.pasteMenuItem_Click);
            // 
            // uf_budget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 498);
            this.Controls.Add(this.budgetTabs);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "uf_budget";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.uf_budget_Load);
            this.budgetTabs.ResumeLayout(false);
            this.cashFlowTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cashFlowDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashFlowDataTable)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.incomeDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesDGV)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.dgvContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage cashFlowTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importFromCSVToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        internal System.Windows.Forms.TabControl budgetTabs;
        internal System.Windows.Forms.DataGridView cashFlowDGV;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        internal System.Windows.Forms.SaveFileDialog saveFileDialog;
        internal System.Data.DataTable cashFlowDataTable;
        internal System.Data.DataColumn DTDate;
        internal System.Data.DataColumn DTObject;
        internal System.Data.DataSet dataSet;
        private System.Data.DataColumn DTWithdraw;
        private System.Data.DataColumn DTDeposit;
        private System.Data.DataColumn DTAccountBal;
        private System.Data.DataColumn DTTag;
        private System.Windows.Forms.ContextMenuStrip dgvContextMenu;
        internal System.Windows.Forms.ToolStripMenuItem pasteMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn withdrawDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depositDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountBalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tagDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignationsToolStripMenuItem;
        private System.Windows.Forms.DataGridView incomeDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomes;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView expensesDGV;
    }
}

