
namespace MarsRovers
{
    class RoverClass
    {
        static void Main(string[] args)
        {
            RoverClass rover = new RoverClass();
            rover.Start();
        }
        public void Start()
        {
            ExplorerClass explorer = new ExplorerClass();
            explorer.CallInputGrid();
            explorer.Start();
        }
    }
}
