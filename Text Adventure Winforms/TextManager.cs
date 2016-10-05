using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure_Winforms
{
    public enum ETexts
    {
        already_dead,
        dark,
        flickering,
        lit,
        burning,
        going_nuts,
        explosion_incoming
    }

    public class TextManager : Manager<TextManager>
    {
        protected TextManager(){}
        
        public Dictionary<ETexts, string> allTexts = new Dictionary<ETexts, string>()
        {
            {ETexts.already_dead, "The fire is already dead"},
            {ETexts.dark, "It's dark"},
            {ETexts.flickering, "The fire is flickering"},
            {ETexts.lit, "It's burning brightly"},
            {ETexts.burning, "It's quite warm and fuzzy"},
            {ETexts.going_nuts, "Hell broke loose"},
            {ETexts.explosion_incoming, "You would kill yourself, if you kindled the fire any further"}
        };
    }
}
