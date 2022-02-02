using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruit
{

    class Old
    {
        public delegate void EverOldHlandler(Dictionary<string, Stack<Produce>> a);
        public event EverOldHlandler everold;
        public Old(EverOldHlandler ever)
        {
            everold = ever;

        }

        public void Start(Dictionary<string, Stack<Produce>> baza)
        {
            everold.Invoke(baza);
        }
    }
}
