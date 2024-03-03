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
    public partial class F_Main : Form
    {
        public F_Main()
        {
            InitializeComponent();
        }

        private void BT_Buy_Click(object sender, EventArgs e)
        {
            double Subtotal = 0, Discount = 0, Total = 0;

            foreach (Control control in GB_Menu.Controls)
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
                double.Parse(LB_Rice.Tag.ToString()) * double.Parse(NM_Rice.Value.ToString()) +
                double.Parse(LB_Gravy.Tag.ToString()) * double.Parse(NM_Gravy.Value.ToString()) +
                double.Parse(LB_Ketchup.Tag.ToString()) * double.Parse(NM_Ketchup.Value.ToString());
            
            TB_Subtotal.Text = Subtotal.ToString();

            foreach (Control control in GB_Discount.Controls)
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


            TB_Discount.Text = Discount.ToString();
            TB_Total.Text = Total.ToString();
        }
    }
}
