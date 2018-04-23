Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Win
Imports System.Collections.Generic
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.ExpressApp.EF
Imports MySolution.Module
Imports System.Data.Common

' For more typical usage scenarios, be sure to check out http://documentation.devexpress.com/#Xaf/DevExpressExpressAppWinWinApplicationMembersTopicAll
Partial Public Class MySolutionWindowsFormsApplication
    Inherits WinApplication
    Public Sub New()
        InitializeComponent()
    End Sub

    Protected Overrides Sub CreateDefaultObjectSpaceProvider(ByVal args As CreateCustomObjectSpaceProviderEventArgs)
		args.ObjectSpaceProvider = New EFObjectSpaceProvider(GetType(MySolutionModelContainer), TypesInfo, Nothing, args.ConnectionString, MySolutionModule.Metadata, MySolutionModule.Provider)
    End Sub
    Private Sub MySolutionWindowsFormsApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs) Handles MyBase.DatabaseVersionMismatch
#If EASYTEST Then
        e.Updater.Update()
        e.Handled = True
#Else
        If System.Diagnostics.Debugger.IsAttached Then
            e.Updater.Update()
            e.Handled = True
        Else
            Throw New InvalidOperationException( _
             "The application cannot connect to the specified database, because the latter doesn't exist or its version is older than that of the application." & Constants.vbCrLf & _
             "This error occurred  because the automatic database update was disabled when the application was started without debugging." & Constants.vbCrLf & _
             "To avoid this error, you should either start the application under Visual Studio in debug mode, or modify the " & _
             "source code of the 'DatabaseVersionMismatch' event handler to enable automatic database update, " & _
             "or manually create a database Imports the 'DBUpdater' tool." & Constants.vbCrLf & _
             "Anyway, refer to the 'Update Application and Database Versions' help topic at http://www.devexpress.com/Help/?document=ExpressApp/CustomDocument2795.htm " & _
             "for more detailed information. If this doesn't help, please contact our Support Team at http://www.devexpress.com/Support/Center/")
        End If
#End If
    End Sub
    Private Shared Sub MySolutionWindowsFormsApplication_CustomizeLanguagesList(ByVal sender As Object, ByVal e As CustomizeLanguagesListEventArgs)
        Dim userLanguageName As String = System.Threading.Thread.CurrentThread.CurrentUICulture.Name
        If userLanguageName <> "en-US" And e.Languages.IndexOf(userLanguageName) = -1 Then
            e.Languages.Add(userLanguageName)
        End If
    End Sub
End Class
