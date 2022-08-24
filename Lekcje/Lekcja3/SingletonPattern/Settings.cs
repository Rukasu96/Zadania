using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Settings
    {
        public int Sound { get; private set; }
        public int Music { get; private set; }

        private static Settings instance;
        public static Settings Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Settings();
                }
                return instance;
            }
        }

        private Settings()
        {

        }

        public void SoundUp()
        {
            Sound++;
        }
    }
}
