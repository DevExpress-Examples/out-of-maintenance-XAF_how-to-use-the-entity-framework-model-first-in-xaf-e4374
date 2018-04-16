Imports DevExpress.ExpressApp.DC
Imports DevExpress.Persistent.Base
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks


<DefaultClassOptions, ImageName("BO_Employee"), MetadataType(GetType(EmployeeMetadata))> _
Partial Public Class Employee
End Class
Public Class EmployeeMetadata
    <Browsable(False)> _
    Public Property Id() As Int32
End Class

