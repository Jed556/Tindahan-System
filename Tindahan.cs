using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Activity2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void bt_Buy_Click(object sender, EventArgs e)
        {
            double Subtotal = 0, Discount = 0, Total = 0;

            foreach (Control control in gb_Menu.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox)
                {
                    if (checkBox.Checked)
                    {
                        Subtotal += double.Parse(checkBox.Tag.ToString());
                    }
                }
            }

            Subtotal +=
                double.Parse(lb_Rice.Tag.ToString()) * double.Parse(num_Rice.Value.ToString()) +
                double.Parse(lb_Gravy.Tag.ToString()) * double.Parse(num_Gravy.Value.ToString()) +
                double.Parse(lb_Ketchup.Tag.ToString()) * double.Parse(num_Ketchup.Value.ToString());
            
            tb_Subtotal.Text = Subtotal.ToString();

            foreach (Control control in gb_Discount.Controls)
            {
                if (control is System.Windows.Forms.RadioButton radioButton)
                {
                    if (radioButton.Checked)
                    {
                        Discount = Subtotal * (double.Parse(radioButton.Tag.ToString()) / 100);
                        Total = Subtotal - Discount;
                        break;
                    }
                }
            }


            tb_Discount.Text = Discount.ToString();
            tb_Total.Text = Total.ToString();
        }
    }
}
