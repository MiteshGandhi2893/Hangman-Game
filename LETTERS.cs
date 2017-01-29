using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
namespace hangman
{
    public class LETTERS
    {
        
        int count = 0;
        public bool search(string names, TextBox[] animals_t,string selected,Graphics g)//,Rectangle[] abcd)
        {
            bool flag = false, f = true;
            try
            {
                
                int[] arrchar = new int[selected.Length];
                //MessageBox.Show(selected + names);
                switch (names)
                {
                    case "A":
                        int k = 0;

                        arrchar = positions('A', selected, out k, out flag);
                        if (flag == true)
                        {
                            for (int i = 0; i < k; i++)
                            {
                               // //MessageBox.Show(i + "");
                                animals_t[arrchar[i]].Text = "" + 'A';
                            }
                        }
                        else
                        {
                            count++;
                            if (count == 6)
                            {
                                drawman(count, g);
                                f = false;
                            }
                            else
                                drawman(count, g);
                        }
                        break;

                    case "B":

                        k = 0;

                        arrchar = positions('B', selected, out k, out flag);

                        if (flag == true)
                        {
                            for (int i = 0; i < k; i++)
                            {
                                //MessageBox.Show(i + "");
                                animals_t[arrchar[i]].Text = "" + 'B';
                            }
                        }
                        else
                        {
                            count++;
                            if (count == 6)
                                f = false;
                            else
                                drawman(count, g);
                        }
                        break;

                    case "C":

                        k = 0;

                        arrchar = positions('C', selected, out k, out flag);
                        if (flag == true)
                        {
                            for (int i = 0; i < k; i++)
                            {
                                //MessageBox.Show(i + "");
                                animals_t[arrchar[i]].Text = "" + 'C';
                            }
                        }
                        else
                        {
                            count++;
                            if (count == 6)
                            {
                                drawman(count, g);
                                f = false;
                            }
                            else
                                drawman(count, g);
                        }
                        break;
                    case "D":

                        k = 0;

                        arrchar = positions('D', selected, out k, out flag);

                        if (flag == true)
                        {
                            for (int i = 0; i < k; i++)
                            {
                                //MessageBox.Show(i + "");
                                animals_t[arrchar[i]].Text = "" + 'D';
                            }
                        }
                        else
                        {
                            count++;
                            if (count == 6)
                            {
                                drawman(count, g);
                                f = false;
                            }
                            else
                                drawman(count, g);
                        }
                        break;
                    case "E":

                        k = 0;

                        arrchar = positions('E', selected, out k, out flag);

                        if (flag == true)
                        {
                            for (int i = 0; i < k; i++)
                            {
                                //MessageBox.Show(i + "");
                                animals_t[arrchar[i]].Text = "" + 'E';
                            }
                        }
                        else
                        {
                            count++;
                            if (count == 6)
                            {
                                drawman(count, g);
                                f = false;
                            }
                            else
                                drawman(count, g);
                        }
                        break;
                    case "F":

                        k = 0;

                        arrchar = positions('F', selected, out k, out flag);

                        if (flag == true)
                        {
                            for (int i = 0; i < k; i++)
                            {
                                //MessageBox.Show(i + "");
                                animals_t[arrchar[i]].Text = "" + 'F';
                            }
                        }
                        else
                        {
                            count++;
                            if (count == 6)
                            {
                                drawman(count, g);
                                f = false;
                            }
                            else
                                drawman(count, g);
                        }
                        break;
                    case "G":

                        k = 0;

                        arrchar = positions('G', selected, out k, out flag);

                        if (flag == true)
                        {
                            for (int i = 0; i < k; i++)
                            {
                                //MessageBox.Show(i + "");
                                animals_t[arrchar[i]].Text = "" + 'G';
                            }
                        }
                        else
                        {
                            count++;
                            if (count == 6)
                            {
                                drawman(count, g);
                                f = false;
                            }
                            else
                                drawman(count, g);
                        }
                        break;
                    case "H":

                        k = 0;

                        arrchar = positions('H', selected, out k, out flag);

                        if (flag == true)
                        {
                            for (int i = 0; i < k; i++)
                            {
                                //MessageBox.Show(i + "");
                                animals_t[arrchar[i]].Text = "" + 'H';
                            }
                        }
                        else
                        {
                            count++;
                            if (count == 6)
                            {
                                drawman(count, g);
                                f = false;
                            }
                            else
                                drawman(count, g);
                        }
                        break;
                    case "I":

                        k = 0;

                        arrchar = positions('I', selected, out k, out flag);

                        if (flag == true)
                        {
                            for (int i = 0; i < k; i++)
                            {
                                //MessageBox.Show(i + "");
                                animals_t[arrchar[i]].Text = "" + 'I';
                            }
                        }
                        else
                        {
                            count++;
                            if (count == 6)
                            {
                                drawman(count, g);
                                f = false;
                            }
                            else
                                drawman(count, g);
                        }
                        break;
                    case "J":

                        k = 0;

                        arrchar = positions('J', selected, out k, out flag);
                        if (flag == true)
                        {
                            for (int i = 0; i < k; i++)
                            {
                                //MessageBox.Show(i + "");
                                animals_t[arrchar[i]].Text = "" + 'J';
                            }
                        }
                        else
                        {
                            count++;
                            if (count == 6)
                            {
                                drawman(count, g);
                                f = false;
                            }
                            else
                                drawman(count, g);
                        }
                        break;
                    case "K":

                        k = 0;

                        arrchar = positions('K', selected, out k, out flag);

                        if (flag == true)
                        {
                            for (int i = 0; i < k; i++)
                            {
                                //MessageBox.Show(i + "");
                                animals_t[arrchar[i]].Text = "" + 'K';
                            }
                        }
                        else
                        {
                            count++;
                            if (count == 6)
                                f = false;
                            else
                                drawman(count, g);
                        }
                        break;
                    case "L":

                        k = 0;

                        arrchar = positions('L', selected, out k, out flag);
                        if (flag == true)
                        {
                            for (int i = 0; i < k; i++)
                            {
                                //MessageBox.Show(i + "");
                                animals_t[arrchar[i]].Text = "" + 'L';
                            }
                        }
                        else
                        {
                            count++;
                            if (count == 6)
                            {
                                drawman(count, g);
                                f = false;
                            }
                            else
                                drawman(count, g);
                        }
                        break;
                    case "M":

                        k = 0;

                        arrchar = positions('M', selected, out k, out flag);

                        if (flag == true)
                        {
                            for (int i = 0; i < k; i++)
                            {
                                //MessageBox.Show(i + "");
                                animals_t[arrchar[i]].Text = "" + 'M';
                            }
                        }
                        else
                        {
                            count++;
                            if (count == 6)
                            {
                                drawman(count, g);
                                f = false;
                            }
                            else
                                drawman(count, g);
                        }
                        break;
                    case "N":

                        k = 0;

                        arrchar = positions('N', selected, out k, out flag);

                        if (flag == true)
                        {
                            for (int i = 0; i < k; i++)
                            {
                                //MessageBox.Show(i + "");
                                animals_t[arrchar[i]].Text = "" + 'N';
                            }
                        }
                        else
                        {
                            count++;
                            if (count == 6)
                            {
                                drawman(count, g);
                                f = false;
                            }
                            else
                                drawman(count, g);
                        }
                        break;
                    case "O":

                        k = 0;

                        arrchar = positions('O', selected, out k, out flag);

                        if (flag == true)
                        {
                            for (int i = 0; i < k; i++)
                            {
                                //MessageBox.Show(i + "");
                                animals_t[arrchar[i]].Text = "" + 'O';
                            }
                        }
                        else
                        {
                            count++;
                            if (count == 6)
                            {
                                drawman(count, g);
                                f = false;
                            }
                            else
                                drawman(count, g);
                        }
                        break;
                    case "P":

                        k = 0;

                        arrchar = positions('P', selected, out k, out flag);

                        if (flag == true)
                        {
                            for (int i = 0; i < k; i++)
                            {
                                //MessageBox.Show(i + "");
                                animals_t[arrchar[i]].Text = "" + 'P';
                            }
                        }
                        else
                        {
                            count++;
                            if (count == 6)
                            {
                                drawman(count, g);
                                f = false;
                            }
                            else
                                drawman(count, g);
                        }
                        break;
                    case "Q":

                        k = 0;

                        arrchar = positions('Q', selected, out k, out flag);

                        if (flag == true)
                        {
                            for (int i = 0; i < k; i++)
                            {
                                //MessageBox.Show(i + "");
                                animals_t[arrchar[i]].Text = "" + 'Q';
                            }
                        }
                        else
                        {
                            count++;
                            if (count == 6)
                            {
                                drawman(count, g);
                                f = false;
                            }
                            else
                                drawman(count, g);
                        }
                        break;
                    case "R":

                        k = 0;

                        arrchar = positions('R', selected, out k, out flag);


                        if (flag == true)
                        {
                            for (int i = 0; i < k; i++)
                            {
                                //MessageBox.Show(i + "");
                                animals_t[arrchar[i]].Text = "" + 'R';
                            }
                        }
                        else
                        {
                            count++;
                            if (count == 6)
                            {
                                drawman(count, g);
                                f = false;
                            }
                            else
                                drawman(count, g);
                        }
                        break;
                    case "S":

                        k = 0;

                        arrchar = positions('S', selected, out k, out flag);


                        if (flag == true)
                        {
                            for (int i = 0; i < k; i++)
                            {
                                //MessageBox.Show(i + "");
                                animals_t[arrchar[i]].Text = "" + 'S';
                            }
                        }
                        else
                        {
                            count++;
                            if (count == 6)
                            {
                                drawman(count, g);
                                f = false;
                            }
                            else
                                drawman(count, g);
                        }
                        break;
                    case "T":

                        k = 0;

                        arrchar = positions('T', selected, out k, out flag);


                        if (flag == true)
                        {
                            for (int i = 0; i < k; i++)
                            {
                                //MessageBox.Show(i + "");
                                animals_t[arrchar[i]].Text = "" + 'T';
                            }
                        }
                        else
                        {
                            count++;
                            if (count == 6)
                            {
                                drawman(count, g);
                                f = false;
                            }
                            else
                                drawman(count, g);
                        }
                        break;
                    case "U":

                        k = 0;

                        arrchar = positions('U', selected, out k, out flag);


                        if (flag == true)
                        {
                            for (int i = 0; i < k; i++)
                            {
                                //MessageBox.Show(i + "");
                                animals_t[arrchar[i]].Text = "" + 'U';
                            }
                        }
                        else
                        {
                            count++;
                            if (count == 6)
                            {
                                drawman(count, g);
                                f = false;
                            }
                            else
                                drawman(count, g);
                        }
                        break;
                    case "V":

                        k = 0;

                        arrchar = positions('V', selected, out k, out flag);


                        if (flag == true)
                        {
                            for (int i = 0; i < k; i++)
                            {
                                //MessageBox.Show(i + "");
                                animals_t[arrchar[i]].Text = "" + 'V';
                            }
                        }
                        else
                        {
                            count++;
                            if (count == 6)
                            {
                                drawman(count, g);
                                f = false;
                            }
                            else
                                drawman(count, g);
                        }
                        break;
                    case "W":

                        k = 0;

                        arrchar = positions('W', selected, out k, out flag);

                        if (flag == true)
                        {
                            for (int i = 0; i < k; i++)
                            {
                                //MessageBox.Show(i + "");
                                animals_t[arrchar[i]].Text = "" + 'W';
                            }
                        }
                        else
                        {
                            count++;
                            if (count == 6)
                            {
                                drawman(count, g);
                                f = false;
                            }
                            else
                                drawman(count, g);
                        }
                        break;
                    case "X":

                        k = 0;

                        arrchar = positions('X', selected, out k, out flag);

                        if (flag == true)
                        {
                            for (int i = 0; i < k; i++)
                            {
                                //MessageBox.Show(i + "");
                                animals_t[arrchar[i]].Text = "" + 'X';
                            }
                        }
                        else
                        {
                            count++;
                            if (count == 6)
                            {
                                drawman(count, g);
                                f = false;
                            }
                            else
                                drawman(count, g);
                        }
                        break;
                    case "Y":

                        k = 0;

                        arrchar = positions('Y', selected, out k, out flag);

                        if (flag == true)
                        {
                            for (int i = 0; i < k; i++)
                            {
                                //MessageBox.Show(i + "");
                                animals_t[arrchar[i]].Text = "" + 'Y';
                            }
                        }
                        else
                        {
                            count++;
                            if (count == 6)
                            {
                                drawman(count, g);
                                f = false;
                            }
                            else
                                drawman(count, g);
                        }
                        break;
                    case "Z":

                        k = 0;

                        arrchar = positions('Z', selected, out k, out flag);

                        if (flag == true)
                        {
                            for (int i = 0; i < k; i++)
                            {
                                //MessageBox.Show(i + "");
                                animals_t[arrchar[i]].Text = "" + 'Z';
                            }
                        }
                        else
                        {
                            count++;
                            if (count == 6)
                            {
                                drawman(count, g);
                                f = false;
                            }
                            else
                                drawman(count, g);
                        }
                        break;
                }
               
            }
            catch (Exception ex)
            {
            }
            return f;
        }
        public int[] positions(char input, string selected, out int k,out bool flag)
        {
            flag = false;
            int j = 0;
            k = 0;
            int[] arrchar = new int[selected.Length];
            char[] arr = selected.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] == input)
                {
                    // ss.Speak("" + input + "   is   " + i + "     " + arr[i]);
                    arrchar[j] = i;
                    j++;
                    flag = true;
                }
               



            }
            k = j;

            return arrchar;

        }
        public void drawman(int count,Graphics g)
        {
            switch(count)
            {
                case 1:
                    //int i=0;
                    Pen  redPen = new Pen(Color.Black, 1);
                    g.DrawLine(redPen, new Point(300, 200), new Point(500, 200));
                    g.DrawLine(redPen, new Point(300, 201), new Point(500, 201));
                    g.DrawLine(redPen, new Point(300, 202), new Point(500, 202));
                    g.DrawLine(redPen, new Point(300, 203), new Point(500, 203));
                        g.DrawLine(redPen, new Point(400, 200), new Point(400, 10));
                        g.DrawLine(redPen, new Point(401, 200), new Point(401, 10));
                        g.DrawLine(redPen, new Point(403, 200), new Point(403, 10));
                        g.DrawLine(redPen, new Point(402, 200), new Point(402, 10));
                    
                    break;
                case 2:
                    //int i=0;
                    redPen = new Pen(Color.Black, 1);

                    g.DrawLine(redPen, new Point(400,10), new Point(600, 10));
                    g.DrawLine(redPen, new Point(400, 9), new Point(600, 9));
                    g.DrawLine(redPen, new Point(400, 8), new Point(600, 8));
                    g.DrawLine(redPen, new Point(400, 7), new Point(600, 7));


                    break;
                case 3:
                    //int i=0;
                    redPen = new Pen(Color.Black, 1);

                    g.DrawLine(redPen, new Point(600, 10), new Point(600, 50));
                    g.DrawLine(redPen, new Point(601, 10), new Point(601, 50));
                    g.DrawLine(redPen, new Point(602, 10), new Point(602, 50));
                    g.DrawLine(redPen, new Point(603, 10), new Point(603,50));

                    g.DrawEllipse(redPen, 555, 50, 80, 100);
                    g.DrawEllipse(redPen, 554, 50, 81, 100);
                    g.DrawEllipse(redPen, 553, 50, 82, 100);
                    break;
                case 4:
                    Point []p=new Point[4]{new Point(585,115),new Point(590,125),new Point(595,125),new Point(600,115)};
                    Brush b=new SolidBrush(Color.Gray);
                    Brush b2 = new SolidBrush(Color.Black);
                    redPen = new Pen(Color.Black, 1);
                    Brush b1 = new SolidBrush(Color.White);
                     Brush b3 = new SolidBrush(Color.Red);
                    
                    g.DrawEllipse(redPen, 560, 65, 70, 70);
                    g.FillEllipse(b, 560, 65, 70, 70);
                    g.FillEllipse(b1, 580, 80, 10, 20);
                    g.FillEllipse(b2, 585, 85, 5, 8);
                      g.FillEllipse(b1, 600, 80, 10, 20);
                    g.FillEllipse(b2, 600, 85, 5, 8);
                    ///g.FillEllipse(b2, 585, 105, 5, 5);
                    g.FillClosedCurve(b3, p);
                    g.DrawLine(redPen, new Point(595, 130), new Point(595, 250));
                    g.DrawLine(redPen, new Point(596, 130), new Point(596, 250));
                    g.DrawLine(redPen, new Point(594, 130), new Point(594, 250));
                    break;
                case 5:
                   b = new SolidBrush(Color.Black);
                    redPen = new Pen(Color.Black, 1);
                   

                   // g.FillEllipse(b, 560, 65, 70, 70);
                    g.DrawLine(redPen, new Point(595, 150), new Point(520, 180));
                    g.DrawLine(redPen, new Point(596, 151), new Point(521, 180));
                    g.DrawLine(redPen, new Point(594, 149), new Point(522, 180));
                    g.DrawLine(redPen, new Point(595, 150), new Point(680, 180));
                    g.DrawLine(redPen, new Point(596, 151), new Point(681, 180));
                    g.DrawLine(redPen, new Point(594, 149), new Point(682, 180));


                    break;
                case 6:
                    redPen = new Pen(Color.Black, 1);
                      g.DrawLine(redPen, new Point(595, 190), new Point(520, 250));
                    g.DrawLine(redPen, new Point(596, 191), new Point(521, 250));
                    g.DrawLine(redPen, new Point(594, 189), new Point(522, 250));
                    g.DrawLine(redPen, new Point(595, 190), new Point(680, 250));
                    g.DrawLine(redPen, new Point(596, 191), new Point(681, 250));
                    g.DrawLine(redPen, new Point(594, 189), new Point(682, 250));

                    break;

           
            }
           
        }
    }
}
