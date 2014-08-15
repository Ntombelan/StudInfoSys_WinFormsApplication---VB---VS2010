<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentsForm
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
        Dim StudentIDLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim BirthdateLabel As System.Windows.Forms.Label
        Dim ReligionLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim ContactNumberLabel As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim InitialsLabel As System.Windows.Forms.Label
        Dim SurnameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentsForm))
        Me.StudentsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.StudentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudInfoSysDataSet = New StudInfoSys_SQLServer.StudInfoSysDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.StudentsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.searchByLastNameTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.searchButton = New System.Windows.Forms.ToolStripButton()
        Me.StudentIDTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.BirthdateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ReligionTextBox = New System.Windows.Forms.TextBox()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.ContactNumberTextBox = New System.Windows.Forms.TextBox()
        Me.viewRegistrationsButton = New System.Windows.Forms.Button()
        Me.StudentsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Initials = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Surname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleComboBox = New System.Windows.Forms.ComboBox()
        Me.InitialsTextBox = New System.Windows.Forms.TextBox()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.StudentsTableAdapter = New StudInfoSys_SQLServer.StudInfoSysDataSetTableAdapters.StudentsTableAdapter()
        Me.TableAdapterManager = New StudInfoSys_SQLServer.StudInfoSysDataSetTableAdapters.TableAdapterManager()
        StudentIDLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        BirthdateLabel = New System.Windows.Forms.Label()
        ReligionLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        ContactNumberLabel = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        InitialsLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        CType(Me.StudentsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StudentsBindingNavigator.SuspendLayout()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudInfoSysDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentIDLabel
        '
        StudentIDLabel.AutoSize = True
        StudentIDLabel.Location = New System.Drawing.Point(12, 46)
        StudentIDLabel.Name = "StudentIDLabel"
        StudentIDLabel.Size = New System.Drawing.Size(61, 13)
        StudentIDLabel.TabIndex = 1
        StudentIDLabel.Text = "Student ID:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(12, 144)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 9
        AddressLabel.Text = "Address:"
        '
        'BirthdateLabel
        '
        BirthdateLabel.AutoSize = True
        BirthdateLabel.Location = New System.Drawing.Point(12, 196)
        BirthdateLabel.Name = "BirthdateLabel"
        BirthdateLabel.Size = New System.Drawing.Size(52, 13)
        BirthdateLabel.TabIndex = 11
        BirthdateLabel.Text = "Birthdate:"
        '
        'ReligionLabel
        '
        ReligionLabel.AutoSize = True
        ReligionLabel.Location = New System.Drawing.Point(12, 221)
        ReligionLabel.Name = "ReligionLabel"
        ReligionLabel.Size = New System.Drawing.Size(48, 13)
        ReligionLabel.TabIndex = 13
        ReligionLabel.Text = "Religion:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(316, 196)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(45, 13)
        GenderLabel.TabIndex = 15
        GenderLabel.Text = "Gender:"
        '
        'ContactNumberLabel
        '
        ContactNumberLabel.AutoSize = True
        ContactNumberLabel.Location = New System.Drawing.Point(276, 221)
        ContactNumberLabel.Name = "ContactNumberLabel"
        ContactNumberLabel.Size = New System.Drawing.Size(87, 13)
        ContactNumberLabel.TabIndex = 17
        ContactNumberLabel.Text = "Contact Number:"
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Location = New System.Drawing.Point(15, 106)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(30, 13)
        TitleLabel.TabIndex = 17
        TitleLabel.Text = "Title:"
        '
        'InitialsLabel
        '
        InitialsLabel.AutoSize = True
        InitialsLabel.Location = New System.Drawing.Point(198, 109)
        InitialsLabel.Name = "InitialsLabel"
        InitialsLabel.Size = New System.Drawing.Size(39, 13)
        InitialsLabel.TabIndex = 18
        InitialsLabel.Text = "Initials:"
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.Location = New System.Drawing.Point(379, 109)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(52, 13)
        SurnameLabel.TabIndex = 19
        SurnameLabel.Text = "Surname:"
        '
        'StudentsBindingNavigator
        '
        Me.StudentsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StudentsBindingNavigator.BindingSource = Me.StudentsBindingSource
        Me.StudentsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StudentsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StudentsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StudentsBindingNavigatorSaveItem, Me.ToolStripSeparator1, Me.searchByLastNameTextBox, Me.searchButton})
        Me.StudentsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.StudentsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StudentsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StudentsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StudentsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StudentsBindingNavigator.Name = "StudentsBindingNavigator"
        Me.StudentsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StudentsBindingNavigator.Size = New System.Drawing.Size(609, 25)
        Me.StudentsBindingNavigator.TabIndex = 0
        Me.StudentsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'StudentsBindingSource
        '
        Me.StudentsBindingSource.DataMember = "Students"
        Me.StudentsBindingSource.DataSource = Me.StudInfoSysDataSet
        '
        'StudInfoSysDataSet
        '
        Me.StudInfoSysDataSet.DataSetName = "StudInfoSysDataSet"
        Me.StudInfoSysDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
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
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
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
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
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
        'StudentsBindingNavigatorSaveItem
        '
        Me.StudentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StudentsBindingNavigatorSaveItem.Image = CType(resources.GetObject("StudentsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StudentsBindingNavigatorSaveItem.Name = "StudentsBindingNavigatorSaveItem"
        Me.StudentsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.StudentsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'searchByLastNameTextBox
        '
        Me.searchByLastNameTextBox.Name = "searchByLastNameTextBox"
        Me.searchByLastNameTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'searchButton
        '
        Me.searchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.searchButton.Image = CType(resources.GetObject("searchButton.Image"), System.Drawing.Image)
        Me.searchButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(121, 22)
        Me.searchButton.Text = "Search by Last Name"
        '
        'StudentIDTextBox
        '
        Me.StudentIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "StudentID", True))
        Me.StudentIDTextBox.Location = New System.Drawing.Point(79, 43)
        Me.StudentIDTextBox.Name = "StudentIDTextBox"
        Me.StudentIDTextBox.ReadOnly = True
        Me.StudentIDTextBox.Size = New System.Drawing.Size(108, 20)
        Me.StudentIDTextBox.TabIndex = 2
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(15, 160)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(502, 20)
        Me.AddressTextBox.TabIndex = 3
        '
        'BirthdateDateTimePicker
        '
        Me.BirthdateDateTimePicker.CustomFormat = "MMM dd, yyyy"
        Me.BirthdateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StudentsBindingSource, "Birthdate", True))
        Me.BirthdateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.BirthdateDateTimePicker.Location = New System.Drawing.Point(70, 192)
        Me.BirthdateDateTimePicker.MaxDate = New Date(1998, 12, 31, 0, 0, 0, 0)
        Me.BirthdateDateTimePicker.MinDate = New Date(1939, 12, 31, 0, 0, 0, 0)
        Me.BirthdateDateTimePicker.Name = "BirthdateDateTimePicker"
        Me.BirthdateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.BirthdateDateTimePicker.TabIndex = 4
        Me.BirthdateDateTimePicker.Value = New Date(1998, 12, 31, 0, 0, 0, 0)
        '
        'ReligionTextBox
        '
        Me.ReligionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "Religion", True))
        Me.ReligionTextBox.Location = New System.Drawing.Point(70, 218)
        Me.ReligionTextBox.Name = "ReligionTextBox"
        Me.ReligionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ReligionTextBox.TabIndex = 6
        '
        'GenderComboBox
        '
        Me.GenderComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "Gender", True))
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenderComboBox.Location = New System.Drawing.Point(366, 191)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(151, 21)
        Me.GenderComboBox.TabIndex = 5
        '
        'ContactNumberTextBox
        '
        Me.ContactNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "ContactNumber", True))
        Me.ContactNumberTextBox.Location = New System.Drawing.Point(366, 218)
        Me.ContactNumberTextBox.Name = "ContactNumberTextBox"
        Me.ContactNumberTextBox.Size = New System.Drawing.Size(154, 20)
        Me.ContactNumberTextBox.TabIndex = 7
        '
        'viewRegistrationsButton
        '
        Me.viewRegistrationsButton.Location = New System.Drawing.Point(279, 244)
        Me.viewRegistrationsButton.Name = "viewRegistrationsButton"
        Me.viewRegistrationsButton.Size = New System.Drawing.Size(241, 23)
        Me.viewRegistrationsButton.TabIndex = 8
        Me.viewRegistrationsButton.Text = "View Registrations"
        Me.viewRegistrationsButton.UseVisualStyleBackColor = True
        '
        'StudentsDataGridView
        '
        Me.StudentsDataGridView.AllowUserToAddRows = False
        Me.StudentsDataGridView.AllowUserToDeleteRows = False
        Me.StudentsDataGridView.AutoGenerateColumns = False
        Me.StudentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.Title, Me.Initials, Me.Surname})
        Me.StudentsDataGridView.DataSource = Me.StudentsBindingSource
        Me.StudentsDataGridView.Location = New System.Drawing.Point(12, 293)
        Me.StudentsDataGridView.MultiSelect = False
        Me.StudentsDataGridView.Name = "StudentsDataGridView"
        Me.StudentsDataGridView.ReadOnly = True
        Me.StudentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.StudentsDataGridView.Size = New System.Drawing.Size(575, 220)
        Me.StudentsDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "StudentID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "StudentID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Birthdate"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Birthdate"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Religion"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Religion"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Gender"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ContactNumber"
        Me.DataGridViewTextBoxColumn9.HeaderText = "ContactNumber"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'Title
        '
        Me.Title.DataPropertyName = "Title"
        Me.Title.HeaderText = "Title"
        Me.Title.Name = "Title"
        Me.Title.ReadOnly = True
        '
        'Initials
        '
        Me.Initials.DataPropertyName = "Initials"
        Me.Initials.HeaderText = "Initials"
        Me.Initials.Name = "Initials"
        Me.Initials.ReadOnly = True
        '
        'Surname
        '
        Me.Surname.DataPropertyName = "Surname"
        Me.Surname.HeaderText = "Surname"
        Me.Surname.Name = "Surname"
        Me.Surname.ReadOnly = True
        '
        'TitleComboBox
        '
        Me.TitleComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "Title", True))
        Me.TitleComboBox.FormattingEnabled = True
        Me.TitleComboBox.Items.AddRange(New Object() {"Mr", "Miss", "Mrs"})
        Me.TitleComboBox.Location = New System.Drawing.Point(51, 103)
        Me.TitleComboBox.Name = "TitleComboBox"
        Me.TitleComboBox.Size = New System.Drawing.Size(121, 21)
        Me.TitleComboBox.TabIndex = 18
        '
        'InitialsTextBox
        '
        Me.InitialsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "Initials", True))
        Me.InitialsTextBox.Location = New System.Drawing.Point(243, 106)
        Me.InitialsTextBox.Name = "InitialsTextBox"
        Me.InitialsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.InitialsTextBox.TabIndex = 19
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "Surname", True))
        Me.SurnameTextBox.Location = New System.Drawing.Point(437, 106)
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SurnameTextBox.TabIndex = 20
        '
        'StudentsTableAdapter
        '
        Me.StudentsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.GradesTableAdapter = Nothing
        Me.TableAdapterManager.RegistrationsTableAdapter = Nothing
        Me.TableAdapterManager.StudentsTableAdapter = Me.StudentsTableAdapter
        Me.TableAdapterManager.UpdateOrder = StudInfoSys_SQLServer.StudInfoSysDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StudentsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 533)
        Me.Controls.Add(SurnameLabel)
        Me.Controls.Add(Me.SurnameTextBox)
        Me.Controls.Add(InitialsLabel)
        Me.Controls.Add(Me.InitialsTextBox)
        Me.Controls.Add(TitleLabel)
        Me.Controls.Add(Me.TitleComboBox)
        Me.Controls.Add(Me.StudentsDataGridView)
        Me.Controls.Add(Me.viewRegistrationsButton)
        Me.Controls.Add(StudentIDLabel)
        Me.Controls.Add(Me.StudentIDTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(BirthdateLabel)
        Me.Controls.Add(Me.BirthdateDateTimePicker)
        Me.Controls.Add(ReligionLabel)
        Me.Controls.Add(Me.ReligionTextBox)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderComboBox)
        Me.Controls.Add(ContactNumberLabel)
        Me.Controls.Add(Me.ContactNumberTextBox)
        Me.Controls.Add(Me.StudentsBindingNavigator)
        Me.Name = "StudentsForm"
        Me.Text = "Students Form"
        CType(Me.StudentsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StudentsBindingNavigator.ResumeLayout(False)
        Me.StudentsBindingNavigator.PerformLayout()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudInfoSysDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StudInfoSysDataSet As StudInfoSys_SQLServer.StudInfoSysDataSet
    Friend WithEvents StudentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentsTableAdapter As StudInfoSys_SQLServer.StudInfoSysDataSetTableAdapters.StudentsTableAdapter
    Friend WithEvents TableAdapterManager As StudInfoSys_SQLServer.StudInfoSysDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StudentsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StudentsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents StudentIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BirthdateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ReligionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenderComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ContactNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents searchByLastNameTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents searchButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents viewRegistrationsButton As System.Windows.Forms.Button
    Friend WithEvents StudentsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TitleComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents InitialsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SurnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Title As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Initials As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Surname As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
