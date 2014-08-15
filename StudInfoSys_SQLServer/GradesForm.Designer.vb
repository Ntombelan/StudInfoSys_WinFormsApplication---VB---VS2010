<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GradesForm
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
        Dim FirstGradingGradeLabel As System.Windows.Forms.Label
        Dim SecondGradingGradeLabel As System.Windows.Forms.Label
        Dim ThirdGradingGradeLabel As System.Windows.Forms.Label
        Dim FourthGradingGradeLabel As System.Windows.Forms.Label
        Dim FinalGradeLabel As System.Windows.Forms.Label
        Dim SubjectLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GradesForm))
        Me.GradesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.GradesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.GradesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.RegistrationIDTextBox = New System.Windows.Forms.TextBox()
        Me.FirstGradingGradeTextBox = New System.Windows.Forms.TextBox()
        Me.SecondGradingGradeTextBox = New System.Windows.Forms.TextBox()
        Me.ThirdGradingGradeTextBox = New System.Windows.Forms.TextBox()
        Me.FourthGradingGradeTextBox = New System.Windows.Forms.TextBox()
        Me.FinalGradeTextBox = New System.Windows.Forms.TextBox()
        Me.SubjectComboBox = New System.Windows.Forms.ComboBox()
        Me.GradesTableAdapter = New StudInfoSys_SQLServer.StudInfoSysDataSetTableAdapters.GradesTableAdapter()
        Me.TableAdapterManager = New StudInfoSys_SQLServer.StudInfoSysDataSetTableAdapters.TableAdapterManager()
        RegistrationIDLabel = New System.Windows.Forms.Label()
        FirstGradingGradeLabel = New System.Windows.Forms.Label()
        SecondGradingGradeLabel = New System.Windows.Forms.Label()
        ThirdGradingGradeLabel = New System.Windows.Forms.Label()
        FourthGradingGradeLabel = New System.Windows.Forms.Label()
        FinalGradeLabel = New System.Windows.Forms.Label()
        SubjectLabel = New System.Windows.Forms.Label()
        CType(Me.GradesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GradesBindingNavigator.SuspendLayout()
        CType(Me.GradesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudInfoSysDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RegistrationIDLabel
        '
        RegistrationIDLabel.AutoSize = True
        RegistrationIDLabel.Location = New System.Drawing.Point(367, 69)
        RegistrationIDLabel.Name = "RegistrationIDLabel"
        RegistrationIDLabel.Size = New System.Drawing.Size(80, 13)
        RegistrationIDLabel.TabIndex = 1
        RegistrationIDLabel.Text = "Registration ID:"
        '
        'FirstGradingGradeLabel
        '
        FirstGradingGradeLabel.AutoSize = True
        FirstGradingGradeLabel.Location = New System.Drawing.Point(11, 69)
        FirstGradingGradeLabel.Name = "FirstGradingGradeLabel"
        FirstGradingGradeLabel.Size = New System.Drawing.Size(40, 13)
        FirstGradingGradeLabel.TabIndex = 5
        FirstGradingGradeLabel.Text = "Test 1:"
        '
        'SecondGradingGradeLabel
        '
        SecondGradingGradeLabel.AutoSize = True
        SecondGradingGradeLabel.Location = New System.Drawing.Point(11, 95)
        SecondGradingGradeLabel.Name = "SecondGradingGradeLabel"
        SecondGradingGradeLabel.Size = New System.Drawing.Size(40, 13)
        SecondGradingGradeLabel.TabIndex = 7
        SecondGradingGradeLabel.Text = "Test 2:"
        '
        'ThirdGradingGradeLabel
        '
        ThirdGradingGradeLabel.AutoSize = True
        ThirdGradingGradeLabel.Location = New System.Drawing.Point(11, 121)
        ThirdGradingGradeLabel.Name = "ThirdGradingGradeLabel"
        ThirdGradingGradeLabel.Size = New System.Drawing.Size(40, 13)
        ThirdGradingGradeLabel.TabIndex = 9
        ThirdGradingGradeLabel.Text = "Test 3:"
        '
        'FourthGradingGradeLabel
        '
        FourthGradingGradeLabel.AutoSize = True
        FourthGradingGradeLabel.Location = New System.Drawing.Point(11, 147)
        FourthGradingGradeLabel.Name = "FourthGradingGradeLabel"
        FourthGradingGradeLabel.Size = New System.Drawing.Size(58, 13)
        FourthGradingGradeLabel.TabIndex = 11
        FourthGradingGradeLabel.Text = "Assigment:"
        '
        'FinalGradeLabel
        '
        FinalGradeLabel.AutoSize = True
        FinalGradeLabel.Location = New System.Drawing.Point(11, 192)
        FinalGradeLabel.Name = "FinalGradeLabel"
        FinalGradeLabel.Size = New System.Drawing.Size(64, 13)
        FinalGradeLabel.TabIndex = 13
        FinalGradeLabel.Text = "Final Grade:"
        '
        'SubjectLabel
        '
        SubjectLabel.AutoSize = True
        SubjectLabel.Location = New System.Drawing.Point(11, 47)
        SubjectLabel.Name = "SubjectLabel"
        SubjectLabel.Size = New System.Drawing.Size(46, 13)
        SubjectLabel.TabIndex = 14
        SubjectLabel.Text = "Subject:"
        '
        'GradesBindingNavigator
        '
        Me.GradesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.GradesBindingNavigator.BindingSource = Me.GradesBindingSource
        Me.GradesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.GradesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.GradesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.GradesBindingNavigatorSaveItem})
        Me.GradesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.GradesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.GradesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.GradesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.GradesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.GradesBindingNavigator.Name = "GradesBindingNavigator"
        Me.GradesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.GradesBindingNavigator.Size = New System.Drawing.Size(548, 25)
        Me.GradesBindingNavigator.TabIndex = 0
        Me.GradesBindingNavigator.Text = "BindingNavigator1"
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
        'GradesBindingNavigatorSaveItem
        '
        Me.GradesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GradesBindingNavigatorSaveItem.Image = CType(resources.GetObject("GradesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.GradesBindingNavigatorSaveItem.Name = "GradesBindingNavigatorSaveItem"
        Me.GradesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.GradesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'RegistrationIDTextBox
        '
        Me.RegistrationIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GradesBindingSource, "RegistrationID", True))
        Me.RegistrationIDTextBox.Location = New System.Drawing.Point(492, 66)
        Me.RegistrationIDTextBox.Name = "RegistrationIDTextBox"
        Me.RegistrationIDTextBox.ReadOnly = True
        Me.RegistrationIDTextBox.Size = New System.Drawing.Size(121, 20)
        Me.RegistrationIDTextBox.TabIndex = 2
        '
        'FirstGradingGradeTextBox
        '
        Me.FirstGradingGradeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GradesBindingSource, "FirstGradingGrade", True))
        Me.FirstGradingGradeTextBox.Location = New System.Drawing.Point(136, 66)
        Me.FirstGradingGradeTextBox.Name = "FirstGradingGradeTextBox"
        Me.FirstGradingGradeTextBox.Size = New System.Drawing.Size(165, 20)
        Me.FirstGradingGradeTextBox.TabIndex = 1
        '
        'SecondGradingGradeTextBox
        '
        Me.SecondGradingGradeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GradesBindingSource, "SecondGradingGrade", True))
        Me.SecondGradingGradeTextBox.Location = New System.Drawing.Point(136, 92)
        Me.SecondGradingGradeTextBox.Name = "SecondGradingGradeTextBox"
        Me.SecondGradingGradeTextBox.Size = New System.Drawing.Size(165, 20)
        Me.SecondGradingGradeTextBox.TabIndex = 2
        '
        'ThirdGradingGradeTextBox
        '
        Me.ThirdGradingGradeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GradesBindingSource, "ThirdGradingGrade", True))
        Me.ThirdGradingGradeTextBox.Location = New System.Drawing.Point(136, 118)
        Me.ThirdGradingGradeTextBox.Name = "ThirdGradingGradeTextBox"
        Me.ThirdGradingGradeTextBox.Size = New System.Drawing.Size(165, 20)
        Me.ThirdGradingGradeTextBox.TabIndex = 3
        '
        'FourthGradingGradeTextBox
        '
        Me.FourthGradingGradeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GradesBindingSource, "FourthGradingGrade", True))
        Me.FourthGradingGradeTextBox.Location = New System.Drawing.Point(136, 144)
        Me.FourthGradingGradeTextBox.Name = "FourthGradingGradeTextBox"
        Me.FourthGradingGradeTextBox.Size = New System.Drawing.Size(165, 20)
        Me.FourthGradingGradeTextBox.TabIndex = 4
        '
        'FinalGradeTextBox
        '
        Me.FinalGradeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GradesBindingSource, "FinalGrade", True))
        Me.FinalGradeTextBox.Location = New System.Drawing.Point(136, 189)
        Me.FinalGradeTextBox.Name = "FinalGradeTextBox"
        Me.FinalGradeTextBox.ReadOnly = True
        Me.FinalGradeTextBox.Size = New System.Drawing.Size(165, 20)
        Me.FinalGradeTextBox.TabIndex = 14
        '
        'SubjectComboBox
        '
        Me.SubjectComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GradesBindingSource, "Subject", True))
        Me.SubjectComboBox.FormattingEnabled = True
        Me.SubjectComboBox.Items.AddRange(New Object() {"Accounting", "Computer system"})
        Me.SubjectComboBox.Location = New System.Drawing.Point(136, 39)
        Me.SubjectComboBox.Name = "SubjectComboBox"
        Me.SubjectComboBox.Size = New System.Drawing.Size(165, 21)
        Me.SubjectComboBox.TabIndex = 0
        '
        'GradesTableAdapter
        '
        Me.GradesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.GradesTableAdapter = Me.GradesTableAdapter
        Me.TableAdapterManager.RegistrationsTableAdapter = Nothing
        Me.TableAdapterManager.StudentsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = StudInfoSys_SQLServer.StudInfoSysDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GradesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 449)
        Me.Controls.Add(SubjectLabel)
        Me.Controls.Add(Me.SubjectComboBox)
        Me.Controls.Add(RegistrationIDLabel)
        Me.Controls.Add(Me.RegistrationIDTextBox)
        Me.Controls.Add(FirstGradingGradeLabel)
        Me.Controls.Add(Me.FirstGradingGradeTextBox)
        Me.Controls.Add(SecondGradingGradeLabel)
        Me.Controls.Add(Me.SecondGradingGradeTextBox)
        Me.Controls.Add(ThirdGradingGradeLabel)
        Me.Controls.Add(Me.ThirdGradingGradeTextBox)
        Me.Controls.Add(FourthGradingGradeLabel)
        Me.Controls.Add(Me.FourthGradingGradeTextBox)
        Me.Controls.Add(FinalGradeLabel)
        Me.Controls.Add(Me.FinalGradeTextBox)
        Me.Controls.Add(Me.GradesBindingNavigator)
        Me.Name = "GradesForm"
        Me.Text = "Grades Form"
        CType(Me.GradesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GradesBindingNavigator.ResumeLayout(False)
        Me.GradesBindingNavigator.PerformLayout()
        CType(Me.GradesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudInfoSysDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StudInfoSysDataSet As StudInfoSys_SQLServer.StudInfoSysDataSet
    Friend WithEvents GradesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GradesTableAdapter As StudInfoSys_SQLServer.StudInfoSysDataSetTableAdapters.GradesTableAdapter
    Friend WithEvents TableAdapterManager As StudInfoSys_SQLServer.StudInfoSysDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GradesBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents GradesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents RegistrationIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstGradingGradeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SecondGradingGradeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ThirdGradingGradeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FourthGradingGradeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FinalGradeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SubjectComboBox As System.Windows.Forms.ComboBox
End Class
