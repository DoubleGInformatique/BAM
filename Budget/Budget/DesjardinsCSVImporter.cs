using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace Budget
{
    class DesjardinsCSVImporter
    {
        //Properties
        private uf_budget uf_budget;
        private string accountFilter;

        //Constructors
        public DesjardinsCSVImporter(string fileName, uf_budget uf, string accountFilter)
        {
            this.uf_budget = uf;
            this.accountFilter = accountFilter;
            importeDesjardinsCSV(fileName);                             
        }

        //Destructors
        ~DesjardinsCSVImporter()
        {
                
        }

        //Methods
        internal void importeDesjardinsCSV(string fileName)
        {

            StreamReader CSVReader = new StreamReader(File.Open(fileName, FileMode.Open, FileAccess.Read),Encoding.Default);

            if (CSVReader != null)
            {
                string tmpStr = "";
                string[] fields = tmpStr.Split(',');
                double tmpDbl = 0;                object[] tmpArr = new object[6] {"", "", "", "", "", "" };

                while(!CSVReader.EndOfStream)
                {
                    
                    tmpStr = CSVReader.ReadLine();
                    fields = tmpStr.Split(',');

                    if (fields.Length > 1)
                    {
                        if (fields[2].Replace("\"","") == accountFilter)
                        {
                            DateTime tmpDate = DateTime.Parse(fields[3].Replace("\"", "")).Date;
                            tmpArr[0] = tmpDate;

                            tmpArr[1] = fields[5].Replace("\"","");

                            double.TryParse(fields[7].Replace("\"", "").Replace(" ", ""), out tmpDbl);
                            tmpArr[2]=tmpDbl;

                            double.TryParse(fields[8].Replace("\"", "").Replace(" ", ""), out tmpDbl);
                            tmpArr[3] = tmpDbl;

                            double.TryParse(fields[13].Replace("\"", "").Replace(" ", ""), out tmpDbl);
                            tmpArr[4] = tmpDbl;
                            
                            uf_budget.dataSet.Tables["cashFlowDataTable"].Rows.Add(tmpArr);
                        }
                    }
                }

                CSVReader.Close();
            }
        }

        //Events
    }
}
