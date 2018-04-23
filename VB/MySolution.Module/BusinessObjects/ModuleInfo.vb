Imports System
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations

Imports DevExpress.ExpressApp.Updating

<Browsable(False)> _
    Partial Public Class XafModuleInfo
    Implements IModuleInfo
    Public Property AssemblyFileName1 As String Implements IModuleInfo.AssemblyFileName
        Get
            Return AssemblyFileName
        End Get
        Set(value As String)
            AssemblyFileName = value
        End Set
    End Property

    Public Property IsMain1 As Boolean Implements IModuleInfo.IsMain
        Get
            Return IsMain
        End Get
        Set(value As Boolean)
            IsMain = value
        End Set
    End Property

    Public Property Name1 As String Implements IModuleInfo.Name
        Get
            Return Name
        End Get
        Set(value As String)
            Name = value
        End Set
    End Property
    Public Property Version1 As String Implements IModuleInfo.Version
        Get
            Return Version
        End Get
        Set(value As String)
            Version = value
        End Set
    End Property
End Class
