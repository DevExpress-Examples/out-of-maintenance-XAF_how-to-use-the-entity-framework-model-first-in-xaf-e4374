Imports System.Configuration

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Security
Imports DevExpress.ExpressApp.Win
Imports DevExpress.Persistent.Base

Namespace MySolution.Win
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Dim winApplication As New MySolutionWindowsFormsApplication()
            winApplication.ConnectionString = "Integrated Security=SSPI;Pooling=false;Data Source=(local);Initial Catalog=ModelFirstEntityFrameworkExample"
            Try
                winApplication.Setup()
                winApplication.Start()
            Catch e As Exception
                winApplication.HandleException(e)
            End Try
        End Sub
    End Class
End Namespace
