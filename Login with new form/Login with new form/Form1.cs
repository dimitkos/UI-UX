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
    public partial class Form1 : Form
    {
        //ftiaxnw ena neo dictionary opoy ua exw mesa dyo string ena gia to user kai ena gia to pass
        //to vazw edv gia na to blepoyn ola ta kommatia tou kwdika

        Dictionary<String, String> accounts = new Dictionary<string, string>();

        System.Media.SoundPlayer success = new System.Media.SoundPlayer();
        System.Media.SoundPlayer fail = new System.Media.SoundPlayer();

        public Form1()
        {
            InitializeComponent();
            //kryvw to deftero panel
            Registerpanel.Hide();
            //pernei to panel to megethos toy parathyrou kai otan pame na to mikrinoume 
            //den mas afhnei na to mikrynoume pereterw apo to panel
            this.AutoSize = true;
            //kanei autosize me vash ti einai panw ths kai den mas afhnei na megalwsoume pereterv h na mikrynoyme
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            //φτιαχνς ena account me user:emi ke pass:123
            accounts.Add("jim", "123");
            //8a pros8eso ke ena deftero account
            accounts.Add("a", "123");

            success.SoundLocation = "success.wav";
            fail.SoundLocation = "fail.wav";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //vazoume mia metavliti password
            String password = "";
            //tha valoume enan elegxo opou tha vlepoume an yparxei to account sto dictionary pou ftiaksame
            //otan o xrhsths pataei to koumpi login
            //me apla logia o xrhsths dinei to username kai sthn synexeia to programma epistrefei to password 
            if (accounts.TryGetValue(userBox.Text,out password))
            {
                //elegxei an to pass pou edwse o xrhsths einai idio me to pass pou einia mesa sto dictionary
                if (password == textBox2.Text)
                {
                    //tha vgalei hxo epityxias
                    success.Play();
                    //tha vgalei mhnyma epityxias tou login
                    MessageBox.Show("Login successfull");

                    //sthn synexeia afou to log in egine epityxws tha dhmiougrhsv mia kainouria forma
                    MainForm myForm = new MainForm();
                    //h deyterh forma emfanizetai,tis exv syndesh mesw tou this.h deyterh forma exei owner thn prwth
                    myForm.Show(this);
                    //twra h prwth form kryvetai
                    this.Hide();

                }
                else
                {
                    fail.Play();
                    System.Threading.Thread.Sleep(500);
                    MessageBox.Show("Wrong password");
                }

            }
            else
            {
                fail.Play();
                System.Threading.Thread.Sleep(500);
                //Ean den iparxi to account sto dictionary mesa na kani print afto sto msqbox

                MessageBox.Show("Account does not exist"); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            //me to pou pathsoume register anoigei to neo panel gia na kanoume eggrafh
            Registerpanel.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            try
            {
                //elegxei an ayto to pass pou evale ox rhsths einai idio me to repeat pass
                if(passBox.Text == passboxrpt.Text)
                {
                    success.Play();
                    //an einai swsta ta pass pou evale tote prosthetei sto dictionary to user kai pass
                    accounts.Add(usertext.Text, passBox.Text);
                    MessageBox.Show("Account created succesfully");
                    //eksafanizei to panel pou kaname registry
                    Registerpanel.Hide();
                }
                else
                {
                    fail.Play();
                    System.Threading.Thread.Sleep(500);
                    //an valei diaforetika pass tou vgazei to parakatw mnm
                    MessageBox.Show("Password mismatch");
                }
            }
            //an kapoios dwsei idia stoixeia me ayta poy einai hdh sto leksiko mesa 
            //mhn crasharei alla na vgalei ena mnm
            catch (Exception ex)
            {

                fail.Play();
                System.Threading.Thread.Sleep(500);
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Account " + usertext.Text + " " + "already exists!");
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Login in SmartHouse", button1);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolTip2.Show("Register an account for the SmartHouse", button2);
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            toolTip3.Show("Create an account for SmartHouse", button4);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //otan pame na klisoume thn efarmogh patwntas x,tha vgei ena mnm pou tha mas rwtaei ti theloume na kanoume
            //an pathsoume nai tote tha klisei alliws oxi tha meinei opws einai
            DialogResult dialogResult = MessageBox.Show("Are you sure want to exit?", "Question", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else if (dialogResult == DialogResult.No)
            {

                e.Cancel = true ;
            }
        }
    }
}
