using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Budget
{
    public partial class uf_budget : Form
    {
        //Properties

        //Classes
        public class dataGridViewVertBorderCell : DataGridViewTextBoxCell
        {
            public dataGridViewVertBorderCell()
            {
            }

            public override DataGridViewAdvancedBorderStyle AdjustCellBorderStyle(
                DataGridViewAdvancedBorderStyle dataGridViewAdvancedBorderStyleInput,
                DataGridViewAdvancedBorderStyle dataGridViewAdvancedBorderStylePlaceholder,
                bool singleVerticalBorderAdded,
                bool singleHorizontalBorderAdded,
                bool isFirstDisplayedColumn,
                bool isFirstDisplayedRow)
            {

                dataGridViewAdvancedBorderStylePlaceholder.Top = DataGridViewAdvancedCellBorderStyle.Outset;
                dataGridViewAdvancedBorderStylePlaceholder.Bottom = DataGridViewAdvancedCellBorderStyle.None;

                dataGridViewAdvancedBorderStylePlaceholder.Right = dataGridViewAdvancedBorderStyleInput.Right;
                dataGridViewAdvancedBorderStylePlaceholder.Left = dataGridViewAdvancedBorderStyleInput.Left;

                return dataGridViewAdvancedBorderStylePlaceholder;
            }


        }

        public class datagridViewDateCell : dataGridViewVertBorderCell
        {
            public datagridViewDateCell()
            {
                this.Style.BackColor = Color.FromArgb(255, 255, 200, 150);
                this.Style.Format = "dddd d-MMM-yyyy";
                this.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        public class dataGridViewRedCell : dataGridViewVertBorderCell
        {
            public dataGridViewRedCell()
            {
                this.Style.BackColor = Color.FromArgb(255, 255, 150, 150);
                this.Style.ForeColor = Color.FromArgb(255, 150, 0, 0);
                this.Style.Format = "#,##0.00 $";
                this.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        public class dataGridViewGreenCell : dataGridViewVertBorderCell
        {
            public dataGridViewGreenCell()
            {
                this.Style.BackColor = Color.FromArgb(255, 150, 255, 150);
                this.Style.ForeColor = Color.FromArgb(255, 0, 150, 0);
                this.Style.Format = "#,##0.00 $";
                this.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        public class accountBalDataGridViewCell : dataGridViewVertBorderCell
        {
            public accountBalDataGridViewCell()
            {
                this.Style.Format = "#,##0.00 $";
                this.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        public class expensesTagsDGVColumn : DataGridViewColumn
        {
            //Properties

            //Constructor
            public expensesTagsDGVColumn()
            {
                this.CellTemplate = new dataGridViewRedCell();
                this.HeaderCell.Value = "Expenses";
                this.Name = "expensesDGVBudgetTagsColumn";
            }

            //Methods

        }

        public class incomeTagsDGVColumn : DataGridViewColumn
        {
            //Properties

            //Constructor
            public incomeTagsDGVColumn()
            {
                this.CellTemplate = new dataGridViewGreenCell();
                this.HeaderCell.Value = "Income";
                this.Name = "incomeDGVBudgetTagsColumn";
            }

            //Methods

        }


        //Constructors
        public uf_budget()
        {
            InitializeComponent();
        }
        

        //Methods

        //Events
        private void importFromCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            openFileDialog.CheckFileExists = true;
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != "")
            {
                DesjardinsCSVImporter DesjardinsCSVImpor = new DesjardinsCSVImporter(openFileDialog.FileName, this, "EOP");
            }
        }

        private void cashFlowDGV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                clipboardDesjardinsImporter clipboardImport = new clipboardDesjardinsImporter(this);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CSVExporter CSVExport = new CSVExporter(this);
            CSVExport.exportCashFlowToCSV();
        }

        private void cashFlowDGV_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgvContextMenu.Show();
                dgvContextMenu.Left =Cursor.Position.X;
                dgvContextMenu.Top = Cursor.Position.Y;
            }
        }

        private void pasteMenuItem_Click(object sender, EventArgs e)
        {
            clipboardDesjardinsImporter clipboardImport = new clipboardDesjardinsImporter(this);
        }

        private void uf_budget_Load(object sender, EventArgs e)
        {
            dateDataGridViewTextBoxColumn.CellTemplate = new datagridViewDateCell();
            withdrawDataGridViewTextBoxColumn.CellTemplate = new dataGridViewRedCell();
            depositDataGridViewTextBoxColumn.CellTemplate = new dataGridViewGreenCell();
            accountBalDataGridViewTextBoxColumn.CellTemplate = new accountBalDataGridViewCell();

            expensesDGV.Columns.Add(new expensesTagsDGVColumn());
        }

        private void expensesDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(cashFlowDGV.Columns[e.ColumnIndex].Name == "dateDataGridViewTextBoxColumn")
            {
                budgetTag bTag = new budgetTag(this);
            }
        }
    }
}
