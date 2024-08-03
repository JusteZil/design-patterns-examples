namespace Patterns2.Proxy
{
    public class ProxyPattern : DesignPattern
    {
        public override string Name => "Proxy";

        public override void Run()
        {
            var image = new ImageProxy();
            image.DisplayImage();
            image.DisplayImage();
        }
    }
}
