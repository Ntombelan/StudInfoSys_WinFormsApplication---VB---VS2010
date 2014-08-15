Public Class RegistrationsForm

    Private CurrentStudentID As Integer

    Public Sub New(ByVal studentID As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        CurrentStudentID = studentID
    End Sub

    Private Sub RegistrationsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrationsBindingNavigatorSaveItem.Click

        Try
            StudentIDTextBox.Text = CurrentStudentID
            Me.Validate()
            Me.RegistrationsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.StudInfoSysDataSet)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub RegistrationsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudInfoSysDataSet.Grades' table. You can move, or remove it, as needed.
        Me.GradesTableAdapter.Fill(Me.StudInfoSysDataSet.Grades)
        'TODO: This line of code loads data into the 'StudInfoSysDataSet.Registrations' table. You can move, or remove it, as needed.
        Me.RegistrationsTableAdapter.FillByStudentID(Me.StudInfoSysDataSet.Registrations, CurrentStudentID)

    End Sub

    Private Sub viewGradesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles viewGradesButton.Click


        If CourseComboBox.SelectedIndex = 0 Then
            Module1TextBox.Text = ("TAX")
            Module2TextBox.Text = ("AUDITING")
            Module3TextBox.Text = ("COST ACCOUNTING")
            Modle4TextBox.Text = ("BUISNESS MANAGEMENT")
            MsgBox("You have registered for Accounting")

        ElseIf CourseComboBox.SelectedIndex = 1 Then
            Module1TextBox.Text = ("PROGRAMMING")
            Module2TextBox.Text = ("DIGITS")
            Module3TextBox.Text = ("ELECTRICAL")
            Modle4TextBox.Text = ("ELECTRONICS")
            MsgBox("You have registered for Computer systems eng")

        End If












        Dim currreg As Integer = RegistrationIDTextBox.Text
        If currreg > 0 Then

            Dim f As New GradesForm(currreg)
            f.ShowDialog()
        End If
    End Sub

 
   
End Class