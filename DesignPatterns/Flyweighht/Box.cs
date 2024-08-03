namespace DesignPatterns.Flyweighht
{
    public abstract class Box
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }

        public Box(int height, int width, int length)
        {
            Height = height;
            Width = width;
            Length = length;
        }
        public abstract void Display(string color);
    }
}
