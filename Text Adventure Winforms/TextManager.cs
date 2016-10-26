using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure_Winforms
{
    public enum ETexts
    {
        dark,
        flickering,
        lit,
        burning,
        going_nuts,
    }

    public class TextManager : Manager<TextManager>
    {
        protected TextManager(){}
        
        public Dictionary<ETexts, string> allTexts = new Dictionary<ETexts, string>()
        {
            {ETexts.dark, "It's dark"},
            {ETexts.flickering, "The fire is flickering"},
            {ETexts.lit, "It's burning brightly"},
            {ETexts.burning, "It's quite warm and fuzzy"},
            {ETexts.going_nuts, "Hell broke loose"},
        };
    }
}
