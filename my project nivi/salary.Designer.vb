<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class salary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(salary))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.salarytb = New System.Windows.Forms.RichTextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.workedtb = New System.Windows.Forms.TextBox()
        Me.EmpPoslbl = New System.Windows.Forms.Label()
        Me.EmpNamelbl = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.empidtb = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.salarytb)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.workedtb)
        Me.Panel1.Controls.Add(Me.EmpPoslbl)
        Me.Panel1.Controls.Add(Me.EmpNamelbl)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.empidtb)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 91)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1729, 745)
        Me.Panel1.TabIndex = 2
        '
        'salarytb
        '
        Me.salarytb.Font = New System.Drawing.Font("Franklin Gothic Medium", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salarytb.Location = New System.Drawing.Point(548, 87)
        Me.salarytb.Name = "salarytb"
        Me.salarytb.Size = New System.Drawing.Size(946, 527)
        Me.salarytb.TabIndex = 35
        Me.salarytb.Text = ""
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Honeydew
        Me.Button4.Location = New System.Drawing.Point(986, 648)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(88, 44)
        Me.Button4.TabIndex = 34
        Me.Button4.Text = "Print"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'workedtb
        '
        Me.workedtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.workedtb.Location = New System.Drawing.Point(50, 513)
        Me.workedtb.Name = "workedtb"
        Me.workedtb.Size = New System.Drawing.Size(211, 38)
        Me.workedtb.TabIndex = 33
        '
        'EmpPoslbl
        '
        Me.EmpPoslbl.AutoSize = True
        Me.EmpPoslbl.BackColor = System.Drawing.Color.Transparent
        Me.EmpPoslbl.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpPoslbl.ForeColor = System.Drawing.Color.White
        Me.EmpPoslbl.Location = New System.Drawing.Point(43, 387)
        Me.EmpPoslbl.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.EmpPoslbl.Name = "EmpPoslbl"
        Me.EmpPoslbl.Size = New System.Drawing.Size(0, 41)
        Me.EmpPoslbl.TabIndex = 31
        '
        'EmpNamelbl
        '
        Me.EmpNamelbl.AutoSize = True
        Me.EmpNamelbl.BackColor = System.Drawing.Color.Transparent
        Me.EmpNamelbl.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpNamelbl.ForeColor = System.Drawing.Color.White
        Me.EmpNamelbl.Location = New System.Drawing.Point(47, 267)
        Me.EmpNamelbl.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.EmpNamelbl.Name = "EmpNamelbl"
        Me.EmpNamelbl.Size = New System.Drawing.Size(0, 41)
        Me.EmpNamelbl.TabIndex = 26
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Honeydew
        Me.Button3.Location = New System.Drawing.Point(281, 86)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(172, 42)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "Fetch Data"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'empidtb
        '
        Me.empidtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empidtb.Location = New System.Drawing.Point(50, 148)
        Me.empidtb.Name = "empidtb"
        Me.empidtb.Size = New System.Drawing.Size(211, 38)
        Me.empidtb.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Black
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label9.Location = New System.Drawing.Point(47, 87)
        Me.Label9.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(197, 41)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Employee ID"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Honeydew
        Me.Button2.Location = New System.Drawing.Point(50, 648)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 44)
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
        Me.Button1.Location = New System.Drawing.Point(226, 648)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 44)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "View"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label5.Location = New System.Drawing.Point(47, 336)
        Me.Label5.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(271, 41)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Employee Position"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label2.Location = New System.Drawing.Point(47, 457)
        Me.Label2.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 41)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Worked Days"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Location = New System.Drawing.Point(47, 210)
        Me.Label1.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 41)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Employee Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label6.Location = New System.Drawing.Point(122, 35)
        Me.Label6.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(247, 41)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Employee Salary"
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label3.Location = New System.Drawing.Point(1569, 9)
        Me.Label3.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 41)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "X"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(22, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'salary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1611, 885)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "salary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "salary"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents EmpPoslbl As Label
    Friend WithEvents EmpNamelbl As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents empidtb As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents workedtb As TextBox
    Friend WithEvents salarytb As RichTextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
