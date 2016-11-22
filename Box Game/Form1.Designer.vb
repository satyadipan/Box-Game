<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.Show_Hide = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.txt1 = New System.Windows.Forms.Label()
        Me.btn2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Show_Hide
        '
        Me.Show_Hide.Location = New System.Drawing.Point(290, 272)
        Me.Show_Hide.Name = "Show_Hide"
        Me.Show_Hide.Size = New System.Drawing.Size(138, 47)
        Me.Show_Hide.TabIndex = 0
        Me.Show_Hide.Text = "Show 1"
        Me.Show_Hide.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Box_Game.My.Resources.Resources.Edit1
        Me.PictureBox1.Location = New System.Drawing.Point(226, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 147)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 1
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(132, 272)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(152, 47)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "Hello"
        '
        'txt1
        '
        Me.txt1.AutoSize = True
        Me.txt1.Location = New System.Drawing.Point(129, 116)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(31, 13)
        Me.txt1.TabIndex = 2
        Me.txt1.Text = "Hello"
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(214, 364)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(125, 54)
        Me.btn2.TabIndex = 3
        Me.btn2.Text = "btn2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 454)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Show_Hide)
        Me.Name = "MainForm"
        Me.Text = "Main"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Show_Hide As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn1 As Button
    Friend WithEvents txt1 As Label
    Friend WithEvents btn2 As Button
End Class
