<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelection
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSelection))
        Me.cbbYear = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.grpboxChoice = New System.Windows.Forms.GroupBox()
        Me.rbttnOrganizationFees = New System.Windows.Forms.RadioButton()
        Me.rbttnStudentFees = New System.Windows.Forms.RadioButton()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.pnlYear = New System.Windows.Forms.Panel()
        Me.cbbOrganization = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpboxChoice.SuspendLayout()
        Me.pnlYear.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbbYear
        '
        Me.cbbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbYear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbYear.FormattingEnabled = True
        Me.cbbYear.Items.AddRange(New Object() {"1st", "2nd", "3rd", "4th", "5th"})
        Me.cbbYear.Location = New System.Drawing.Point(57, 9)
        Me.cbbYear.Name = "cbbYear"
        Me.cbbYear.Size = New System.Drawing.Size(238, 29)
        Me.cbbYear.TabIndex = 0
        Me.cbbYear.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Year"
        Me.Label1.Visible = False
        '
        'btnEnter
        '
        Me.btnEnter.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Location = New System.Drawing.Point(12, 134)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(301, 39)
        Me.btnEnter.TabIndex = 4
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'grpboxChoice
        '
        Me.grpboxChoice.Controls.Add(Me.rbttnOrganizationFees)
        Me.grpboxChoice.Controls.Add(Me.rbttnStudentFees)
        Me.grpboxChoice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpboxChoice.ForeColor = System.Drawing.Color.White
        Me.grpboxChoice.Location = New System.Drawing.Point(12, 5)
        Me.grpboxChoice.Name = "grpboxChoice"
        Me.grpboxChoice.Size = New System.Drawing.Size(301, 66)
        Me.grpboxChoice.TabIndex = 5
        Me.grpboxChoice.TabStop = False
        Me.grpboxChoice.Text = "Selection"
        '
        'rbttnOrganizationFees
        '
        Me.rbttnOrganizationFees.AutoSize = True
        Me.rbttnOrganizationFees.Location = New System.Drawing.Point(139, 28)
        Me.rbttnOrganizationFees.Name = "rbttnOrganizationFees"
        Me.rbttnOrganizationFees.Size = New System.Drawing.Size(153, 25)
        Me.rbttnOrganizationFees.TabIndex = 1
        Me.rbttnOrganizationFees.TabStop = True
        Me.rbttnOrganizationFees.Text = "Organization Fees"
        Me.rbttnOrganizationFees.UseVisualStyleBackColor = True
        '
        'rbttnStudentFees
        '
        Me.rbttnStudentFees.AutoSize = True
        Me.rbttnStudentFees.Location = New System.Drawing.Point(6, 28)
        Me.rbttnStudentFees.Name = "rbttnStudentFees"
        Me.rbttnStudentFees.Size = New System.Drawing.Size(117, 25)
        Me.rbttnStudentFees.TabIndex = 0
        Me.rbttnStudentFees.TabStop = True
        Me.rbttnStudentFees.Text = "Student Fees"
        Me.rbttnStudentFees.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'pnlYear
        '
        Me.pnlYear.Controls.Add(Me.cbbOrganization)
        Me.pnlYear.Controls.Add(Me.cbbYear)
        Me.pnlYear.Controls.Add(Me.Label2)
        Me.pnlYear.Controls.Add(Me.Label1)
        Me.pnlYear.Location = New System.Drawing.Point(12, 77)
        Me.pnlYear.Name = "pnlYear"
        Me.pnlYear.Size = New System.Drawing.Size(301, 51)
        Me.pnlYear.TabIndex = 2
        '
        'cbbOrganization
        '
        Me.cbbOrganization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbOrganization.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbOrganization.FormattingEnabled = True
        Me.cbbOrganization.Location = New System.Drawing.Point(103, 9)
        Me.cbbOrganization.Name = "cbbOrganization"
        Me.cbbOrganization.Size = New System.Drawing.Size(192, 29)
        Me.cbbOrganization.TabIndex = 0
        Me.cbbOrganization.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Oganization"
        Me.Label2.Visible = False
        '
        'frmSelection
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(325, 181)
        Me.Controls.Add(Me.grpboxChoice)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.pnlYear)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSelection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "College Of Education - Selection"
        Me.grpboxChoice.ResumeLayout(False)
        Me.grpboxChoice.PerformLayout()
        Me.pnlYear.ResumeLayout(False)
        Me.pnlYear.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbbYear As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents grpboxChoice As System.Windows.Forms.GroupBox
    Friend WithEvents rbttnStudentFees As System.Windows.Forms.RadioButton
    Friend WithEvents rbttnOrganizationFees As System.Windows.Forms.RadioButton
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents pnlYear As System.Windows.Forms.Panel
    Friend WithEvents cbbOrganization As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
