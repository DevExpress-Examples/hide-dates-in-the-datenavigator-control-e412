﻿Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsApplication22
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            Me.dateNavigator1.InactiveDaysVisibility = DevExpress.XtraEditors.Controls.CalendarInactiveDaysVisibility.Hidden
        End Sub
    End Class
End Namespace