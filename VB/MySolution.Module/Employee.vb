Imports System.Linq
Imports System.Text
Imports DevExpress.Persistent.Base
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel
Imports DevExpress.ExpressApp.DC

Namespace MySolution.Module
    <DefaultClassOptions, ImageName("BO_Employee"), MetadataType(GetType(EmployeeMetadata))> _
    Partial Public Class Employee
    End Class
    Public Class EmployeeMetadata
        Private privateId As Int32
        <Browsable(False)> _
        Public Property Id() As Int32
            Get
                Return privateId
            End Get
            Set(ByVal value As Int32)
                privateId = value
            End Set
        End Property
    End Class
End Namespace
