using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns2.Iterator
{
    public interface IIterator
    {
        public bool HasNext();
        public void Next();

        public Song First();

        public Song CurrentElement();
    }
}
