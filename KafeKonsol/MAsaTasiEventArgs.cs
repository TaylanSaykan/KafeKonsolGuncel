using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeKonsol
{
    public class MAsaTasiEventArgs:EventArgs
    {
        public MAsaTasiEventArgs(int eskiMasaNO, int yeniMasaNO)
        {
            EskiMasaNo = eskiMasaNO;
            YeniMasaNo = yeniMasaNO;

        }
        public int EskiMasaNo { get;}
        public int YeniMasaNo { get;}
    }
}
