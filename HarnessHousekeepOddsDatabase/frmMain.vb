Public Class frmMain
    Private Sub btnHousekeepDatabase_Click(sender As Object, e As EventArgs) Handles btnHousekeepDatabase.Click

        'If My.Settings.HousekeepPastEvents Then

        '    ' Delete events/outcomes/betting offers
        '    Dim HousekeepDatabase As New HousekeepDatabaseClass()
        '    HousekeepDatabase.IdentifyEvents()
        '    HousekeepDatabase = Nothing

        'End If


        If My.Settings.HousekeepStagingTables Then

            ' Delete orphaned betting offers from staging table bookmaker_xml_nodes
            Dim HousekeepBettingOffersOrphans As New HousekeepDatabaseClass()
            HousekeepBettingOffersOrphans.DeleteStaleBettingOffersStaging()
            HousekeepBettingOffersOrphans = Nothing

            ' Delete orphaned outcopmes from staging table bookmaker_xml_nodes
            Dim HousekeepOutcomesOrphans As New HousekeepDatabaseClass()
            HousekeepOutcomesOrphans.DeleteOrphanedOutcomesStaging()
            HousekeepOutcomesOrphans = Nothing

        End If

    End Sub
End Class
