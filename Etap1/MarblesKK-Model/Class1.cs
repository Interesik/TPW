using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarblesKK_Model
{
    public class Murbles : IEnumerable<State.Marble>
    {
        private List<State.Marble> Lmurbles = new List<State.Marble>();
        public void AddMurble(State.Marble murble)
        {
            Lmurbles.Add(murble);
        }
        public bool DelMurble(State.Marble murble)
        {
            return Lmurbles.Remove(murble);
        }

        public IEnumerator<State.Marble> GetEnumerator()
        {
            return Lmurbles.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)this.GetEnumerator();
        }

        public State.Marble this[int index]
        {
            get
            {
                return Lmurbles[index];
            }
        }
    }
}
