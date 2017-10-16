namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            int rooms, doors;
            MazeGame game = new MazeGame();
            CountingMazeBuilder builder = new CountingMazeBuilder();
            game.CreateComplexMaze(builder);
            builder.GetCounts(out rooms, out doors);
        }

        public void CreateMaze()
        {
            Maze maze;
            MazeGame game = new MazeGame();
            StandardMazeBuilder builder = new StandardMazeBuilder();
            game.CreateComplexMaze(builder);
            maze = builder.GetMaze();
        }
    }
}
