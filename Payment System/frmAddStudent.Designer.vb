<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddStudent))
        Me.cbbGender = New System.Windows.Forms.ComboBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.cbbYear = New System.Windows.Forms.ComboBox()
        Me.cbbBlock = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbbCourse = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtExtname = New System.Windows.Forms.TextBox()
        Me.txtMname = New System.Windows.Forms.TextBox()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.txtStudNo = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.pnlStudent = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbbOrganization3 = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbbOrganization2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbbOrganization1 = New System.Windows.Forms.ComboBox()
        Me.bttnEdit = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.pnlStudent.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbbGender
        '
        Me.cbbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbGender.FormattingEnabled = True
        Me.cbbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbbGender.Location = New System.Drawing.Point(159, 236)
        Me.cbbGender.Name = "cbbGender"
        Me.cbbGender.Size = New System.Drawing.Size(217, 29)
        Me.cbbGender.TabIndex = 6
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(157, 356)
        Me.txtContact.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtContact.MaxLength = 11
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(217, 29)
        Me.txtContact.TabIndex = 10
        '
        'cbbYear
        '
        Me.cbbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbYear.FormattingEnabled = True
        Me.cbbYear.Items.AddRange(New Object() {"1st", "2nd", "3rd", "4th", "5th"})
        Me.cbbYear.Location = New System.Drawing.Point(159, 315)
        Me.cbbYear.Name = "cbbYear"
        Me.cbbYear.Size = New System.Drawing.Size(86, 29)
        Me.cbbYear.TabIndex = 8
        '
        'cbbBlock
        '
        Me.cbbBlock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbBlock.FormattingEnabled = True
        Me.cbbBlock.Items.AddRange(New Object() {"", "A", "B", "C", "D", "E"})
        Me.cbbBlock.Location = New System.Drawing.Point(309, 315)
        Me.cbbBlock.Name = "cbbBlock"
        Me.cbbBlock.Size = New System.Drawing.Size(67, 29)
        Me.cbbBlock.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(29, 359)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 21)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Contact"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(29, 320)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 21)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Year"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(255, 318)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 21)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Block"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(29, 277)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 21)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Course"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, 198)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 21)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Extension Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 114)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 21)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "First Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 156)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 21)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Middle Name"
        '
        'cbbCourse
        '
        Me.cbbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbCourse.FormattingEnabled = True
        Me.cbbCourse.Items.AddRange(New Object() {"BSED", "BEED"})
        Me.cbbCourse.Location = New System.Drawing.Point(159, 274)
        Me.cbbCourse.Name = "cbbCourse"
        Me.cbbCourse.Size = New System.Drawing.Size(217, 29)
        Me.cbbCourse.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 239)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 21)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Gender"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 71)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Last Name"
        '
        'txtExtname
        '
        Me.txtExtname.Location = New System.Drawing.Point(159, 195)
        Me.txtExtname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtExtname.Name = "txtExtname"
        Me.txtExtname.Size = New System.Drawing.Size(217, 29)
        Me.txtExtname.TabIndex = 5
        '
        'txtMname
        '
        Me.txtMname.Location = New System.Drawing.Point(159, 153)
        Me.txtMname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMname.Name = "txtMname"
        Me.txtMname.Size = New System.Drawing.Size(217, 29)
        Me.txtMname.TabIndex = 4
        '
        'txtLname
        '
        Me.txtLname.Location = New System.Drawing.Point(159, 68)
        Me.txtLname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(217, 29)
        Me.txtLname.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.ShapeContainer2)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 52)
        Me.Panel1.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(82, 13)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(237, 25)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "STUDENT INFORMATION"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer2.Size = New System.Drawing.Size(396, 48)
        Me.ShapeContainer2.TabIndex = 27
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.SystemColors.Control
        Me.LineShape4.BorderWidth = 5
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 394
        Me.LineShape4.X2 = 394
        Me.LineShape4.Y1 = 5
        Me.LineShape4.Y2 = 43
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.Control
        Me.LineShape3.BorderWidth = 5
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 3
        Me.LineShape3.X2 = 3
        Me.LineShape3.Y1 = 5
        Me.LineShape3.Y2 = 43
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.LineShape2.BorderWidth = 5
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 0
        Me.LineShape2.X2 = 397
        Me.LineShape2.Y1 = 2
        Me.LineShape2.Y2 = 2
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.LineShape1.BorderWidth = 5
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 0
        Me.LineShape1.X2 = 397
        Me.LineShape1.Y1 = 46
        Me.LineShape1.Y2 = 46
        '
        'txtFname
        '
        Me.txtFname.Location = New System.Drawing.Point(159, 111)
        Me.txtFname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(217, 29)
        Me.txtFname.TabIndex = 3
        '
        'txtStudNo
        '
        Me.txtStudNo.Location = New System.Drawing.Point(159, 25)
        Me.txtStudNo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtStudNo.MaxLength = 7
        Me.txtStudNo.Name = "txtStudNo"
        Me.txtStudNo.Size = New System.Drawing.Size(217, 29)
        Me.txtStudNo.TabIndex = 1
        '
        'btnBack
        '
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(259, 516)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(118, 42)
        Me.btnBack.TabIndex = 36
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student No."
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(33, 516)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(118, 42)
        Me.btnSave.TabIndex = 35
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'pnlStudent
        '
        Me.pnlStudent.BackColor = System.Drawing.Color.Silver
        Me.pnlStudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlStudent.Controls.Add(Me.Label14)
        Me.pnlStudent.Controls.Add(Me.cbbOrganization3)
        Me.pnlStudent.Controls.Add(Me.Label13)
        Me.pnlStudent.Controls.Add(Me.cbbOrganization2)
        Me.pnlStudent.Controls.Add(Me.Label2)
        Me.pnlStudent.Controls.Add(Me.cbbOrganization1)
        Me.pnlStudent.Controls.Add(Me.cbbGender)
        Me.pnlStudent.Controls.Add(Me.btnBack)
        Me.pnlStudent.Controls.Add(Me.txtContact)
        Me.pnlStudent.Controls.Add(Me.cbbYear)
        Me.pnlStudent.Controls.Add(Me.cbbBlock)
        Me.pnlStudent.Controls.Add(Me.Label12)
        Me.pnlStudent.Controls.Add(Me.Label11)
        Me.pnlStudent.Controls.Add(Me.Label10)
        Me.pnlStudent.Controls.Add(Me.Label9)
        Me.pnlStudent.Controls.Add(Me.Label8)
        Me.pnlStudent.Controls.Add(Me.Label7)
        Me.pnlStudent.Controls.Add(Me.Label6)
        Me.pnlStudent.Controls.Add(Me.cbbCourse)
        Me.pnlStudent.Controls.Add(Me.Label5)
        Me.pnlStudent.Controls.Add(Me.Label3)
        Me.pnlStudent.Controls.Add(Me.txtExtname)
        Me.pnlStudent.Controls.Add(Me.txtMname)
        Me.pnlStudent.Controls.Add(Me.txtFname)
        Me.pnlStudent.Controls.Add(Me.txtLname)
        Me.pnlStudent.Controls.Add(Me.txtStudNo)
        Me.pnlStudent.Controls.Add(Me.Label1)
        Me.pnlStudent.Controls.Add(Me.btnSave)
        Me.pnlStudent.Controls.Add(Me.bttnEdit)
        Me.pnlStudent.Location = New System.Drawing.Point(2, 58)
        Me.pnlStudent.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnlStudent.Name = "pnlStudent"
        Me.pnlStudent.Size = New System.Drawing.Size(399, 568)
        Me.pnlStudent.TabIndex = 38
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(29, 479)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(141, 21)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "Organization No. 3"
        '
        'cbbOrganization3
        '
        Me.cbbOrganization3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbOrganization3.FormattingEnabled = True
        Me.cbbOrganization3.Items.AddRange(New Object() {"", "GENES ORGANIZATION", "SIGMA", "FYE", "TEATRO BUGHAW", "FAITH EDUCATORS", "MORSEL", "NOMADSS", "AFEMS", "KAMFIL", "BYI", "CCGI"})
        Me.cbbOrganization3.Location = New System.Drawing.Point(177, 476)
        Me.cbbOrganization3.Name = "cbbOrganization3"
        Me.cbbOrganization3.Size = New System.Drawing.Size(197, 29)
        Me.cbbOrganization3.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(29, 438)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(141, 21)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Organization No. 2"
        '
        'cbbOrganization2
        '
        Me.cbbOrganization2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbOrganization2.FormattingEnabled = True
        Me.cbbOrganization2.Items.AddRange(New Object() {"", "GENES ORGANIZATION", "SIGMA", "FYE", "TEATRO BUGHAW", "FAITH EDUCATORS", "MORSEL", "NOMADSS", "AFEMS", "KAMFIL", "BYI", "CCGI"})
        Me.cbbOrganization2.Location = New System.Drawing.Point(177, 435)
        Me.cbbOrganization2.Name = "cbbOrganization2"
        Me.cbbOrganization2.Size = New System.Drawing.Size(197, 29)
        Me.cbbOrganization2.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 400)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 21)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Organization No. 1"
        '
        'cbbOrganization1
        '
        Me.cbbOrganization1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbOrganization1.FormattingEnabled = True
        Me.cbbOrganization1.Items.AddRange(New Object() {"", "GENES ORGANIZATION", "SIGMA", "FYE", "TEATRO BUGHAW", "FAITH EDUCATORS", "MORSEL", "NOMADSS", "AFEMS", "KAMFIL", "BYI", "CCGI"})
        Me.cbbOrganization1.Location = New System.Drawing.Point(177, 397)
        Me.cbbOrganization1.Name = "cbbOrganization1"
        Me.cbbOrganization1.Size = New System.Drawing.Size(197, 29)
        Me.cbbOrganization1.TabIndex = 11
        '
        'bttnEdit
        '
        Me.bttnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttnEdit.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnEdit.Location = New System.Drawing.Point(33, 516)
        Me.bttnEdit.Name = "bttnEdit"
        Me.bttnEdit.Size = New System.Drawing.Size(118, 42)
        Me.bttnEdit.TabIndex = 37
        Me.bttnEdit.Text = "Edit"
        Me.bttnEdit.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.Location = New System.Drawing.Point(37, 460)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(118, 35)
        Me.btnEdit.TabIndex = 37
        Me.btnEdit.Text = "Update"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'frmAddStudent
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(404, 630)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlStudent)
        Me.Controls.Add(Me.btnEdit)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "College Of Education - Student Information"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlStudent.ResumeLayout(False)
        Me.pnlStudent.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbbGender As System.Windows.Forms.ComboBox
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents cbbYear As System.Windows.Forms.ComboBox
    Friend WithEvents cbbBlock As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbbCourse As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtExtname As System.Windows.Forms.TextBox
    Friend WithEvents txtMname As System.Windows.Forms.TextBox
    Friend WithEvents txtLname As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents txtFname As System.Windows.Forms.TextBox
    Friend WithEvents txtStudNo As System.Windows.Forms.TextBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents pnlStudent As System.Windows.Forms.Panel
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents bttnEdit As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbbOrganization3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbbOrganization2 As System.Windows.Forms.ComboBox
    Friend WithEvents cbbOrganization1 As System.Windows.Forms.ComboBox
End Class
