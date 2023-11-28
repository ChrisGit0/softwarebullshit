using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace softwarebullshit
{
    public partial class StartedCookin : Form
    {
        public StartedCookin()
        {
            InitializeComponent();
        }

        private void FirstLb_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            iNeedMaDrUgz iNeed = new iNeedMaDrUgz();
            iNeed.Show();
            Hide();

        }
    }
}
