using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayLoop
{
    public partial class ArrayLoop : Form
    {
        public ArrayLoop()
        {
            InitializeComponent();
        }

        private void ReturnNames()
        {
            string[] names = { "Beyonce (f)", "David Bowie (m)", "Elvis Costello (m)",
                    "Madonna (f)", "Elton John (m)", "Charles Aznavour (m)"};

            foreach (string n in names)
            {
                lstNames.Items.Add(n);
            }
        }

        private void Calculate()
        {
            int males = 0;
            int females = 0;

            foreach (string name in lstNames.Items)
            {
                if (name.Contains("(m)"))
                {
                    males++;
                }
                
                if (name.Contains("(f)"))
                {
                    females++;
                }
            }

            males.ToString();
            females.ToString();

            string countResult = "There are " + males + " male singers" +
                " and " + females + " female singers";
            richTxtResult.Text = countResult;
        }

        private void ArrayLoop_Load(object sender, EventArgs e)
        {
            ReturnNames();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
           Calculate();
        }
    }
}
