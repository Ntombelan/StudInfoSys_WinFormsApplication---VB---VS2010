Public Class GradesForm

    Private CurrentRegistrationID

    Public Sub New(ByVal registrationID As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        CurrentRegistrationID = registrationID
    End Sub

    Private Sub GradesBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradesBindingNavigatorSaveItem.Click
        RegistrationIDTextBox.Text = CurrentRegistrationID

        If FirstGradingGradeTextBox.Text <> "" And SecondGradingGradeTextBox.Text <> "" And ThirdGradingGradeTextBox.Text <> "" And FourthGradingGradeTextBox.Text <> "" Then
            FinalGradeTextBox.Text = (Val(FirstGradingGradeTextBox.Text) + Val(SecondGradingGradeTextBox.Text) + Val(ThirdGradingGradeTextBox.Text) + Val(FourthGradingGradeTextBox.Text)) / 4

        End If
        Try

            Me.Validate()
            Me.GradesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.StudInfoSysDataSet)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub GradesForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudInfoSysDataSet.Grades' table. You can move, or remove it, as needed.
        Me.GradesTableAdapter.FillByRegistrationID(Me.StudInfoSysDataSet.Grades, CurrentRegistrationID)
        RegistrationIDTextBox.Text = CurrentRegistrationID

    End Sub

    Private Sub GradesForm_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        RegistrationIDTextBox.Text = CurrentRegistrationID

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        RegistrationIDTextBox.Text = CurrentRegistrationID

    End Sub

    Private Sub SubjectComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectComboBox.SelectedIndexChanged

    End Sub
End Class