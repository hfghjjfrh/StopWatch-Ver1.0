using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class StopWatch : Form
    {
        public StopWatch()
        {
            InitializeComponent();
            _timer1.Interval = 100;
            _timer1.Tick += timer1_tick;
            Start.Enabled = true;
            Stop.Enabled = false;
            Status.Minimum = 0;
            Status.Maximum = 0;
            Status.Value = 0;

        }
        Timer _timer1 = new Timer();
        TimeSpan _timespan = new TimeSpan(0);

      
        private void timer1_tick(object sender, EventArgs e)
        {
                TimeSpan timespan = DateTime.Now - sn + _timespan;
                display.Text = string.Format("{0:00}:{1:00}:{2:00}", timespan.Hours, timespan.Minutes, timespan.Seconds);
        }    
        DateTime sn = DateTime.Now;
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timespan = DateTime.Now - sn + _timespan;
            display.Text = string.Format("{0:00}:{1:00}:{2:00}", timespan.Hours, timespan.Minutes, timespan.Seconds);
        }
        private void Start_Click(object sender, EventArgs e)
        {
            Start.Enabled = false;
            Stop.Enabled = true;
           
            
            try
            {
                SoundPlayer simpleSound = new SoundPlayer(@"..\..\sound\chimes.wav");
                simpleSound.Play();
            }
            catch(System.IO.FileNotFoundException) 
            {
                MessageBox.Show("サウンドファイルが見つかりません。\nファイルが指定の場所にあるか確認してください。\n","エラー");
            }
            _timer1.Start();
            sn = DateTime.Now;
            Status.Style = ProgressBarStyle.Marquee;
            Status.Maximum = 10;
            Status.MarqueeAnimationSpeed = 30;
        }
        private void Stop_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer simpleSound = new SoundPlayer(@"..\..\sound\chimes.wav");
                simpleSound.Play();
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("サウンドファイルが見つかりません。\nファイルが指定の場所にあるか確認してください。\n", "エラー");
            }

            Start.Enabled = true;
            _timer1.Stop();
            _timespan += DateTime.Now - sn;
            Start.Enabled = true;
            Stop.Enabled = false;
            Status.Style = ProgressBarStyle.Marquee;
            Status.MarqueeAnimationSpeed = 0;

            

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer simpleSound = new SoundPlayer(@"..\..\sound\notify.wav");
                simpleSound.Play();
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("サウンドファイルが見つかりません。\nファイルが指定の場所にあるか確認してください。\n", "エラー");
            }

            Start.Enabled = true;
            Stop.Enabled = false;
            Status.Minimum = 0;
            Status.Maximum = 0;
            Status.Value = 0;
            _timer1.Stop();
            _timespan = new TimeSpan(0);
            sn = DateTime.Now;
            display.Text = string.Format("{0:00}:{1:00}:{2:00}", _timespan.Hours, _timespan.Minutes, _timespan.Seconds);
        }

        
    }
}
