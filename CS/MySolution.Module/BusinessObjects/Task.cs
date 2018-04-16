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
    [DefaultClassOptions, ImageName("BO_Task")]
    [MetadataType(typeof(TaskMetadata))]
    public partial class Task {
    }
    public class TaskMetadata {
        [Browsable(false)]
        public Int32 Id { get; set; }
        [FieldSize(FieldSizeAttribute.Unlimited)]
        public String Description { get; set; }
    }

}
