Imports System.string
Imports System.io

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim x As New StreamWriter("c:\testbat.bat", False)

        x.WriteLine("cd c:\dmv\")
        x.WriteLine("mkdir abc")
        x.Close()
        'FaxCommandLine = "SubmitFax /s" + "DMVVTDFAX.aot.state.vt.us" + "/u" + "supervisor" + "/p" + "" + "/R" + "TestFaxPress@ EDS@ 802-828-2098" + "/c" + "Testing FAXPress SDK" + "/m" + "" + "/a" + "SampleTestFax.doc"
        Shell("C:\testbat.bat", AppWinStyle.MaximizedFocus, True, 100)

    End Sub
End Class
