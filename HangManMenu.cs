using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hangman
{
    public partial class HangManMenu : Form
    {
        public HangManMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Click += new EventHandler(eqtxt_Click);
            button2.Click += new EventHandler(eqtxt_Click);
            button3.Click += new EventHandler(eqtxt_Click);
            button4.Click += new EventHandler(eqtxt_Click);
        }
        private void exit(object sender, EventArgs e)
        {
            this.Close();
        }
        private void eqtxt_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Game f2;
            switch (b.Name)
            {
                case "button1":
                     Game form2 = new Game(button1.Text.ToLower(),0,"");
                form2.FormClosed += new FormClosedEventHandler(exit);
                form2.Show();
                this.Hide();
                    break;
                case "button2":
                  form2 = new Game(button2.Text.ToLower(),0,"");
                form2.FormClosed += new FormClosedEventHandler(exit);
                form2.Show();
                this.Hide();
                    break;
                case "button3":
                  form2 = new Game(button3.Text.ToLower(),0,"");
                form2.FormClosed += new FormClosedEventHandler(exit);
                form2.Show();
                this.Hide();
                    break;
                case "button4":
                    form2 = new Game(button4.Text.ToLower(),0,"");
                    form2.FormClosed += new FormClosedEventHandler(exit);
                    form2.Show();
                    this.Hide();
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
