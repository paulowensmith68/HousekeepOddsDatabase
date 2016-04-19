Public Class frmMain
    Private Sub btnHousekeepDatabase_Click(sender As Object, e As EventArgs) Handles btnHousekeepDatabase.Click

        ' Delete events/outcomes/betting offers
        Dim HousekeepDatabase As New HousekeepDatabaseClass()
        HousekeepDatabase.IdentifyEvents()
        HousekeepDatabase = Nothing

    End Sub
End Class
