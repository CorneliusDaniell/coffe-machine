using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petri
{
    public class Location
    {
        public Location(String aTag)
        {
            mJetoane = 0;
            mTag = aTag;
        }

        public bool UpdateJetoane(int aValue)
        {
            int result = mJetoane + aValue;
            if (result < 0)
            {
                return false;
            }
            mJetoane = result;
            return true;
        }

        public int GetJetoane()
        {
            return mJetoane;
        }

        public String GetTag()
        {
            return mTag;
        }

        private int mJetoane;
        private String mTag;
    }
}
