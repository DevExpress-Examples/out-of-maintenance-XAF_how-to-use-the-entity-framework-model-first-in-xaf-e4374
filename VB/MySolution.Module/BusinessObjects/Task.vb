Imports DevExpress.ExpressApp.DC
Imports DevExpress.Persistent.Base
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

<DefaultClassOptions, ImageName("BO_Task"), MetadataType(GetType(TaskMetadata))> _
    Partial Public Class Task
End Class
Public Class TaskMetadata
    <Browsable(False)> _
    Public Property Id() As Int32
    <FieldSize(FieldSizeAttribute.Unlimited)> _
    Public Property Description() As String
End Class
