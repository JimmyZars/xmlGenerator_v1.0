namespace XMLGenerator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.loc = new System.Windows.Forms.TextBox();
            this.sHour = new System.Windows.Forms.TextBox();
            this.sMin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sDayTime = new System.Windows.Forms.ComboBox();
            this.eDayTime = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.eMin = new System.Windows.Forms.TextBox();
            this.eHour = new System.Windows.Forms.TextBox();
            this.nextEventButton = new System.Windows.Forms.Button();
            this.nextDayButton = new System.Windows.Forms.Button();
            this.finishButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.daylabel = new System.Windows.Forms.Label();
            this.eventlabel = new System.Windows.Forms.Label();
            this.prevDay = new System.Windows.Forms.Button();
            this.outputWindow = new System.Windows.Forms.RichTextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(156, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(156, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(156, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "End Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(156, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Location:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(256, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 1;
            // 
            // loc
            // 
            this.loc.Location = new System.Drawing.Point(256, 245);
            this.loc.Name = "loc";
            this.loc.Size = new System.Drawing.Size(197, 20);
            this.loc.TabIndex = 8;
            // 
            // sHour
            // 
            this.sHour.Location = new System.Drawing.Point(284, 160);
            this.sHour.Name = "sHour";
            this.sHour.Size = new System.Drawing.Size(35, 20);
            this.sHour.TabIndex = 2;
            // 
            // sMin
            // 
            this.sMin.Location = new System.Drawing.Point(349, 160);
            this.sMin.Name = "sMin";
            this.sMin.Size = new System.Drawing.Size(35, 20);
            this.sMin.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(260, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "H";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(325, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "M";
            // 
            // sDayTime
            // 
            this.sDayTime.FormattingEnabled = true;
            this.sDayTime.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.sDayTime.Location = new System.Drawing.Point(401, 160);
            this.sDayTime.Name = "sDayTime";
            this.sDayTime.Size = new System.Drawing.Size(52, 21);
            this.sDayTime.TabIndex = 4;
            this.sDayTime.Text = "AM";
            // 
            // eDayTime
            // 
            this.eDayTime.FormattingEnabled = true;
            this.eDayTime.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.eDayTime.Location = new System.Drawing.Point(401, 203);
            this.eDayTime.Name = "eDayTime";
            this.eDayTime.Size = new System.Drawing.Size(52, 21);
            this.eDayTime.TabIndex = 7;
            this.eDayTime.Text = "AM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(325, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "M";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(260, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "H";
            // 
            // eMin
            // 
            this.eMin.Location = new System.Drawing.Point(349, 203);
            this.eMin.Name = "eMin";
            this.eMin.Size = new System.Drawing.Size(35, 20);
            this.eMin.TabIndex = 6;
            // 
            // eHour
            // 
            this.eHour.Location = new System.Drawing.Point(284, 203);
            this.eHour.Name = "eHour";
            this.eHour.Size = new System.Drawing.Size(35, 20);
            this.eHour.TabIndex = 5;
            // 
            // nextEventButton
            // 
            this.nextEventButton.Location = new System.Drawing.Point(496, 122);
            this.nextEventButton.Name = "nextEventButton";
            this.nextEventButton.Size = new System.Drawing.Size(88, 23);
            this.nextEventButton.TabIndex = 16;
            this.nextEventButton.Text = "Next Event";
            this.nextEventButton.UseVisualStyleBackColor = true;
            this.nextEventButton.Click += new System.EventHandler(this.nextEventButton_Click);
            // 
            // nextDayButton
            // 
            this.nextDayButton.Location = new System.Drawing.Point(496, 160);
            this.nextDayButton.Name = "nextDayButton";
            this.nextDayButton.Size = new System.Drawing.Size(88, 23);
            this.nextDayButton.TabIndex = 17;
            this.nextDayButton.Text = "Next Day";
            this.nextDayButton.UseVisualStyleBackColor = true;
            this.nextDayButton.Click += new System.EventHandler(this.nextDayButton_Click);
            // 
            // finishButton
            // 
            this.finishButton.Location = new System.Drawing.Point(496, 242);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(88, 23);
            this.finishButton.TabIndex = 19;
            this.finishButton.Text = "Finish";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click_1);
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(43, 122);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(88, 23);
            this.previousButton.TabIndex = 20;
            this.previousButton.Text = "Previous Event";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Britannic Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(154, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(321, 38);
            this.label9.TabIndex = 21;
            this.label9.Text = "Schedule Generator";
            // 
            // daylabel
            // 
            this.daylabel.AutoSize = true;
            this.daylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daylabel.Location = new System.Drawing.Point(252, 71);
            this.daylabel.Name = "daylabel";
            this.daylabel.Size = new System.Drawing.Size(50, 20);
            this.daylabel.TabIndex = 22;
            this.daylabel.Text = "Day 1";
            // 
            // eventlabel
            // 
            this.eventlabel.AutoSize = true;
            this.eventlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventlabel.Location = new System.Drawing.Point(308, 71);
            this.eventlabel.Name = "eventlabel";
            this.eventlabel.Size = new System.Drawing.Size(63, 20);
            this.eventlabel.TabIndex = 23;
            this.eventlabel.Text = "Event 1";
            // 
            // prevDay
            // 
            this.prevDay.Location = new System.Drawing.Point(43, 160);
            this.prevDay.Name = "prevDay";
            this.prevDay.Size = new System.Drawing.Size(88, 23);
            this.prevDay.TabIndex = 24;
            this.prevDay.Text = "Previous Day";
            this.prevDay.UseVisualStyleBackColor = true;
            this.prevDay.Click += new System.EventHandler(this.prevDay_Click);
            // 
            // outputWindow
            // 
            this.outputWindow.Location = new System.Drawing.Point(765, 33);
            this.outputWindow.Name = "outputWindow";
            this.outputWindow.ReadOnly = true;
            this.outputWindow.Size = new System.Drawing.Size(402, 536);
            this.outputWindow.TabIndex = 25;
            this.outputWindow.Text = "";
            this.outputWindow.TextChanged += new System.EventHandler(this.outputWindow_TextChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(496, 200);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(88, 23);
            this.deleteButton.TabIndex = 26;
            this.deleteButton.Text = "Delete Event";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 600);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.outputWindow);
            this.Controls.Add(this.prevDay);
            this.Controls.Add(this.eventlabel);
            this.Controls.Add(this.daylabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.nextDayButton);
            this.Controls.Add(this.nextEventButton);
            this.Controls.Add(this.eDayTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.eMin);
            this.Controls.Add(this.eHour);
            this.Controls.Add(this.sDayTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sMin);
            this.Controls.Add(this.sHour);
            this.Controls.Add(this.loc);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "XML Schedule Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox sHour;
        private System.Windows.Forms.TextBox sMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox sDayTime;
        private System.Windows.Forms.ComboBox eDayTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox eMin;
        private System.Windows.Forms.TextBox eHour;
        private System.Windows.Forms.Button nextEventButton;
        private System.Windows.Forms.Button nextDayButton;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox loc;
        private System.Windows.Forms.Label daylabel;
        private System.Windows.Forms.Label eventlabel;
        private System.Windows.Forms.Button prevDay;
        private System.Windows.Forms.RichTextBox outputWindow;
        private System.Windows.Forms.Button deleteButton;
    }
}

