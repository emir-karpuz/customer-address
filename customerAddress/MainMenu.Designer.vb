<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        Me.components = New System.ComponentModel.Container()
        Dim lblId As System.Windows.Forms.Label
        Dim lblCName As System.Windows.Forms.Label
        Dim lblCSurname As System.Windows.Forms.Label
        Dim lblCGender As System.Windows.Forms.Label
        Dim lblCBirth As System.Windows.Forms.Label
        Dim lblCStreet As System.Windows.Forms.Label
        Dim lblCNeighbourhood As System.Windows.Forms.Label
        Dim lblCBuilding As System.Windows.Forms.Label
        Dim lblCFlat As System.Windows.Forms.Label
        Dim lblCPostal As System.Windows.Forms.Label
        Dim lblCTown As System.Windows.Forms.Label
        Dim lblCProvince As System.Windows.Forms.Label
        Dim lblCreation As System.Windows.Forms.Label
        Dim lblUpdate As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.CustomerInfoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.CustomerInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EducationDataSet = New customerAddress.EducationDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtCName = New System.Windows.Forms.TextBox()
        Me.txtCSurname = New System.Windows.Forms.TextBox()
        Me.txtCBirth = New System.Windows.Forms.TextBox()
        Me.txtCStreet = New System.Windows.Forms.TextBox()
        Me.txtCBuilding = New System.Windows.Forms.TextBox()
        Me.txtCFlat = New System.Windows.Forms.TextBox()
        Me.txtCPostal = New System.Windows.Forms.TextBox()
        Me.txtCTown = New System.Windows.Forms.TextBox()
        Me.txtCProvince = New System.Windows.Forms.TextBox()
        Me.dpCreation = New System.Windows.Forms.DateTimePicker()
        Me.dpUpdate = New System.Windows.Forms.DateTimePicker()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cbCGender = New System.Windows.Forms.ComboBox()
        Me.CustomerInfoTableAdapter = New customerAddress.EducationDataSetTableAdapters.customerInfoTableAdapter()
        Me.TableAdapterManager = New customerAddress.EducationDataSetTableAdapters.TableAdapterManager()
        Me.txtCNeighbourhood = New System.Windows.Forms.TextBox()
        Me.CustomerInfoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customerNeighbourhoodName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.pbUserPic = New System.Windows.Forms.PictureBox()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        lblId = New System.Windows.Forms.Label()
        lblCName = New System.Windows.Forms.Label()
        lblCSurname = New System.Windows.Forms.Label()
        lblCGender = New System.Windows.Forms.Label()
        lblCBirth = New System.Windows.Forms.Label()
        lblCStreet = New System.Windows.Forms.Label()
        lblCNeighbourhood = New System.Windows.Forms.Label()
        lblCBuilding = New System.Windows.Forms.Label()
        lblCFlat = New System.Windows.Forms.Label()
        lblCPostal = New System.Windows.Forms.Label()
        lblCTown = New System.Windows.Forms.Label()
        lblCProvince = New System.Windows.Forms.Label()
        lblCreation = New System.Windows.Forms.Label()
        lblUpdate = New System.Windows.Forms.Label()
        CType(Me.CustomerInfoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomerInfoBindingNavigator.SuspendLayout()
        CType(Me.CustomerInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EducationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerInfoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUserPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblId
        '
        lblId.AutoSize = True
        lblId.BackColor = System.Drawing.Color.Transparent
        lblId.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        lblId.Location = New System.Drawing.Point(70, 50)
        lblId.Name = "lblId"
        lblId.Size = New System.Drawing.Size(75, 13)
        lblId.TabIndex = 3
        lblId.Text = "ID Number:"
        '
        'lblCName
        '
        lblCName.AutoSize = True
        lblCName.BackColor = System.Drawing.Color.Transparent
        lblCName.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        lblCName.Location = New System.Drawing.Point(100, 76)
        lblCName.Name = "lblCName"
        lblCName.Size = New System.Drawing.Size(45, 13)
        lblCName.TabIndex = 5
        lblCName.Text = "Name:"
        '
        'lblCSurname
        '
        lblCSurname.AutoSize = True
        lblCSurname.BackColor = System.Drawing.Color.Transparent
        lblCSurname.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        lblCSurname.Location = New System.Drawing.Point(81, 102)
        lblCSurname.Name = "lblCSurname"
        lblCSurname.Size = New System.Drawing.Size(64, 13)
        lblCSurname.TabIndex = 7
        lblCSurname.Text = "Surname:"
        '
        'lblCGender
        '
        lblCGender.AutoSize = True
        lblCGender.BackColor = System.Drawing.Color.Transparent
        lblCGender.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        lblCGender.Location = New System.Drawing.Point(91, 127)
        lblCGender.Name = "lblCGender"
        lblCGender.Size = New System.Drawing.Size(54, 13)
        lblCGender.TabIndex = 9
        lblCGender.Text = "Gender:"
        '
        'lblCBirth
        '
        lblCBirth.AutoSize = True
        lblCBirth.BackColor = System.Drawing.Color.Transparent
        lblCBirth.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        lblCBirth.Location = New System.Drawing.Point(60, 154)
        lblCBirth.Name = "lblCBirth"
        lblCBirth.Size = New System.Drawing.Size(85, 13)
        lblCBirth.TabIndex = 11
        lblCBirth.Text = "Year Of Birth:"
        '
        'lblCStreet
        '
        lblCStreet.AutoSize = True
        lblCStreet.BackColor = System.Drawing.Color.Transparent
        lblCStreet.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        lblCStreet.Location = New System.Drawing.Point(48, 180)
        lblCStreet.Name = "lblCStreet"
        lblCStreet.Size = New System.Drawing.Size(97, 13)
        lblCStreet.TabIndex = 13
        lblCStreet.Text = "Street Address:"
        '
        'lblCNeighbourhood
        '
        lblCNeighbourhood.AutoSize = True
        lblCNeighbourhood.BackColor = System.Drawing.Color.Transparent
        lblCNeighbourhood.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        lblCNeighbourhood.Location = New System.Drawing.Point(10, 206)
        lblCNeighbourhood.Name = "lblCNeighbourhood"
        lblCNeighbourhood.Size = New System.Drawing.Size(135, 13)
        lblCNeighbourhood.TabIndex = 15
        lblCNeighbourhood.Text = "Neighbourhood Name:"
        '
        'lblCBuilding
        '
        lblCBuilding.AutoSize = True
        lblCBuilding.BackColor = System.Drawing.Color.Transparent
        lblCBuilding.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        lblCBuilding.Location = New System.Drawing.Point(39, 232)
        lblCBuilding.Name = "lblCBuilding"
        lblCBuilding.Size = New System.Drawing.Size(106, 13)
        lblCBuilding.TabIndex = 17
        lblCBuilding.Text = "Building Number:"
        '
        'lblCFlat
        '
        lblCFlat.AutoSize = True
        lblCFlat.BackColor = System.Drawing.Color.Transparent
        lblCFlat.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        lblCFlat.Location = New System.Drawing.Point(64, 258)
        lblCFlat.Name = "lblCFlat"
        lblCFlat.Size = New System.Drawing.Size(81, 13)
        lblCFlat.TabIndex = 19
        lblCFlat.Text = "Flat Number:"
        '
        'lblCPostal
        '
        lblCPostal.AutoSize = True
        lblCPostal.BackColor = System.Drawing.Color.Transparent
        lblCPostal.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        lblCPostal.Location = New System.Drawing.Point(65, 284)
        lblCPostal.Name = "lblCPostal"
        lblCPostal.Size = New System.Drawing.Size(80, 13)
        lblCPostal.TabIndex = 21
        lblCPostal.Text = "Postal Code:"
        '
        'lblCTown
        '
        lblCTown.AutoSize = True
        lblCTown.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        lblCTown.Location = New System.Drawing.Point(104, 310)
        lblCTown.Name = "lblCTown"
        lblCTown.Size = New System.Drawing.Size(41, 13)
        lblCTown.TabIndex = 23
        lblCTown.Text = "Town:"
        '
        'lblCProvince
        '
        lblCProvince.AutoSize = True
        lblCProvince.BackColor = System.Drawing.Color.Transparent
        lblCProvince.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        lblCProvince.Location = New System.Drawing.Point(84, 336)
        lblCProvince.Name = "lblCProvince"
        lblCProvince.Size = New System.Drawing.Size(61, 13)
        lblCProvince.TabIndex = 25
        lblCProvince.Text = "Province:"
        '
        'lblCreation
        '
        lblCreation.AutoSize = True
        lblCreation.BackColor = System.Drawing.Color.Transparent
        lblCreation.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        lblCreation.Location = New System.Drawing.Point(53, 365)
        lblCreation.Name = "lblCreation"
        lblCreation.Size = New System.Drawing.Size(92, 13)
        lblCreation.TabIndex = 27
        lblCreation.Text = "Creation Date:"
        '
        'lblUpdate
        '
        lblUpdate.AutoSize = True
        lblUpdate.BackColor = System.Drawing.Color.Transparent
        lblUpdate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        lblUpdate.Location = New System.Drawing.Point(62, 392)
        lblUpdate.Name = "lblUpdate"
        lblUpdate.Size = New System.Drawing.Size(83, 13)
        lblUpdate.TabIndex = 29
        lblUpdate.Text = "Update Date:"
        '
        'CustomerInfoBindingNavigator
        '
        Me.CustomerInfoBindingNavigator.AddNewItem = Nothing
        Me.CustomerInfoBindingNavigator.BindingSource = Me.CustomerInfoBindingSource
        Me.CustomerInfoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CustomerInfoBindingNavigator.DeleteItem = Nothing
        Me.CustomerInfoBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CustomerInfoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.CustomerInfoBindingNavigator.Location = New System.Drawing.Point(0, 796)
        Me.CustomerInfoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CustomerInfoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CustomerInfoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CustomerInfoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CustomerInfoBindingNavigator.Name = "CustomerInfoBindingNavigator"
        Me.CustomerInfoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CustomerInfoBindingNavigator.Size = New System.Drawing.Size(1038, 25)
        Me.CustomerInfoBindingNavigator.TabIndex = 2
        Me.CustomerInfoBindingNavigator.Text = "BindingNavigator"
        '
        'CustomerInfoBindingSource
        '
        Me.CustomerInfoBindingSource.DataMember = "customerInfo"
        Me.CustomerInfoBindingSource.DataSource = Me.EducationDataSet
        '
        'EducationDataSet
        '
        Me.EducationDataSet.DataSetName = "EducationDataSet"
        Me.EducationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.BackColor = System.Drawing.Color.Transparent
        Me.BindingNavigatorCountItem.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BindingNavigatorCountItem.ForeColor = System.Drawing.Color.Gray
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(47, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = Global.customerAddress.My.Resources.Resources._035_previous
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = Global.customerAddress.My.Resources.Resources._029_rewind
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BindingNavigatorPositionItem.ForeColor = System.Drawing.Color.Black
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 15)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = Global.customerAddress.My.Resources.Resources._028_fast_forward
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = Global.customerAddress.My.Resources.Resources._034_skip
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'txtId
        '
        Me.txtId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "id", True))
        Me.txtId.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtId.Location = New System.Drawing.Point(149, 47)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(108, 21)
        Me.txtId.TabIndex = 4
        '
        'txtCName
        '
        Me.txtCName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "customerName", True))
        Me.txtCName.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtCName.Location = New System.Drawing.Point(149, 73)
        Me.txtCName.Name = "txtCName"
        Me.txtCName.Size = New System.Drawing.Size(108, 21)
        Me.txtCName.TabIndex = 6
        '
        'txtCSurname
        '
        Me.txtCSurname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "customerSurname", True))
        Me.txtCSurname.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtCSurname.Location = New System.Drawing.Point(149, 99)
        Me.txtCSurname.Name = "txtCSurname"
        Me.txtCSurname.Size = New System.Drawing.Size(108, 21)
        Me.txtCSurname.TabIndex = 8
        '
        'txtCBirth
        '
        Me.txtCBirth.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "customerYearOfBirth", True))
        Me.txtCBirth.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtCBirth.Location = New System.Drawing.Point(149, 151)
        Me.txtCBirth.Name = "txtCBirth"
        Me.txtCBirth.Size = New System.Drawing.Size(108, 21)
        Me.txtCBirth.TabIndex = 12
        '
        'txtCStreet
        '
        Me.txtCStreet.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "customerStreetAddress", True))
        Me.txtCStreet.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtCStreet.Location = New System.Drawing.Point(149, 177)
        Me.txtCStreet.Name = "txtCStreet"
        Me.txtCStreet.Size = New System.Drawing.Size(108, 21)
        Me.txtCStreet.TabIndex = 14
        '
        'txtCBuilding
        '
        Me.txtCBuilding.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "customerBuildingNumber", True))
        Me.txtCBuilding.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtCBuilding.Location = New System.Drawing.Point(149, 229)
        Me.txtCBuilding.Name = "txtCBuilding"
        Me.txtCBuilding.Size = New System.Drawing.Size(108, 21)
        Me.txtCBuilding.TabIndex = 18
        '
        'txtCFlat
        '
        Me.txtCFlat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "customerFlatNumber", True))
        Me.txtCFlat.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtCFlat.Location = New System.Drawing.Point(149, 255)
        Me.txtCFlat.Name = "txtCFlat"
        Me.txtCFlat.Size = New System.Drawing.Size(108, 21)
        Me.txtCFlat.TabIndex = 20
        '
        'txtCPostal
        '
        Me.txtCPostal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "customerPostalCode", True))
        Me.txtCPostal.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtCPostal.Location = New System.Drawing.Point(149, 281)
        Me.txtCPostal.Name = "txtCPostal"
        Me.txtCPostal.Size = New System.Drawing.Size(108, 21)
        Me.txtCPostal.TabIndex = 22
        '
        'txtCTown
        '
        Me.txtCTown.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "customerTown", True))
        Me.txtCTown.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtCTown.Location = New System.Drawing.Point(149, 307)
        Me.txtCTown.Name = "txtCTown"
        Me.txtCTown.Size = New System.Drawing.Size(108, 21)
        Me.txtCTown.TabIndex = 24
        '
        'txtCProvince
        '
        Me.txtCProvince.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "customerProvince", True))
        Me.txtCProvince.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtCProvince.Location = New System.Drawing.Point(149, 333)
        Me.txtCProvince.Name = "txtCProvince"
        Me.txtCProvince.Size = New System.Drawing.Size(108, 21)
        Me.txtCProvince.TabIndex = 26
        '
        'dpCreation
        '
        Me.dpCreation.CustomFormat = "yyyy-MM-dd"
        Me.dpCreation.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerInfoBindingSource, "customerCreationDate", True))
        Me.dpCreation.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.dpCreation.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpCreation.Location = New System.Drawing.Point(149, 359)
        Me.dpCreation.MinDate = New Date(1989, 1, 1, 0, 0, 0, 0)
        Me.dpCreation.Name = "dpCreation"
        Me.dpCreation.Size = New System.Drawing.Size(108, 21)
        Me.dpCreation.TabIndex = 28
        '
        'dpUpdate
        '
        Me.dpUpdate.CustomFormat = "yyyy-MM-dd"
        Me.dpUpdate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerInfoBindingSource, "customerUpdateDate", True))
        Me.dpUpdate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.dpUpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpUpdate.Location = New System.Drawing.Point(149, 386)
        Me.dpUpdate.MinDate = New Date(1989, 1, 1, 0, 0, 0, 0)
        Me.dpUpdate.Name = "dpUpdate"
        Me.dpUpdate.Size = New System.Drawing.Size(108, 21)
        Me.dpUpdate.TabIndex = 30
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblTitle.Location = New System.Drawing.Point(8, 8)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(313, 25)
        Me.lblTitle.TabIndex = 36
        Me.lblTitle.Text = "Customer Address Record"
        '
        'cbCGender
        '
        Me.cbCGender.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cbCGender.FormattingEnabled = True
        Me.cbCGender.Items.AddRange(New Object() {"M", "F"})
        Me.cbCGender.Location = New System.Drawing.Point(149, 124)
        Me.cbCGender.Name = "cbCGender"
        Me.cbCGender.Size = New System.Drawing.Size(108, 21)
        Me.cbCGender.TabIndex = 37
        Me.cbCGender.Text = "M"
        '
        'CustomerInfoTableAdapter
        '
        Me.CustomerInfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.customerInfoTableAdapter = Me.CustomerInfoTableAdapter
        Me.TableAdapterManager.UpdateOrder = customerAddress.EducationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'txtCNeighbourhood
        '
        Me.txtCNeighbourhood.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "customerNeighbourhoodName", True))
        Me.txtCNeighbourhood.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtCNeighbourhood.Location = New System.Drawing.Point(149, 203)
        Me.txtCNeighbourhood.Name = "txtCNeighbourhood"
        Me.txtCNeighbourhood.Size = New System.Drawing.Size(108, 21)
        Me.txtCNeighbourhood.TabIndex = 38
        '
        'CustomerInfoDataGridView
        '
        Me.CustomerInfoDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.CustomerInfoDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.CustomerInfoDataGridView.AutoGenerateColumns = False
        Me.CustomerInfoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.CustomerInfoDataGridView.BackgroundColor = System.Drawing.Color.LightGray
        Me.CustomerInfoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CustomerInfoDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.CustomerInfoDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.NullValue = "-"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomerInfoDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.CustomerInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerInfoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.customerNeighbourhoodName, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.CustomerInfoDataGridView.DataSource = Me.CustomerInfoBindingSource
        Me.CustomerInfoDataGridView.GridColor = System.Drawing.Color.DimGray
        Me.CustomerInfoDataGridView.Location = New System.Drawing.Point(12, 509)
        Me.CustomerInfoDataGridView.Name = "CustomerInfoDataGridView"
        Me.CustomerInfoDataGridView.ReadOnly = True
        Me.CustomerInfoDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomerInfoDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.CustomerInfoDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.CustomerInfoDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.CustomerInfoDataGridView.Size = New System.Drawing.Size(1014, 284)
        Me.CustomerInfoDataGridView.TabIndex = 31
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 47
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "customerName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 69
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "customerSurname"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Surname"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 90
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "customerGender"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 79
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "customerYearOfBirth"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Year of Birth"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 105
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "customerStreetAddress"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Street Address"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 118
        '
        'customerNeighbourhoodName
        '
        Me.customerNeighbourhoodName.DataPropertyName = "customerNeighbourhoodName"
        Me.customerNeighbourhoodName.HeaderText = "Neighbourhood Name"
        Me.customerNeighbourhoodName.Name = "customerNeighbourhoodName"
        Me.customerNeighbourhoodName.ReadOnly = True
        Me.customerNeighbourhoodName.Width = 157
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "customerBuildingNumber"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Building Number"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 127
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "customerFlatNumber"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Flat Number"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 103
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "customerPostalCode"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Postal Code"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 99
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "customerTown"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Town"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 66
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "customerProvince"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Province"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 89
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "customerCreationDate"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Creation Date"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 111
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "customerUpdateDate"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Update Date"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 103
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.DarkGray
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnDelete.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.ForeColor = System.Drawing.Color.DimGray
        Me.btnDelete.Image = Global.customerAddress.My.Resources.Resources._089_trash1
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(264, 312)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(154, 46)
        Me.btnDelete.TabIndex = 35
        Me.btnDelete.Text = "Delete Record"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.DarkGray
        Me.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnUpdate.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Gray
        Me.btnUpdate.Image = Global.customerAddress.My.Resources.Resources._075_reload1
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Location = New System.Drawing.Point(264, 260)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(154, 46)
        Me.btnUpdate.TabIndex = 34
        Me.btnUpdate.Text = "Update Record"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.DarkGray
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnAdd.ForeColor = System.Drawing.Color.Gray
        Me.btnAdd.Image = Global.customerAddress.My.Resources.Resources._008_check1
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(264, 208)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(154, 46)
        Me.btnAdd.TabIndex = 33
        Me.btnAdd.Text = "Add Record"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'pbUserPic
        '
        Me.pbUserPic.BackColor = System.Drawing.Color.Transparent
        Me.pbUserPic.BackgroundImage = Global.customerAddress.My.Resources.Resources._364_user
        Me.pbUserPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbUserPic.Location = New System.Drawing.Point(263, 47)
        Me.pbUserPic.Name = "pbUserPic"
        Me.pbUserPic.Size = New System.Drawing.Size(155, 155)
        Me.pbUserPic.TabIndex = 32
        Me.pbUserPic.TabStop = False
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.BackgroundImage = Global.customerAddress.My.Resources.Resources._154_windows
        Me.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Location = New System.Drawing.Point(972, 12)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(24, 24)
        Me.btnMinimize.TabIndex = 1
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.BackgroundImage = Global.customerAddress.My.Resources.Resources._325_close
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(1002, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(24, 24)
        Me.btnExit.TabIndex = 0
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.DarkGray
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnSearch.ForeColor = System.Drawing.Color.Gray
        Me.btnSearch.Image = Global.customerAddress.My.Resources.Resources._313_search1
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(264, 364)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(154, 46)
        Me.btnSearch.TabIndex = 39
        Me.btnSearch.Text = "Search Record"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.BackgroundImage = Global.customerAddress.My.Resources.Resources.cool_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1038, 821)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.pbUserPic)
        Me.Controls.Add(Me.CustomerInfoDataGridView)
        Me.Controls.Add(lblId)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(lblCName)
        Me.Controls.Add(Me.txtCName)
        Me.Controls.Add(lblCSurname)
        Me.Controls.Add(Me.txtCSurname)
        Me.Controls.Add(lblCGender)
        Me.Controls.Add(Me.cbCGender)
        Me.Controls.Add(lblCBirth)
        Me.Controls.Add(Me.txtCBirth)
        Me.Controls.Add(lblCStreet)
        Me.Controls.Add(Me.txtCStreet)
        Me.Controls.Add(lblCNeighbourhood)
        Me.Controls.Add(Me.txtCNeighbourhood)
        Me.Controls.Add(lblCBuilding)
        Me.Controls.Add(Me.txtCBuilding)
        Me.Controls.Add(lblCFlat)
        Me.Controls.Add(Me.txtCFlat)
        Me.Controls.Add(lblCPostal)
        Me.Controls.Add(Me.txtCPostal)
        Me.Controls.Add(lblCTown)
        Me.Controls.Add(Me.txtCTown)
        Me.Controls.Add(lblCProvince)
        Me.Controls.Add(Me.txtCProvince)
        Me.Controls.Add(lblCreation)
        Me.Controls.Add(Me.dpCreation)
        Me.Controls.Add(lblUpdate)
        Me.Controls.Add(Me.dpUpdate)
        Me.Controls.Add(Me.CustomerInfoBindingNavigator)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.btnExit)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main  Menu"
        CType(Me.CustomerInfoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomerInfoBindingNavigator.ResumeLayout(False)
        Me.CustomerInfoBindingNavigator.PerformLayout()
        CType(Me.CustomerInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EducationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerInfoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUserPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents EducationDataSet As EducationDataSet
    Friend WithEvents CustomerInfoBindingSource As BindingSource
    Friend WithEvents CustomerInfoTableAdapter As EducationDataSetTableAdapters.customerInfoTableAdapter
    Friend WithEvents TableAdapterManager As EducationDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomerInfoBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtCName As TextBox
    Friend WithEvents txtCSurname As TextBox
    Friend WithEvents txtCBirth As TextBox
    Friend WithEvents txtCStreet As TextBox
    Friend WithEvents txtCBuilding As TextBox
    Friend WithEvents txtCFlat As TextBox
    Friend WithEvents txtCPostal As TextBox
    Friend WithEvents txtCTown As TextBox
    Friend WithEvents txtCProvince As TextBox
    Friend WithEvents dpCreation As DateTimePicker
    Friend WithEvents dpUpdate As DateTimePicker
    Friend WithEvents pbUserPic As PictureBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents cbCGender As ComboBox
    Friend WithEvents txtCNeighbourhood As TextBox
    Friend WithEvents CustomerInfoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents customerNeighbourhoodName As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents btnSearch As Button
End Class
