namespace Patterns2.Composite
{
    public abstract class MenuComponent
    {
        public bool IsMenuItem { get; set; }

        public MenuComponent(bool isMenuItem)
        {
            IsMenuItem = isMenuItem;
        }

        public abstract void Display(int depth);
    }
}
