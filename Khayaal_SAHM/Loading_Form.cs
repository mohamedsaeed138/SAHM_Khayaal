﻿using System;
using System.Threading;
using System.Windows.Forms;

namespace Khayaal_SAHM
{
    public partial class Loading_Screen_Form : Form
    {


        public Loading_Screen_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                timer1.Interval += 1000;

                if (timer1.Interval > 3000)
                {
                    timer1.Stop();

                    Thread login_Start_Thread = new Thread(Start_A_Login_Form);
                    login_Start_Thread.SetApartmentState(ApartmentState.STA);
                    login_Start_Thread.Start();

                    this.Close();
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        static void Start_A_Login_Form()
        {
            Application.Run(new Login_Form());
        }

    }
}
