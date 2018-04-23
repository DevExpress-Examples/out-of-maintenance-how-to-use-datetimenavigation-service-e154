using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraScheduler.Drawing;
using DevExpress.XtraScheduler.Services;

namespace NavigateBackForth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CustomizeScheduler();
            DevExpress.Skins.SkinManager.EnableFormSkins();

        }

        private void schedulerControl1_InitAppointmentImages(object sender, DevExpress.XtraScheduler.AppointmentImagesEventArgs e)
        {
            AppointmentImageInfo info = new AppointmentImageInfo();
            info.Image = this.sportsImages.Images[e.Appointment.LabelId];
            e.ImageInfoList.Add(info);
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            IDateTimeNavigationService svc = (IDateTimeNavigationService)schedulerControl1.GetService(typeof(IDateTimeNavigationService));
            if (svc != null)svc.NavigateBackward();            
        }

        private void btnForth_Click(object sender, EventArgs e)
        {
            IDateTimeNavigationService svc = (IDateTimeNavigationService)schedulerControl1.GetService(typeof(IDateTimeNavigationService));
            if (svc != null) svc.NavigateForward();  
        }

        private void schedulerControl1_Resize(object sender, EventArgs e)
        {
            btnForth.Left = schedulerControl1.Right - btnForth.Width;
        }


    }
}