Imports System.IO

Module Module1

    Sub Main()
        CleanSteamScreenshots()
    End Sub

    Private Sub CleanSteamScreenshots()

        Dim steamScreenshotDirectory As String = "C:\Program Files (x86)\Steam\userdata\6223619\760\remote"
        Dim di As New DirectoryInfo(steamScreenshotDirectory)

        For Each folder In di.GetDirectories
            For Each subFolder In folder.GetDirectories
                If subFolder.Name.ToUpper = "SCREENSHOTS" Then
                    DeleteScreenshots(subFolder)
                End If
            Next
        Next
    End Sub

    Private Sub DeleteScreenshots(subFolder As DirectoryInfo)

        For Each item In subFolder.GetDirectories
            Directory.Delete(item.FullName, True)
        Next

        For Each item In subFolder.GetFiles
            item.Delete()
        Next

    End Sub

End Module
