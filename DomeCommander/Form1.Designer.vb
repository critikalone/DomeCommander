<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        GroupBox1 = New GroupBox()
        lblStatusSlotPower = New Label()
        lblStatusDomeTemp = New Label()
        lblStatusAz = New Label()
        lblStatusCondition = New Label()
        lblStatusSlotPosition = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        BindingSource1 = New BindingSource(components)
        DomeGraphic = New PictureBox()
        PicDomeControlHome = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        BtnDomeControlOpen = New Button()
        BtnDomeControlClose = New Button()
        PicDomeControlStop = New PictureBox()
        GroupBox2 = New GroupBox()
        BtnDomeControlChangeSlotPos = New Button()
        BtnDomeControlStop = New Button()
        BtnDomeControlPark = New Button()
        RadioDomeControlClosed = New RadioButton()
        RadioDomeControlOpenPart = New RadioButton()
        RadioDomeControlOpenFull = New RadioButton()
        BtnDomeControlGo = New Button()
        txtDomeControlAz = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        GroupBox3 = New GroupBox()
        lblWxDewPoint = New Label()
        lblWxHumidity = New Label()
        lblWxTemp = New Label()
        lblWxCondition = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        GroupBox4 = New GroupBox()
        ListAlerts = New ListBox()
        BtnDomeControlRightTurn = New Button()
        BtnDomeControlLeftTurn = New Button()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DomeGraphic, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicDomeControlHome, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicDomeControlStop, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lblStatusSlotPower)
        GroupBox1.Controls.Add(lblStatusDomeTemp)
        GroupBox1.Controls.Add(lblStatusAz)
        GroupBox1.Controls.Add(lblStatusCondition)
        GroupBox1.Controls.Add(lblStatusSlotPosition)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(389, 118)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Status"
        ' 
        ' lblStatusSlotPower
        ' 
        lblStatusSlotPower.AutoSize = True
        lblStatusSlotPower.Location = New Point(107, 79)
        lblStatusSlotPower.Name = "lblStatusSlotPower"
        lblStatusSlotPower.Size = New Size(62, 15)
        lblStatusSlotPower.TabIndex = 9
        lblStatusSlotPower.Text = "slot power"
        ' 
        ' lblStatusDomeTemp
        ' 
        lblStatusDomeTemp.AutoSize = True
        lblStatusDomeTemp.Location = New Point(107, 64)
        lblStatusDomeTemp.Name = "lblStatusDomeTemp"
        lblStatusDomeTemp.Size = New Size(69, 15)
        lblStatusDomeTemp.TabIndex = 8
        lblStatusDomeTemp.Text = "dome temp"
        ' 
        ' lblStatusAz
        ' 
        lblStatusAz.AutoSize = True
        lblStatusAz.Location = New Point(107, 49)
        lblStatusAz.Name = "lblStatusAz"
        lblStatusAz.Size = New Size(50, 15)
        lblStatusAz.TabIndex = 7
        lblStatusAz.Text = "azimuth"
        ' 
        ' lblStatusCondition
        ' 
        lblStatusCondition.AutoSize = True
        lblStatusCondition.Location = New Point(107, 34)
        lblStatusCondition.Name = "lblStatusCondition"
        lblStatusCondition.Size = New Size(58, 15)
        lblStatusCondition.TabIndex = 6
        lblStatusCondition.Text = "condition"
        ' 
        ' lblStatusSlotPosition
        ' 
        lblStatusSlotPosition.AutoSize = True
        lblStatusSlotPosition.Location = New Point(107, 19)
        lblStatusSlotPosition.Name = "lblStatusSlotPosition"
        lblStatusSlotPosition.Size = New Size(72, 15)
        lblStatusSlotPosition.TabIndex = 5
        lblStatusSlotPosition.Text = "slot position"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 79)
        Label5.Name = "Label5"
        Label5.Size = New Size(63, 15)
        Label5.TabIndex = 4
        Label5.Text = "Slot Power"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 64)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 15)
        Label4.TabIndex = 3
        Label4.Text = "Dome Temp:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 49)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 15)
        Label3.TabIndex = 2
        Label3.Text = "Dome AZ:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 15)
        Label2.TabIndex = 1
        Label2.Text = "Condition:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(30, 15)
        Label1.TabIndex = 0
        Label1.Text = "Slot:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.skyshedlogo
        PictureBox1.Location = New Point(619, 384)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(169, 54)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' DomeGraphic
        ' 
        DomeGraphic.Image = My.Resources.Resources.dome
        DomeGraphic.Location = New Point(494, 110)
        DomeGraphic.Name = "DomeGraphic"
        DomeGraphic.Size = New Size(221, 212)
        DomeGraphic.SizeMode = PictureBoxSizeMode.StretchImage
        DomeGraphic.TabIndex = 2
        DomeGraphic.TabStop = False
        ' 
        ' PicDomeControlHome
        ' 
        PicDomeControlHome.Image = My.Resources.Resources.domehome
        PicDomeControlHome.Location = New Point(575, 24)
        PicDomeControlHome.Name = "PicDomeControlHome"
        PicDomeControlHome.Size = New Size(62, 80)
        PicDomeControlHome.SizeMode = PictureBoxSizeMode.StretchImage
        PicDomeControlHome.TabIndex = 3
        PicDomeControlHome.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.rotateRight
        PictureBox4.Location = New Point(417, 167)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(71, 86)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 4
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.rotateLeft
        PictureBox5.Location = New Point(721, 167)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(71, 86)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 5
        PictureBox5.TabStop = False
        ' 
        ' BtnDomeControlOpen
        ' 
        BtnDomeControlOpen.Location = New Point(494, 328)
        BtnDomeControlOpen.Name = "BtnDomeControlOpen"
        BtnDomeControlOpen.Size = New Size(79, 23)
        BtnDomeControlOpen.TabIndex = 6
        BtnDomeControlOpen.Text = "Dome Open"
        BtnDomeControlOpen.UseVisualStyleBackColor = True
        ' 
        ' BtnDomeControlClose
        ' 
        BtnDomeControlClose.Location = New Point(629, 328)
        BtnDomeControlClose.Name = "BtnDomeControlClose"
        BtnDomeControlClose.Size = New Size(86, 23)
        BtnDomeControlClose.TabIndex = 7
        BtnDomeControlClose.Text = "Dome Close"
        BtnDomeControlClose.UseVisualStyleBackColor = True
        ' 
        ' PicDomeControlStop
        ' 
        PicDomeControlStop.Image = My.Resources.Resources.stopButton
        PicDomeControlStop.Location = New Point(585, 328)
        PicDomeControlStop.Name = "PicDomeControlStop"
        PicDomeControlStop.Size = New Size(34, 37)
        PicDomeControlStop.SizeMode = PictureBoxSizeMode.StretchImage
        PicDomeControlStop.TabIndex = 8
        PicDomeControlStop.TabStop = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(BtnDomeControlChangeSlotPos)
        GroupBox2.Controls.Add(BtnDomeControlStop)
        GroupBox2.Controls.Add(BtnDomeControlPark)
        GroupBox2.Controls.Add(RadioDomeControlClosed)
        GroupBox2.Controls.Add(RadioDomeControlOpenPart)
        GroupBox2.Controls.Add(RadioDomeControlOpenFull)
        GroupBox2.Controls.Add(BtnDomeControlGo)
        GroupBox2.Controls.Add(txtDomeControlAz)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.ForeColor = Color.White
        GroupBox2.Location = New Point(12, 135)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(389, 116)
        GroupBox2.TabIndex = 9
        GroupBox2.TabStop = False
        GroupBox2.Text = "Dome Control"
        ' 
        ' BtnDomeControlChangeSlotPos
        ' 
        BtnDomeControlChangeSlotPos.ForeColor = Color.Black
        BtnDomeControlChangeSlotPos.Location = New Point(160, 71)
        BtnDomeControlChangeSlotPos.Name = "BtnDomeControlChangeSlotPos"
        BtnDomeControlChangeSlotPos.Size = New Size(126, 23)
        BtnDomeControlChangeSlotPos.TabIndex = 9
        BtnDomeControlChangeSlotPos.Text = "Change Slot Position"
        BtnDomeControlChangeSlotPos.UseVisualStyleBackColor = True
        ' 
        ' BtnDomeControlStop
        ' 
        BtnDomeControlStop.ForeColor = Color.Black
        BtnDomeControlStop.Location = New Point(275, 15)
        BtnDomeControlStop.Name = "BtnDomeControlStop"
        BtnDomeControlStop.Size = New Size(51, 23)
        BtnDomeControlStop.TabIndex = 8
        BtnDomeControlStop.Text = "Stop"
        BtnDomeControlStop.UseVisualStyleBackColor = True
        ' 
        ' BtnDomeControlPark
        ' 
        BtnDomeControlPark.ForeColor = Color.Black
        BtnDomeControlPark.Location = New Point(332, 15)
        BtnDomeControlPark.Name = "BtnDomeControlPark"
        BtnDomeControlPark.Size = New Size(43, 23)
        BtnDomeControlPark.TabIndex = 7
        BtnDomeControlPark.Text = "Park"
        BtnDomeControlPark.UseVisualStyleBackColor = True
        ' 
        ' RadioDomeControlClosed
        ' 
        RadioDomeControlClosed.AutoSize = True
        RadioDomeControlClosed.Location = New Point(64, 93)
        RadioDomeControlClosed.Name = "RadioDomeControlClosed"
        RadioDomeControlClosed.Size = New Size(54, 19)
        RadioDomeControlClosed.TabIndex = 6
        RadioDomeControlClosed.TabStop = True
        RadioDomeControlClosed.Text = "Close"
        RadioDomeControlClosed.UseVisualStyleBackColor = True
        ' 
        ' RadioDomeControlOpenPart
        ' 
        RadioDomeControlOpenPart.AutoSize = True
        RadioDomeControlOpenPart.Location = New Point(64, 73)
        RadioDomeControlOpenPart.Name = "RadioDomeControlOpenPart"
        RadioDomeControlOpenPart.Size = New Size(90, 19)
        RadioDomeControlOpenPart.TabIndex = 5
        RadioDomeControlOpenPart.TabStop = True
        RadioDomeControlOpenPart.Text = "Open Partial"
        RadioDomeControlOpenPart.UseVisualStyleBackColor = True
        ' 
        ' RadioDomeControlOpenFull
        ' 
        RadioDomeControlOpenFull.AutoSize = True
        RadioDomeControlOpenFull.Location = New Point(64, 53)
        RadioDomeControlOpenFull.Name = "RadioDomeControlOpenFull"
        RadioDomeControlOpenFull.Size = New Size(76, 19)
        RadioDomeControlOpenFull.TabIndex = 4
        RadioDomeControlOpenFull.TabStop = True
        RadioDomeControlOpenFull.Text = "Open Full"
        RadioDomeControlOpenFull.UseVisualStyleBackColor = True
        ' 
        ' BtnDomeControlGo
        ' 
        BtnDomeControlGo.ForeColor = Color.Black
        BtnDomeControlGo.Location = New Point(227, 15)
        BtnDomeControlGo.Name = "BtnDomeControlGo"
        BtnDomeControlGo.Size = New Size(42, 23)
        BtnDomeControlGo.TabIndex = 3
        BtnDomeControlGo.Text = "GO!"
        BtnDomeControlGo.UseVisualStyleBackColor = True
        ' 
        ' txtDomeControlAz
        ' 
        txtDomeControlAz.Location = New Point(121, 16)
        txtDomeControlAz.Name = "txtDomeControlAz"
        txtDomeControlAz.Size = New Size(100, 23)
        txtDomeControlAz.TabIndex = 2
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(6, 57)
        Label7.Name = "Label7"
        Label7.Size = New Size(52, 15)
        Label7.TabIndex = 1
        Label7.Text = "Slot Pos:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(6, 19)
        Label6.Name = "Label6"
        Label6.Size = New Size(76, 15)
        Label6.TabIndex = 0
        Label6.Text = "Rotate to AZ:"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(lblWxDewPoint)
        GroupBox3.Controls.Add(lblWxHumidity)
        GroupBox3.Controls.Add(lblWxTemp)
        GroupBox3.Controls.Add(lblWxCondition)
        GroupBox3.Controls.Add(Label11)
        GroupBox3.Controls.Add(Label10)
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Controls.Add(Label8)
        GroupBox3.ForeColor = Color.White
        GroupBox3.Location = New Point(12, 258)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(389, 100)
        GroupBox3.TabIndex = 10
        GroupBox3.TabStop = False
        GroupBox3.Text = "Wx Conditions"
        ' 
        ' lblWxDewPoint
        ' 
        lblWxDewPoint.AutoSize = True
        lblWxDewPoint.Location = New Point(121, 65)
        lblWxDewPoint.Name = "lblWxDewPoint"
        lblWxDewPoint.Size = New Size(61, 15)
        lblWxDewPoint.TabIndex = 13
        lblWxDewPoint.Text = "Dew Point"
        ' 
        ' lblWxHumidity
        ' 
        lblWxHumidity.AutoSize = True
        lblWxHumidity.Location = New Point(121, 50)
        lblWxHumidity.Name = "lblWxHumidity"
        lblWxHumidity.Size = New Size(57, 15)
        lblWxHumidity.TabIndex = 12
        lblWxHumidity.Text = "Humidity"
        ' 
        ' lblWxTemp
        ' 
        lblWxTemp.AutoSize = True
        lblWxTemp.Location = New Point(121, 35)
        lblWxTemp.Name = "lblWxTemp"
        lblWxTemp.Size = New Size(56, 15)
        lblWxTemp.TabIndex = 11
        lblWxTemp.Text = "Wx Temp"
        ' 
        ' lblWxCondition
        ' 
        lblWxCondition.AutoSize = True
        lblWxCondition.Location = New Point(121, 19)
        lblWxCondition.Name = "lblWxCondition"
        lblWxCondition.Size = New Size(83, 15)
        lblWxCondition.TabIndex = 10
        lblWxCondition.Text = "Wx conditions"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(6, 64)
        Label11.Name = "Label11"
        Label11.Size = New Size(64, 15)
        Label11.TabIndex = 3
        Label11.Text = "Dew Point:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(6, 49)
        Label10.Name = "Label10"
        Label10.Size = New Size(60, 15)
        Label10.TabIndex = 2
        Label10.Text = "Humidity:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(6, 34)
        Label9.Name = "Label9"
        Label9.Size = New Size(76, 15)
        Label9.TabIndex = 1
        Label9.Text = "Temperature:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(6, 19)
        Label8.Name = "Label8"
        Label8.Size = New Size(63, 15)
        Label8.TabIndex = 0
        Label8.Text = "Condition:"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(ListAlerts)
        GroupBox4.ForeColor = Color.White
        GroupBox4.Location = New Point(12, 364)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(389, 74)
        GroupBox4.TabIndex = 11
        GroupBox4.TabStop = False
        GroupBox4.Text = "Alerts"
        ' 
        ' ListAlerts
        ' 
        ListAlerts.FormattingEnabled = True
        ListAlerts.ItemHeight = 15
        ListAlerts.Location = New Point(6, 17)
        ListAlerts.Name = "ListAlerts"
        ListAlerts.Size = New Size(377, 49)
        ListAlerts.TabIndex = 14
        ' 
        ' BtnDomeControlRightTurn
        ' 
        BtnDomeControlRightTurn.Location = New Point(417, 258)
        BtnDomeControlRightTurn.Name = "BtnDomeControlRightTurn"
        BtnDomeControlRightTurn.Size = New Size(75, 23)
        BtnDomeControlRightTurn.TabIndex = 12
        BtnDomeControlRightTurn.Text = "Turn Right"
        BtnDomeControlRightTurn.UseVisualStyleBackColor = True
        ' 
        ' BtnDomeControlLeftTurn
        ' 
        BtnDomeControlLeftTurn.Location = New Point(721, 259)
        BtnDomeControlLeftTurn.Name = "BtnDomeControlLeftTurn"
        BtnDomeControlLeftTurn.Size = New Size(75, 23)
        BtnDomeControlLeftTurn.TabIndex = 13
        BtnDomeControlLeftTurn.Text = "Turn Left"
        BtnDomeControlLeftTurn.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(800, 450)
        Controls.Add(BtnDomeControlLeftTurn)
        Controls.Add(BtnDomeControlRightTurn)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(PicDomeControlStop)
        Controls.Add(BtnDomeControlClose)
        Controls.Add(BtnDomeControlOpen)
        Controls.Add(PicDomeControlHome)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(DomeGraphic)
        Controls.Add(PictureBox1)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Dome Commander"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        CType(DomeGraphic, ComponentModel.ISupportInitialize).EndInit()
        CType(PicDomeControlHome, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PicDomeControlStop, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents DomeGraphic As PictureBox
    Friend WithEvents PicDomeControlHome As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents BtnDomeControlOpen As Button
    Friend WithEvents BtnDomeControlClose As Button
    Friend WithEvents PicDomeControlStop As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnDomeControlRightTurn As Button
    Friend WithEvents BtnDomeControlLeftTurn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents RadioDomeControlOpenPart As RadioButton
    Friend WithEvents RadioDomeControlOpenFull As RadioButton
    Friend WithEvents BtnDomeControlGo As Button
    Friend WithEvents txtDomeControlAz As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents BtnDomeControlPark As Button
    Friend WithEvents RadioDomeControlClosed As RadioButton
    Friend WithEvents BtnDomeControlStop As Button
    Friend WithEvents lblStatusSlotPosition As Label
    Friend WithEvents lblStatusCondition As Label
    Friend WithEvents lblStatusAz As Label
    Friend WithEvents lblStatusDomeTemp As Label
    Friend WithEvents lblStatusSlotPower As Label
    Friend WithEvents BtnDomeControlChangeSlotPos As Button
    Friend WithEvents lblWxDewPoint As Label
    Friend WithEvents lblWxHumidity As Label
    Friend WithEvents lblWxTemp As Label
    Friend WithEvents lblWxCondition As Label
    Friend WithEvents ListAlerts As ListBox

End Class
