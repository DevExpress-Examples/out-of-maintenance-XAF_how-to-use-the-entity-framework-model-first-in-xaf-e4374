using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Web;
using DevExpress.ExpressApp.EF;
using MySolution.Module;
using DevExpress.ExpressApp.DC;

namespace MySolution.Web {
    public partial class MySolutionAspNetApplication : WebApplication {
        private DevExpress.ExpressApp.SystemModule.SystemModule module1;
        private DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule module2;
        private MySolution.Module.MySolutionModule module3;

        public MySolutionAspNetApplication() {
            InitializeComponent();
        }

        protected override void CreateDefaultObjectSpaceProvider(CreateCustomObjectSpaceProviderEventArgs args) {
            args.ObjectSpaceProvider = new EFObjectSpaceProvider(
            typeof(MyObjectContext), (TypesInfo)TypesInfo, null, args.ConnectionString,
         "res://*/MySolutionDataModel.csdl|res://*/MySolutionDataModel.ssdl|res://*/MySolutionDataModel.msl",
         "System.Data.SqlClient");

        }

        private void MySolutionAspNetApplication_DatabaseVersionMismatch(object sender, DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs e) {
			e.Updater.Update();
			e.Handled = true;
        }

        private void InitializeComponent() {
            this.module1 = new DevExpress.ExpressApp.SystemModule.SystemModule();
            this.module2 = new DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule();
            this.module3 = new MySolution.Module.MySolutionModule();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // MySolutionAspNetApplication
            // 
            this.ApplicationName = "MySolution";
            this.Modules.Add(this.module1);
            this.Modules.Add(this.module2);
            this.Modules.Add(this.module3);
            this.DatabaseVersionMismatch += new System.EventHandler<DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs>(this.MySolutionAspNetApplication_DatabaseVersionMismatch);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
    }
}
