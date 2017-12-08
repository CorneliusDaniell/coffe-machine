using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petri
{
    public class PetriNet
    {
        public PetriNet()
        {
            mTransitions = new LinkedList<Transition>();
        }


        public virtual void Exec(string aAction)
        {
            foreach (Transition trans in mTransitions)
            {
                if (trans.GetTag() == aAction && trans.IsValid())
                {
                    trans.Update();
                    return;
                }
            }
        }


        protected internal LinkedList<Transition> mTransitions;
    }
}
