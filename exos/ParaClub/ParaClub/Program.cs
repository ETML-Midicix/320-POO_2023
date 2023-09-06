namespace ParaClub
{
    internal class Program
    {
        static class Config
        {
            public const int SCREEN_HEIGHT = 40;
            public const int SCREEN_WIDTH = 150;
        }
        static void Main(string[] args)
        {
            Console.SetBufferSize(Config.SCREEN_WIDTH, Config.SCREEN_HEIGHT);
        }
    }
}