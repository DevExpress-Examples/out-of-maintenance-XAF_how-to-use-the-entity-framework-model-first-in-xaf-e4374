Imports System.Linq
Imports System.Text
Imports DevExpress.Persistent.Base
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel
Imports DevExpress.ExpressApp.DC

Namespace MySolution.Module
    <DefaultClassOptions, ImageName("BO_Task"), MetadataType(GetType(TaskMetadata))> _
    Partial Public Class Task
    End Class
    Public Class TaskMetadata
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
        Private privateDescription As String
        <FieldSize(FieldSizeAttribute.Unlimited)> _
        Public Property Description() As String
            Get
                Return privateDescription
            End Get
            Set(ByVal value As String)
                privateDescription = value
            End Set
        End Property
    End Class
End Namespace
