﻿Imports System.Windows.Forms

Namespace WinPivot_GettingStarted
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            ' This line of code is generated by Data Source Configuration Wizard
            salesPersonTableAdapter1.Fill(nwindDataSet1.SalesPerson)
        End Sub
    End Class
End Namespace
