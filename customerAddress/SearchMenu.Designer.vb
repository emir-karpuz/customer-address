<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchMenu
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
        Dim lblSId As System.Windows.Forms.Label
        Dim lblSName As System.Windows.Forms.Label
        Dim lblSSurname As System.Windows.Forms.Label
        Dim lblSGender As System.Windows.Forms.Label
        Dim lblSBirth As System.Windows.Forms.Label
        Dim lblSStreet As System.Windows.Forms.Label
        Dim lblSNeighbourhood As System.Windows.Forms.Label
        Dim lblSBuilding As System.Windows.Forms.Label
        Dim lblSFlat As System.Windows.Forms.Label
        Dim lblSPostal As System.Windows.Forms.Label
        Dim lblSTown As System.Windows.Forms.Label
        Dim lblSProvince As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchMenu))
        Me.txtSId = New System.Windows.Forms.TextBox()
        Me.txtSName = New System.Windows.Forms.TextBox()
        Me.txtSSurname = New System.Windows.Forms.TextBox()
        Me.cbSGender = New System.Windows.Forms.ComboBox()
        Me.txtSBirth = New System.Windows.Forms.TextBox()
        Me.txtSStreet = New System.Windows.Forms.TextBox()
        Me.txtSNeighbourhood = New System.Windows.Forms.TextBox()
        Me.txtSBuilding = New System.Windows.Forms.TextBox()
        Me.txtSFlat = New System.Windows.Forms.TextBox()
        Me.txtSPostal = New System.Windows.Forms.TextBox()
        Me.txtSTown = New System.Windows.Forms.TextBox()
        Me.txtSProvince = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        lblSId = New System.Windows.Forms.Label()
        lblSName = New System.Windows.Forms.Label()
        lblSSurname = New System.Windows.Forms.Label()
        lblSGender = New System.Windows.Forms.Label()
        lblSBirth = New System.Windows.Forms.Label()
        lblSStreet = New System.Windows.Forms.Label()
        lblSNeighbourhood = New System.Windows.Forms.Label()
        lblSBuilding = New System.Windows.Forms.Label()
        lblSFlat = New System.Windows.Forms.Label()
        lblSPostal = New System.Windows.Forms.Label()
        lblSTown = New System.Windows.Forms.Label()
        lblSProvince = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblSId
        '
        lblSId.AutoSize = True
        lblSId.BackColor = System.Drawing.Color.Transparent
        lblSId.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        lblSId.Location = New System.Drawing.Point(67, 50)
        lblSId.Name = "lblSId"
        lblSId.Size = New System.Drawing.Size(75, 13)
        lblSId.TabIndex = 39
        lblSId.Text = "ID Number:"
        '
        'lblSName
        '
        lblSName.AutoSize = True
        lblSName.BackColor = System.Drawing.Color.Transparent
        lblSName.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        lblSName.Location = New System.Drawing.Point(97, 76)
        lblSName.Name = "lblSName"
        lblSName.Size = New System.Drawing.Size(45, 13)
        lblSName.TabIndex = 41
        lblSName.Text = "Name:"
        '
        'lblSSurname
        '
        lblSSurname.AutoSize = True
        lblSSurname.BackColor = System.Drawing.Color.Transparent
        lblSSurname.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        lblSSurname.Location = New System.Drawing.Point(78, 102)
        lblSSurname.Name = "lblSSurname"
        lblSSurname.Size = New System.Drawing.Size(64, 13)
        lblSSurname.TabIndex = 43
        lblSSurname.Text = "Surname:"
        '
        'lblSGender
        '
        lblSGender.AutoSize = True
        lblSGender.BackColor = System.Drawing.Color.Transparent
        lblSGender.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        lblSGender.Location = New System.Drawing.Point(88, 127)
        lblSGender.Name = "lblSGender"
        lblSGender.Size = New System.Drawing.Size(54, 13)
        lblSGender.TabIndex = 45
        lblSGender.Text = "Gender:"
        '
        'lblSBirth
        '
        lblSBirth.AutoSize = True
        lblSBirth.BackColor = System.Drawing.Color.Transparent
        lblSBirth.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        lblSBirth.Location = New System.Drawing.Point(57, 154)
        lblSBirth.Name = "lblSBirth"
        lblSBirth.Size = New System.Drawing.Size(85, 13)
        lblSBirth.TabIndex = 46
        lblSBirth.Text = "Year Of Birth:"
        '
        'lblSStreet
        '
        lblSStreet.AutoSize = True
        lblSStreet.BackColor = System.Drawing.Color.Transparent
        lblSStreet.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        lblSStreet.Location = New System.Drawing.Point(45, 180)
        lblSStreet.Name = "lblSStreet"
        lblSStreet.Size = New System.Drawing.Size(97, 13)
        lblSStreet.TabIndex = 48
        lblSStreet.Text = "Street Address:"
        '
        'lblSNeighbourhood
        '
        lblSNeighbourhood.AutoSize = True
        lblSNeighbourhood.BackColor = System.Drawing.Color.Transparent
        lblSNeighbourhood.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        lblSNeighbourhood.Location = New System.Drawing.Point(7, 206)
        lblSNeighbourhood.Name = "lblSNeighbourhood"
        lblSNeighbourhood.Size = New System.Drawing.Size(135, 13)
        lblSNeighbourhood.TabIndex = 50
        lblSNeighbourhood.Text = "Neighbourhood Name:"
        '
        'lblSBuilding
        '
        lblSBuilding.AutoSize = True
        lblSBuilding.BackColor = System.Drawing.Color.Transparent
        lblSBuilding.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        lblSBuilding.Location = New System.Drawing.Point(36, 232)
        lblSBuilding.Name = "lblSBuilding"
        lblSBuilding.Size = New System.Drawing.Size(106, 13)
        lblSBuilding.TabIndex = 51
        lblSBuilding.Text = "Building Number:"
        '
        'lblSFlat
        '
        lblSFlat.AutoSize = True
        lblSFlat.BackColor = System.Drawing.Color.Transparent
        lblSFlat.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        lblSFlat.Location = New System.Drawing.Point(61, 258)
        lblSFlat.Name = "lblSFlat"
        lblSFlat.Size = New System.Drawing.Size(81, 13)
        lblSFlat.TabIndex = 53
        lblSFlat.Text = "Flat Number:"
        '
        'lblSPostal
        '
        lblSPostal.AutoSize = True
        lblSPostal.BackColor = System.Drawing.Color.Transparent
        lblSPostal.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        lblSPostal.Location = New System.Drawing.Point(62, 284)
        lblSPostal.Name = "lblSPostal"
        lblSPostal.Size = New System.Drawing.Size(80, 13)
        lblSPostal.TabIndex = 55
        lblSPostal.Text = "Postal Code:"
        '
        'lblSTown
        '
        lblSTown.AutoSize = True
        lblSTown.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        lblSTown.Location = New System.Drawing.Point(101, 310)
        lblSTown.Name = "lblSTown"
        lblSTown.Size = New System.Drawing.Size(41, 13)
        lblSTown.TabIndex = 57
        lblSTown.Text = "Town:"
        '
        'lblSProvince
        '
        lblSProvince.AutoSize = True
        lblSProvince.BackColor = System.Drawing.Color.Transparent
        lblSProvince.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        lblSProvince.Location = New System.Drawing.Point(81, 336)
        lblSProvince.Name = "lblSProvince"
        lblSProvince.Size = New System.Drawing.Size(61, 13)
        lblSProvince.TabIndex = 59
        lblSProvince.Text = "Province:"
        '
        'txtSId
        '
        Me.txtSId.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSId.Location = New System.Drawing.Point(146, 47)
        Me.txtSId.Name = "txtSId"
        Me.txtSId.Size = New System.Drawing.Size(108, 21)
        Me.txtSId.TabIndex = 40
        '
        'txtSName
        '
        Me.txtSName.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSName.Location = New System.Drawing.Point(146, 73)
        Me.txtSName.Name = "txtSName"
        Me.txtSName.Size = New System.Drawing.Size(108, 21)
        Me.txtSName.TabIndex = 42
        '
        'txtSSurname
        '
        Me.txtSSurname.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSSurname.Location = New System.Drawing.Point(146, 99)
        Me.txtSSurname.Name = "txtSSurname"
        Me.txtSSurname.Size = New System.Drawing.Size(108, 21)
        Me.txtSSurname.TabIndex = 44
        '
        'cbSGender
        '
        Me.cbSGender.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cbSGender.FormattingEnabled = True
        Me.cbSGender.Items.AddRange(New Object() {"M", "F"})
        Me.cbSGender.Location = New System.Drawing.Point(146, 124)
        Me.cbSGender.Name = "cbSGender"
        Me.cbSGender.Size = New System.Drawing.Size(108, 21)
        Me.cbSGender.TabIndex = 61
        Me.cbSGender.Text = "M"
        '
        'txtSBirth
        '
        Me.txtSBirth.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSBirth.Location = New System.Drawing.Point(146, 151)
        Me.txtSBirth.Name = "txtSBirth"
        Me.txtSBirth.Size = New System.Drawing.Size(108, 21)
        Me.txtSBirth.TabIndex = 47
        '
        'txtSStreet
        '
        Me.txtSStreet.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSStreet.Location = New System.Drawing.Point(146, 177)
        Me.txtSStreet.Name = "txtSStreet"
        Me.txtSStreet.Size = New System.Drawing.Size(108, 21)
        Me.txtSStreet.TabIndex = 49
        '
        'txtSNeighbourhood
        '
        Me.txtSNeighbourhood.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSNeighbourhood.Location = New System.Drawing.Point(146, 203)
        Me.txtSNeighbourhood.Name = "txtSNeighbourhood"
        Me.txtSNeighbourhood.Size = New System.Drawing.Size(108, 21)
        Me.txtSNeighbourhood.TabIndex = 62
        '
        'txtSBuilding
        '
        Me.txtSBuilding.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSBuilding.Location = New System.Drawing.Point(146, 229)
        Me.txtSBuilding.Name = "txtSBuilding"
        Me.txtSBuilding.Size = New System.Drawing.Size(108, 21)
        Me.txtSBuilding.TabIndex = 52
        '
        'txtSFlat
        '
        Me.txtSFlat.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSFlat.Location = New System.Drawing.Point(146, 255)
        Me.txtSFlat.Name = "txtSFlat"
        Me.txtSFlat.Size = New System.Drawing.Size(108, 21)
        Me.txtSFlat.TabIndex = 54
        '
        'txtSPostal
        '
        Me.txtSPostal.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSPostal.Location = New System.Drawing.Point(146, 281)
        Me.txtSPostal.Name = "txtSPostal"
        Me.txtSPostal.Size = New System.Drawing.Size(108, 21)
        Me.txtSPostal.TabIndex = 56
        '
        'txtSTown
        '
        Me.txtSTown.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSTown.Location = New System.Drawing.Point(146, 307)
        Me.txtSTown.Name = "txtSTown"
        Me.txtSTown.Size = New System.Drawing.Size(108, 21)
        Me.txtSTown.TabIndex = 58
        '
        'txtSProvince
        '
        Me.txtSProvince.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSProvince.Location = New System.Drawing.Point(146, 333)
        Me.txtSProvince.Name = "txtSProvince"
        Me.txtSProvince.Size = New System.Drawing.Size(108, 21)
        Me.txtSProvince.TabIndex = 60
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblTitle.Location = New System.Drawing.Point(5, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(180, 25)
        Me.lblTitle.TabIndex = 63
        Me.lblTitle.Text = "Search Record"
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Transparent
        Me.btnOK.BackgroundImage = Global.customerAddress.My.Resources.Resources._009_check
        Me.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOK.FlatAppearance.BorderSize = 0
        Me.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.ForeColor = System.Drawing.Color.Transparent
        Me.btnOK.Location = New System.Drawing.Point(104, 383)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(45, 44)
        Me.btnOK.TabIndex = 64
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BackgroundImage = Global.customerAddress.My.Resources.Resources._019_close
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(199, 383)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(45, 44)
        Me.btnCancel.TabIndex = 65
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'SearchMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.BackgroundImage = Global.customerAddress.My.Resources.Resources.cool_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(350, 449)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(lblSId)
        Me.Controls.Add(Me.txtSId)
        Me.Controls.Add(lblSName)
        Me.Controls.Add(Me.txtSName)
        Me.Controls.Add(lblSSurname)
        Me.Controls.Add(Me.txtSSurname)
        Me.Controls.Add(lblSGender)
        Me.Controls.Add(Me.cbSGender)
        Me.Controls.Add(lblSBirth)
        Me.Controls.Add(Me.txtSBirth)
        Me.Controls.Add(lblSStreet)
        Me.Controls.Add(Me.txtSStreet)
        Me.Controls.Add(lblSNeighbourhood)
        Me.Controls.Add(Me.txtSNeighbourhood)
        Me.Controls.Add(lblSBuilding)
        Me.Controls.Add(Me.txtSBuilding)
        Me.Controls.Add(lblSFlat)
        Me.Controls.Add(Me.txtSFlat)
        Me.Controls.Add(lblSPostal)
        Me.Controls.Add(Me.txtSPostal)
        Me.Controls.Add(lblSTown)
        Me.Controls.Add(Me.txtSTown)
        Me.Controls.Add(lblSProvince)
        Me.Controls.Add(Me.txtSProvince)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SearchMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "searchForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSId As TextBox
    Friend WithEvents txtSName As TextBox
    Friend WithEvents txtSSurname As TextBox
    Friend WithEvents cbSGender As ComboBox
    Friend WithEvents txtSBirth As TextBox
    Friend WithEvents txtSStreet As TextBox
    Friend WithEvents txtSNeighbourhood As TextBox
    Friend WithEvents txtSBuilding As TextBox
    Friend WithEvents txtSFlat As TextBox
    Friend WithEvents txtSPostal As TextBox
    Friend WithEvents txtSTown As TextBox
    Friend WithEvents txtSProvince As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
End Class
