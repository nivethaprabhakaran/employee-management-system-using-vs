<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.userid = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Uid = New System.Windows.Forms.TextBox()
        Me.Pwd = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Reset = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Location = New System.Drawing.Point(186, 73)
        Me.Label1.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(558, 50)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Employee Management System"
        '
        'userid
        '
        Me.userid.AutoSize = True
        Me.userid.Font = New System.Drawing.Font("Palatino Linotype", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userid.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.userid.Location = New System.Drawing.Point(185, 260)
        Me.userid.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.userid.Name = "userid"
        Me.userid.Size = New System.Drawing.Size(151, 50)
        Me.userid.TabIndex = 2
        Me.userid.Text = "Admin:"
        '
        'password
        '
        Me.password.AutoSize = True
        Me.password.Font = New System.Drawing.Font("Palatino Linotype", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.password.Location = New System.Drawing.Point(155, 340)
        Me.password.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(193, 50)
        Me.password.TabIndex = 3
        Me.password.Text = "Password:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 260)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Uid
        '
        Me.Uid.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Uid.Location = New System.Drawing.Point(390, 272)
        Me.Uid.Name = "Uid"
        Me.Uid.Size = New System.Drawing.Size(258, 38)
        Me.Uid.TabIndex = 5
        '
        'Pwd
        '
        Me.Pwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pwd.Location = New System.Drawing.Point(390, 350)
        Me.Pwd.Name = "Pwd"
        Me.Pwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Pwd.Size = New System.Drawing.Size(258, 38)
        Me.Pwd.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(390, 454)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 41)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Reset
        '
        Me.Reset.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Reset.FlatAppearance.BorderSize = 0
        Me.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Reset.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset.Location = New System.Drawing.Point(538, 454)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(110, 41)
        Me.Reset.TabIndex = 8
        Me.Reset.Text = "Reset"
        Me.Reset.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label4.Location = New System.Drawing.Point(975, 9)
        Me.Label4.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 38)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "X"
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1014, 616)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Pwd)
        Me.Controls.Add(Me.Uid)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.userid)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents userid As Label
    Friend WithEvents password As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Uid As TextBox
    Friend WithEvents Pwd As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Reset As Button
    Friend WithEvents Label4 As Label
End Class
