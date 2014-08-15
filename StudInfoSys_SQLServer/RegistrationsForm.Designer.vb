<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrationsForm
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
        Dim RegistrationIDLabel As System.Windows.Forms.Label
        Dim StudentIDLabel As System.Windows.Forms.Label
        Dim YearLevelLabel As System.Windows.Forms.Label
        Dim ScholYearLabel1 As System.Windows.Forms.Label
        Dim CourseLabel As System.Windows.Forms.Label
        Dim Module1Label As System.Windows.Forms.Label
        Dim Module2Label As System.Windows.Forms.Label
        Dim Module3Label As System.Windows.Forms.Label
        Dim Modle4Label As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrationsForm))
        Me.RegistrationsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
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
        Me.RegistrationsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.viewGradesButton = New System.Windows.Forms.Button()
        Me.RegistrationIDTextBox = New System.Windows.Forms.TextBox()
        Me.StudentIDTextBox = New System.Windows.Forms.TextBox()
        Me.YearLevelComboBox = New System.Windows.Forms.ComboBox()
        Me.ScholYearDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CourseComboBox = New System.Windows.Forms.ComboBox()
        Me.Module1TextBox = New System.Windows.Forms.TextBox()
        Me.Module2TextBox = New System.Windows.Forms.TextBox()
        Me.Module3TextBox = New System.Windows.Forms.TextBox()
        Me.Modle4TextBox = New System.Windows.Forms.TextBox()
        Me.GradesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudInfoSysDataSet = New StudInfoSys_SQLServer.StudInfoSysDataSet()
        Me.RegistrationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegistrationsTableAdapter = New StudInfoSys_SQLServer.StudInfoSysDataSetTableAdapters.RegistrationsTableAdapter()
        Me.TableAdapterManager = New StudInfoSys_SQLServer.StudInfoSysDataSetTableAdapters.TableAdapterManager()
        Me.GradesTableAdapter = New StudInfoSys_SQLServer.StudInfoSysDataSetTableAdapters.GradesTableAdapter()
        Me.GradesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        RegistrationIDLabel = New System.Windows.Forms.Label()
        StudentIDLabel = New System.Windows.Forms.Label()
        YearLevelLabel = New System.Windows.Forms.Label()
        ScholYearLabel1 = New System.Windows.Forms.Label()
        CourseLabel = New System.Windows.Forms.Label()
        Module1Label = New System.Windows.Forms.Label()
        Module2Label = New System.Windows.Forms.Label()
        Module3Label = New System.Windows.Forms.Label()
        Modle4Label = New System.Windows.Forms.Label()
        CType(Me.RegistrationsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RegistrationsBindingNavigator.SuspendLayout()
        CType(Me.GradesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudInfoSysDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RegistrationIDLabel
        '
        RegistrationIDLabel.AutoSize = True
        RegistrationIDLabel.Location = New System.Drawing.Point(364, 45)
        RegistrationIDLabel.Name = "RegistrationIDLabel"
        RegistrationIDLabel.Size = New System.Drawing.Size(80, 13)
        RegistrationIDLabel.TabIndex = 3
        RegistrationIDLabel.Text = "Registration ID:"
        '
        'StudentIDLabel
        '
        StudentIDLabel.AutoSize = True
        StudentIDLabel.Location = New System.Drawing.Point(364, 73)
        StudentIDLabel.Name = "StudentIDLabel"
        StudentIDLabel.Size = New System.Drawing.Size(61, 13)
        StudentIDLabel.TabIndex = 5
        StudentIDLabel.Text = "Student ID:"
        '
        'YearLevelLabel
        '
        YearLevelLabel.AutoSize = True
        YearLevelLabel.Location = New System.Drawing.Point(23, 74)
        YearLevelLabel.Name = "YearLevelLabel"
        YearLevelLabel.Size = New System.Drawing.Size(61, 13)
        YearLevelLabel.TabIndex = 9
        YearLevelLabel.Text = "Year Level:"
        '
        'ScholYearLabel1
        '
        ScholYearLabel1.AutoSize = True
        ScholYearLabel1.Location = New System.Drawing.Point(23, 45)
        ScholYearLabel1.Name = "ScholYearLabel1"
        ScholYearLabel1.Size = New System.Drawing.Size(75, 13)
        ScholYearLabel1.TabIndex = 11
        ScholYearLabel1.Text = "Enrolling Year:"
        '
        'CourseLabel
        '
        CourseLabel.AutoSize = True
        CourseLabel.Location = New System.Drawing.Point(23, 109)
        CourseLabel.Name = "CourseLabel"
        CourseLabel.Size = New System.Drawing.Size(43, 13)
        CourseLabel.TabIndex = 12
        CourseLabel.Text = "Course:"
        '
        'Module1Label
        '
        Module1Label.AutoSize = True
        Module1Label.Location = New System.Drawing.Point(16, 141)
        Module1Label.Name = "Module1Label"
        Module1Label.Size = New System.Drawing.Size(50, 13)
        Module1Label.TabIndex = 13
        Module1Label.Text = "module1:"
        '
        'Module2Label
        '
        Module2Label.AutoSize = True
        Module2Label.Location = New System.Drawing.Point(16, 167)
        Module2Label.Name = "Module2Label"
        Module2Label.Size = New System.Drawing.Size(50, 13)
        Module2Label.TabIndex = 15
        Module2Label.Text = "module2:"
        '
        'Module3Label
        '
        Module3Label.AutoSize = True
        Module3Label.Location = New System.Drawing.Point(16, 193)
        Module3Label.Name = "Module3Label"
        Module3Label.Size = New System.Drawing.Size(50, 13)
        Module3Label.TabIndex = 17
        Module3Label.Text = "module3:"
        '
        'Modle4Label
        '
        Modle4Label.AutoSize = True
        Modle4Label.Location = New System.Drawing.Point(22, 219)
        Modle4Label.Name = "Modle4Label"
        Modle4Label.Size = New System.Drawing.Size(44, 13)
        Modle4Label.TabIndex = 19
        Modle4Label.Text = "modle4:"
        '
        'RegistrationsBindingNavigator
        '
        Me.RegistrationsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RegistrationsBindingNavigator.BindingSource = Me.RegistrationsBindingSource
        Me.RegistrationsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RegistrationsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RegistrationsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RegistrationsBindingNavigatorSaveItem})
        Me.RegistrationsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RegistrationsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RegistrationsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RegistrationsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RegistrationsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RegistrationsBindingNavigator.Name = "RegistrationsBindingNavigator"
        Me.RegistrationsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RegistrationsBindingNavigator.Size = New System.Drawing.Size(837, 25)
        Me.RegistrationsBindingNavigator.TabIndex = 0
        Me.RegistrationsBindingNavigator.Text = "BindingNavigator1"
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
        'RegistrationsBindingNavigatorSaveItem
        '
        Me.RegistrationsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RegistrationsBindingNavigatorSaveItem.Image = CType(resources.GetObject("RegistrationsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RegistrationsBindingNavigatorSaveItem.Name = "RegistrationsBindingNavigatorSaveItem"
        Me.RegistrationsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.RegistrationsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'viewGradesButton
        '
        Me.viewGradesButton.Location = New System.Drawing.Point(328, 319)
        Me.viewGradesButton.Name = "viewGradesButton"
        Me.viewGradesButton.Size = New System.Drawing.Size(197, 23)
        Me.viewGradesButton.TabIndex = 2
        Me.viewGradesButton.Text = "Submit"
        Me.viewGradesButton.UseVisualStyleBackColor = True
        '
        'RegistrationIDTextBox
        '
        Me.RegistrationIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationsBindingSource, "RegistrationID", True))
        Me.RegistrationIDTextBox.Location = New System.Drawing.Point(450, 42)
        Me.RegistrationIDTextBox.Name = "RegistrationIDTextBox"
        Me.RegistrationIDTextBox.ReadOnly = True
        Me.RegistrationIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RegistrationIDTextBox.TabIndex = 4
        '
        'StudentIDTextBox
        '
        Me.StudentIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationsBindingSource, "StudentID", True))
        Me.StudentIDTextBox.Location = New System.Drawing.Point(450, 70)
        Me.StudentIDTextBox.Name = "StudentIDTextBox"
        Me.StudentIDTextBox.ReadOnly = True
        Me.StudentIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StudentIDTextBox.TabIndex = 6
        '
        'YearLevelComboBox
        '
        Me.YearLevelComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationsBindingSource, "YearLevel", True))
        Me.YearLevelComboBox.FormattingEnabled = True
        Me.YearLevelComboBox.Items.AddRange(New Object() {"First Year", "Second Year", "Third Year", "Fourth Year"})
        Me.YearLevelComboBox.Location = New System.Drawing.Point(109, 66)
        Me.YearLevelComboBox.Name = "YearLevelComboBox"
        Me.YearLevelComboBox.Size = New System.Drawing.Size(197, 21)
        Me.YearLevelComboBox.TabIndex = 1
        '
        'ScholYearDateTimePicker
        '
        Me.ScholYearDateTimePicker.CustomFormat = "yyyy"
        Me.ScholYearDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RegistrationsBindingSource, "ScholYear", True))
        Me.ScholYearDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ScholYearDateTimePicker.Location = New System.Drawing.Point(108, 41)
        Me.ScholYearDateTimePicker.MaxDate = New Date(2029, 12, 31, 0, 0, 0, 0)
        Me.ScholYearDateTimePicker.MinDate = New Date(2014, 1, 1, 0, 0, 0, 0)
        Me.ScholYearDateTimePicker.Name = "ScholYearDateTimePicker"
        Me.ScholYearDateTimePicker.Size = New System.Drawing.Size(58, 20)
        Me.ScholYearDateTimePicker.TabIndex = 12
        '
        'CourseComboBox
        '
        Me.CourseComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GradesBindingSource, "Course", True))
        Me.CourseComboBox.FormattingEnabled = True
        Me.CourseComboBox.Items.AddRange(New Object() {"Accounting", "Computer systems"})
        Me.CourseComboBox.Location = New System.Drawing.Point(72, 106)
        Me.CourseComboBox.Name = "CourseComboBox"
        Me.CourseComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CourseComboBox.TabIndex = 13
        Me.CourseComboBox.Text = "select"
        '
        'Module1TextBox
        '
        Me.Module1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GradesBindingSource, "module1", True))
        Me.Module1TextBox.Location = New System.Drawing.Point(72, 138)
        Me.Module1TextBox.Name = "Module1TextBox"
        Me.Module1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Module1TextBox.TabIndex = 14
        '
        'Module2TextBox
        '
        Me.Module2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GradesBindingSource, "module2", True))
        Me.Module2TextBox.Location = New System.Drawing.Point(72, 164)
        Me.Module2TextBox.Name = "Module2TextBox"
        Me.Module2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Module2TextBox.TabIndex = 16
        '
        'Module3TextBox
        '
        Me.Module3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GradesBindingSource, "module3", True))
        Me.Module3TextBox.Location = New System.Drawing.Point(72, 190)
        Me.Module3TextBox.Name = "Module3TextBox"
        Me.Module3TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Module3TextBox.TabIndex = 18
        '
        'Modle4TextBox
        '
        Me.Modle4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GradesBindingSource, "modle4", True))
        Me.Modle4TextBox.Location = New System.Drawing.Point(72, 216)
        Me.Modle4TextBox.Name = "Modle4TextBox"
        Me.Modle4TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Modle4TextBox.TabIndex = 20
        '
        'GradesBindingSource
        '
        Me.GradesBindingSource.DataMember = "Grades"
        Me.GradesBindingSource.DataSource = Me.StudInfoSysDataSet
        '
        'StudInfoSysDataSet
        '
        Me.StudInfoSysDataSet.DataSetName = "StudInfoSysDataSet"
        Me.StudInfoSysDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RegistrationsBindingSource
        '
        Me.RegistrationsBindingSource.DataMember = "Registrations"
        Me.RegistrationsBindingSource.DataSource = Me.StudInfoSysDataSet
        '
        'RegistrationsTableAdapter
        '
        Me.RegistrationsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.GradesTableAdapter = Nothing
        Me.TableAdapterManager.RegistrationsTableAdapter = Me.RegistrationsTableAdapter
        Me.TableAdapterManager.StudentsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = StudInfoSys_SQLServer.StudInfoSysDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GradesTableAdapter
        '
        Me.GradesTableAdapter.ClearBeforeFill = True
        '
        'GradesBindingSource1
        '
        Me.GradesBindingSource1.DataMember = "Grades"
        Me.GradesBindingSource1.DataSource = Me.StudInfoSysDataSet
        '
        'RegistrationsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 362)
        Me.Controls.Add(Modle4Label)
        Me.Controls.Add(Me.Modle4TextBox)
        Me.Controls.Add(Module3Label)
        Me.Controls.Add(Me.Module3TextBox)
        Me.Controls.Add(Module2Label)
        Me.Controls.Add(Me.Module2TextBox)
        Me.Controls.Add(Module1Label)
        Me.Controls.Add(Me.Module1TextBox)
        Me.Controls.Add(CourseLabel)
        Me.Controls.Add(Me.CourseComboBox)
        Me.Controls.Add(ScholYearLabel1)
        Me.Controls.Add(Me.ScholYearDateTimePicker)
        Me.Controls.Add(YearLevelLabel)
        Me.Controls.Add(Me.YearLevelComboBox)
        Me.Controls.Add(RegistrationIDLabel)
        Me.Controls.Add(Me.RegistrationIDTextBox)
        Me.Controls.Add(StudentIDLabel)
        Me.Controls.Add(Me.StudentIDTextBox)
        Me.Controls.Add(Me.viewGradesButton)
        Me.Controls.Add(Me.RegistrationsBindingNavigator)
        Me.Name = "RegistrationsForm"
        Me.Text = "Registrations Form"
        CType(Me.RegistrationsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RegistrationsBindingNavigator.ResumeLayout(False)
        Me.RegistrationsBindingNavigator.PerformLayout()
        CType(Me.GradesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudInfoSysDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistrationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StudInfoSysDataSet As StudInfoSys_SQLServer.StudInfoSysDataSet
    Friend WithEvents RegistrationsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RegistrationsTableAdapter As StudInfoSys_SQLServer.StudInfoSysDataSetTableAdapters.RegistrationsTableAdapter
    Friend WithEvents TableAdapterManager As StudInfoSys_SQLServer.StudInfoSysDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RegistrationsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents RegistrationsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents viewGradesButton As System.Windows.Forms.Button
    Friend WithEvents RegistrationIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StudentIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents YearLevelComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ScholYearDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents GradesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GradesTableAdapter As StudInfoSys_SQLServer.StudInfoSysDataSetTableAdapters.GradesTableAdapter
    Friend WithEvents CourseComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Module1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Module2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Module3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Modle4TextBox As System.Windows.Forms.TextBox
    Friend WithEvents GradesBindingSource1 As System.Windows.Forms.BindingSource
End Class
