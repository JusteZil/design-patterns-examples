namespace Patterns2.Iterator
{
    public interface IIterator
    {
        public bool HasNext();
        public void Next();
        public Song First();
        public Song Current();
    }
}
