Public Class frm_Main
    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
        'display open file dialog
        If (ofd_csvSource.ShowDialog() = DialogResult.OK) Then
            tb_csvSource.Text = ofd_csvSource.FileName
            tb_csvSource.Update()
        End If
    End Sub

    Private Sub tb_csvSource_TextChanged(sender As Object, e As EventArgs) Handles tb_csvSource.TextChanged
        tooltip_FormMain.SetToolTip(tb_csvSource, tb_csvSource.Text)
        If String.IsNullOrWhiteSpace(tb_csvSource.Text) Then
            tooltip_FormMain.RemoveAll()
        End If
    End Sub

    Private Sub cb_Environment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Environment.SelectedIndexChanged

    End Sub

    Private Sub cb_Environment_ContextMenuStripChanged(sender As Object, e As EventArgs) Handles cb_Environment.Click
        If cb_Environment.Items.Count = 0 Then
            Dim _srv As New Xml.Servers()

            For Each env In _srv.Environments
                cb_Environment.Items.Add(env)
            Next

            cb_Environment.Update()
        End If
    End Sub
End Class
