using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsXproduction
{
    public partial class FormMain : Form
    {
        #region variables
            public OpenFileDialog archive = new OpenFileDialog();
            int play = 0;
            string route;
            bool confirmTimerTick = false; 
        #endregion

        public FormMain()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            // finishing the app
            this.Close();
        }

        private void mtb_main_ValueChanged(object sender, decimal value)
        {
            if (wmp_main.URL != "" && wmp_main.URL != null)
            {
                mtb_main.Maximum = (int)wmp_main.currentMedia.duration;
            }

            if (mtb_main.Value == (int)wmp_main.Ctlcontrols.currentPosition)
            {

            }
            else
            {
                wmp_main.Ctlcontrols.currentPosition = mtb_main.Value;
            }
        }

        private void lbl_startTime_Click(object sender, EventArgs e)
        {

        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            // logic of the button play/pause
            
             if(play == 1)
             {

                 OpenMusic();
                 play = 2;
             }
             else if(play == 2) 
             {
                        
                 wmp_main.Ctlcontrols.pause();
                 tmSlider.Stop();

                btn_play.BackgroundImage = Properties.Resources.play_ico;
                 play = 3;
             }
             else if(play == 3)
             {
                 wmp_main.Ctlcontrols.play();
                 tmSlider.Start();

                btn_play.BackgroundImage = Properties.Resources.pause_ico;
                play = 2;
             }


        }

        public void OpenMusic()
        {
            try
            {
                wmp_main.URL = @"" + route;
                wmp_main.Ctlcontrols.play();

                this.Visible = true;
                tmSlider.Start();

                mtb_main.Enabled = true;

                //commented code forward
            }
            catch
            {
            }
        }

        private void tmSlider_Tick(object sender, EventArgs e)
        {
            try
            {
                if (confirmTimerTick)
                {
                    mtb_main.Value = (int)wmp_main.Ctlcontrols.currentPosition;
                    lbl_startTime.Text = wmp_main.Ctlcontrols.currentPositionString;
                    lbl_endTime.Text = wmp_main.currentMedia.durationString;
                }
            }
            catch
            {
                throw;
            }
        }

        private void btn_forward_Click(object sender, EventArgs e)
        {
            //Back 15 seconds
            if ((mtb_main.Value -= 15) < 0)
            {
                mtb_main.Value = 0;
            } 
            else
            {
                mtb_main.Value -= 15;
            }
        }

        public bool OpenArchive()
        {
            archive.Filter = "Archive files|*.mp3;*.mp4;*.wmv;.*;";
            DialogResult result = archive.ShowDialog();

            if (result == DialogResult.Abort) 
                return false;

            if (result == DialogResult.Cancel) 
                return false;

            route = archive.FileName;
            lbl_archiveTitle.Text = archive.SafeFileName;
            btn_play.BackgroundImage = Properties.Resources.pause_ico;
            return true;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                confirmTimerTick = OpenArchive();

                if (route != "")
                {
                    play = 2;
                    OpenMusic();

                }
                else
                {

                }
            }
            catch
            {
                throw;
            }
        }

        private void mtb_vol_ValueChanged(object sender, decimal value)
        {
            wmp_main.settings.volume = mtb_vol.Value;
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            //forward 10 seconds
            if ((mtb_main.Value += 10) > mtb_main.Maximum)
            {
                mtb_main.Value = 100;
            }
            else
            {
                mtb_main.Value += 10;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //adjust the uiDisplay of the windows Media player
            this.wmp_main.uiMode = "none";
        }

        private void lbl_endTime_Click(object sender, EventArgs e)
        {

        }
    }
}
