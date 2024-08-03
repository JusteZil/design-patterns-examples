namespace DesignPatterns.Iterator
{
    public interface Aggregate
    {
        public void Add(Song song);

        public IIterator CreateIterator();
    }
}
