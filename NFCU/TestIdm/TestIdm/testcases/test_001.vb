Imports System.ComponentModel

Namespace TestCases
    Public Class Test_001
        Inherits System.ComponentModel.BackgroundWorker

        Private Property MyProgress As Byte = 0

        Public Sub New()
            WorkerReportsProgress = True
            WorkerSupportsCancellation = True
        End Sub

        ' This is called when the do work event is raised
        Public Overloads Sub RunWorkerAsync(ByVal sender As System.Object,
        ByVal e As DoWorkEventArgs) Handles Me.DoWork

        End Sub

        ' This event handler updates the progress. 
        Private Sub re_ProgressChanged(increment As Byte)
            'RaiseEvent me.ProgressChanged()
        End Sub

        ' This event handler deals with the results of the background operation. 
        Private Sub backgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object,
        ByVal e As RunWorkerCompletedEventArgs) Handles Me.RunWorkerCompleted

        End Sub
    End Class
End Namespace
