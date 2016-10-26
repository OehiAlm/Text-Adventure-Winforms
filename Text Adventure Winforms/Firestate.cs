using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure_Winforms
{
    class Firestate
    {
        public int intFirestate;
        public string strFirestate;

        public void KindleFire()
        {
            switch (intFirestate)
            {
                case 5:
                    break;

                default:
                    intFirestate++; ;
                    break;
            }
            strFirestate = TextManager.Get().allTexts[((ETexts)intFirestate)] + "\n";
        }

        public void ExtinguishFire()
        {
            switch (intFirestate)
            {
                case 0:
                    break;

                default:
                    intFirestate--;
                    break;
            }
            strFirestate = TextManager.Get().allTexts[((ETexts)intFirestate)] + "\n";
        }
    }
}
