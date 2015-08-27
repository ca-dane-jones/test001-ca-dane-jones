<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.frmMain_StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.lbl_Status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.flp_Config = New System.Windows.Forms.FlowLayoutPanel()
        Me.gb_Environment = New System.Windows.Forms.GroupBox()
        Me.gb_csvSource = New System.Windows.Forms.GroupBox()
        Me.tb_csvSource = New System.Windows.Forms.TextBox()
        Me.btn_browse = New System.Windows.Forms.Button()
        Me.ofd_csvSource = New System.Windows.Forms.OpenFileDialog()
        Me.tooltip_FormMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.cb_Environment = New System.Windows.Forms.ComboBox()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.frmMain_StatusStrip.SuspendLayout()
        Me.flp_Config.SuspendLayout()
        Me.gb_Environment.SuspendLayout()
        Me.gb_csvSource.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.BottomToolStripPanel
        '
        Me.ToolStripContainer1.BottomToolStripPanel.Controls.Add(Me.frmMain_StatusStrip)
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.flp_Config)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(728, 390)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(728, 439)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'frmMain_StatusStrip
        '
        Me.frmMain_StatusStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.frmMain_StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_Status})
        Me.frmMain_StatusStrip.Location = New System.Drawing.Point(0, 0)
        Me.frmMain_StatusStrip.Name = "frmMain_StatusStrip"
        Me.frmMain_StatusStrip.Size = New System.Drawing.Size(728, 24)
        Me.frmMain_StatusStrip.TabIndex = 0
        '
        'lbl_Status
        '
        Me.lbl_Status.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lbl_Status.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(30, 19)
        Me.lbl_Status.Text = "Idle"
        '
        'flp_Config
        '
        Me.flp_Config.AutoScroll = True
        Me.flp_Config.Controls.Add(Me.gb_Environment)
        Me.flp_Config.Controls.Add(Me.gb_csvSource)
        Me.flp_Config.Location = New System.Drawing.Point(3, 3)
        Me.flp_Config.Name = "flp_Config"
        Me.flp_Config.Size = New System.Drawing.Size(722, 66)
        Me.flp_Config.TabIndex = 5
        '
        'gb_Environment
        '
        Me.gb_Environment.Controls.Add(Me.cb_Environment)
        Me.gb_Environment.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Environment.Location = New System.Drawing.Point(3, 3)
        Me.gb_Environment.Name = "gb_Environment"
        Me.gb_Environment.Size = New System.Drawing.Size(219, 55)
        Me.gb_Environment.TabIndex = 0
        Me.gb_Environment.TabStop = False
        Me.gb_Environment.Text = "Environment"
        '
        'gb_csvSource
        '
        Me.gb_csvSource.Controls.Add(Me.tb_csvSource)
        Me.gb_csvSource.Controls.Add(Me.btn_browse)
        Me.gb_csvSource.Location = New System.Drawing.Point(228, 3)
        Me.gb_csvSource.Name = "gb_csvSource"
        Me.gb_csvSource.Size = New System.Drawing.Size(491, 55)
        Me.gb_csvSource.TabIndex = 1
        Me.gb_csvSource.TabStop = False
        Me.gb_csvSource.Text = "CSV Source"
        '
        'tb_csvSource
        '
        Me.tb_csvSource.Location = New System.Drawing.Point(6, 20)
        Me.tb_csvSource.Name = "tb_csvSource"
        Me.tb_csvSource.ReadOnly = True
        Me.tb_csvSource.Size = New System.Drawing.Size(404, 20)
        Me.tb_csvSource.TabIndex = 6
        '
        'btn_browse
        '
        Me.btn_browse.Location = New System.Drawing.Point(416, 18)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(75, 23)
        Me.btn_browse.TabIndex = 4
        Me.btn_browse.Text = "Browse"
        Me.btn_browse.UseVisualStyleBackColor = True
        '
        'ofd_csvSource
        '
        Me.ofd_csvSource.DefaultExt = "csv"
        Me.ofd_csvSource.Filter = "CSV Files|*.csv|All Files|*.*"
        Me.ofd_csvSource.SupportMultiDottedExtensions = True
        Me.ofd_csvSource.Title = "Select CSV Source File"
        '
        'tooltip_FormMain
        '
        Me.tooltip_FormMain.ShowAlways = True
        '
        'cb_Environment
        '
        Me.cb_Environment.FormattingEnabled = True
        Me.cb_Environment.Location = New System.Drawing.Point(7, 20)
        Me.cb_Environment.Name = "cb_Environment"
        Me.cb_Environment.Size = New System.Drawing.Size(200, 21)
        Me.cb_Environment.TabIndex = 0
        Me.cb_Environment.Text = "Select Environment"
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 439)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "frm_Main"
        Me.Text = "CA Identity Manger Testing Automation"
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.frmMain_StatusStrip.ResumeLayout(False)
        Me.frmMain_StatusStrip.PerformLayout()
        Me.flp_Config.ResumeLayout(False)
        Me.gb_Environment.ResumeLayout(False)
        Me.gb_csvSource.ResumeLayout(False)
        Me.gb_csvSource.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents frmMain_StatusStrip As StatusStrip
    Friend WithEvents lbl_Status As ToolStripStatusLabel
    Friend WithEvents flp_Config As FlowLayoutPanel
    Friend WithEvents tb_csvSource As TextBox
    Friend WithEvents btn_browse As Button
    Friend WithEvents ofd_csvSource As OpenFileDialog
    Friend WithEvents tooltip_FormMain As ToolTip
    Friend WithEvents gb_Environment As GroupBox
    Friend WithEvents gb_csvSource As GroupBox
    Friend WithEvents cb_Environment As ComboBox
End Class
