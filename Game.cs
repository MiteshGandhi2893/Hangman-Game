using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
namespace hangman
{
    public partial class Game : Form
    {
        List<string> animals = new List<string>() { "LEOPARD", "LANGUR", "DEER", "CAMEL", "BLACK BUCK", "RHINOCEROS", "SNOW LEOPARD", "STRIPED HYENA", "WILD BOAR", "LION", "HIPOPOTOUS", "ELEPHANT", "GIRAFF", "ZEBRA", "COBRA", "TIGER" };
        List<string> bollywood = new List<string>() { "HUM TUM", "OH MY GOD", "EK THA TIGER", "VIVAH", "TARZEN THE WONDER CAR", "DASHAVATAR", "MAHABHARAT", "RAMAYAN" };
        List<string> fruits = new List<string>() { "ORANGE", "GRAPES", "APPLE", "PINEAPPLE", "WATERMELON", "PEACH" };
     
        int score=0;
        LETTERS lr = new LETTERS();
        string choices = "";
        string selected = "";
        TextBox[] fruits_t;
        TextBox[] animals_t;
        TextBox[] bollywood_t;
        TextBox[] random;
        public Game(string choices,int score,string selected)
        {
            InitializeComponent();
            this.choices = choices;
            this.score = score;
            this.selected = selected;
            if (label1.Text == "animals")
            {
                animals.Remove(selected);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
           

            int[] arrchar = new int[this.selected.Length];
            Button b = (Button)sender;
            Graphics g = this.CreateGraphics();
            if (label1.Text == "animals")
            {
                bool flag=lr.search(b.Name, animals_t, this.selected,g);
                if (flag == false)
                {
                    string ss = "";
                    char[] a = this.selected.ToCharArray();
                    for (int i = 0; i < animals_t.Length; i++)
                    {
                        ss = ss + a[i].ToString();
                    }
                    MessageBox.Show("game is over sorry next time your answer is   " + ss);
                    panel1.Enabled = false;
                }
                
                else
                {
                    char[]a=this.selected.ToCharArray();
                    for (int i = 0; i < animals_t.Length; i++)
                    {
                        flag = false;
                        if (animals_t[i].Text == a[i].ToString() || (animals_t[i].Text == "" && a[i].ToString() == " "))
                        {
                            flag = true;

                        }
                        else
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag == true)
                   {

                       MessageBox.Show("you won!!!!!!!!!!!");
                       this.score = score + 100;
                       Game form2;
                       form2 = new Game(label1.Text,score,selected);
                       form2.FormClosed += new FormClosedEventHandler(exit);
                       form2.Show();
                       this.Hide();
                       label3.Text = "" + score;
                       panel1.Visible = false;
                    }

                        panel1.Enabled = true;
                }
            }
            if (label1.Text == "bollywood")
            {
                bool flag = lr.search(b.Name, bollywood_t, this.selected, g);
                if (flag == false)
                {
                    string ss = "";
                    char[] a = this.selected.ToCharArray();
                    for (int i = 0; i < bollywood_t.Length; i++)
                    {
                        ss = ss + a[i].ToString();
                    }
                    MessageBox.Show("game is over sorry next time your answer is   " + ss);
                    panel1.Enabled = false;
                }

                else
                {

                    char[] a = this.selected.ToCharArray();
                    for (int i = 0; i < bollywood_t.Length; i++)
                    {
                        flag = false;
                        if ((bollywood_t[i].Text == a[i].ToString())||(bollywood_t[i].Text==""&&a[i].ToString()==" "))
                        {
                            flag = true;

                        }
                        else
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag == true)
                    {
                        MessageBox.Show("you won!!!!!!!!!!!");
                        this.score = score + 100;
                        panel1.Visible = false;
                        Game form2;
                        form2 = new Game(label1.Text,score,selected);
                        form2.FormClosed += new FormClosedEventHandler(exit);
                        form2.Show();
                        this.Hide();
                        label3.Text = "" + score;
                    }

                    panel1.Enabled = true;
                }
            }
            if (label1.Text == "fruits")
            {
                bool flag = lr.search(b.Name, fruits_t, this.selected, g);
                if (flag == false)
                {
                   
                    string ss = "";
                    char[] a = this.selected.ToCharArray();
                    for (int i = 0; i < fruits_t.Length; i++)
                    {
                        ss = ss + a[i].ToString();
                    }
                    MessageBox.Show("game is over sorry next time your answer is   "+ss);
                    panel1.Enabled = false;
                }

                else
                {
                    char []a = this.selected.ToCharArray();
                    for (int i = 0; i < fruits_t.Length; i++)
                    {
                        flag = false;
                        if (fruits_t[i].Text == a[i].ToString())
                        {
                            flag = true;

                        }
                        else
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag == true)
                    {
                        this.score = score + 100;
                        MessageBox.Show("you won!!!!!!!!!!!");
                        panel1.Visible = false;
                        Game form2;
                        form2 = new Game(label1.Text,score,selected);
                        form2.FormClosed += new FormClosedEventHandler(exit);
                        form2.Show();
                        this.Hide();
                        label3.Text = "" + score;
                    }

                    panel1.Enabled = true;
                }
            }
            b.Enabled = false;
            b.BackColor = Color.Orange;
            b.ForeColor = Color.White;
           
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            int index = 0,len=0;
            label3.Text = "" + this.score;
            Random r = new Random();

            int i = 0;
           
            switch (choices.ToLower())
            {
                case "animals":
                    index = r.Next(0, animals.Count);
                    this.selected = animals[index];
                 //   MessageBox.Show("" + selected);
                    len = selected.ToString().Length;
                    if (len < 15)
                    {
                        this.animals_t = textboxdaalo(len, 380, 315);
                    }
                    else
                    {
                        this.animals_t = textboxdaalo(len, 40, 315);
                    }
                    label1.Text = "animals";
                    char[] a=selected.ToCharArray();
                    for (i = 0; i < this.animals_t.Length; i++)
                    {
                        //label1.Text = label1.Text + i;
                        this.animals_t[i].Enabled = false;
                        if (a[i].ToString() == " ")
                        {
                            MessageBox.Show(i + "");
                            this.animals_t[i].Visible = false;
                        }
                        this.Controls.Add(this.animals_t[i]);
                    }
                    break;
                case "bollywood":
                    index = r.Next(0, bollywood.Count);
                    this.selected = bollywood[index];
                    len = selected.ToString().Length;
                    char[] a1 = selected.ToCharArray();
                    if (len < 15)
                        this.bollywood_t = textboxdaalo(len, 380, 315);
                    else
                        this.bollywood_t = textboxdaalo(len, 40, 315);
                    for (i = 0; i < this.bollywood_t.Length; i++)
                    {
                       // MessageBox.Show(i + "");
                        this.bollywood_t[i].Enabled = false;
                        
                        if ( a1[i].ToString() == " ")
                        {
                           // MessageBox.Show(i+"");
                            this.bollywood_t[i].Visible = false;
                        }
                        this.Controls.Add(this.bollywood_t[i]);

                    }
                    label1.Text = "bollywood";
                    break;
                case "fruits":
                    index = r.Next(0, fruits.Count);
                    this.selected = fruits[index];
                    len = selected.ToString().Length;
                    if (len < 15)
                        this.fruits_t = textboxdaalo(len, 380, 315);
                    else
                        this.fruits_t = textboxdaalo(len, 40, 315);
                    for (i = 0; i < this.fruits_t.Length; i++)
                    {
                        this.fruits_t[i].Enabled = false;
                        this.Controls.Add(this.fruits_t[i]);
                    }
                    label1.Text = "fruits";
                    break;
            }
            //foreach(string s in animals)
            //{
            //    MessageBox.Show(s); 
            //}
            //MessageBox.Show(selected);
            //if (label1.Text == "animals" && Convert.ToInt16(label3.Text) != 0)
            //{
            //    MessageBox.Show("true");
            //    animals.Remove(selected);
            //}
      

 A.Click += new EventHandler(btn_Click);
            B.Click += new EventHandler(btn_Click);
            C.Click += new EventHandler(btn_Click);
            D.Click += new EventHandler(btn_Click);
            E.Click += new EventHandler(btn_Click);
            F.Click += new EventHandler(btn_Click);
            G.Click += new EventHandler(btn_Click);
            H.Click += new EventHandler(btn_Click);
            I.Click += new EventHandler(btn_Click);
            J.Click += new EventHandler(btn_Click);
            K.Click += new EventHandler(btn_Click);
            L.Click += new EventHandler(btn_Click);
            M.Click += new EventHandler(btn_Click);
            N.Click += new EventHandler(btn_Click);
            O.Click += new EventHandler(btn_Click);
            P.Click += new EventHandler(btn_Click);
            Q.Click += new EventHandler(btn_Click);
            R.Click += new EventHandler(btn_Click);
            S.Click += new EventHandler(btn_Click);
            T.Click += new EventHandler(btn_Click);
            U.Click += new EventHandler(btn_Click);
            V.Click += new EventHandler(btn_Click);
            W.Click += new EventHandler(btn_Click);
            X.Click += new EventHandler(btn_Click);
            Y.Click += new EventHandler(btn_Click);
            Z.Click += new EventHandler(btn_Click);


        }
        public TextBox[] textboxdaalo(int m, int x, int y)
        {
            TextBox[] a = new TextBox[m];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = new TextBox();
                a[i].BackColor = Color.White;
                a[i].Width = 20;
                a[i].Height = 100;
                a[i].Location = new Point(x, y);
                x = x + 35;
            }
            HangManMenu f = new HangManMenu();
            return a;
        }
       
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           MessageBox.Show("please see it","confrm",MessageBoxButtons.YesNoCancel);
          
            Game form2;
            form2 = new Game(label1.Text,0,"");
            form2.FormClosed += new FormClosedEventHandler(exit);
            form2.Show();
            this.Hide();
            label3.Text = "" + 0;
        }
        private void exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            HangManMenu form2;
            form2 = new HangManMenu();
            form2.FormClosed += new FormClosedEventHandler(exit);
            form2.Show();
            this.Hide();
        }

     
       
    }
}
