using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinifyERPBilling.Forms.Utils
{
    public partial class ReciptRefWindow : Form
    {
        public ReciptRefWindow()
        {
            InitializeComponent();
        }

        public ReciptRefWindow(string Name,double Amount)
        {
            InitializeComponent();
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_closeForReceiptRef_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
