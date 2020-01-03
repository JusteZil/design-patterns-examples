using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns2.Iterator
{
    public interface Aggregate
    {
        public void Add(Song song);

        public IIterator CreateIterator();
    }
}
