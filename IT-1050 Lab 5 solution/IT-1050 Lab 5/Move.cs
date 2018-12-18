

namespace IT_1050_Lab_5
{
     class Move : Pawn 
    {
        private int targetX;
        private int targetY;
        private int destinationX;
        private int destinationY;

        public Move()
        {
            targetX = 0;
            targetY = 0;
            destinationX = 0;
            destinationY = 0;
            Exit = false;
        }
        public bool Exit { get; set; }

        public void MakeMove()
        {
            getInput();
            if (!Exit)
            {
                changePawns();
            }

            changePawns();
        }

        private void getInput()
        {
            System.Console.Write("Enter Target's X axis");
            int.TryParse(System.Console.ReadLine(), out targetX);

            if (!Exit)
            {
                System.Console.Write("Enter Target's Y axis");
               int.TryParse(System.Console.ReadLine(), out targetY);
            }

            if (!Exit)
            {
                System.Console.Write("Enter Destinations X axis");
               int.TryParse(System.Console.ReadLine(), out destinationX);
            }

            if (!Exit)
            {
                System.Console.Write("Enter destination Y axis");
                int.TryParse(System.Console.ReadLine(), out destinationY);
            }
        }

        

        private void changePawns()
        {
            pawns[targetX,targetY] = pawns[destinationX,destinationY];
            pawns[destinationY,destinationY] = Space;
        }
    }
}
