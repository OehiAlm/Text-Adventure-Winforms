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

        void FuelFire()
        {
            intFirestate++;
        }

        void UnfuelFire()
        {
            intFirestate--;
        }

        public void KindleFire()
        {
            switch (intFirestate)
            {
                case 0:
                    FuelFire();
                    strFirestate = (TextManager.Get().allTexts[ETexts.flickering] + "\n");
                    break;

                case 1:
                    FuelFire();
                    strFirestate = (TextManager.Get().allTexts[ETexts.lit] + "\n");
                    break;

                case 2:
                    FuelFire();
                    strFirestate = (TextManager.Get().allTexts[ETexts.burning] + "\n");
                    break;

                case 3:
                    FuelFire();
                    strFirestate = (TextManager.Get().allTexts[ETexts.going_nuts] + "\n");
                    break;

                case 4:
                    FuelFire();
                    strFirestate = (TextManager.Get().allTexts[ETexts.explosion_incoming] + "\n");
                    break;

                case 5:
                    strFirestate = (TextManager.Get().allTexts[ETexts.explosion_incoming] + "\n");
                    break;
            }
        }

        public void ExtinguishFire()
        {
            switch (intFirestate)
            {
                case 0:
                    strFirestate = (TextManager.Get().allTexts[ETexts.already_dead] + "\n");
                    break;

                case 1:
                    UnfuelFire();
                    strFirestate = (TextManager.Get().allTexts[ETexts.dark] + "\n");
                    break;

                case 2:
                    UnfuelFire();
                    strFirestate = (TextManager.Get().allTexts[ETexts.flickering] + "\n");
                    break;

                case 3:
                    UnfuelFire();
                    strFirestate = (TextManager.Get().allTexts[ETexts.lit] + "\n");
                    break;

                case 4:
                    UnfuelFire();
                    strFirestate = (TextManager.Get().allTexts[ETexts.burning] + "\n");
                    break;

                case 5:
                    UnfuelFire();
                    strFirestate = (TextManager.Get().allTexts[ETexts.going_nuts] + "\n");
                    break;
            }
        }
    }
}
