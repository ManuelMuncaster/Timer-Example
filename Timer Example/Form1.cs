using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_Example
{
    public partial class Form1 : Form
    {
        int milliseconds = 0;
        int seconds = 0;
        int minutes = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (countTimer.Enabled == true)
            {
                countTimer.Enabled = false;
            }
            else
            {
                countTimer.Enabled = true;
            }
        }

        private void countTimer_Tick(object sender, EventArgs e)
        {
            #region changing background color
            //if (this.BackColor == Color.Black)
            //{
            //    this.BackColor = Color.White;
            //}
            //else
            //{
            //  this.BackColor = Color.Black;
            //}
            #endregion

            //Increase timer counter
            milliseconds++;

            //Update time values
            if (milliseconds == 100)
            {
                seconds++;
                milliseconds = 0;
            }
            if (seconds == 60)
            {
                minutes++;
                seconds = 0;
            }

            //Update displays
            milliLabel.Text = milliseconds.ToString(":00");
            secLabel.Text = seconds.ToString(":00");
            minLabel.Text = minutes + "0";
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if (countTimer.Enabled == false)
            {
                //clear screen outputs
                milliLabel.Text = ":00";
                secLabel.Text = ":00";
                minLabel.Text = "0";
                //clear variables
                milliseconds = 0;
                seconds = 0;
                minutes = 0;
            }
        }
    }
}
