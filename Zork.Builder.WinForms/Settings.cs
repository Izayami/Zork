﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zork.Builder.WinForms
{
    internal sealed partial class Settings
    {
        public Settings()
        {
            this.SettingChanging += this.SettingChangingEventHandler;

            this.SettingsSaving += this.SettingsSavingEventHandler;
        }
        private void SettingChangingEventHandler(object sender, System.Configuration.SettingChangingEventArgs e)
        {          
        }
        private void SettingsSavingEventHandler(object sender, System.ComponentModel.CancelEventArgs e)
        {           
        }
    }
}

