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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //paroti otan pame apo thn prwth forma sthn deyterh exoume valei h prwth forma na kryvetai
            //omws twra me aythn thn entolh ama pame na klisoume thn deyterh forma tote emfanizetai h prwth
            //ayto ginetai dioti ama klisw thn deyterh forma kai den yparxei oyte h prwth to programma tha synexisie na trexei
            this.Owner.Show();

        }

        private void fringe_Click(object sender, EventArgs e)
        {
            //sthn synexeia afou to log in egine epityxws tha dhmiougrhsv mia kainouria forma
            Fridge fridge = new Fridge();
            //h deyterh forma emfanizetai,tis exv syndesh mesw tou this.h deyterh forma exei owner thn prwth
            fridge.Show(this);
            //twra h prwth form kryvetai
            this.Hide();
        }

        private void lights_Click(object sender, EventArgs e)
        {


            //sthn synexeia afou to log in egine epityxws tha dhmiougrhsv mia kainouria forma
            Fota fota = new Fota();
            //h deyterh forma emfanizetai,tis exv syndesh mesw tou this.h deyterh forma exei owner thn prwth
            fota.Show(this);
            //twra h prwth form kryvetai
            this.Hide();
        }

        private void ntoylapa_Click(object sender, EventArgs e)
        {
            //sthn synexeia afou to log in egine epityxws tha dhmiougrhsv mia kainouria forma
            Ntoulapa ntoulapa = new Ntoulapa();
            //h deyterh forma emfanizetai,tis exv syndesh mesw tou this.h deyterh forma exei owner thn prwth
            ntoulapa.Show(this);
            //twra h prwth form kryvetai
            this.Hide();
        }
    }
}
