<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ttank = New System.Windows.Forms.TextBox()
        Me.btank = New System.Windows.Forms.TextBox()
        Me.top3 = New System.Windows.Forms.TextBox()
        Me.top2 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ctrl = New System.Windows.Forms.Button()
        Me.bot1 = New System.Windows.Forms.TextBox()
        Me.bot2 = New System.Windows.Forms.TextBox()
        Me.use = New System.Windows.Forms.Button()
        Me.use_timer = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.stop_timer = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(163, 26)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(208, 221)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Brown
        Me.TextBox2.Location = New System.Drawing.Point(-3, 515)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(1107, 306)
        Me.TextBox2.TabIndex = 1
        '
        'ttank
        '
        Me.ttank.BackColor = System.Drawing.Color.Blue
        Me.ttank.Location = New System.Drawing.Point(163, 26)
        Me.ttank.Multiline = True
        Me.ttank.Name = "ttank"
        Me.ttank.Size = New System.Drawing.Size(208, 221)
        Me.ttank.TabIndex = 2
        '
        'btank
        '
        Me.btank.BackColor = System.Drawing.Color.Blue
        Me.btank.Location = New System.Drawing.Point(345, 515)
        Me.btank.Multiline = True
        Me.btank.Name = "btank"
        Me.btank.Size = New System.Drawing.Size(591, 297)
        Me.btank.TabIndex = 3
        '
        'top3
        '
        Me.top3.Location = New System.Drawing.Point(354, 7)
        Me.top3.Name = "top3"
        Me.top3.Size = New System.Drawing.Size(101, 22)
        Me.top3.TabIndex = 4
        '
        'top2
        '
        Me.top2.Location = New System.Drawing.Point(425, 7)
        Me.top2.Multiline = True
        Me.top2.Name = "top2"
        Me.top2.Size = New System.Drawing.Size(37, 511)
        Me.top2.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(451, 413)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(138, 105)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'ctrl
        '
        Me.ctrl.BackColor = System.Drawing.Color.Red
        Me.ctrl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctrl.Location = New System.Drawing.Point(477, 347)
        Me.ctrl.Name = "ctrl"
        Me.ctrl.Size = New System.Drawing.Size(92, 60)
        Me.ctrl.TabIndex = 8
        Me.ctrl.Text = "Off"
        Me.ctrl.UseVisualStyleBackColor = False
        '
        'bot1
        '
        Me.bot1.Location = New System.Drawing.Point(76, 201)
        Me.bot1.Name = "bot1"
        Me.bot1.Size = New System.Drawing.Size(101, 22)
        Me.bot1.TabIndex = 9
        '
        'bot2
        '
        Me.bot2.Location = New System.Drawing.Point(76, 201)
        Me.bot2.Multiline = True
        Me.bot2.Name = "bot2"
        Me.bot2.Size = New System.Drawing.Size(31, 135)
        Me.bot2.TabIndex = 10
        '
        'use
        '
        Me.use.BackColor = System.Drawing.Color.Gold
        Me.use.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.use.Location = New System.Drawing.Point(134, 264)
        Me.use.Name = "use"
        Me.use.Size = New System.Drawing.Size(103, 54)
        Me.use.TabIndex = 11
        Me.use.Text = "USE"
        Me.use.UseVisualStyleBackColor = False
        '
        'use_timer
        '
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gold
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(275, 264)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 54)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "STOP"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'stop_timer
        '
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.Highlight
        Me.TextBox3.Location = New System.Drawing.Point(425, 515)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(37, 277)
        Me.TextBox3.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 819)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.use)
        Me.Controls.Add(Me.bot2)
        Me.Controls.Add(Me.bot1)
        Me.Controls.Add(Me.ctrl)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.top2)
        Me.Controls.Add(Me.top3)
        Me.Controls.Add(Me.btank)
        Me.Controls.Add(Me.ttank)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ttank As TextBox
    Friend WithEvents btank As TextBox
    Friend WithEvents top3 As TextBox
    Friend WithEvents top2 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ctrl As Button
    Friend WithEvents bot1 As TextBox
    Friend WithEvents bot2 As TextBox
    Friend WithEvents use As Button
    Friend WithEvents use_timer As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents stop_timer As Timer
    Friend WithEvents TextBox3 As TextBox
End Class
