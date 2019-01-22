using System;
using System.Collections.Generic;
using System.Text;

namespace opgave_klasser_simpel
{
    internal class AppSettings
    {
        public int AppId;
        private static bool alreadyCreated = false;
        private static AppSettings a;
        private AppSettings()
        {
           // nothing
            

        }

        public static AppSettings HentAppSettings()
        {
            if (AppSettings.alreadyCreated == false)
            {
                AppSettings.alreadyCreated = true;
                a = new AppSettings();
                
            }
            return a;
        }

        private int tal;

        public int Tal
        {
            get
            {
                return this.tal;
            }
            set
            {
                this.tal = value;
            }
        }





    }
}
