using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Persistent.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;

namespace MySolution.Module {
    [DefaultClassOptions, ImageName("BO_Employee")]
    [MetadataType(typeof(EmployeeMetadata))]
    public partial class Employee {
    }
    public class EmployeeMetadata {
        [Browsable(false)]
        public Int32 Id { get; set; }
    }
}
