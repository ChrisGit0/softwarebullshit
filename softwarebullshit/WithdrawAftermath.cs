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
    public partial class WithdrawAftermath : Form
    {
        public WithdrawAftermath()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WithdrawEnding withdraw = new WithdrawEnding();
            withdraw.Show();
            Hide();
        }
    }
}
