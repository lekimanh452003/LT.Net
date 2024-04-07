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
    public partial class DanhSachSinhVien : Form
    {
        public DanhSachSinhVien()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string ten=txtHoTen.Text;
            if(ten!=null)
            {
                LstBoxDsLopA.Items.Add(ten);
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult tl;
            tl = MessageBox.Show("Bạn có muốn thoát chương trình không?","Kết thúc",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(tl == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void btnAsangB_Click(object sender, EventArgs e)
        {
            if (LstBoxDsLopA != null)
            {
                string selectedName=LstBoxDsLopA.SelectedItem.ToString();
                lstBoxDsLopB.Items.Add(selectedName);
                LstBoxDsLopA.Items.Remove(selectedName);
            }
            else
            {
                MessageBox.Show("Hãy chọn 1 tên trong Lớp A để chuyển sang lớp B!");
            }
        }

        private void btnBsangA_Click(object sender, EventArgs e)
        {
            if (lstBoxDsLopB != null)
            {
                string selectedNameLopB = lstBoxDsLopB.SelectedItem.ToString();
                LstBoxDsLopA.Items.Add(selectedNameLopB);
                lstBoxDsLopB.Items.Remove(selectedNameLopB);
            }
            else
            {
                MessageBox.Show("Hãy chọn 1 tên trong Lớp B để chuyển sang lớp A!");
            }
        }

        private void btnDsAB_Click(object sender, EventArgs e)
        {
            if(LstBoxDsLopA!=null)
            {
                while(LstBoxDsLopA.Items.Count > 0)
                {
                    string selectedAll = LstBoxDsLopA.Items[0].ToString();
                    lstBoxDsLopB.Items.Add(selectedAll);
                    LstBoxDsLopA.Items.RemoveAt(0);

                }
            }
        }

        private void btnDsBA_Click(object sender, EventArgs e)
        {
            if(lstBoxDsLopB!=null)
            {
                while(lstBoxDsLopB.Items.Count >0){
                    string selectedAll2 = lstBoxDsLopB.Items[0].ToString();
                    LstBoxDsLopA.Items.Add(selectedAll2);
                    lstBoxDsLopB.Items.RemoveAt(0);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (LstBoxDsLopA != null)
            {
                string selectedNameClear=LstBoxDsLopA.SelectedItem.ToString();
                LstBoxDsLopA.Items.Remove(selectedNameClear);
            }
            else
            {
                MessageBox.Show("Bạn hãy chọn 1 tên trong danh sách lớp A để xóa!!");
            }
        }
    }
}
