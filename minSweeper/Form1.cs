using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace minSweeper
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        // you can do this  in configuration or whatever
        int width = 25, hight = 25, boomb = 50;
        private void Form1_Load(object sender, EventArgs e)
        {
        
            initialGame(width, hight, boomb);
        }

       

        void initialGame (int width , int hight, int boombCount )
        {
            
            // object random for get random number >>> for chose the places of the boombs randomly
            Random ra = new Random();
            // listB is the list of the boomb
            List<boomb> listB = new List<boomb>();
            pGame.Width = width * 30;
            pGame.Height = hight * 30;
            for (int i = 0; i < boombCount;i++)
            {

                // here i do width and hight + 1 to take all the width because the "random" object not including the end 
                // *** i do problem i hear height +1 it's a problem and i correct it here i forget that we start from 0 hhhh that mean 25
                // boomb b = new boomb(ra.Next(0, width + 1), ra.Next(0, hight + 1));
                boomb b = new boomb(ra.Next(0, width ), ra.Next(0, hight ));
                // this if statmet to check if the boomb is already add or not 
                // if the x and y == null means it's not add yet else it's already there
                if (listB.SingleOrDefault(a => a.x == b.x && a.y == b.y) == null)
                    listB.Add(b);
                else
                    i--;
                // i-- i do this to make the iteration repeated so i can add another boomb 
                // this is ensure me to get the boombCount in the listB
            }
            // loop inside loop to creat the buttons of the game 
            for(int i = 0; i < width ; i++)
            {
                for (int j = 0; j < hight; j++)
                {
                    Mbutton mb = new Mbutton { x = i, y = j, Width = 30, Height =30, Margin = new Padding(0), Font = new Font("Cairo", 12, FontStyle.Bold, GraphicsUnit.Point), BackColor = Color.Wheat, Location = new Point(i * 30, j * 30), FlatStyle = FlatStyle.Flat};
                    if(listB.SingleOrDefault(a => a.x == mb.x && a.y == mb.y) != null)
                    {
                        mb.isBoomb = true;
                        // uncomment the comment below to see the places of the boombs to test fast
                       // mb.BackColor = Color.Red;
                    }
                    pGame.Controls.Add(mb);
                    mb.MouseDown += Mb_MouseDown;
                }
                
            }
            boombNumberShow.Text = boomb.ToString();
        }
        int s = 0 , m = 0 , h = 0;

        private void hardClick(object sender, EventArgs e)
        {
            hard.BackColor = Color.Red;
            meduim.BackColor = Color.Blue;
            easy.BackColor = Color.Blue;
            boomb = 150;
        }

        private void mediumClick(object sender, EventArgs e)
        {
            hard.BackColor = Color.Blue;
            meduim.BackColor = Color.Red;
            easy.BackColor = Color.Blue;
            boomb = 100;
        }

        private void easyClick(object sender, EventArgs e)
        {
            hard.BackColor = Color.Blue;
            meduim.BackColor = Color.Blue;
            easy.BackColor = Color.Red;
            boomb = 50;
        }

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pGame.Controls.Clear();
            initialGame(width, hight, boomb);
            s = 0;
            m = 0;
            h = 0;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void PGame_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            pGame.Controls.Clear();
            initialGame(width, hight, boomb);
            s = 0;
            m = 0;
            h = 0;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            s++;
            if (s == 60)
            {
                s = 0;
                m++;
            }
            if(m==60)
            {
                m = 0;
                h++;
            }
            txtshowtime.Text =string.Format("{0}:{1}:{2}",h.ToString().PadLeft(2,'0'),m.ToString().PadLeft(2,'0'), s.ToString().PadLeft(2, '0'));
            
        }

        private void Mb_MouseDown(object sender, MouseEventArgs e)
        {
            Mbutton mb = sender as Mbutton; 
            if( mb != null)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (mb.isClicked || mb.isFlaged)
                        return;
                    if (mb.isBoomb)
                    {
                        mb.BackColor = Color.Red;
                        MessageBox.Show("لقد خسرت");
                        pGame.Controls.Clear();
                        initialGame(width , hight , boomb);
                        s = 0;
                        m = 0;
                        h = 0;
                    }
                    else
                    {
                        mb.isClicked = true;
                        mb.BackColor = Color.White;
                        // open all the button near the button if there is no boomb near the button
                        if (mb.NearlyCount == 0)
                        {
                            foreach (var item in mb.Nearly)
                            {
                                if (!item.isFlaged || !item.isClicked)
                                { 
                                    Mb_MouseDown(item, e); 
                                }
                            }
                        }
                        else
                        {
                            mb.ForeColor = mb.NearlyCount == 1 ? Color.Blue : mb.NearlyCount == 2 ? Color.Green : mb.NearlyCount == 3 ? Color.Red : Color.Purple;
                            mb.Text = mb.NearlyCount.ToString();
                        }
                    }
                } else
                {
                    if (mb.isClicked)
                        return;
                    if(mb.isFlaged)
                    {
                        mb.Image = null;
                        mb.isFlaged = false; 
                    }else
                    {
                        mb.Image = minSweeper.Properties.Resources.small_flag;
                        mb.isFlaged = true;
                    }
                }
            }
            checkWin();
        }

        void checkWin()
        {
            List<Mbutton> ls = new List<Mbutton>();
            foreach (var item in pGame.Controls)
            {
                ls.Add(item as Mbutton);
            }
            int c = ls.Where(a => a.isClicked == false).Count();
            if(c == boomb)
            {
                string time = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0')); 
               
                MessageBox.Show("لقد ربحت ", time);
                pGame.Controls.Clear();
                initialGame(width, hight, boomb);
                s = 0;
                m = 0;
                h = 0;
            }
        }
    }
    // Creat class that extend from button class and add new features for my new button kjj
    public class Mbutton : Button
    {
        // x , y to know the place of the button
        public int x { get; set; }
        public int y { get; set; }
        // isClick to konw if the button is clicked or no ; 
        public bool isClicked { get; set; }
        // isBoomb to see if the button has a bomb 
        public bool isBoomb { get; set; }
        // isflaged to see if you do a flage on the button 
        public bool isFlaged { get; set; }
        // NearlyCount to see the number of the bomb near the button 
        public int NearlyCount
        {
            get
            {
                // ls all the button in the parent 
                // parent.controls give us all the buttons because the parrent is the panal and the panal 
                // has just the button of the game 
                List<Mbutton> ls =  new List<Mbutton>();
                foreach (var item in Parent.Controls)
                {
                    ls.Add(item as Mbutton);
                }
                // c is the number of boomb around the button 
                //    [x-1; y+1][x; y+1][x+1; y+1]
                //    [x-1; y][x;y][x+1; y]
                //    [x-1; y-1][y-1][x+1; y-1]
                int c = ls.Where(a => (a.x == x || a.x == x + 1 || a.x == x - 1) && (a.y == y || a.y == y + 1 || a.y == y - 1)).Where(a => a.isBoomb).Count();

                return c;
            }
        }
        // we also need the buttons around the the button 
        // you ask why : and i tell you because i need to open near button if there is no boomb near 
        // check the code in the 126
        public List<Mbutton> Nearly
        {
            get
            {
                
                List<Mbutton> ls = new List<Mbutton>();
                foreach (var item in Parent.Controls)
                {
                    ls.Add(item as Mbutton);
                }
                
                
                var c = ls.Where(a => (a.x == x || a.x == x + 1 || a.x == x - 1) && (a.y == y || a.y == y + 1 || a.y == y - 1)).ToList();

                return c;
            }
        }

    }

    // this class for stor x , y the boombs
    public class boomb
    {
        public boomb (int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // x , y to know the place of the boomb
        public int x { get; set; }
        public int y { get; set; }
    }
}
