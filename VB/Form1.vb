Imports DevExpress.Utils
Imports DevExpress.Utils.Controls
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Drawing
Imports DevExpress.XtraScheduler.Services
Imports System
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms

Namespace NavigateBackForth
    Partial Public Class Form1
        Inherits Form

        Public Const sportEventsResourceName As String = "NavigateBackForth.Data.sportevents.xml"
        Private sportsImages As ImageCollection
        Private channelsImages As ImageCollection

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            CustomizeScheduler()
            DevExpress.Skins.SkinManager.EnableFormSkins()
        End Sub

        Private Sub btnBack_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBack.Click
            Dim svc As IDateTimeNavigationService = schedulerControl1.GetService(Of IDateTimeNavigationService)()
            If svc IsNot Nothing Then
                svc.NavigateBackward()
            End If
            ' You can also use the following code to navigate backward.
            'schedulerControl1.Services.DateTimeNavigation.NavigateBackward(); 
        End Sub

        Private Sub btnForth_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnForth.Click
'            #Region "#IDateTimeNavigationService"
            Dim svc As IDateTimeNavigationService = schedulerControl1.GetService(Of IDateTimeNavigationService)()
            If svc IsNot Nothing Then
                svc.NavigateForward()
            End If
            ' You can also use the following code to navigate forward.
            'schedulerControl1.Services.DateTimeNavigation.NavigateForward();
'            #End Region ' #IDateTimeNavigationService
        End Sub

        #Region "Customization"
        Private Sub schedulerControl1_InitAppointmentImages(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.AppointmentImagesEventArgs) Handles schedulerControl1.InitAppointmentImages
            Dim info As New AppointmentImageInfo()
            info.Image = Me.sportsImages.Images(e.Appointment.LabelId)
            e.ImageInfoList.Add(info)
        End Sub

        Private Sub schedulerControl1_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles schedulerControl1.Resize
            btnForth.Left = schedulerControl1.Right - btnForth.Width
        End Sub

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
            schedulerControl1.Start = New Date(2015, 03, 12)
            schedulerControl1.DayView.ShowWorkTimeOnly = True
            btnForth.Left = schedulerControl1.Right - btnForth.Width

        End Sub

        Public Sub FillData()
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
            Dim sportEventDS As New DataSet()
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
            Dim r As New Resource(index.ToString(), caption)
            r.Image = Me.channelsImages.Images(index)
            r.Color = schedulerControl1.ResourceColorSchemas.GetSchema(index).CellLight
            schedulerStorage1.Resources.Add(r)
        End Sub
        #End Region ' Customization
    End Class
End Namespace