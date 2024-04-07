using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN_Bai1_LienKetWebSite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtKQ.Clear();  
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(IstBox.SelectedItems!=null)
            {
               string selectedWeb=IstBox.SelectedItem.ToString();
                txtKQ.Text = "Bạn đã chọn " + selectedWeb;
            }
        }
    }
}
