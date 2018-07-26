﻿using System;
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
    public partial class Fridge : Form
    {
        public Fridge()
        {
            InitializeComponent();
            //arxika oles oi eikones kai to hmerologio tha einai hide
            monthCalendar1.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
        }

        private void Fridge_FormClosing(object sender, FormClosingEventArgs e)
        {
            //paroti otan pame apo thn prwth forma sthn deyterh exoume valei h prwth forma na kryvetai
            //omws twra me aythn thn entolh ama pame na klisoume thn deyterh forma tote emfanizetai h prwth
            //ayto ginetai dioti ama klisw thn deyterh forma kai den yparxei oyte h prwth to programma tha synexisie na trexei
            this.Owner.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ta kanoyme ola hide giati se periptwsh opoy vgei mia eikona kai meta valoume ton kairo h eikona tha exie kryftei
            monthCalendar1.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            //emfanish tou katallhloy mynhmatos
            MessageBox.Show("Η υγρασία αυτή την στιγμή εντός ψυγείου είναι: 50%");
        }

        private void thermokrasia_Click(object sender, EventArgs e)
        {
            //ta kanoyme ola hide giati se periptwsh opoy vgei mia eikona kai meta valoume ton kairo h eikona tha exie kryftei
            monthCalendar1.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            //emfanish tou katallhloy mynhmatos
            MessageBox.Show("Η θερμοκρασία στον καταψύκτη είναι: -5 C και η θερμοκρασία του ψυγείου ειναι 12 C");
        }

        private void kairos_Click(object sender, EventArgs e)
        {
            //ta kanoyme ola hide giati se periptwsh opoy vgei mia eikona kai meta valoume ton kairo h eikona tha exie kryftei
            monthCalendar1.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            //emfanish tou katallhloy mynhmatos
            MessageBox.Show("Η θερμοκρασία στην Αθήνα θα κυμανθεί απο 27 C-38 C .Οι άνεμοι θα πνέουν 3-4 μποφόρ  και ο ουρανός θα είναι αίθριος ");
        }

        private void radiofwno_Click(object sender, EventArgs e)
        {
            //ta kanoume ola hide wste h forma na einai katharh me to pathma twn koympiwn
            monthCalendar1.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox4.Hide();
            //emfanish ths katallhlhs leitoyrgias
            pictureBox3.Show();
        }

        private void onlineoffers_Click(object sender, EventArgs e)
        {
            //ta kanoyme ola hide giati se periptwsh opoy vgei mia eikona kai meta valoume ton kairo h eikona tha exie kryftei
            monthCalendar1.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            //emfanish tou katallhloy mynhmatos
            MessageBox.Show("Προσφορές για τα αγαπημένα σας προίοντα \n www.sklavenitis.gr\\eshop");
        }

        private void agoraproiontwn_Click(object sender, EventArgs e)
        {
            //ta kanoyme ola hide giati se periptwsh opoy vgei mia eikona kai meta valoume ton kairo h eikona tha exie kryftei
            monthCalendar1.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            //emfanish tou katallhloy mynhmatos
            MessageBox.Show("Απόθεμα προιοντων που τελείωνουν: \n Γάλα: 14% \n Χυμός Πορτοκάλι: 25% \n Μπανάνες: 2 κομμάτια  \n Φέτα:μισό κιλό ");
        }

        private void hmerologio_Click(object sender, EventArgs e)
        {
            //ta kanoume ola hide wste h forma na einai katharh me to pathma twn koympiwn
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            //emfanish ths katallhlhs leitoyrgias
            monthCalendar1.Show();
        }

        private void camera_Click(object sender, EventArgs e)
        {
            //ta kanoume ola hide wste h forma na einai katharh me to pathma twn koympiwn
            monthCalendar1.Hide();
            pictureBox4.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            //emfanish ths katallhlhs leitoyrgias
            pictureBox1.Show();
        }

        private void web_Click(object sender, EventArgs e)
        {
            //ta kanoume ola hide wste h forma na einai katharh me to pathma twn koympiwn
            monthCalendar1.Hide();
            pictureBox1.Hide();
            pictureBox4.Hide();
            pictureBox3.Hide();
            //emfanish ths katallhlhs leitoyrgias
            pictureBox2.Show();
        }

        private void syntages_Click(object sender, EventArgs e)
        {
            //ta kanoume ola hide wste h forma na einai katharh me to pathma twn koympiwn
            monthCalendar1.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            //emfanish ths katallhlhs leitoyrgias
            pictureBox4.Show();
        }
    }
}