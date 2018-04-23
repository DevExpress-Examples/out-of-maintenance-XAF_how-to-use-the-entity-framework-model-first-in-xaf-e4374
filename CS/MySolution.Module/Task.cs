using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Persistent.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;

namespace MySolution.Module {
    [DefaultClassOptions, ImageName("BO_Task")]
    [MetadataType(typeof(TaskMetadata))]
    partial class Task {
    }
    public class TaskMetadata {
        [Browsable(false)]
        public Int32 Id { get; set; }
        [FieldSize(FieldSizeAttribute.Unlimited)]
        public String Description { get; set; }
    }
}
