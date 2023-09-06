namespace ParaClub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(Config.SCREEN_WIDTH, Config.SCREEN_HEIGHT);

            Plane plane = new Plane();

            Console.Write(plane.view);
        }
    }
}