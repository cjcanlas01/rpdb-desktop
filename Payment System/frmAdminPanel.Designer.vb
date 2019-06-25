<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminPanel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminPanel))
        Me.grpboxManagePanel = New System.Windows.Forms.GroupBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnBackUp = New System.Windows.Forms.Button()
        Me.grpboxManagePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpboxManagePanel
        '
        Me.grpboxManagePanel.Controls.Add(Me.btnReset)
        Me.grpboxManagePanel.Controls.Add(Me.btnBackUp)
        Me.grpboxManagePanel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpboxManagePanel.ForeColor = System.Drawing.Color.White
        Me.grpboxManagePanel.Location = New System.Drawing.Point(12, 12)
        Me.grpboxManagePanel.Name = "grpboxManagePanel"
        Me.grpboxManagePanel.Size = New System.Drawing.Size(353, 239)
        Me.grpboxManagePanel.TabIndex = 6
        Me.grpboxManagePanel.TabStop = False
        Me.grpboxManagePanel.Text = "Database Record"
        '
        'btnReset
        '
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.Black
        Me.btnReset.Location = New System.Drawing.Point(11, 36)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(330, 90)
        Me.btnReset.TabIndex = 24
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnBackUp
        '
        Me.btnBackUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBackUp.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackUp.ForeColor = System.Drawing.Color.Black
        Me.btnBackUp.Location = New System.Drawing.Point(11, 132)
        Me.btnBackUp.Name = "btnBackUp"
        Me.btnBackUp.Size = New System.Drawing.Size(330, 90)
        Me.btnBackUp.TabIndex = 23
        Me.btnBackUp.Text = "BACK UP"
        Me.btnBackUp.UseVisualStyleBackColor = True
        '
        'frmAdminPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(378, 262)
        Me.Controls.Add(Me.grpboxManagePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAdminPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "College of Education - Management Panel"
        Me.grpboxManagePanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpboxManagePanel As System.Windows.Forms.GroupBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnBackUp As System.Windows.Forms.Button
End Class
