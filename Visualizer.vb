Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SW_dataDataSet.Characters' table. You can move, or remove it, as needed.
        Me.CharactersTableAdapter.Fill(Me.SW_dataDataSet.Characters)

    End Sub

    Private Sub bttn_exit_Click(sender As Object, e As EventArgs) Handles bttn_exit.Click
        End
    End Sub

    Private Sub bttn_first_Click(sender As Object, e As EventArgs) Handles bttn_first.Click
        Me.CharactersBindingSource.MoveFirst()
    End Sub

    Private Sub bttn_previous_Click(sender As Object, e As EventArgs) Handles bttn_previous.Click
        Me.CharactersBindingSource.MovePrevious()
    End Sub

    Private Sub bttn_next_Click(sender As Object, e As EventArgs) Handles bttn_next.Click
        Me.CharactersBindingSource.MoveNext()
    End Sub

    Private Sub bttn_last_Click(sender As Object, e As EventArgs) Handles bttn_last.Click
        Me.CharactersBindingSource.MoveLast()
    End Sub
End Class
