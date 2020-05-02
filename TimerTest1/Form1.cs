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

namespace TimerTest1
{
    public partial class Form1 : Form
    {
        int hundreds = 0;
        int seconds = 0;
        int minutes = 0;
        int hours = 0;

        System.Windows.Forms.Timer timer1;


        public Form1()
        {
            InitializeComponent();
        }





        private void Form1_Load(object sender, EventArgs e)
        {
            Timer1();
        }




 




        private void Timer1()
        {
             timer1 = new System.Windows.Forms.Timer();


           timer1.Interval = 10; // specify interval time as you want
           timer1.Tick += new EventHandler(timer_Tick);
          
             
          

            void timer_Tick(object sender, EventArgs e)
            {
                Count();
            }
        }



        private void TimerTextBoxesUpdate()
        {
            hundreds_textBox.Text = hundreds.ToString();
            seconds_textBox.Text = seconds.ToString();
            minutes_textBox.Text = minutes.ToString();
            hours_textBox.Text = hours.ToString();
        }



        private void Count()
        {
            hundreds = hundreds + 1;// Tick

            if(hundreds == 100)
            {
                hundreds = 0;
                seconds += 1;
            }

            if(seconds == 60)// If 1 minute
            {
                seconds = 0; // Reset Seconds
                minutes += 1; // Add minute to minutes

            }
            
            if(minutes == 60)// Minutes
            {
                minutes = 0;
                hours += 1;
            }

            TimerTextBoxesUpdate();
        }





        //Start
        private void Start_button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
            timer1.Enabled = true;
            timer1.Start();
            }
            else
            {
                timer1.Stop();
            }


        }

        //Pause
        private void pause_button_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }


        //Stop
        private void stop_button_Click(object sender, EventArgs e)
        {
            hundreds = 0;
            seconds = 0;
            minutes = 0;
            hours = 0;

            TimerTextBoxesUpdate();
        }
    }
}
