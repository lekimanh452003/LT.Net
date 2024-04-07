using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab04
{
    public partial class Form1 : Form
    {
        private Color selectedColor = Color.White;
        public Form1()
        {
            InitializeComponent();
            
        }


        private void buttonDoiMau_Click(object sender, EventArgs e)
        {
            switch (comboBoxMau.SelectedItem.ToString())
            {
                case "Yellow":
                    selectedColor = Color.Yellow;
                    break;
                case "Red":
                    selectedColor = Color.Red;
                    break;
                case "Blue":
                    selectedColor = Color.Blue;
                    break;
                case "Green":
                    selectedColor = Color.Green;
                    break;
            }
            this.BackColor = selectedColor;

        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Kết thúc chương trình
            }
        }

       
    }
}
