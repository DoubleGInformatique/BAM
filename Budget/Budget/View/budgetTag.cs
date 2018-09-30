using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace Budget
{
    public class budgetTag
    {
        public string tag { get; set; }
        public double amount { get; set; }

        private uf_budget uf_budget;
        
        public List<string> assignations = new List<string>();

        //Constructors
        public budgetTag(uf_budget uf_budget)
        {
            this.uf_budget = uf_budget;
        }


        //Methods
        public void add(string assignation)
        {
            if (assignation != "")
            {
                assignations.Add(assignation);
            }
        }

        public void updateCBox()
        {

        }

        //Events
        public void addToCBox(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        }
    }
}
