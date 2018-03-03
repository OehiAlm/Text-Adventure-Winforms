using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure_Winforms
{
    public enum EFireTexts
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
        
        public Dictionary<EFireTexts, string> allTexts = new Dictionary<EFireTexts, string>()
        {
            {EFireTexts.dark, "It's dark"},
            {EFireTexts.flickering, "The fire is flickering"},
            {EFireTexts.lit, "It's burning brightly"},
            {EFireTexts.burning, "It's quite warm and fuzzy"},
            {EFireTexts.going_nuts, "Hell broke loose"},
        };
    }
}
