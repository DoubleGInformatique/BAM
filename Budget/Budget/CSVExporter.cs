using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Budget
{
    class CSVExporter
    {
        //Properties
        uf_budget uf_budget;

        //Constructors
        public CSVExporter(uf_budget uf_budget)
        {
            this.uf_budget =uf_budget;
        }

        //Destructors

        //Methods
        public void exportCashFlowToCSV()
        {
            uf_budget.saveFileDialog.ShowDialog();
            uf_budget.saveFileDialog.CheckFileExists = false;

            try
            {
                StreamWriter CSVWriter = new StreamWriter(uf_budget.saveFileDialog.FileName,false,Encoding.UTF8);
                foreach (DataGridViewRow row in uf_budget.cashFlowDGV.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.ColumnIndex < row.Cells.Count - 1) CSVWriter.Write(cell.Value + ";");
                        else CSVWriter.Write(cell.Value);
                    }
                    if (row.Index < uf_budget.cashFlowDGV.Rows.Count - 1) CSVWriter.Write("\r\n");
                }
                CSVWriter.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Events

    }
}
