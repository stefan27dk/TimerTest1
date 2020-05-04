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
            this.StartPause_button1 = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.resetAndContinue_button = new System.Windows.Forms.Button();
            this.add_time_button = new System.Windows.Forms.Button();
            this.timeTable_listView = new System.Windows.Forms.ListView();
            this.columnDays = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHours = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMinutes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSeconds = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEvent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.count_down_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.AddresetAnd_stop_button = new System.Windows.Forms.Button();
            this.edit_textBox = new System.Windows.Forms.TextBox();
            this.save_Edit_button = new System.Windows.Forms.Button();
            this.AbortEdit_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.resize_trackBar = new System.Windows.Forms.TrackBar();
            this.fk1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hours_label = new System.Windows.Forms.Label();
            this.min_label = new System.Windows.Forms.Label();
            this.sec_label = new System.Windows.Forms.Label();
            this.day_label = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.timer_Controls_holder_panel = new System.Windows.Forms.Panel();
            this.open_folder_button = new System.Windows.Forms.Button();
            this.holder_panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.resize_trackBar)).BeginInit();
            this.timer_Controls_holder_panel.SuspendLayout();
            this.holder_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // hours_textBox
            // 
            this.hours_textBox.Location = new System.Drawing.Point(86, 57);
            this.hours_textBox.Name = "hours_textBox";
            this.hours_textBox.Size = new System.Drawing.Size(65, 20);
            this.hours_textBox.TabIndex = 0;
            this.hours_textBox.Text = "0";
            // 
            // minutes_textBox
            // 
            this.minutes_textBox.Location = new System.Drawing.Point(167, 57);
            this.minutes_textBox.Name = "minutes_textBox";
            this.minutes_textBox.Size = new System.Drawing.Size(65, 20);
            this.minutes_textBox.TabIndex = 1;
            this.minutes_textBox.Text = "0";
            // 
            // seconds_textBox
            // 
            this.seconds_textBox.Location = new System.Drawing.Point(248, 57);
            this.seconds_textBox.Name = "seconds_textBox";
            this.seconds_textBox.Size = new System.Drawing.Size(65, 20);
            this.seconds_textBox.TabIndex = 2;
            this.seconds_textBox.Text = "0";
            // 
            // StartPause_button1
            // 
            this.StartPause_button1.Location = new System.Drawing.Point(5, 83);
            this.StartPause_button1.Name = "StartPause_button1";
            this.StartPause_button1.Size = new System.Drawing.Size(75, 23);
            this.StartPause_button1.TabIndex = 4;
            this.StartPause_button1.Text = "Start/Pause";
            this.StartPause_button1.UseVisualStyleBackColor = true;
            this.StartPause_button1.Click += new System.EventHandler(this.StartPause_button1_Click);
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(5, 112);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(75, 23);
            this.reset_button.TabIndex = 5;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // stop_button
            // 
            this.stop_button.Location = new System.Drawing.Point(167, 83);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(75, 23);
            this.stop_button.TabIndex = 6;
            this.stop_button.Text = "End";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.end_button_Click);
            // 
            // resetAndContinue_button
            // 
            this.resetAndContinue_button.Location = new System.Drawing.Point(86, 112);
            this.resetAndContinue_button.Name = "resetAndContinue_button";
            this.resetAndContinue_button.Size = new System.Drawing.Size(75, 23);
            this.resetAndContinue_button.TabIndex = 8;
            this.resetAndContinue_button.Text = "ARC";
            this.resetAndContinue_button.UseVisualStyleBackColor = true;
            this.resetAndContinue_button.Click += new System.EventHandler(this.resetAndContinue_button_Click);
            // 
            // add_time_button
            // 
            this.add_time_button.Location = new System.Drawing.Point(86, 83);
            this.add_time_button.Name = "add_time_button";
            this.add_time_button.Size = new System.Drawing.Size(75, 23);
            this.add_time_button.TabIndex = 9;
            this.add_time_button.Text = "Add";
            this.add_time_button.UseVisualStyleBackColor = true;
            this.add_time_button.Click += new System.EventHandler(this.add_time_button_Click);
            // 
            // timeTable_listView
            // 
            this.timeTable_listView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.timeTable_listView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeTable_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnDays,
            this.columnHours,
            this.columnMinutes,
            this.columnSeconds,
            this.columnTag,
            this.columnName,
            this.columnEvent,
            this.columnType,
            this.columnDate});
            this.timeTable_listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeTable_listView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.timeTable_listView.FullRowSelect = true;
            this.timeTable_listView.HideSelection = false;
            this.timeTable_listView.Location = new System.Drawing.Point(3, 32);
            this.timeTable_listView.MaximumSize = new System.Drawing.Size(587, 100);
            this.timeTable_listView.MinimumSize = new System.Drawing.Size(250, 10);
            this.timeTable_listView.Name = "timeTable_listView";
            this.timeTable_listView.Size = new System.Drawing.Size(250, 100);
            this.timeTable_listView.TabIndex = 10;
            this.timeTable_listView.UseCompatibleStateImageBehavior = false;
            this.timeTable_listView.View = System.Windows.Forms.View.Details;
            this.timeTable_listView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.timeTable_listView_MouseUp);
            // 
            // columnDays
            // 
            this.columnDays.Text = "Days:";
            this.columnDays.Width = 55;
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
            // columnTag
            // 
            this.columnTag.Text = "Tag";
            this.columnTag.Width = 70;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 100;
            // 
            // columnEvent
            // 
            this.columnEvent.Text = "Event:";
            // 
            // columnType
            // 
            this.columnType.Text = "Type:";
            // 
            // columnDate
            // 
            this.columnDate.Text = "DateTime:";
            this.columnDate.Width = 120;
            // 
            // count_down_button
            // 
            this.count_down_button.Location = new System.Drawing.Point(248, 83);
            this.count_down_button.Name = "count_down_button";
            this.count_down_button.Size = new System.Drawing.Size(75, 23);
            this.count_down_button.TabIndex = 11;
            this.count_down_button.Text = "Count Down";
            this.count_down_button.UseVisualStyleBackColor = true;
            this.count_down_button.Click += new System.EventHandler(this.count_down_button_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(3, 3);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 12;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // AddresetAnd_stop_button
            // 
            this.AddresetAnd_stop_button.Location = new System.Drawing.Point(167, 112);
            this.AddresetAnd_stop_button.Name = "AddresetAnd_stop_button";
            this.AddresetAnd_stop_button.Size = new System.Drawing.Size(75, 23);
            this.AddresetAnd_stop_button.TabIndex = 14;
            this.AddresetAnd_stop_button.Text = "ARS";
            this.AddresetAnd_stop_button.UseVisualStyleBackColor = true;
            this.AddresetAnd_stop_button.Click += new System.EventHandler(this.AddresetAnd_stop_button_Click);
            // 
            // edit_textBox
            // 
            this.edit_textBox.Location = new System.Drawing.Point(3, 3);
            this.edit_textBox.Name = "edit_textBox";
            this.edit_textBox.Size = new System.Drawing.Size(100, 20);
            this.edit_textBox.TabIndex = 15;
            // 
            // save_Edit_button
            // 
            this.save_Edit_button.Location = new System.Drawing.Point(109, 3);
            this.save_Edit_button.Name = "save_Edit_button";
            this.save_Edit_button.Size = new System.Drawing.Size(75, 23);
            this.save_Edit_button.TabIndex = 16;
            this.save_Edit_button.Text = "Save";
            this.save_Edit_button.UseVisualStyleBackColor = true;
            this.save_Edit_button.Click += new System.EventHandler(this.save_Edit_button_Click);
            // 
            // AbortEdit_button
            // 
            this.AbortEdit_button.Location = new System.Drawing.Point(190, 3);
            this.AbortEdit_button.Name = "AbortEdit_button";
            this.AbortEdit_button.Size = new System.Drawing.Size(75, 23);
            this.AbortEdit_button.TabIndex = 17;
            this.AbortEdit_button.Text = "Abort";
            this.AbortEdit_button.UseVisualStyleBackColor = true;
            this.AbortEdit_button.Click += new System.EventHandler(this.AbortEdit_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox1.Location = new System.Drawing.Point(6, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(65, 20);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "0";
            // 
            // resize_trackBar
            // 
            this.resize_trackBar.Location = new System.Drawing.Point(271, 3);
            this.resize_trackBar.Maximum = 600;
            this.resize_trackBar.Name = "resize_trackBar";
            this.resize_trackBar.Size = new System.Drawing.Size(71, 45);
            this.resize_trackBar.TabIndex = 19;
            this.resize_trackBar.Scroll += new System.EventHandler(this.resize_trackBar_Scroll);
            this.resize_trackBar.ValueChanged += new System.EventHandler(this.resize_trackBar_ValueChanged);
            // 
            // fk1
            // 
            this.fk1.AutoSize = true;
            this.fk1.Font = new System.Drawing.Font("Miriam CLM", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.fk1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(193)))), ((int)(((byte)(106)))));
            this.fk1.Location = new System.Drawing.Point(152, 59);
            this.fk1.Name = "fk1";
            this.fk1.Size = new System.Drawing.Size(10, 15);
            this.fk1.TabIndex = 20;
            this.fk1.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Miriam CLM", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(193)))), ((int)(((byte)(106)))));
            this.label1.Location = new System.Drawing.Point(235, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = ":";
            // 
            // hours_label
            // 
            this.hours_label.AutoSize = true;
            this.hours_label.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hours_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(193)))), ((int)(((byte)(106)))));
            this.hours_label.Location = new System.Drawing.Point(87, 39);
            this.hours_label.Name = "hours_label";
            this.hours_label.Size = new System.Drawing.Size(43, 15);
            this.hours_label.TabIndex = 22;
            this.hours_label.Text = "Hours:";
            // 
            // min_label
            // 
            this.min_label.AutoSize = true;
            this.min_label.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.min_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(193)))), ((int)(((byte)(106)))));
            this.min_label.Location = new System.Drawing.Point(169, 39);
            this.min_label.Name = "min_label";
            this.min_label.Size = new System.Drawing.Size(32, 15);
            this.min_label.TabIndex = 23;
            this.min_label.Text = "Min:";
            // 
            // sec_label
            // 
            this.sec_label.AutoSize = true;
            this.sec_label.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sec_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(193)))), ((int)(((byte)(106)))));
            this.sec_label.Location = new System.Drawing.Point(248, 39);
            this.sec_label.Name = "sec_label";
            this.sec_label.Size = new System.Drawing.Size(29, 15);
            this.sec_label.TabIndex = 24;
            this.sec_label.Text = "Sec:";
            // 
            // day_label
            // 
            this.day_label.AutoSize = true;
            this.day_label.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.day_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(193)))), ((int)(((byte)(106)))));
            this.day_label.Location = new System.Drawing.Point(7, 39);
            this.day_label.Name = "day_label";
            this.day_label.Size = new System.Drawing.Size(45, 15);
            this.day_label.TabIndex = 25;
            this.day_label.Text = "Days: =";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(341, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(25, 20);
            this.textBox2.TabIndex = 26;
            // 
            // timer_Controls_holder_panel
            // 
            this.timer_Controls_holder_panel.Controls.Add(this.edit_textBox);
            this.timer_Controls_holder_panel.Controls.Add(this.textBox2);
            this.timer_Controls_holder_panel.Controls.Add(this.hours_textBox);
            this.timer_Controls_holder_panel.Controls.Add(this.day_label);
            this.timer_Controls_holder_panel.Controls.Add(this.minutes_textBox);
            this.timer_Controls_holder_panel.Controls.Add(this.sec_label);
            this.timer_Controls_holder_panel.Controls.Add(this.seconds_textBox);
            this.timer_Controls_holder_panel.Controls.Add(this.min_label);
            this.timer_Controls_holder_panel.Controls.Add(this.StartPause_button1);
            this.timer_Controls_holder_panel.Controls.Add(this.hours_label);
            this.timer_Controls_holder_panel.Controls.Add(this.reset_button);
            this.timer_Controls_holder_panel.Controls.Add(this.label1);
            this.timer_Controls_holder_panel.Controls.Add(this.stop_button);
            this.timer_Controls_holder_panel.Controls.Add(this.fk1);
            this.timer_Controls_holder_panel.Controls.Add(this.resetAndContinue_button);
            this.timer_Controls_holder_panel.Controls.Add(this.resize_trackBar);
            this.timer_Controls_holder_panel.Controls.Add(this.add_time_button);
            this.timer_Controls_holder_panel.Controls.Add(this.textBox1);
            this.timer_Controls_holder_panel.Controls.Add(this.count_down_button);
            this.timer_Controls_holder_panel.Controls.Add(this.AbortEdit_button);
            this.timer_Controls_holder_panel.Controls.Add(this.AddresetAnd_stop_button);
            this.timer_Controls_holder_panel.Controls.Add(this.save_Edit_button);
            this.timer_Controls_holder_panel.Location = new System.Drawing.Point(-16, 138);
            this.timer_Controls_holder_panel.Name = "timer_Controls_holder_panel";
            this.timer_Controls_holder_panel.Size = new System.Drawing.Size(369, 141);
            this.timer_Controls_holder_panel.TabIndex = 27;
            // 
            // open_folder_button
            // 
            this.open_folder_button.Location = new System.Drawing.Point(84, 3);
            this.open_folder_button.Name = "open_folder_button";
            this.open_folder_button.Size = new System.Drawing.Size(75, 23);
            this.open_folder_button.TabIndex = 28;
            this.open_folder_button.Text = "Folder";
            this.open_folder_button.UseVisualStyleBackColor = true;
            this.open_folder_button.Click += new System.EventHandler(this.open_folder_button_Click);
            // 
            // holder_panel
            // 
            this.holder_panel.AutoSize = true;
            this.holder_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.holder_panel.Controls.Add(this.save_button);
            this.holder_panel.Controls.Add(this.open_folder_button);
            this.holder_panel.Controls.Add(this.timer_Controls_holder_panel);
            this.holder_panel.Controls.Add(this.timeTable_listView);
            this.holder_panel.Location = new System.Drawing.Point(12, 12);
            this.holder_panel.Name = "holder_panel";
            this.holder_panel.Size = new System.Drawing.Size(356, 282);
            this.holder_panel.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(78)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1403, 498);
            this.Controls.Add(this.holder_panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resize_trackBar)).EndInit();
            this.timer_Controls_holder_panel.ResumeLayout(false);
            this.timer_Controls_holder_panel.PerformLayout();
            this.holder_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hours_textBox;
        private System.Windows.Forms.TextBox minutes_textBox;
        private System.Windows.Forms.TextBox seconds_textBox;
        private System.Windows.Forms.Button StartPause_button1;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.Button resetAndContinue_button;
        private System.Windows.Forms.Button add_time_button;
        private System.Windows.Forms.ListView timeTable_listView;
        private System.Windows.Forms.ColumnHeader columnHours;
        private System.Windows.Forms.ColumnHeader columnMinutes;
        private System.Windows.Forms.ColumnHeader columnSeconds;
        private System.Windows.Forms.ColumnHeader columnDays;
        private System.Windows.Forms.ColumnHeader columnTag;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnEvent;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.Button count_down_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button AddresetAnd_stop_button;
        private System.Windows.Forms.TextBox edit_textBox;
        private System.Windows.Forms.Button save_Edit_button;
        private System.Windows.Forms.Button AbortEdit_button;
        private System.Windows.Forms.ColumnHeader columnType;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TrackBar resize_trackBar;
        private System.Windows.Forms.Label fk1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hours_label;
        private System.Windows.Forms.Label min_label;
        private System.Windows.Forms.Label sec_label;
        private System.Windows.Forms.Label day_label;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel timer_Controls_holder_panel;
        private System.Windows.Forms.Button open_folder_button;
        private System.Windows.Forms.Panel holder_panel;
    }
}

