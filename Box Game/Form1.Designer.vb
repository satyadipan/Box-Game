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
        Me.txt2 = New System.Windows.Forms.Label()
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
        'txt2
        '
        Me.txt2.AutoSize = True
        Me.txt2.Location = New System.Drawing.Point(70, 139)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(66, 13)
        Me.txt2.TabIndex = 2
        Me.txt2.Text = "Picture Here"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 454)
        Me.Controls.Add(Me.txt2)
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
    Friend WithEvents txt2 As Label
End Class
