Imports StudInfoSys_SQLServer
Imports System.Windows.Forms
Public Class StudentsForm



    Private Sub StudentsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudInfoSysDataSet.Students' table. You can move, or remove it, as needed
        Me.StudentsTableAdapter.Fill(Me.StudInfoSysDataSet.Students)



        ' StudentBindingSource.DataSource = context.Students


    End Sub

    Private Sub StudentsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsBindingNavigatorSaveItem.Click

        Try
            Me.Validate()
            Me.StudentsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.StudInfoSysDataSet)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub searchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchButton.Click

        If searchByLastNameTextBox.Text <> "" Then
            Me.StudentsTableAdapter.FillByLastName(Me.StudInfoSysDataSet.Students, searchByLastNameTextBox.Text)
        Else
            Me.StudentsTableAdapter.Fill(Me.StudInfoSysDataSet.Students)
        End If

    End Sub

    Private Sub viewRegistrationsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles viewRegistrationsButton.Click

        Me.StudentsTableAdapter.Fill(Me.StudInfoSysDataSet.Students)
        Dim currstud As Integer = StudentIDTextBox.Text
        If currstud > 0 Then

            Dim f As New RegistrationsForm(currstud)
            f.ShowDialog()
        End If

    End Sub

   
End Class