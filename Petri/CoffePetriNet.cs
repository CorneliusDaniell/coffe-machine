using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petri
{
    public class CoffePetriNet : PetriNet
    {
        public CoffePetriNet()
            : base()
        {
            Initialize();
        }

        public virtual string GetCurrentState()
        {
            foreach (Transition transition in mTransitions)
            {
                LinkedList<Location> locs = transition.GetLocations();
                foreach (Location loc in locs)
                {
                    if (loc.GetJetoane() == 1)
                    {
                        return loc.GetTag();
                    }
                }
            }
            return null;
        }

        protected internal virtual void Initialize()
        {
            Location Zero = new Location("0 Coins");
            Location Cinci = new Location("5 Coins");
            Location Zece = new Location("10 Coins");
            Location Cincisprezece = new Location("15 Coins");
            Location Douazeci = new Location("20 Coins");

            Zero.UpdateJetoane(1);

            mTransitions.AddFirst(new Transition("+5 Coins", new LinkedListAnonymousInnerClass(this, Zero, Cinci)));

            mTransitions.AddFirst(new Transition("+10 Coins", new LinkedListAnonymousInnerClass2(this, Cinci, Cincisprezece)));

            mTransitions.AddFirst(new Transition("+10 Coins", new LinkedListAnonymousInnerClass3(this, Zero, Zece)));

            mTransitions.AddFirst(new Transition("+10 Coins", new LinkedListAnonymousInnerClass4(this, Zece, Douazeci)));

            mTransitions.AddFirst(new Transition("+5 Coins", new LinkedListAnonymousInnerClass5(this, Cinci, Zece)));

            mTransitions.AddFirst(new Transition("+5 Coins", new LinkedListAnonymousInnerClass6(this, Zece, Cincisprezece)));

            mTransitions.AddFirst(new Transition("+5 Coins", new LinkedListAnonymousInnerClass7(this, Cincisprezece, Douazeci)));

            mTransitions.AddFirst(new Transition("-15 Coins", new LinkedListAnonymousInnerClass8(this, Cinci, Douazeci)));

            mTransitions.AddFirst(new Transition("-15 Coins", new LinkedListAnonymousInnerClass9(this, Zero, Cincisprezece)));

            mTransitions.AddFirst(new Transition("-20 Coins", new LinkedListAnonymousInnerClass10(this, Zero, Douazeci)));
        }

        private class LinkedListAnonymousInnerClass : LinkedList<Arc>
        {
            private readonly CoffePetriNet outerInstance;

            private Location Zero;
            private Location Cinci;

            public LinkedListAnonymousInnerClass(CoffePetriNet outerInstance, Location Zero, Location Cinci)
            {
                this.outerInstance = outerInstance;
                this.Zero = Zero;
                this.Cinci = Cinci;

                this.AddFirst(new Arc(1, Zero, Direction.OUT));
                this.AddFirst(new Arc(1, Cinci, Direction.IN));
            }

        }

        private class LinkedListAnonymousInnerClass2 : LinkedList<Arc>
        {
            private readonly CoffePetriNet outerInstance;

            private Location Cinci;
            private Location Cincisprezece;

            public LinkedListAnonymousInnerClass2(CoffePetriNet outerInstance, Location Cinci, Location Cincisprezece)
            {
                this.outerInstance = outerInstance;
                this.Cinci = Cinci;
                this.Cincisprezece = Cincisprezece;

                this.AddFirst(new Arc(1, Cinci, Direction.OUT));
                this.AddFirst(new Arc(1, Cincisprezece, Direction.IN));
            }

        }

        private class LinkedListAnonymousInnerClass3 : LinkedList<Arc>
        {
            private readonly CoffePetriNet outerInstance;

            private Location Zero;
            private Location Zece;

            public LinkedListAnonymousInnerClass3(CoffePetriNet outerInstance, Location Zero, Location Zece)
            {
                this.outerInstance = outerInstance;
                this.Zero = Zero;
                this.Zece = Zece;

                this.AddFirst(new Arc(1, Zero, Direction.OUT));
                this.AddFirst(new Arc(1, Zece, Direction.IN));
            }

        }

        private class LinkedListAnonymousInnerClass4 : LinkedList<Arc>
        {
            private readonly CoffePetriNet outerInstance;

            private Location Zece;
            private Location Douazeci;

            public LinkedListAnonymousInnerClass4(CoffePetriNet outerInstance, Location Zece, Location Douazeci)
            {
                this.outerInstance = outerInstance;
                this.Zece = Zece;
                this.Douazeci = Douazeci;

                this.AddFirst(new Arc(1, Zece, Direction.OUT));
                this.AddFirst(new Arc(1, Douazeci, Direction.IN));
            }

        }

        private class LinkedListAnonymousInnerClass5 : LinkedList<Arc>
        {
            private readonly CoffePetriNet outerInstance;

            private Location Cinci;
            private Location Zece;

            public LinkedListAnonymousInnerClass5(CoffePetriNet outerInstance, Location Cinci, Location Zece)
            {
                this.outerInstance = outerInstance;
                this.Cinci = Cinci;
                this.Zece = Zece;

                this.AddFirst(new Arc(1, Cinci, Direction.OUT));
                this.AddFirst(new Arc(1, Zece, Direction.IN));
            }

        }

        private class LinkedListAnonymousInnerClass6 : LinkedList<Arc>
        {
            private readonly CoffePetriNet outerInstance;

            private Location Zece;
            private Location Cincisprezece;

            public LinkedListAnonymousInnerClass6(CoffePetriNet outerInstance, Location Zece, Location Cincisprezece)
            {
                this.outerInstance = outerInstance;
                this.Zece = Zece;
                this.Cincisprezece = Cincisprezece;

                this.AddFirst(new Arc(1, Zece, Direction.OUT));
                this.AddFirst(new Arc(1, Cincisprezece, Direction.IN));
            }

        }

        private class LinkedListAnonymousInnerClass7 : LinkedList<Arc>
        {
            private readonly CoffePetriNet outerInstance;

            private Location Cincisprezece;
            private Location Douazeci;

            public LinkedListAnonymousInnerClass7(CoffePetriNet outerInstance, Location Cincisprezece, Location Douazeci)
            {
                this.outerInstance = outerInstance;
                this.Cincisprezece = Cincisprezece;
                this.Douazeci = Douazeci;

                this.AddFirst(new Arc(1, Cincisprezece, Direction.OUT));
                this.AddFirst(new Arc(1, Douazeci, Direction.IN));
            }

        }

        private class LinkedListAnonymousInnerClass8 : LinkedList<Arc>
        {
            private readonly CoffePetriNet outerInstance;

            private Location Cinci;
            private Location Douazeci;

            public LinkedListAnonymousInnerClass8(CoffePetriNet outerInstance, Location Cinci, Location Douazeci)
            {
                this.outerInstance = outerInstance;
                this.Cinci = Cinci;
                this.Douazeci = Douazeci;

                this.AddFirst(new Arc(1, Douazeci, Direction.OUT));
                this.AddFirst(new Arc(1, Cinci, Direction.IN));
            }

        }

        private class LinkedListAnonymousInnerClass9 : LinkedList<Arc>
        {
            private readonly CoffePetriNet outerInstance;

            private Location Zero;
            private Location Cincisprezece;

            public LinkedListAnonymousInnerClass9(CoffePetriNet outerInstance, Location Zero, Location Cincisprezece)
            {
                this.outerInstance = outerInstance;
                this.Zero = Zero;
                this.Cincisprezece = Cincisprezece;

                this.AddFirst(new Arc(1, Cincisprezece, Direction.OUT));
                this.AddFirst(new Arc(1, Zero, Direction.IN));
            }

        }

        private class LinkedListAnonymousInnerClass10 : LinkedList<Arc>
        {
            private readonly CoffePetriNet outerInstance;

            private Location Zero;
            private Location Douazeci;

            public LinkedListAnonymousInnerClass10(CoffePetriNet outerInstance, Location Zero, Location Douazeci)
            {
                this.outerInstance = outerInstance;
                this.Zero = Zero;
                this.Douazeci = Douazeci;

                this.AddFirst(new Arc(1, Douazeci, Direction.OUT));
                this.AddFirst(new Arc(1, Zero, Direction.IN));
            }

        }
        public void Start()
        {
            {
                while (true)
                {
                    Console.WriteLine("Press-1 to Insert 5 Coins.");
                    Console.WriteLine("Press-1 to Insert 10 Coins.");
                    Console.WriteLine("        Option 3 ===> Coffe(1) = 15 Coins ");
                    Console.WriteLine("        Option 4 ===> Coffe(2) = 20 Coins ");

                    Console.WriteLine("Balance: {0} ", GetCurrentState());
                    Console.WriteLine(" ");

                    string[] input = Console.ReadLine().Split(' ');


                    if (input[0] == "1")
                    {
                        Exec("+5 Coins");
                    }
                    if (input[0] == "2")
                    {
                        Exec("+10 Coins");
                    }
                    if (input[0] == "3")
                    {
                        Exec("-15 Coins");
                    }
                    if (input[0] == "4")
                    {
                        Exec("-20 Coins");
                    }

                    Console.WriteLine(" ");

                }
            }
        }
    }
}


