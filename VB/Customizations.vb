Imports Microsoft.VisualBasic
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler.Services
Imports System.Data
Imports System.IO
Imports DevExpress.XtraScheduler
Imports DevExpress.Utils
Imports DevExpress.Utils.Controls
Imports System

Namespace NavigateBackForth
	Partial Public Class Form1
		Inherits Form
		Public Const sportEventsResourceName As String = "NavigateBackForth.Data.sportevents.xml"
		Private sportsImages As ImageCollection
		Private channelsImages As ImageCollection

		Public Sub CustomizeScheduler()
			schedulerControl1.ActiveViewType = SchedulerViewType.Day
			schedulerControl1.Views.DayView.GroupType = SchedulerGroupType.Resource
			schedulerControl1.Views.DayView.ResourcesPerPage = 2
			schedulerControl1.Views.DayView.DayCount = 1
			schedulerControl1.Views.MonthView.ResourcesPerPage = 2
			schedulerControl1.Views.MonthView.WeekCount = 2
			schedulerControl1.Views.TimelineView.ResourcesPerPage = 2
			schedulerControl1.Views.WeekView.ResourcesPerPage = 2
			schedulerControl1.Views.WorkWeekView.ResourcesPerPage = 2
			AddSportChannels()
			FillData()
			schedulerControl1.Start = New DateTime(2008, 03, 12)
			schedulerControl1.DayView.ShowWorkTimeOnly = True
			btnForth.Left = schedulerControl1.Right - btnForth.Width

		End Sub


		Private Sub FillData()
			Me.schedulerStorage1.EnableReminders = False
			Me.schedulerStorage1.Appointments.Mappings.End = "Finish"
			Me.schedulerStorage1.Appointments.Mappings.Label = "SportID"
			Me.schedulerStorage1.Appointments.Mappings.ResourceId = "ResourceID"
			Me.schedulerStorage1.Appointments.Mappings.Start = "Start"
			Me.schedulerStorage1.Appointments.Mappings.Subject = "Caption"
			Me.schedulerStorage1.Appointments.Mappings.AllDay = "AllDay"

			schedulerStorage1.Appointments.DataSource = GetSportEventsData()
		End Sub

		Private Shared Function GetResourceStream(ByVal resourceName As String) As Stream
			Return System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName)
		End Function

		Public Shared Function GetSportEventsData() As DataTable
			Dim sportEventDS As DataSet = New DataSet()
			Using stream As Stream = GetResourceStream(sportEventsResourceName)
				sportEventDS.ReadXml(stream)
				stream.Close()
			End Using
			Return sportEventDS.Tables(0)
		End Function

		Private Sub AddSportChannels()
			Me.sportsImages = ImageHelper.CreateImageCollectionFromResources("NavigateBackForth.Images.sports.png", System.Reflection.Assembly.GetExecutingAssembly(), New Size(16, 16))
			Me.channelsImages = ImageHelper.CreateImageCollectionFromResources("NavigateBackForth.Images.channels.png", System.Reflection.Assembly.GetExecutingAssembly(), New Size(60, 40))

			schedulerStorage1.Resources.BeginUpdate()
			AddResource(0, "Channel 1")
			AddResource(1, "Channel 2")
			AddResource(2, "Channel 3")
			AddResource(3, "Channel 4")
			AddResource(4, "Channel 5")
			AddResource(5, "Channel 6")
			AddResource(6, "Channel 7")
			AddResource(7, "Channel 8")
			schedulerStorage1.Resources.EndUpdate()
		End Sub
		Private Sub AddResource(ByVal index As Integer, ByVal caption As String)
			Dim r As Resource = New Resource(index.ToString(), caption)
			r.Image = Me.channelsImages.Images(index)
			r.Color = schedulerControl1.ResourceColorSchemas.GetSchema(index).CellLight
			schedulerStorage1.Resources.Add(r)
		End Sub
	End Class
End Namespace