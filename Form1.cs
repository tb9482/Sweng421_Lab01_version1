using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sweng421_Lab01_version1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Width = 900;
            this.Height = 700;
            bm = new Bitmap(pic_panel.Width, pic_panel.Height);  //sets the paint area white
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic_panel.Image = bm;
            
        }

        //Global variables used to allow communication with the program.

        Bitmap bm;                      //sets the canvas 
        Point px, py;
        bool draw = false;
        Graphics g;
        Pen p = new Pen(Color.Black, 2);        //default drawing pen global version
        Pen erase = new Pen(Color.White, 10);   //A pen designated as an "eraser"

        int shape;                              //sets the desired shape
        int x, y, circx, circy, sqx, sqy;       //coordinate locations for determining stop points
        int rvalue, gvalue, bvalue;             //sets the pen colors based on the slider value : TODO   

        private void btn_line_Click(object sender, EventArgs e)
        {
            shape = 5;
        }

        private void pic_panel_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;
            py = e.Location;

            circx = e.X;
            circy = e.Y;
        }

        private void pic_panel_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;

            //code snippet sets the color of the shape outline based on the slider values present

                Color c = new Color();                          
                c = Color.FromArgb(rvalue,gvalue,bvalue);
                p.Color = c;

            sqx = x - circx;
            sqy = y - circy;

            if (shape == 3)
            {
               
                g.DrawEllipse(p, circx, circy, sqx, sqy);
                
            }
            if (shape == 4)
            {
                g.DrawRectangle(p, circx, circy, sqx, sqy);
            }
            if (shape == 5)
            {
                g.DrawLine(p, circx, circy, x, y);
            }
        }

        private void pic_panel_MouseMove(object sender, MouseEventArgs e)
        {
            

            if (draw)
            {
                if (shape == 1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }
                if (shape == 2)
                {
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;
                }
            }
            pic_panel.Refresh();

            x = e.X;
            y = e.Y;
            sqx = e.X - circx;
            sqy = e.Y - circy;
        }

        

        private void btn_ell_Click(object sender, EventArgs e)
        {
            shape = 3;
        }

        private void btn_rect_Click(object sender, EventArgs e)
        {
            shape = 4;
        }

        private void btn_free_Click(object sender, EventArgs e)
        {
            shape = 1;
        }

        private void btn_erase_Click(object sender, EventArgs e)
        {
            shape = 2;
        }

        private void Track_red_Scroll(object sender, EventArgs e)
        {
            rvalue = Track_red.Value;   //sets red value
        }

        private void Track_grn_Scroll(object sender, EventArgs e)
        {
            gvalue = Track_grn.Value;      //sets green value

        }

        private void track_blu_Scroll(object sender, EventArgs e)
        {
            bvalue = track_blu.Value;  
        }

        //the control panel element is just their to anchor the controls and is not used as a
        //canvas for the program
        private void pic_panel_Paint(object sender, PaintEventArgs e)
        {
            //Used as the paint canvas 
            //options are selected based on a logical switch to change the shape paramenter.
            //the panel uses a form of buffering to preserve ans update images.

            Graphics g = e.Graphics;
            if (draw)
            {
                if (shape == 3)
                {
                    g.DrawEllipse(p, circx, circy, sqx, sqy);
                    
                }
                if (shape == 4)
                {
                    g.DrawRectangle(p, circx, circy, sqx, sqy);
                }
                if (shape == 5)
                {
                    g.DrawLine(p, circx, circy, x, y);
                }
            }
        }
    }
}
