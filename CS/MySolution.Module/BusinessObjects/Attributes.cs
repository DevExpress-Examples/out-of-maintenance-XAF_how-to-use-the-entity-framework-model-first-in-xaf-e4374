using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MySolution.Module.BusinessObjects {

    [MetadataType(typeof(EmployeeMetadata))]
    [DefaultClassOptions, ImageName("BO_Employee")]
    public partial class Employee { }
    public class EmployeeMetadata {
        [Browsable(false)]
        public Int32 Id { get; set; }
    }

    [MetadataType(typeof(TaskMetadata))]
    [DefaultClassOptions, ImageName("BO_Task")]
    public partial class Task { }
    public class TaskMetadata {
        [Browsable(false)]
        public Int32 Id { get; set; }

        [FieldSize(FieldSizeAttribute.Unlimited)]
        public String Description { get; set; }
    }
}

