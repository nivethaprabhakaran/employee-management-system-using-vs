<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class employeemanage
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(employeemanage))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.employeegrid = New System.Windows.Forms.DataGridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.empid = New System.Windows.Forms.Label()
        Me.EmpIdtb = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.employeegrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label9.Location = New System.Drawing.Point(1525, 845)
        Me.Label9.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 21)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Nivi VB Project"
        '
        'employeegrid
        '
        Me.employeegrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.employeegrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.employeegrid.Location = New System.Drawing.Point(597, 34)
        Me.employeegrid.Name = "employeegrid"
        Me.employeegrid.RowHeadersWidth = 51
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.employeegrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.employeegrid.RowTemplate.Height = 24
        Me.employeegrid.Size = New System.Drawing.Size(755, 610)
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
        Me.Button2.Location = New System.Drawing.Point(225, 697)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 44)
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
        'empqualicb
        '
        Me.empqualicb.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!)
        Me.empqualicb.FormattingEnabled = True
        Me.empqualicb.Items.AddRange(New Object() {"Diploma", "UG", "PG"})
        Me.empqualicb.Location = New System.Drawing.Point(264, 463)
        Me.empqualicb.Name = "empqualicb"
        Me.empqualicb.Size = New System.Drawing.Size(321, 39)
        Me.empqualicb.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label7.Location = New System.Drawing.Point(267, 410)
        Me.Label7.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(318, 38)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Employee Qualification"
        '
        'empposcb
        '
        Me.empposcb.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!)
        Me.empposcb.FormattingEnabled = True
        Me.empposcb.Items.AddRange(New Object() {"Manager", "Security", "Cleaner", "Accountant", "IT"})
        Me.empposcb.Location = New System.Drawing.Point(289, 316)
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
        Me.Label5.Location = New System.Drawing.Point(291, 260)
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
        Me.Label4.Location = New System.Drawing.Point(9, 260)
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
        Me.empgendercb.Location = New System.Drawing.Point(9, 316)
        Me.empgendercb.Name = "empgendercb"
        Me.empgendercb.Size = New System.Drawing.Size(264, 39)
        Me.empgendercb.TabIndex = 13
        '
        'empphntb
        '
        Me.empphntb.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empphntb.Location = New System.Drawing.Point(3, 463)
        Me.empphntb.Name = "empphntb"
        Me.empphntb.Size = New System.Drawing.Size(246, 38)
        Me.empphntb.TabIndex = 12
        '
        'empaddresstb
        '
        Me.empaddresstb.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empaddresstb.Location = New System.Drawing.Point(304, 177)
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
        Me.Label3.Location = New System.Drawing.Point(297, 117)
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
        Me.Label2.Location = New System.Drawing.Point(2, 410)
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
        Me.Label1.Location = New System.Drawing.Point(9, 117)
        Me.Label1.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 41)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Employee Name"
        '
        'Empnametb
        '
        Me.Empnametb.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Empnametb.Location = New System.Drawing.Point(9, 177)
        Me.Empnametb.Name = "Empnametb"
        Me.Empnametb.Size = New System.Drawing.Size(258, 38)
        Me.Empnametb.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label6.Location = New System.Drawing.Point(115, 33)
        Me.Label6.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(271, 41)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Manage Employee"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.EmpIdtb)
        Me.Panel1.Controls.Add(Me.empid)
        Me.Panel1.Controls.Add(Me.employeegrid)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
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
        Me.Panel1.Location = New System.Drawing.Point(1, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1643, 760)
        Me.Panel1.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label11.Location = New System.Drawing.Point(1300, 19)
        Me.Label11.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 41)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "X"
        '
        'empid
        '
        Me.empid.AutoSize = True
        Me.empid.BackColor = System.Drawing.Color.Black
        Me.empid.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empid.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.empid.Location = New System.Drawing.Point(15, 24)
        Me.empid.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.empid.Name = "empid"
        Me.empid.Size = New System.Drawing.Size(197, 41)
        Me.empid.TabIndex = 26
        Me.empid.Text = "Employee ID"
        '
        'EmpIdtb
        '
        Me.EmpIdtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpIdtb.Location = New System.Drawing.Point(244, 27)
        Me.EmpIdtb.Name = "EmpIdtb"
        Me.EmpIdtb.Size = New System.Drawing.Size(258, 38)
        Me.EmpIdtb.TabIndex = 27
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(19, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(84, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'employeemanage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1356, 844)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "employeemanage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "employeemanage"
        CType(Me.employeegrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents employeegrid As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents empqualicb As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents empposcb As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents empgendercb As ComboBox
    Friend WithEvents empphntb As TextBox
    Friend WithEvents empaddresstb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Empnametb As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents empid As Label
    Friend WithEvents EmpIdtb As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
