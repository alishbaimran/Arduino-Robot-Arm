<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.base = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.upBase = New System.Windows.Forms.TrackBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ankle = New System.Windows.Forms.TrackBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.wrist = New System.Windows.Forms.TrackBar()
        Me.gripper = New System.Windows.Forms.TrackBar()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.PORT = New System.Windows.Forms.ListBox()
        Me.portRefresh = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.train = New System.Windows.Forms.Button()
        Me.play = New System.Windows.Forms.Button()
        CType(Me.base, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.upBase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ankle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wrist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gripper, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'base
        '
        Me.base.Enabled = False
        Me.base.Location = New System.Drawing.Point(267, 394)
        Me.base.Name = "base"
        Me.base.Size = New System.Drawing.Size(378, 56)
        Me.base.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 394)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "BASE MOVEMENT"
        '
        'upBase
        '
        Me.upBase.Enabled = False
        Me.upBase.Location = New System.Drawing.Point(267, 318)
        Me.upBase.Name = "upBase"
        Me.upBase.Size = New System.Drawing.Size(378, 56)
        Me.upBase.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 318)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "LIFTER MOVEMENT"
        '
        'ankle
        '
        Me.ankle.Enabled = False
        Me.ankle.Location = New System.Drawing.Point(267, 241)
        Me.ankle.Name = "ankle"
        Me.ankle.Size = New System.Drawing.Size(378, 56)
        Me.ankle.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ANKLE MOVEMENT"
        '
        'wrist
        '
        Me.wrist.Enabled = False
        Me.wrist.Location = New System.Drawing.Point(267, 170)
        Me.wrist.Name = "wrist"
        Me.wrist.Size = New System.Drawing.Size(378, 56)
        Me.wrist.TabIndex = 7
        '
        'gripper
        '
        Me.gripper.Enabled = False
        Me.gripper.Location = New System.Drawing.Point(267, 99)
        Me.gripper.Name = "gripper"
        Me.gripper.Size = New System.Drawing.Size(378, 56)
        Me.gripper.TabIndex = 8
        '
        'PORT
        '
        Me.PORT.FormattingEnabled = True
        Me.PORT.ItemHeight = 16
        Me.PORT.Location = New System.Drawing.Point(40, 23)
        Me.PORT.Name = "PORT"
        Me.PORT.Size = New System.Drawing.Size(87, 36)
        Me.PORT.TabIndex = 9
        '
        'portRefresh
        '
        Me.portRefresh.Location = New System.Drawing.Point(148, 23)
        Me.portRefresh.Name = "portRefresh"
        Me.portRefresh.Size = New System.Drawing.Size(87, 36)
        Me.portRefresh.TabIndex = 10
        Me.portRefresh.Text = "Refresh"
        Me.portRefresh.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(255, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 36)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Set Port"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "WRIST MOVEMENT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "GRIPPER MOVEMENT"
        '
        'train
        '
        Me.train.Location = New System.Drawing.Point(709, 190)
        Me.train.Name = "train"
        Me.train.Size = New System.Drawing.Size(90, 36)
        Me.train.TabIndex = 14
        Me.train.Text = "Train"
        Me.train.UseVisualStyleBackColor = True
        '
        'play
        '
        Me.play.Location = New System.Drawing.Point(709, 281)
        Me.play.Name = "play"
        Me.play.Size = New System.Drawing.Size(90, 36)
        Me.play.TabIndex = 15
        Me.play.Text = "Play"
        Me.play.UseVisualStyleBackColor = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 467)
        Me.Controls.Add(Me.play)
        Me.Controls.Add(Me.train)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.portRefresh)
        Me.Controls.Add(Me.PORT)
        Me.Controls.Add(Me.gripper)
        Me.Controls.Add(Me.wrist)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ankle)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.upBase)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.base)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "main"
        Me.Text = "Trainable Robotic Arm"
        CType(Me.base, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.upBase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ankle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wrist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gripper, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents base As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents upBase As TrackBar
    Friend WithEvents Label2 As Label
    Friend WithEvents ankle As TrackBar
    Friend WithEvents Label3 As Label
    Friend WithEvents wrist As TrackBar
    Friend WithEvents gripper As TrackBar
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents PORT As ListBox
    Friend WithEvents portRefresh As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents train As Button
    Friend WithEvents play As Button
End Class
