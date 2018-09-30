using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Budget
{
    class clipboardDesjardinsImporter
    {
        //Properties
        uf_budget uf_budget;
        //DataGridViewCellEventArgs e;

        //Constructors
        public clipboardDesjardinsImporter(uf_budget uf_budget)
        {
            this.uf_budget = uf_budget;
            string[] sep = {"\r\n"};
            List<string> cashFlow = Clipboard.GetText().Split(sep, StringSplitOptions.None).ToList();

            if(cashFlow.Count>0)
            {
                List<string> entryFields = new List<string>();
                string[] entrySep = {"\t"};
                double tmpDbl = 0;

                foreach (string entry in cashFlow)
                {
                    entryFields = entry.Split(entrySep, StringSplitOptions.None).ToList();

                    if (entryFields.Count == 5)
                    {
                        System.Data.DataRow dataRow = uf_budget.dataSet.Tables[0].NewRow();

                        if (entryFields[0]!= "") dataRow["date"] = convertFromDesjardinsDateFormat(entryFields[0]);
                        if (entryFields[1] != "") dataRow["object"] = entryFields[1];

                        if (entryFields[2] != "")
                        {
                            double.TryParse(entryFields[2], out tmpDbl);
                            dataRow["withdraw"] = tmpDbl;
                        }

                        if (entryFields[3] != "")
                        {
                            double.TryParse(entryFields[3], out tmpDbl);
                            dataRow["deposit"] = tmpDbl;
                        }

                        if (entryFields[4] != "")
                        {
                            double.TryParse(entryFields[4], out tmpDbl);
                            dataRow["accountBal"] = tmpDbl;
                        }

                        uf_budget.dataSet.Tables["cashFlowDataTable"].Rows.Add(dataRow);
                    }                    
                }
            }
            
        }

        //Destructors

        //Methods
        private DateTime convertFromDesjardinsDateFormat(string date)
        {
            byte[] utfSpace = new byte[] { 194, 160 };
            
            char[] sep = Encoding.UTF8.GetChars(utfSpace);

            try
            {
                string[] dateFields = date.Split(sep, StringSplitOptions.None);

                int day = int.Parse(dateFields[0].Replace("\"", ""));
                int month = 0;
                int year = int.Parse(dateFields[2].Replace("\"", ""));

                if (dateFields[1].Replace("\"", "").ToUpper().Contains("JAN")) month = 1;
                if (dateFields[1].Replace("\"", "").ToUpper().Contains("FEV") | dateFields[1].Replace("\"", "").ToUpper().Contains("FÉV")) month = 2;
                if (dateFields[1].Replace("\"", "").ToUpper().Contains("MAR")) month = 3;
                if (dateFields[1].Replace("\"", "").ToUpper().Contains("AVR")) month = 4;
                if (dateFields[1].Replace("\"", "").ToUpper().Contains("MAI")) month = 5;
                if (dateFields[1].Replace("\"", "").ToUpper().Contains("JUN")) month = 6;
                if (dateFields[1].Replace("\"", "").ToUpper().Contains("JUI") | dateFields[1].Replace("\"", "").ToUpper().Contains("JUL")) month = 7;
                if (dateFields[1].Replace("\"", "").ToUpper().Contains("AOU") | dateFields[1].Replace("\"", "").ToUpper().Contains("AOÛ") | dateFields[1].Replace("\"", "").ToUpper().Contains("AUG")) month = 8;
                if (dateFields[1].Replace("\"", "").ToUpper().Contains("SEP")) month = 9;
                if (dateFields[1].Replace("\"", "").ToUpper().Contains("OCT")) month = 10;
                if (dateFields[1].Replace("\"", "").ToUpper().Contains("NOV ")) month = 11;
                if (dateFields[1].Replace("\"", "").ToUpper().Contains("DEC") | dateFields[1].Replace("\"", "").ToUpper().Contains("DÉC")) month = 12;

                return new DateTime(year, month, day);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return new DateTime(2000, 1, 1);
            }            
        }
        //Events

    }
}
