using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petri
{
    public class Transition
    {
        public Transition(string aTag, LinkedList<Arc> aArce)
        {
            mTag = aTag;
            mArce = aArce;
        }

        public virtual bool IsValid()
        {
            foreach (Arc arc in mArce)
            {
                if (!arc.IsValid())
                {
                    return false;
                }
            }
            return true;
        }

        public virtual void Update()
        {
            foreach (Arc arc in mArce)
            {
                arc.Update();
            }
        }

        public virtual string GetTag()
        {
            return mTag;
        }

        public virtual LinkedList<Location> GetLocations()
        {
            LinkedList<Location> locs = new LinkedList<Location>();
            foreach (Arc arc in mArce)
            {
                locs.AddLast(arc.GetLocatie());
            }
            return locs;
        }

        private LinkedList<Arc> mArce;
        private string mTag;
    }
}
