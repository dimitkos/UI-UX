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
    public partial class Ntoulapa : Form
    {
        public Ntoulapa()
        {
            InitializeComponent();
        }

        private void Ntoulapa_FormClosing(object sender, FormClosingEventArgs e)
        {
            //paroti otan pame apo thn prwth forma sthn deyterh exoume valei h prwth forma na kryvetai
            //omws twra me aythn thn entolh ama pame na klisoume thn deyterh forma tote emfanizetai h prwth
            //ayto ginetai dioti ama klisw thn deyterh forma kai den yparxei oyte h prwth to programma tha synexisie na trexei
            this.Owner.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Προτεινώμενα ρούχα σύμφωνα με τον καιρό σήμερα :  " +
                "\n\n" +
                "Κοντομάνικη Μπλούζα με Τζίν παντελόνι χωρίς μπουφάν");
        }
    }
}
