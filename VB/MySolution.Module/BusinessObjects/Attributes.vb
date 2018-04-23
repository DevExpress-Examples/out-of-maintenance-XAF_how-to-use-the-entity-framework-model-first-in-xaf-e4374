Imports DevExpress.ExpressApp.DC
Imports DevExpress.Persistent.Base
Imports System
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations

<MetadataType(GetType(EmployeeMetadata)), _
DefaultClassOptions, ImageName("BO_Employee")> _
Partial Public Class Employee
End Class
Public Class EmployeeMetadata
    Public Property Id() As Int32
End Class

<MetadataType(GetType(TaskMetadata)), _
DefaultClassOptions, ImageName("BO_Task")> _
Partial Public Class Task
End Class
Public Class TaskMetadata
    Public Property Id() As Int32

    Public Property Description() As String
End Class