Imports Microsoft.VisualBasic
Imports System
Namespace NavigateBackForth
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim timeRuler3 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
			Dim timeRuler4 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
			Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
			Me.dateNavigator1 = New DevExpress.XtraScheduler.DateNavigator()
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.btnForth = New DevExpress.XtraEditors.SimpleButton()
			Me.btnBack = New DevExpress.XtraEditors.SimpleButton()
			Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' schedulerControl1
			' 
			Me.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.schedulerControl1.Location = New System.Drawing.Point(0, 24)
			Me.schedulerControl1.Name = "schedulerControl1"
			Me.schedulerControl1.Size = New System.Drawing.Size(527, 366)
			Me.schedulerControl1.Start = New System.DateTime(2008, 3, 24, 0, 0, 0, 0)
			Me.schedulerControl1.Storage = Me.schedulerStorage1
			Me.schedulerControl1.TabIndex = 0
			Me.schedulerControl1.Text = "schedulerControl1"
			Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler3)
			Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler4)
'			Me.schedulerControl1.InitAppointmentImages += New DevExpress.XtraScheduler.AppointmentImagesEventHandler(Me.schedulerControl1_InitAppointmentImages);
'			Me.schedulerControl1.Resize += New System.EventHandler(Me.schedulerControl1_Resize);
			' 
			' dateNavigator1
			' 
			Me.dateNavigator1.Dock = System.Windows.Forms.DockStyle.Right
			Me.dateNavigator1.Location = New System.Drawing.Point(527, 24)
			Me.dateNavigator1.Name = "dateNavigator1"
			Me.dateNavigator1.SchedulerControl = Me.schedulerControl1
			Me.dateNavigator1.Size = New System.Drawing.Size(179, 366)
			Me.dateNavigator1.TabIndex = 1
			Me.dateNavigator1.View = DevExpress.XtraEditors.Controls.DateEditCalendarViewType.MonthInfo
			' 
			' defaultLookAndFeel1
			' 
			Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins"
			' 
			' panelControl1
			' 
			Me.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.panelControl1.Appearance.Options.UseBackColor = True
			Me.panelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
			Me.panelControl1.Controls.Add(Me.btnForth)
			Me.panelControl1.Controls.Add(Me.btnBack)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panelControl1.Location = New System.Drawing.Point(0, 390)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(706, 31)
			Me.panelControl1.TabIndex = 2
			' 
			' btnForth
			' 
			Me.btnForth.Image = (CType(resources.GetObject("btnForth.Image"), System.Drawing.Image))
			Me.btnForth.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
			Me.btnForth.Location = New System.Drawing.Point(452, 3)
			Me.btnForth.Name = "btnForth"
			Me.btnForth.Size = New System.Drawing.Size(75, 23)
			Me.btnForth.TabIndex = 1
			Me.btnForth.Text = "Forth"
'			Me.btnForth.Click += New System.EventHandler(Me.btnForth_Click);
			' 
			' btnBack
			' 
			Me.btnBack.Image = (CType(resources.GetObject("btnBack.Image"), System.Drawing.Image))
			Me.btnBack.Location = New System.Drawing.Point(5, 3)
			Me.btnBack.Name = "btnBack"
			Me.btnBack.Size = New System.Drawing.Size(75, 23)
			Me.btnBack.TabIndex = 0
			Me.btnBack.Text = "Back"
'			Me.btnBack.Click += New System.EventHandler(Me.btnBack_Click);
			' 
			' panelControl2
			' 
			Me.panelControl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
			Me.panelControl2.Controls.Add(Me.labelControl1)
			Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl2.Location = New System.Drawing.Point(0, 0)
			Me.panelControl2.Name = "panelControl2"
			Me.panelControl2.Size = New System.Drawing.Size(706, 24)
			Me.panelControl2.TabIndex = 3
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(5, 6)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(433, 13)
			Me.labelControl1.TabIndex = 0
			Me.labelControl1.Text = "Use buttons below the scheduler to navigate a displayed time frame backward or fo" & "rward."
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(706, 421)
			Me.Controls.Add(Me.schedulerControl1)
			Me.Controls.Add(Me.dateNavigator1)
			Me.Controls.Add(Me.panelControl1)
			Me.Controls.Add(Me.panelControl2)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl2.ResumeLayout(False)
			Me.panelControl2.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
		Private schedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
		Private dateNavigator1 As DevExpress.XtraScheduler.DateNavigator
		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents btnForth As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnBack As DevExpress.XtraEditors.SimpleButton
		Private panelControl2 As DevExpress.XtraEditors.PanelControl
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
	End Class
End Namespace

