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
    public partial class ComboboxLienKetWebsite : Form
    {
        public ComboboxLienKetWebsite()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtKQ.ResetText();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(cbBox.SelectedItem != null)
            {
                string slWeb=cbBox.SelectedItem.ToString();
                txtKQ.Text = "Bạn đã chọn "+slWeb;
            }
        }
    }
}
