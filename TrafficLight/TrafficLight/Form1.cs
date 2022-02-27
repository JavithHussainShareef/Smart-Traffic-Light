using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficLight
{
    public partial class Form1 : Form
    {
        static int ticks, ticksE, ticksW, ticksS, StopTicks = 0; // It holds the ticker count
        
        List<PictureBox> lstLights = new List<PictureBox>();
        public Form1()
        {
            InitializeComponent();
            lstLights.Add(picNRed);
            lstLights.Add(picNOrange);
            lstLights.Add(picNGreen);

            lstLights.Add(picERed);
            lstLights.Add(picEOrange);
            lstLights.Add(picEGreen);

            lstLights.Add(picWRed);
            lstLights.Add(picWOrange);
            lstLights.Add(picWGreen);

            lstLights.Add(picSRed);
            lstLights.Add(picSOrange);
            lstLights.Add(picSGreen);


            Reset();


        }
        public void Reset()
        {
            picNRed.Visible = false;
            picNGreen.Visible = false;
            picSRed.Visible = false;
            picSGreen.Visible = false;
            picERed.Visible = false;
            picEGreen.Visible = false;
            picWRed.Visible = false;
            picWGreen.Visible = false;
            picNOrange.Visible = true;
            picEOrange.Visible = true;
            picWOrange.Visible = true;
            picSOrange.Visible = true;
        }

        #region unwanted
        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //private void Reset()
        //{
        //    try
        //    {
        //        picNGreen.Visible = true;
        //        picERed.Visible = true;
        //        picSRed.Visible = true;
        //        picWRed.Visible = true;
        //        picSOrange.Visible = false;
        //        picNOrange.Visible = false;

        //        picEOrange.Visible = false;

        //        picWOrange.Visible = false;


        //    }
        //    catch (Exception ex)
        //    {

        //        lblCounter.Text = ex.Message;

        //    }
        //}
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            //System.Threading.Timer T = new System.Threading.Timer(TimerCallback, null, 0, 2000);
            if (btn_Start.Text == "Start")
            {
                btn_Start.Text = "Stop";
                timer1.Interval = 1000;
                timer1.Start();
            }
            else
            {
                btn_Start.Text = "Start";
                timer1.Stop();

                Reset();
               
                lblStatusN.Text = "NorthStatus";
                lblStatusE.Text = "EastStatus";
                lblStatusW.Text = "WestStatus";
                lblStatusS.Text = "SouthStatus";

                lblN.Text = StopTicks.ToString();
                lblE.Text = StopTicks.ToString();
                lblW.Text = StopTicks.ToString();
                lblS.Text = StopTicks.ToString();
            }

        }

        private void Timer_Ticks(object sender, EventArgs e)
        {
            /* int ticksS = 0;
            int ticksE = 0;
            int ticksW = 0;
            int ticks = 0;*/

            lblN.Text = ticks.ToString();
            lblE.Text = ticksE.ToString();
            lblW.Text = ticksW.ToString();
            lblS.Text = ticksS.ToString();

         
            if (ticks == 1)
            {
                lblStatusN.Text = "Green";
                lblStatusE.Text = "Red";
                lblStatusW.Text = "Red";
                lblStatusS.Text = "Red";
                SetLights("picN","Green");
            }
            else if (ticks == 7)
            {
                //picNGreen.Visible = false;
                //picNOrange.Visible = true;


                lblStatusN.Text = "Yellow";

                SetLights("picN", "Orange");
            }
            else if (ticks == 10)
            {
                //picNOrange.Visible = false;
                //picNRed.Visible = true;
                //picERed.Visible = false;

                //picEGreen.Visible = true;
                ticksE = 0;
                lblStatusN.Text = "Red";
                lblStatusE.Text = "Green";

                SetLights("picE", "Green");
            }
            else if (ticks == 17)
            {
                //picEGreen.Visible = false;
                //picEOrange.Visible = true;
                lblStatusE.Text = "Orange";

                SetLights("picE", "Orange");
            }
            else if (ticks == 20)
            {
                //picEOrange.Visible = false;
                //picERed.Visible = true;
                //picWRed.Visible = false;
                //picWGreen.Visible = true;
                ticksW = 0;
                lblStatusE.Text = "Red";
                lblStatusW.Text = "Green";
                SetLights("picW", "Green");
            }
            else if (ticks == 27)
            {
                //picWGreen.Visible = false;
                //picWOrange.Visible = true;
                lblStatusW.Text = "Orange";
                SetLights("picW", "Orange");
            }
            else if (ticks == 30)
            {
                //picWOrange.Visible = false;
                //picWRed.Visible = true;
                //picSRed.Visible = false;
                //picSGreen.Visible = true;
                ticksS = 0;
                lblStatusS.Text = "Green";
                lblStatusW.Text = "Red";
                SetLights("picS", "Green");
            }
            else if (ticks == 37)
            {
                //picSGreen.Visible = false;
                //picSOrange.Visible = true;
                lblStatusS.Text = "Orange";
                SetLights("picS", "Orange");
            }
            else if (ticks == 40)
            {
                //picSOrange.Visible = false;
                //picSRed.Visible = true;
                //picNRed.Visible = false;
                //picNGreen.Visible = true;
                lblStatusS.Text = "Green";
                lblStatusN.Text = "Red";
                SetLights("picN", "Green");
                ticks = 0;
            }
            ticks++;
            ticksS++;
            ticksE++;
            ticksW++;
        }

        private void SetLights(string lightName, string lightColor)
        {
            try
            {
                foreach (var item in lstLights)
                {
                    
                    if (item.Name == string.Format("{0}{1}",lightName,lightColor) || (item.Name.Contains("Red") && !item.Name.Contains(string.Format("{0}Red", lightName))))
                    {                        
                            item.Visible = true;
                        
                    }
                    else 
                    {
                        item.Visible = false;
                    }
                    
                }
            }
            catch (Exception ex)
            {

                lblStatusN.Text = ex.Message;
            }
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {

        }
    }
}
