using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraScheduler.Services;
using System.Data;
using System.IO;
using DevExpress.XtraScheduler;
using DevExpress.Utils;
using DevExpress.Utils.Controls;
using System;

namespace NavigateBackForth
{
    public partial class Form1 : Form
    {
        public const string sportEventsResourceName = "NavigateBackForth.Data.sportevents.xml";
        ImageCollection sportsImages;
        ImageCollection channelsImages;

        public void CustomizeScheduler()
        {
            schedulerControl1.ActiveViewType = SchedulerViewType.Day;
            schedulerControl1.Views.DayView.GroupType = SchedulerGroupType.Resource;
            schedulerControl1.Views.DayView.ResourcesPerPage = 2;
            schedulerControl1.Views.DayView.DayCount = 1;
            schedulerControl1.Views.MonthView.ResourcesPerPage = 2;
            schedulerControl1.Views.MonthView.WeekCount = 2;
            schedulerControl1.Views.TimelineView.ResourcesPerPage = 2;
            schedulerControl1.Views.WeekView.ResourcesPerPage = 2;
            schedulerControl1.Views.WorkWeekView.ResourcesPerPage = 2;
            AddSportChannels();
            FillData();
            schedulerControl1.Start = new DateTime(2008, 03, 12);
            schedulerControl1.DayView.ShowWorkTimeOnly = true;
            btnForth.Left = schedulerControl1.Right - btnForth.Width;

        }


        void FillData()
        {
            this.schedulerStorage1.EnableReminders = false;
            this.schedulerStorage1.Appointments.Mappings.End = "Finish";
            this.schedulerStorage1.Appointments.Mappings.Label = "SportID";
            this.schedulerStorage1.Appointments.Mappings.ResourceId = "ResourceID";
            this.schedulerStorage1.Appointments.Mappings.Start = "Start";
            this.schedulerStorage1.Appointments.Mappings.Subject = "Caption";
            this.schedulerStorage1.Appointments.Mappings.AllDay = "AllDay";

            schedulerStorage1.Appointments.DataSource = GetSportEventsData();
        }

        static Stream GetResourceStream(string resourceName)
        {
            return System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName);
        }

        public static DataTable GetSportEventsData()
        {
            DataSet sportEventDS = new DataSet();
            using (Stream stream = GetResourceStream(sportEventsResourceName))
            {
                sportEventDS.ReadXml(stream);
                stream.Close();
            }
            return sportEventDS.Tables[0];
        }

        void AddSportChannels()
        {
            this.sportsImages = ImageHelper.CreateImageCollectionFromResources("NavigateBackForth.Images.sports.png", System.Reflection.Assembly.GetExecutingAssembly(), new Size(16, 16));
            this.channelsImages = ImageHelper.CreateImageCollectionFromResources("NavigateBackForth.Images.channels.png", System.Reflection.Assembly.GetExecutingAssembly(), new Size(60, 40));

            schedulerStorage1.Resources.BeginUpdate();
            AddResource(0, "Channel 1");
            AddResource(1, "Channel 2");
            AddResource(2, "Channel 3");
            AddResource(3, "Channel 4");
            AddResource(4, "Channel 5");
            AddResource(5, "Channel 6");
            AddResource(6, "Channel 7");
            AddResource(7, "Channel 8");
            schedulerStorage1.Resources.EndUpdate();
        }
        void AddResource(int index, string caption)
        {
            Resource r = new Resource(index.ToString(), caption);
            r.Image = this.channelsImages.Images[index];
            r.Color = schedulerControl1.ResourceColorSchemas.GetSchema(index).CellLight;
            schedulerStorage1.Resources.Add(r);
        }
    }
}