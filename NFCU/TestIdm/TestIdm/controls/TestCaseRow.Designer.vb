<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestCaseRow
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.cb_selected = New System.Windows.Forms.CheckBox()
        Me.progressBar = New System.Windows.Forms.ProgressBar()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.cb_selected)
        Me.FlowLayoutPanel1.Controls.Add(Me.progressBar)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_cancel)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(358, 30)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'cb_selected
        '
        Me.cb_selected.Location = New System.Drawing.Point(3, 6)
        Me.cb_selected.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.cb_selected.Name = "cb_selected"
        Me.cb_selected.Size = New System.Drawing.Size(114, 18)
        Me.cb_selected.TabIndex = 0
        Me.cb_selected.Text = "Test Case Name"
        Me.cb_selected.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.cb_selected.UseVisualStyleBackColor = True
        '
        'progressBar
        '
        Me.progressBar.Location = New System.Drawing.Point(123, 6)
        Me.progressBar.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(151, 18)
        Me.progressBar.TabIndex = 1
        '
        'btn_cancel
        '
        Me.btn_cancel.Enabled = False
        Me.btn_cancel.Location = New System.Drawing.Point(280, 3)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 24)
        Me.btn_cancel.TabIndex = 2
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'TestCaseRow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "TestCaseRow"
        Me.Size = New System.Drawing.Size(358, 30)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents cb_selected As CheckBox
    Friend WithEvents progressBar As ProgressBar
    Friend WithEvents btn_cancel As Button
End Class
