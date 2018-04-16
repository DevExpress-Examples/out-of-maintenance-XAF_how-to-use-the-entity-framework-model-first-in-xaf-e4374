using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
