using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace TimerTest1
{
    public partial class Form1 : Form
    {
        string savePath = "C://";
        string saveName = "";
        string localPath = "";/* Path.GetDirectoryName(savePath);*/

     

        bool countDownTrigger = false;
        int seconds = 0;
        int minutes = 0;
        int hours = 0;
        int selecdedItemForEdit = 0;
        string PressedButton = ""; // String to determain wich button was pressed "Gets recorded in the listview box on added time"

       // Timer
        System.Windows.Forms.Timer timer1;


        public Form1()
        {
            InitializeComponent();
        }





        private void Form1_Load(object sender, EventArgs e)
        {
            // Resize
            int x = timeTable_listView.Width;
            int y = timeTable_listView.Height;

            Timer1();
        }




 



        // Timmer Body
        private void Timer1()
        {
           timer1 = new System.Windows.Forms.Timer();
           timer1.Interval = 1000;
           timer1.Tick += new EventHandler(timer_Tick);

            // Tick
            void timer_Tick(object sender, EventArgs e)
            {
                Count();
            }

        }




       // Timer on Tick
        private void Count()
        {
            if (countDownTrigger == false)
            {
                CountUP();

            }
            else
            {
                CountDown();
            }
          
        }





        private void CountDown()
        {
            seconds -= 1;

            if(seconds == -1)
            {

                if(minutes != 0)
                {
                    minutes -= 1;
                    seconds = 59;
                }

                else if (hours != 0) // If minutes "0"
                {
                    
 
                        hours -= 1;
                        minutes = 60;
                        minutes -= 1;
                        seconds = 60;

                    hours_textBox.Text = hours.ToString();
                }

                else
                {

                    timer1.Stop();
                    seconds = 0;
                }



                minutes_textBox.Text = minutes.ToString();
            }


                seconds_textBox.Text = seconds.ToString();
        }










        // Count UP
        private void CountUP()
        {
           


                // Add second
                seconds += 1;


            if (seconds == 60)// If 1 minute
            {
                seconds = 0; // Reset Seconds
                minutes += 1; // Add minute to minutes
             



                if (minutes == 60)// IF 1 Hour
                {
                    minutes = 0;
                    hours += 1;

                    // Update Hour Textbox
                    hours_textBox.Text = hours.ToString();

                }


            }

            minutes_textBox.Text = minutes.ToString();
            seconds_textBox.Text = seconds.ToString();
        }


        // Textboxes Update
        private void TimerTextBoxesUpdate()
        {
            //hundreds_textBox.Text = hundreds.ToString();
            seconds_textBox.Text = seconds.ToString();
            minutes_textBox.Text = minutes.ToString();
            hours_textBox.Text = hours.ToString();
        }




        //END- Button
        private void end_button_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            seconds = 0;
            minutes = 0;
            hours = 0;

            // Make the textboxes "0"
            TimerTextBoxesUpdate();

            // Allow to write in the textboxes
            EnableTextboxes(); // Enable Textboxes
        }




        // Enable Textboxes
        private void EnableTextboxes()
        {
            hours_textBox.ReadOnly = false;
            minutes_textBox.ReadOnly = false;
            seconds_textBox.ReadOnly = false;
            
        }
       
        

        // Disable Textboxes
        private void DisableTextboxes()
        {
            hours_textBox.ReadOnly = true;
            minutes_textBox.ReadOnly = true;
            seconds_textBox.ReadOnly = true;
         
        }




        // Change Time
        private void ChangeTime()
        {
            //bool hu = int.TryParse(hundreds_textBox.Text, out hundreds);
            bool se = int.TryParse(seconds_textBox.Text, out seconds);
            bool mi = int.TryParse(minutes_textBox.Text, out minutes);
            bool ho = int.TryParse(hours_textBox.Text, out hours);
         

            // Validate Input "Maximum number"
           

            if(seconds > 60 || seconds<0)
            {
                seconds = 0;
            }
     
            if(minutes > 60 || minutes <0)
            {
                minutes = 0;
            }

            if(hours <0)
            {
                hours = 0;
                hours_textBox.Text = "0";
            }

        }






        //Start / Pause
        private void StartPause_button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                ChangeTime();
                timer1.Enabled = true;
                DisableTextboxes();// Disable Textboxes
                timer1.Start();

            }
            else
            {   // Pause
                timer1.Enabled = false;
                EnableTextboxes(); // Enable Textboxes
            }
        }





        // CountDown "TRUE" / "FALSE"
        private void count_down_button_Click(object sender, EventArgs e)
        {
            if(countDownTrigger == false)
            {
                countDownTrigger = true;
            }

            else
            {
                countDownTrigger = false;
            }

        }





        //Add Time to List and continue - Button
        private void add_time_button_Click(object sender, EventArgs e)
        {
            PressedButton = "Add";
            AddTimeToList();
        }



        // Add to list
        private void AddTimeToList()
        {

            string type = "";
            if(countDownTrigger == true)
            {
                type = "Down";
            }
            else
            {
                type = "Up";
            }


            string[] row = { "<" + ((double)hours / 24).ToString("N2") + ">" + "=".ToString(), hours_textBox.Text, minutes_textBox.Text, seconds_textBox.Text, "N", "None", PressedButton, type, DateTime.Now.ToString() };
            ListViewItem item = new ListViewItem(row);
            timeTable_listView.Items.Add(item);
        }



        // Reset and Continue
        private void resetAndContinue_button_Click(object sender, EventArgs e)
        {
            PressedButton = "ARC";
            AddTimeToList();
            Reset();
        }


        //Only reset Values
        private void Reset()
        {
            seconds = 0;
            minutes = 0;
            hours = 0;

            seconds_textBox.Text = "0";
            minutes_textBox.Text = "0";
            hours_textBox.Text = "0";
        }



        // Reset and stop
        private void reset_button_Click(object sender, EventArgs e)
        {
            Reset();
        }


        // Add Reset and Stop
        private void AddresetAnd_stop_button_Click(object sender, EventArgs e)
        {
            PressedButton = "ARS";
            AddTimeToList();
            Reset();
            timer1.Stop();
            EnableTextboxes();
        }



        // Get Item on click
        private void timeTable_listView_MouseUp(object sender, MouseEventArgs e)
        {
            Point mousePos = timeTable_listView.PointToClient(Control.MousePosition);
            ListViewHitTestInfo hitTest = timeTable_listView.HitTest(mousePos);
          

            try
            {
            int columnIndex = hitTest.Item.SubItems.IndexOf(hitTest.SubItem);
            edit_textBox.Text = timeTable_listView.SelectedItems[0].SubItems[columnIndex].Text;

                // Last Viewwd Color
                timeTable_listView.SelectedItems[0].BackColor = Color.FromArgb(86, 91, 92);

            selecdedItemForEdit = columnIndex; // Remember the Index so you can save the edit
            }
            catch(Exception)
            {

            }

        

        }

        // Save Edit
        private void save_Edit_button_Click(object sender, EventArgs e)
        {
            try
            {
            timeTable_listView.SelectedItems[0].SubItems[selecdedItemForEdit].Text = edit_textBox.Text;
            timeTable_listView.SelectedItems[0].BackColor = Color.FromArgb(255, 199, 94);
            timeTable_listView.SelectedItems[0].ForeColor = Color.Blue;

            }
            catch(Exception)
            {
                MessageBox.Show("Failed Saving: Please select item to edit first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Abort Edir // Cancel Edit
        private void AbortEdit_button_Click(object sender, EventArgs e)
        {
            edit_textBox.Text = "";
        }


        // Change Listview Size
        private void resize_trackBar_Scroll(object sender, EventArgs e)
        {


        }

        private void resize_trackBar_ValueChanged(object sender, EventArgs e)
        {
             
            timeTable_listView.Width =  resize_trackBar.Value;
          
            textBox2.Text = resize_trackBar.Value.ToString();

        }



        // Save File Button
        private void save_button_Click(object sender, EventArgs e)
        {
            // Make the file name so it maches all streamwriters "If it is at the top it gets the time when the application was started and the name with date will not change"
            saveName = "Timer -" + DateTime.Now.ToString("dd -MM-yyyy  HH-mm-ss") + ".txt";


            System.IO.File.AppendAllText(savePath+saveName, Environment.NewLine + Environment.NewLine);

                // Columns NAMES
                for (int c = 0; c < timeTable_listView.Columns.Count; c++)
                {
                    System.IO.File.AppendAllText(savePath+saveName, timeTable_listView.Columns[c].Text + "\t");
                }

                // Add new Line int the txt file
                System.IO.File.AppendAllText(savePath+saveName, Environment.NewLine + Environment.NewLine);


                // Get all Items  "loop All items"
                for (int i = 0; i < timeTable_listView.Items.Count; i++)
                {

                    // Loop all Sub Items of the Current Item "[i]"
                    for (int a = 0; a < timeTable_listView.Items[i].SubItems.Count; a++)
                    {
                        // Write the sub item "[a]" to the file with "tab betwen each item"
                        System.IO.File.AppendAllText(savePath+saveName, timeTable_listView.Items[i].SubItems[a].Text + "\t");
                    }

                    // Add new Line "the new Row" starts at new line
                    System.IO.File.AppendAllText(savePath+saveName, Environment.NewLine);
                }
            
         
        }

        // Open Local Folder
        private void open_folder_button_Click(object sender, EventArgs e)
        {
            Process.Start(localPath);
        }
    }
}
