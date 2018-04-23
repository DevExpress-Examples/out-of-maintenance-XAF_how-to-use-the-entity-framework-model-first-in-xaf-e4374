using System;
using System.Collections.Generic;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Updating;


namespace MySolution.Module {
    public sealed partial class MySolutionModule : ModuleBase {
        public MySolutionModule() {
            InitializeComponent();
       }
        public override IEnumerable<ModuleUpdater> GetModuleUpdaters(IObjectSpace objectSpace, Version versionFromDB) {
            return ModuleUpdater.EmptyModuleUpdaters;
        }
    }
}
