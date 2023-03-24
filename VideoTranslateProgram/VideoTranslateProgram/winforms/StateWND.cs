using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoTranslateProgram.winforms
{
    public partial class StateWND : Form
    {
        public enum state { toAudio, upload, recognition, translate, render, finished };
        state currentState;
        public state CurrentState
        {
            get { return currentState; }
            set { currentState = value; }
        }
        public StateWND()
        {
            InitializeComponent();
        }
        private void ProgressTimer_Tick(object sender, EventArgs e)
        {
            progressbar.Width += 5;
            int mWidth;
            switch (currentState)
            {
                case state.toAudio:
                    mWidth = progressbar.MaximumSize.Width / 5;
                    break;
                case state.upload:
                    mWidth = progressbar.MaximumSize.Width * 2 / 5;
                    break;
                case state.recognition:
                    mWidth = progressbar.MaximumSize.Width * 3 / 5;
                    break;
                case state.translate:
                    mWidth = progressbar.MaximumSize.Width * 4 / 5;
                    break;
                case state.render:
                    mWidth = progressbar.MaximumSize.Width;
                    break;
                default:
                    mWidth = progressbar.MaximumSize.Width / 5;
                    break;
            }
            if (progressbar.Width == mWidth)
            {
                progressTimer.Stop();
            }
        }

        public void updateState(state s)
        {
            currentState = s;
            labelState.Text = s.ToString();
            if (s == state.finished)
            {
                Close();
            }
            progressTimer.Start();
        }
    }
}
