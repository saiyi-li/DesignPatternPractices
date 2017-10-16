namespace Builder
{
    public class MazeGame
    {
        public Maze CreateMaze(MazeFactory mazeFactory)
        {
            Maze maze = mazeFactory.MakeMaze();
            Room r1 = mazeFactory.MakeRoom(1);
            Room r2 = mazeFactory.MakeRoom(2);
            Door door = mazeFactory.MakeDoor(r1, r2);

            maze.AddRoom(r1);
            maze.AddRoom(r2);

            r1.SetSide(Direction.North, new Wall());
            r1.SetSide(Direction.East, door);
            r1.SetSide(Direction.South, new Wall());
            r1.SetSide(Direction.West, new Wall());

            r2.SetSide(Direction.North, new Wall());
            r2.SetSide(Direction.East, new Wall());
            r2.SetSide(Direction.South, new Wall());
            r2.SetSide(Direction.West, door);

            return maze;
        }

        public Maze CreateComplexMaze(MazeBuilder builder)
        {
            builder.BuildRoom(1);
            builder.BuildRoom(2);
            builder.BuildRoom(3);
            builder.BuildRoom(4);

            return builder.GetMaze();
        }
    }
}
