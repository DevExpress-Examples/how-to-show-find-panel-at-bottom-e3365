﻿Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace GridControlWithFindPanel
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			Dim rnd As New Random()
			Dim table As New DataTable()
			table.Columns.Add("Value1")
			table.Columns.Add("Value2")
			For i As Integer = 0 To rnd.Next(100) - 1
				table.Rows.Add(New Object() { "Custom" & rnd.Next(15), "Address" & rnd.Next(20) })
			Next i
			myGridControl1.DataSource = table
			checkBox1.Checked = myGridView1.ShowFindPanelOnTop
		End Sub

		Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
			myGridView1.ShowFindPanelOnTop = checkBox1.Checked
		End Sub
	End Class
End Namespace
