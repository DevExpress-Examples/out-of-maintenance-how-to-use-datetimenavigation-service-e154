Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler.Drawing
Imports DevExpress.XtraScheduler.Services

Namespace NavigateBackForth
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			CustomizeScheduler()
			DevExpress.Skins.SkinManager.EnableFormSkins()

		End Sub

		Private Sub schedulerControl1_InitAppointmentImages(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.AppointmentImagesEventArgs) Handles schedulerControl1.InitAppointmentImages
			Dim info As AppointmentImageInfo = New AppointmentImageInfo()
			info.Image = Me.sportsImages.Images(e.Appointment.LabelId)
			e.ImageInfoList.Add(info)
		End Sub


		Private Sub btnBack_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBack.Click
			Dim svc As IDateTimeNavigationService = CType(schedulerControl1.GetService(GetType(IDateTimeNavigationService)), IDateTimeNavigationService)
			If Not svc Is Nothing Then
			svc.NavigateBackward()
			End If
		End Sub

		Private Sub btnForth_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnForth.Click
			Dim svc As IDateTimeNavigationService = CType(schedulerControl1.GetService(GetType(IDateTimeNavigationService)), IDateTimeNavigationService)
			If Not svc Is Nothing Then
			svc.NavigateForward()
			End If
		End Sub

		Private Sub schedulerControl1_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles schedulerControl1.Resize
			btnForth.Left = schedulerControl1.Right - btnForth.Width
		End Sub


	End Class
End Namespace