﻿using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Control_Audio
{
    public partial class Form1 : Form
    {
        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0x0a0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x090000;
        private const int WM_APPCOMMAND = 0x319;

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
       
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonVolumeDown_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_DOWN);
        }

        private void buttonVolumeUp_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_UP);
        }

        private void buttonVolumeMute_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_MUTE);
        }
    }
}
