using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_with_new_form
{
    public partial class Fota : Form
    {
        public Fota()
        {
            InitializeComponent();
        }

        private void Fota_Load(object sender, EventArgs e)
        {

        }

        private void Fota_FormClosing(object sender, FormClosingEventArgs e)
        {
            //paroti otan pame apo thn prwth forma sthn deyterh exoume valei h prwth forma na kryvetai
            //omws twra me aythn thn entolh ama pame na klisoume thn deyterh forma tote emfanizetai h prwth
            //ayto ginetai dioti ama klisw thn deyterh forma kai den yparxei oyte h prwth to programma tha synexisie na trexei
            this.Owner.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Check the box for the night function", checkBox1);
        }

        private void numericUpDown1_MouseUp(object sender, MouseEventArgs e)
        {
            toolTip2.Show("Increase or decrease the intensity of light ", numericUpDown1);
        }

        private void numericUpDown2_MouseUp(object sender, MouseEventArgs e)
        {
            toolTip3.Show("Increase or decrease the intensity of light ", numericUpDown2);
        }

        private void numericUpDown3_MouseUp(object sender, MouseEventArgs e)
        {
            toolTip4.Show("Increase or decrease the intensity of light ", numericUpDown3);
        }

        private void numericUpDown4_MouseUp(object sender, MouseEventArgs e)
        {
            toolTip5.Show("Increase or decrease the intensity of light ", numericUpDown4);
        }

        private void numericUpDown5_MouseUp(object sender, MouseEventArgs e)
        {
            toolTip6.Show("Increase or decrease the intensity of light ", numericUpDown5);
        }
    }
}
