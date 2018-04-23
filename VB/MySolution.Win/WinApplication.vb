Imports System.ComponentModel
Imports DevExpress.ExpressApp.Win
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.ExpressApp
Imports MySolution.Module
Imports DevExpress.ExpressApp.DC
Imports DevExpress.ExpressApp.EF

Namespace MySolution.Win
    Partial Public Class MySolutionWindowsFormsApplication
        Inherits WinApplication

        Public Sub New()
            InitializeComponent()
            DelayedViewItemsInitialization = True
        End Sub

        Protected Overrides Sub CreateDefaultObjectSpaceProvider(ByVal args As CreateCustomObjectSpaceProviderEventArgs)
            args.ObjectSpaceProvider = New EFObjectSpaceProvider(GetType(MyObjectContext), CType(TypesInfo, TypesInfo), Nothing, args.ConnectionString, "res://*/MySolutionDataModel.csdl|res://*/MySolutionDataModel.ssdl|res://*/MySolutionDataModel.msl", "System.Data.SqlClient")

        End Sub
        Private Sub MySolutionWindowsFormsApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs) Handles MyBase.DatabaseVersionMismatch
            e.Updater.Update()
            e.Handled = True
        End Sub
        Private Sub MySolutionWindowsFormsApplication_CustomizeLanguagesList(ByVal sender As Object, ByVal e As CustomizeLanguagesListEventArgs) Handles MyBase.CustomizeLanguagesList
            Dim userLanguageName As String = System.Threading.Thread.CurrentThread.CurrentUICulture.Name
            If userLanguageName <> "en-US" AndAlso e.Languages.IndexOf(userLanguageName) = -1 Then
                e.Languages.Add(userLanguageName)
            End If
        End Sub
    End Class
End Namespace
