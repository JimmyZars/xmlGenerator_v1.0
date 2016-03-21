using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLGenerator
{
    public partial class Form1 : Form
    {
        protected string xmlOutput;
        protected static int rows = 5;
        protected static int cols = 5;
        protected string xmlOutputWindow;
        xmlEvent[,] events = new xmlEvent[rows, cols];
        protected int day;
        protected int eventnum;
        protected string tempname;


        public Form1()
        {
            InitializeComponent();
            day = 1;
            eventnum = 1;
            daylabel.Text = "Day " + day;
            eventlabel.Text = "Event " + eventnum;
            textBox1.Focus();

        }

        //Next Event Button
        protected void nextEventButton_Click(object sender, EventArgs e)
        {
            bool error1 = false;

            error1 = saveEvent();

            if (error1)
            {
                //
            }
            else {
                xmlOutputWindow = generateXML();
                outputWindow.Text = xmlOutputWindow;
                eventnum++;
                try
                {
                    if (events[day, eventnum].name.Length > 0)
                    {
                        displayEvent();
                    }
                }
                catch (NullReferenceException)
                {
                    clearForm();
                }
            }

        }

        //previous button clicked
        protected void previousButton_Click(object sender, EventArgs e)
        {
            if (eventnum > 1)
            {
                eventnum--;
                eventlabel.Text = "Event " + eventnum;
                displayEvent();
            }
            else if ((eventnum == 1) && (day > 1))
            {
                day--;
                eventnum = eventCount(day);
                daylabel.Text = "Day " + day;
                eventlabel.Text = "Event " + eventnum;
                displayEvent();
            }
        }

        protected void writetofile(string text)
        {
            System.IO.File.WriteAllText(@"C:\Users\jimmy.zars\Desktop\agenda.xml", text);
        }

        private void nextDayButton_Click(object sender, EventArgs e)
        {
            bool error1 = false;

            error1 = saveEvent();

            if (error1)
            {
                //
            }
            else {
                day++;
                eventnum = 1;
                try
                {
                    if (events[day, eventnum].name.Length > 0)
                    {
                        displayEvent();
                    }
                }
                catch (NullReferenceException)
                {
                    clearForm();
                }
            }
        }

        protected int eventCount(int daynum)
        {
            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                try
                {
                    if (events[daynum, i].name.Length > 0)
                    {
                        count++;
                    }
                    else
                    {
                        
                    }
                }
                catch (NullReferenceException)
                {
                    //Do nothing
                }
                catch (IndexOutOfRangeException)
                {
                    
                }
            }
            return count;
        }

        protected void displayEvent()
        {
            xmlEvent tempevent = new xmlEvent();
            tempevent = events[day, eventnum];
            textBox1.Text = tempevent.name;
            sHour.Text = tempevent.starttime.getHour();
            sMin.Text = tempevent.starttime.getMin();
            sDayTime.Text = tempevent.starttime.getDayTime();
            eHour.Text = tempevent.endtime.getHour();
            eMin.Text = tempevent.endtime.getMin();
            eDayTime.Text = tempevent.endtime.getDayTime();
            loc.Text = tempevent.location;
            daylabel.Text = "Day " + day;
            eventlabel.Text = "Event " + eventnum;
            textBox1.Focus();
        }

        protected void prevDay_Click(object sender, EventArgs e)
        {
            if (day > 1)
            {
                day--;
                eventnum = 1;
                displayEvent();
                textBox1.Focus();
            }
        }

        protected bool saveEvent()
        {
            bool errorx = false;

            xmlEvent tempevent = new xmlEvent();
            if (textBox1.Text.Length < 1)
            {
                MessageBox.Show("Please enter a valid name", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorx = true;
            }
            else
            {
                tempevent.name = textBox1.Text;
            }
            events[day, eventnum] = tempevent;
            try
            {
                xmltime sTime = new xmltime();
                sTime.setHour(int.Parse(sHour.Text));
                sTime.setMin(int.Parse(sMin.Text));
                sTime.setDayTime(sDayTime.Text);
                tempevent.starttime = sTime;
            }
            catch (Exception ex)
            {
                if (ex is FormatException || ex is NullReferenceException)
                {
                    MessageBox.Show("Incorrect Start Time", "Start Time Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    errorx = true;
                }
            }
            try
            {
                xmltime eTime = new xmltime();
                eTime.setHour(int.Parse(eHour.Text));
                eTime.setMin(int.Parse(eMin.Text));
                eTime.setDayTime(eDayTime.Text);
                tempevent.endtime = eTime;
            }
            catch (Exception ex)
            {
                if (ex is FormatException || ex is NullReferenceException)
                {
                    MessageBox.Show("Incorrect End Time", "Start Time Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                errorx = true;
            }
            tempevent.location = loc.Text;
            return errorx;
        }

        private void outputWindow_TextChanged(object sender, EventArgs e)
        {

        }

        protected string generateXML()
        {
            //Start of File
            string xmlgen = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\n" +
                        "<activity>\n";
            for (int i = 1; i < rows; i++)
            {
                try
                {
                    if (events[i, 1].name.Length > 0)
                    {
                        xmlgen += "     <day count=\"" + i + "\">\n";
                        for (int j = 1; j < cols; j++)
                        {
                            try
                            {
                                if (events[i, j].name.Length > 0)
                                {
                                    xmlgen += "          <event id=\"" + j + "\">\n";
                                    xmlgen += "               <name>" + events[i, j].name + "</name>\n";

                                    if (events[i, j].starttime.getDayTime() == "AM")
                                    {
                                        xmlgen += "               <starttime>" + events[i, j].starttime.getHour() + ":" + events[i, j].starttime.getMin() + "</starttime>\n";
                                    }
                                    else if (events[i, j].starttime.getDayTime() == "PM")
                                    {
                                        xmlgen += "               <starttime>" + getPM(events[i, j].starttime.getHour()) + ":" + events[i, j].starttime.getMin() + "</starttime>\n";
                                    }

                                    if (events[i, j].endtime.getDayTime() == "AM")
                                    {
                                        xmlgen += "               <endtime>" + events[i, j].endtime.getHour() + ":" + events[i, j].endtime.getMin() + "</endtime>\n";
                                    }
                                    else if (events[i, j].endtime.getDayTime() == "PM")
                                    {
                                        xmlgen += "               <endtime>" + getPM(events[i, j].endtime.getHour()) + ":" + events[i, j].endtime.getMin() + "</endtime>\n";
                                    }
                                    xmlgen += "               <location>" + events[i, j].location + "</location>\n";
                                    xmlgen += "          </event>\n";
                                }
                            }
                            catch (NullReferenceException)
                            {
                                //No more events
                            }
                            
                        }
                        
                    }
                    xmlgen += "     </day>\n";
                }
                catch (NullReferenceException)
                {
                    //No data
                }

            }
            xmlgen += "</activity>";
            return xmlgen;
        }
        protected string getPM(string am)
        {
            string pm = "";
            int l = int.Parse(am);
            int p = 0;
            for (int i = 1; i < 12; i++)
            {
                if (l == i)
                {
                    p = i + 12;
                    pm = "" + p;
                    return pm;
                }
                else if(am == "12")
                {
                    pm = "12";
                    return pm;
                }
            }
            return am;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            
            for (int i = eventnum; i < rows; i++)
            {

                try
                {

                    if (eventnum > 1)
                    {

                        events[day, i].name = events[day, i + 1].name;
                        events[day, i + 1].name = null;
                        events[day, i + 1].starttime = null;
                        events[day, i + 1].endtime = null;
                        events[day, i + 1].location = null;
                        if (events[day, eventnum].name.Length > 0)
                        {
                            eventnum--;
                            displayEvent();
                            daylabel.Text = "Day " + day;
                            eventlabel.Text = "Event " + eventnum;
                            textBox1.Focus();
                        }
                        else
                        {
                            clearForm();
                        }
                    }
                    else
                    {
                        events[day, i].name = null;
                        events[day, i].starttime = null;
                        events[day, i].endtime = null;
                        events[day, i].location = null;

                        clearForm();
                    }
                }
                catch (NullReferenceException)
                {

                    try {

                        if (events[day, eventnum].name.Length > 0)
                        {
                            if (eventnum > 1)
                            {
                                events[day, i].name = null;
                                events[day, i].starttime = null;
                                events[day, i].endtime = null;
                                events[day, i].location = null;
                                eventnum--;
                                displayEvent();
                                textBox1.Focus();
                                daylabel.Text = "Day " + day;
                                eventlabel.Text = "Event " + eventnum;
                            }
                        }
                        else
                        {
                            clearForm();
                        }
                    }
                    catch (NullReferenceException)
                    {

                        clearForm();
                    }
                    catch (IndexOutOfRangeException)
                    {
                        clearForm();
                    }
                }

                catch (IndexOutOfRangeException)
                {

                    try
                    {

                        if (events[day, eventnum].name.Length > 0)
                        {
                            eventnum--;
                            displayEvent();
                            daylabel.Text = "Day " + day;
                            eventlabel.Text = "Event " + eventnum;
                            textBox1.Focus();
                        }
                        else
                        {
                            clearForm();
                        }
                    }
                    catch (NullReferenceException)
                    {
                    }
                    catch (IndexOutOfRangeException)
                    {
                    }
                }
            }
  
            xmlOutputWindow = generateXML();
            outputWindow.Text = xmlOutputWindow;
        }

        private void finishButton_Click_1(object sender, EventArgs e)
        {
            xmlOutput = generateXML();
          //  writetofile(xmlOutput);
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Convert.ToString(Environment.SpecialFolder.MyDocuments);
            saveFileDialog1.Filter = "xml (*.xml)|*.xml|All Files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog1.FileName, xmlOutput);//Do what you want here
             //   System.IO.File.WriteAllText(@"C:\Users\jimmy.zars\Desktop\agenda.xml", text);
            }
            // End of File

            this.Close();
        }

        private void clearForm()
        {
            xmlOutputWindow = generateXML();
            outputWindow.Text = xmlOutputWindow;
            textBox1.Text = String.Empty;
            loc.Text = String.Empty;
            sHour.Text = String.Empty;
            sMin.Text = String.Empty;
            eMin.Text = String.Empty;
            eHour.Text = String.Empty;
            daylabel.Text = "Day " + day;
            eventlabel.Text = "Event " + eventnum;
            textBox1.Focus();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Right)
            {
                nextEventButton.PerformClick();
                return true;
            }
            else if (keyData == Keys.Left)
            {
                previousButton.PerformClick();
                return true;
            }
            
            else if (keyData == Keys.Delete)
            {
                deleteButton.PerformClick();
                return true;
            }
           
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}