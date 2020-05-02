namespace TimerTest1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hours_textBox = new System.Windows.Forms.TextBox();
            this.minutes_textBox = new System.Windows.Forms.TextBox();
            this.seconds_textBox = new System.Windows.Forms.TextBox();
            this.hundreds_textBox = new System.Windows.Forms.TextBox();
            this.Start_button1 = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.timer_size_button = new System.Windows.Forms.Button();
            this.resetAndContinue_button = new System.Windows.Forms.Button();
            this.add_time_button = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHours = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMinutes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSeconds = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHundreds = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEvent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.count_down_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.open_button = new System.Windows.Forms.Button();
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // hours_textBox
            // 
            this.hours_textBox.Location = new System.Drawing.Point(179, 292);
            this.hours_textBox.Name = "hours_textBox";
            this.hours_textBox.Size = new System.Drawing.Size(65, 20);
            this.hours_textBox.TabIndex = 0;
            // 
            // minutes_textBox
            // 
            this.minutes_textBox.Location = new System.Drawing.Point(263, 292);
            this.minutes_textBox.Name = "minutes_textBox";
            this.minutes_textBox.Size = new System.Drawing.Size(65, 20);
            this.minutes_textBox.TabIndex = 1;
            // 
            // seconds_textBox
            // 
            this.seconds_textBox.Location = new System.Drawing.Point(350, 292);
            this.seconds_textBox.Name = "seconds_textBox";
            this.seconds_textBox.Size = new System.Drawing.Size(65, 20);
            this.seconds_textBox.TabIndex = 2;
            // 
            // hundreds_textBox
            // 
            this.hundreds_textBox.Location = new System.Drawing.Point(441, 292);
            this.hundreds_textBox.Name = "hundreds_textBox";
            this.hundreds_textBox.Size = new System.Drawing.Size(65, 20);
            this.hundreds_textBox.TabIndex = 3;
            // 
            // Start_button1
            // 
            this.Start_button1.Location = new System.Drawing.Point(201, 332);
            this.Start_button1.Name = "Start_button1";
            this.Start_button1.Size = new System.Drawing.Size(75, 23);
            this.Start_button1.TabIndex = 4;
            this.Start_button1.Text = "Start / Stop";
            this.Start_button1.UseVisualStyleBackColor = true;
            this.Start_button1.Click += new System.EventHandler(this.Start_button1_Click);
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(296, 332);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(75, 23);
            this.reset_button.TabIndex = 5;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.pause_button_Click);
            // 
            // stop_button
            // 
            this.stop_button.Location = new System.Drawing.Point(400, 332);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(75, 23);
            this.stop_button.TabIndex = 6;
            this.stop_button.Text = "Stop";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // timer_size_button
            // 
            this.timer_size_button.Location = new System.Drawing.Point(131, 227);
            this.timer_size_button.Name = "timer_size_button";
            this.timer_size_button.Size = new System.Drawing.Size(75, 23);
            this.timer_size_button.TabIndex = 7;
            this.timer_size_button.Text = "Big/Smal";
            this.timer_size_button.UseVisualStyleBackColor = true;
            // 
            // resetAndContinue_button
            // 
            this.resetAndContinue_button.Location = new System.Drawing.Point(296, 382);
            this.resetAndContinue_button.Name = "resetAndContinue_button";
            this.resetAndContinue_button.Size = new System.Drawing.Size(75, 23);
            this.resetAndContinue_button.TabIndex = 8;
            this.resetAndContinue_button.Text = "RC";
            this.resetAndContinue_button.UseVisualStyleBackColor = true;
            // 
            // add_time_button
            // 
            this.add_time_button.Location = new System.Drawing.Point(201, 382);
            this.add_time_button.Name = "add_time_button";
            this.add_time_button.Size = new System.Drawing.Size(75, 23);
            this.add_time_button.TabIndex = 9;
            this.add_time_button.Text = "Add";
            this.add_time_button.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHours,
            this.columnMinutes,
            this.columnSeconds,
            this.columnHundreds,
            this.columnTag,
            this.columnName,
            this.columnEvent,
            this.columnDate,
            this.columnTime});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(103, 32);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(568, 189);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHours
            // 
            this.columnHours.Text = "Hours";
            this.columnHours.Width = 40;
            // 
            // columnMinutes
            // 
            this.columnMinutes.Text = "Min:";
            this.columnMinutes.Width = 40;
            // 
            // columnSeconds
            // 
            this.columnSeconds.Text = "Sec:";
            this.columnSeconds.Width = 40;
            // 
            // columnHundreds
            // 
            this.columnHundreds.Text = "Hund:";
            this.columnHundreds.Width = 45;
            // 
            // columnTag
            // 
            this.columnTag.Text = "Tag";
            this.columnTag.Width = 70;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 150;
            // 
            // columnEvent
            // 
            this.columnEvent.Text = "Event:";
            // 
            // count_down_button
            // 
            this.count_down_button.Location = new System.Drawing.Point(212, 227);
            this.count_down_button.Name = "count_down_button";
            this.count_down_button.Size = new System.Drawing.Size(75, 23);
            this.count_down_button.TabIndex = 11;
            this.count_down_button.Text = "Count Down";
            this.count_down_button.UseVisualStyleBackColor = true;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(131, 3);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 12;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            // 
            // open_button
            // 
            this.open_button.Location = new System.Drawing.Point(212, 3);
            this.open_button.Name = "open_button";
            this.open_button.Size = new System.Drawing.Size(75, 23);
            this.open_button.TabIndex = 13;
            this.open_button.Text = "Open";
            this.open_button.UseVisualStyleBackColor = true;
            // 
            // columnDate
            // 
            this.columnDate.Text = "Date:";
            // 
            // columnTime
            // 
            this.columnTime.Text = "Time:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 441);
            this.Controls.Add(this.open_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.count_down_button);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.add_time_button);
            this.Controls.Add(this.resetAndContinue_button);
            this.Controls.Add(this.timer_size_button);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.Start_button1);
            this.Controls.Add(this.hundreds_textBox);
            this.Controls.Add(this.seconds_textBox);
            this.Controls.Add(this.minutes_textBox);
            this.Controls.Add(this.hours_textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hours_textBox;
        private System.Windows.Forms.TextBox minutes_textBox;
        private System.Windows.Forms.TextBox seconds_textBox;
        private System.Windows.Forms.TextBox hundreds_textBox;
        private System.Windows.Forms.Button Start_button1;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.Button timer_size_button;
        private System.Windows.Forms.Button resetAndContinue_button;
        private System.Windows.Forms.Button add_time_button;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHours;
        private System.Windows.Forms.ColumnHeader columnMinutes;
        private System.Windows.Forms.ColumnHeader columnSeconds;
        private System.Windows.Forms.ColumnHeader columnHundreds;
        private System.Windows.Forms.ColumnHeader columnTag;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnEvent;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.ColumnHeader columnTime;
        private System.Windows.Forms.Button count_down_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button open_button;
    }
}

