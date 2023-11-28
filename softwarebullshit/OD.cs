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
    public partial class OD : Form
    {
        public OD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            odEnding od2 = new odEnding();  
            od2.Show();
            Hide();

        }
    }
}
