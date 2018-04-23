Imports System.ComponentModel
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Web
Imports DevExpress.ExpressApp.EF
Imports MySolution.Module
Imports DevExpress.ExpressApp.DC

Namespace MySolution.Web
    Partial Public Class MySolutionAspNetApplication
        Inherits WebApplication

        Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
        Private module2 As DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule
        Private module3 As MySolution.Module.MySolutionModule

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides Sub CreateDefaultObjectSpaceProvider(ByVal args As CreateCustomObjectSpaceProviderEventArgs)
            args.ObjectSpaceProvider = New EFObjectSpaceProvider(GetType(MyObjectContext), CType(TypesInfo, TypesInfo), Nothing, args.ConnectionString, "res://*/MySolutionDataModel.csdl|res://*/MySolutionDataModel.ssdl|res://*/MySolutionDataModel.msl", "System.Data.SqlClient")

        End Sub

        Private Sub MySolutionAspNetApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs) Handles MyBase.DatabaseVersionMismatch
            e.Updater.Update()
            e.Handled = True
        End Sub

        Private Sub InitializeComponent()
            Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
            Me.module2 = New DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule()
            Me.module3 = New MySolution.Module.MySolutionModule()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' MySolutionAspNetApplication
            ' 
            Me.ApplicationName = "MySolution"
            Me.Modules.Add(Me.module1)
            Me.Modules.Add(Me.module2)
            Me.Modules.Add(Me.module3)
'            Me.DatabaseVersionMismatch += New System.EventHandler(Of DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs)(Me.MySolutionAspNetApplication_DatabaseVersionMismatch)
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
    End Class
End Namespace
