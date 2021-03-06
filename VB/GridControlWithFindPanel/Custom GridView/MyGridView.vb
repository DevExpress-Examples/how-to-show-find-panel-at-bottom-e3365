﻿Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Controls

Namespace GridControlWithFindPanel
	Public Class MyGridView
		Inherits GridView
		Public Sub New()
			Me.New(Nothing)
		End Sub

		Public Sub New(ByVal grid As GridControl)
			MyBase.New(grid)
			' put your initialization code here
		End Sub

		Protected Overrides ReadOnly Property ViewName() As String
			Get
				Return "MyGridView"
			End Get
		End Property

		Private showFindPanelOnTop_Renamed As Boolean
		Public Overridable Property ShowFindPanelOnTop() As Boolean
			Get
				Return showFindPanelOnTop_Renamed
			End Get
			Set(ByVal value As Boolean)
				If value = showFindPanelOnTop_Renamed Then
					Return
				End If
				showFindPanelOnTop_Renamed = value
				HideFindPanel()
				ShowFindPanel()
			End Set
		End Property

		Private privateFindPanelHeight As Integer
		Public Property FindPanelHeight() As Integer
			Get
				Return privateFindPanelHeight
			End Get
			Private Set(ByVal value As Integer)
				privateFindPanelHeight = value
			End Set
		End Property

		Protected Overrides Function CreateFindPanel(ByVal findPanelProperties As Object) As FindControl
			Dim findControl As New FindControl(Me, findPanelProperties)
			FindPanelHeight = findControl.Height
			Return findControl
		End Function
	End Class
End Namespace