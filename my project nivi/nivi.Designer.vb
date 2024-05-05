<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.employeegrid = New System.Windows.Forms.DataGridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.empdob = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.empqualicb = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.empposcb = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.empgendercb = New System.Windows.Forms.ComboBox()
        Me.empphntb = New System.Windows.Forms.TextBox()
        Me.empaddresstb = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Empnametb = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.empidtb = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.employeegrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.empidtb)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.employeegrid)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.empdob)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.empqualicb)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.empposcb)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.empgendercb)
        Me.Panel1.Controls.Add(Me.empphntb)
        Me.Panel1.Controls.Add(Me.empaddresstb)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Empnametb)
        Me.Panel1.Location = New System.Drawing.Point(-24, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1692, 752)
        Me.Panel1.TabIndex = 0
        '
        'employeegrid
        '
        Me.employeegrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.employeegrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.employeegrid.Location = New System.Drawing.Point(724, 45)
        Me.employeegrid.Name = "employeegrid"
        Me.employeegrid.RowHeadersWidth = 51
        Me.employeegrid.RowTemplate.Height = 24
        Me.employeegrid.Size = New System.Drawing.Size(897, 610)
        Me.employeegrid.TabIndex = 25
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Honeydew
        Me.Button4.Location = New System.Drawing.Point(225, 611)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(88, 44)
        Me.Button4.TabIndex = 24
        Me.Button4.Text = "Edit"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Honeydew
        Me.Button3.Location = New System.Drawing.Point(371, 611)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(105, 44)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Honeydew
        Me.Button2.Location = New System.Drawing.Point(225, 688)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 44)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Home"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Honeydew
        Me.Button1.Location = New System.Drawing.Point(82, 611)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 44)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'empdob
        '
        Me.empdob.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empdob.Location = New System.Drawing.Point(145, 520)
        Me.empdob.Name = "empdob"
        Me.empdob.Size = New System.Drawing.Size(273, 38)
        Me.empdob.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Black
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label8.Location = New System.Drawing.Point(168, 465)
        Me.Label8.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(231, 41)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Employee DOB"
        '
        'empqualicb
        '
        Me.empqualicb.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!)
        Me.empqualicb.FormattingEnabled = True
        Me.empqualicb.Items.AddRange(New Object() {"Diploma", "UG", "PG"})
        Me.empqualicb.Location = New System.Drawing.Point(353, 401)
        Me.empqualicb.Name = "empqualicb"
        Me.empqualicb.Size = New System.Drawing.Size(342, 39)
        Me.empqualicb.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label7.Location = New System.Drawing.Point(358, 346)
        Me.Label7.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(337, 41)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Employee Qualification"
        '
        'empposcb
        '
        Me.empposcb.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!)
        Me.empposcb.FormattingEnabled = True
        Me.empposcb.Items.AddRange(New Object() {"Manager", "Security", "Cleaner", "Accountant", "IT"})
        Me.empposcb.Location = New System.Drawing.Point(362, 266)
        Me.empposcb.Name = "empposcb"
        Me.empposcb.Size = New System.Drawing.Size(273, 39)
        Me.empposcb.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label5.Location = New System.Drawing.Point(364, 213)
        Me.Label5.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(271, 41)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Employee Position"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label4.Location = New System.Drawing.Point(38, 213)
        Me.Label4.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(264, 41)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Employee Gender"
        '
        'empgendercb
        '
        Me.empgendercb.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!)
        Me.empgendercb.FormattingEnabled = True
        Me.empgendercb.Items.AddRange(New Object() {"Male", "Female"})
        Me.empgendercb.Location = New System.Drawing.Point(37, 266)
        Me.empgendercb.Name = "empgendercb"
        Me.empgendercb.Size = New System.Drawing.Size(248, 39)
        Me.empgendercb.TabIndex = 13
        '
        'empphntb
        '
        Me.empphntb.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empphntb.Location = New System.Drawing.Point(36, 401)
        Me.empphntb.Name = "empphntb"
        Me.empphntb.Size = New System.Drawing.Size(258, 38)
        Me.empphntb.TabIndex = 12
        '
        'empaddresstb
        '
        Me.empaddresstb.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empaddresstb.Location = New System.Drawing.Point(371, 150)
        Me.empaddresstb.Name = "empaddresstb"
        Me.empaddresstb.Size = New System.Drawing.Size(258, 38)
        Me.empaddresstb.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label3.Location = New System.Drawing.Point(365, 94)
        Me.Label3.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(270, 41)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Employee Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label2.Location = New System.Drawing.Point(38, 346)
        Me.Label2.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(247, 41)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Employee Phone"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Location = New System.Drawing.Point(42, 94)
        Me.Label1.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 41)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Employee Name"
        '
        'Empnametb
        '
        Me.Empnametb.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Empnametb.Location = New System.Drawing.Point(41, 150)
        Me.Empnametb.Name = "Empnametb"
        Me.Empnametb.Size = New System.Drawing.Size(258, 38)
        Me.Empnametb.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label6.Location = New System.Drawing.Point(6, 28)
        Me.Label6.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(271, 41)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Manage Employee"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label9.Location = New System.Drawing.Point(1473, 864)
        Me.Label9.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 21)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Nivi VB Project"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Black
        Me.Label10.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label10.Location = New System.Drawing.Point(43, 18)
        Me.Label10.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(197, 41)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Employee ID"
        '
        'empidtb
        '
        Me.empidtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empidtb.Location = New System.Drawing.Point(337, 21)
        Me.empidtb.Name = "empidtb"
        Me.empidtb.Size = New System.Drawing.Size(258, 38)
        Me.empidtb.TabIndex = 27
        '
        'Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1611, 885)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Employee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.employeegrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents empphntb As TextBox
    Friend WithEvents empaddresstb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Empnametb As TextBox
    Friend WithEvents empgendercb As ComboBox
    Friend WithEvents empqualicb As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents empposcb As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents empdob As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents employeegrid As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents empidtb As TextBox
    Friend WithEvents Label10 As Label
End Class
