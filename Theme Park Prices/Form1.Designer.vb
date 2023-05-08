<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        lblHeading = New Label()
        lblTag = New Label()
        picThemePark = New PictureBox()
        cboVisit = New ComboBox()
        grpOption = New GroupBox()
        radVIP = New RadioButton()
        radUnlimited = New RadioButton()
        radNormal = New RadioButton()
        lblAmount = New Label()
        txtAmount = New TextBox()
        lblCost = New Label()
        btnCalculate = New Button()
        btnClear = New Button()
        CType(picThemePark, ComponentModel.ISupportInitialize).BeginInit()
        grpOption.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("STXingkai", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point)
        lblHeading.Location = New Point(286, 9)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(301, 50)
        lblHeading.TabIndex = 0
        lblHeading.Text = "Starlight Avenue"
        ' 
        ' lblTag
        ' 
        lblTag.AutoSize = True
        lblTag.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblTag.Location = New Point(310, 59)
        lblTag.Name = "lblTag"
        lblTag.Size = New Size(252, 24)
        lblTag.TabIndex = 1
        lblTag.Text = "Check our prices below:"
        ' 
        ' picThemePark
        ' 
        picThemePark.Image = CType(resources.GetObject("picThemePark.Image"), Image)
        picThemePark.Location = New Point(0, 101)
        picThemePark.Name = "picThemePark"
        picThemePark.Size = New Size(415, 293)
        picThemePark.SizeMode = PictureBoxSizeMode.StretchImage
        picThemePark.TabIndex = 2
        picThemePark.TabStop = False
        ' 
        ' cboVisit
        ' 
        cboVisit.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        cboVisit.FormattingEnabled = True
        cboVisit.Items.AddRange(New Object() {"Day Visit", "Hotel Visit"})
        cboVisit.Location = New Point(421, 102)
        cboVisit.Name = "cboVisit"
        cboVisit.Size = New Size(440, 29)
        cboVisit.TabIndex = 3
        cboVisit.Text = "Choose Your Visit"
        ' 
        ' grpOption
        ' 
        grpOption.BackColor = Color.Cornsilk
        grpOption.Controls.Add(radVIP)
        grpOption.Controls.Add(radUnlimited)
        grpOption.Controls.Add(radNormal)
        grpOption.Font = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        grpOption.Location = New Point(421, 150)
        grpOption.Name = "grpOption"
        grpOption.Size = New Size(440, 127)
        grpOption.TabIndex = 4
        grpOption.TabStop = False
        grpOption.Text = "Choose Your Experience"
        ' 
        ' radVIP
        ' 
        radVIP.AutoSize = True
        radVIP.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
        radVIP.Location = New Point(6, 88)
        radVIP.Name = "radVIP"
        radVIP.Size = New Size(264, 22)
        radVIP.TabIndex = 2
        radVIP.TabStop = True
        radVIP.Text = "VIP: Unlimited rides and skip the line"
        radVIP.UseVisualStyleBackColor = True
        ' 
        ' radUnlimited
        ' 
        radUnlimited.AutoSize = True
        radUnlimited.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
        radUnlimited.Location = New Point(6, 57)
        radUnlimited.Name = "radUnlimited"
        radUnlimited.Size = New Size(187, 22)
        radUnlimited.TabIndex = 1
        radUnlimited.TabStop = True
        radUnlimited.Text = "Upgrade: Unlimited rides"
        radUnlimited.UseVisualStyleBackColor = True
        ' 
        ' radNormal
        ' 
        radNormal.AutoSize = True
        radNormal.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
        radNormal.Location = New Point(6, 26)
        radNormal.Name = "radNormal"
        radNormal.Size = New Size(266, 22)
        radNormal.TabIndex = 0
        radNormal.TabStop = True
        radNormal.Text = "Normal: 15 rides per person per day"
        radNormal.UseVisualStyleBackColor = True
        ' 
        ' lblAmount
        ' 
        lblAmount.AutoSize = True
        lblAmount.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lblAmount.Location = New Point(464, 301)
        lblAmount.Name = "lblAmount"
        lblAmount.Size = New Size(219, 21)
        lblAmount.TabIndex = 5
        lblAmount.Text = "How many or how long?"
        ' 
        ' txtAmount
        ' 
        txtAmount.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        txtAmount.Location = New Point(751, 295)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(79, 31)
        txtAmount.TabIndex = 6
        txtAmount.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblCost
        ' 
        lblCost.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblCost.Location = New Point(12, 428)
        lblCost.Name = "lblCost"
        lblCost.Size = New Size(849, 58)
        lblCost.TabIndex = 7
        lblCost.Text = "The total cost of your visit is $XX.XX"
        lblCost.TextAlign = ContentAlignment.TopCenter
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnCalculate.Location = New Point(464, 347)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(120, 40)
        btnCalculate.TabIndex = 8
        btnCalculate.Text = "Check Price"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnClear.Location = New Point(710, 347)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(120, 40)
        btnClear.TabIndex = 9
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PaleGoldenrod
        ClientSize = New Size(873, 495)
        Controls.Add(btnClear)
        Controls.Add(btnCalculate)
        Controls.Add(lblCost)
        Controls.Add(txtAmount)
        Controls.Add(lblAmount)
        Controls.Add(grpOption)
        Controls.Add(cboVisit)
        Controls.Add(picThemePark)
        Controls.Add(lblTag)
        Controls.Add(lblHeading)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Starlight Ave Prices"
        CType(picThemePark, ComponentModel.ISupportInitialize).EndInit()
        grpOption.ResumeLayout(False)
        grpOption.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblTag As Label
    Friend WithEvents picThemePark As PictureBox
    Friend WithEvents cboVisit As ComboBox
    Friend WithEvents grpOption As GroupBox
    Friend WithEvents radVIP As RadioButton
    Friend WithEvents radUnlimited As RadioButton
    Friend WithEvents radNormal As RadioButton
    Friend WithEvents lblAmount As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents lblCost As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
End Class
