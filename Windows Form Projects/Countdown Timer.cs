using System;
using System.Windows.Forms;

namespace CountdownTimer
{
    public partial class CountdownTimer : Form
    {
        public CountdownTimer()
        {
            InitializeComponent();
        }

        int timeleft = 60;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timeleft > 0)
            {
                timeleft -= 1;
                timerLabel.Text = timeleft + " seconds";
            } else
            {
                timer.Stop();
                timerLabel.Text = "Time is up!";
            }

            if (timeleft == 0) deathLabel.Text = "End of the world...you dead!";
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timeleft = 60;
            timerLabel.Text = timeleft + " seconds";
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            timeleft -= 5;
            timerLabel.Text = timeleft.ToString() + " seconds";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            timeleft += 5;
            timerLabel.Text = timeleft.ToString() + " seconds";
        }
    }
}
