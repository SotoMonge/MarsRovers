using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRovers
{
    class ExplorerClass
    {
        readonly string[] cardinalPoints = new string[4];
        private int[] corner;
        public Dictionary<string, string> dicMovements = new Dictionary<string, string>();
        readonly InputClass input = new InputClass();
        public ExplorerClass()
        {
            //assigns the value of the four cardinal points:
            //North, East, South and West
            cardinalPoints[0] = "N";
            cardinalPoints[1] = "E";
            cardinalPoints[2] = "S";
            cardinalPoints[3] = "W";

            corner = new int[2];

            dicMovements =
           new Dictionary<string, string>
           {
               { "N", "p1" },
               { "E", "p0" },
               { "S", "n1" },
               { "W", "n0" }
           };
        }
        public void CallInputGrid()
        {
            input.GridInput(corner);
        }

        //This method is used to turn the rover left or right
        //cardinalPoint parameter is where the rover is rovers heading
        //turn parameter is the turn instruction
        public string MoveCardinalPoint(string cardinalPoint, string turn)
        {
            int length = cardinalPoints.Length;
            int pos = 0;
            for (int i = 0; i < length; i++)
            {
                if (cardinalPoint == cardinalPoints[i])
                {
                    pos = i;
                    break;
                }
            }
            switch (turn)
            {
                case "R":
                    pos = (pos + 1) % length;
                    break;
                case "L":
                    pos = pos == 0 ? length - 1 : pos - 1;
                    break;
            }
            cardinalPoint = cardinalPoints[pos];

            return cardinalPoint;
        }

        //This method call the input method for the origin and instructions for the rover
        //and update the coordinates according to rover direction.
        /*If the next move of rover is greater or less than the grid, it won´t move on that axis
         So the code validates it and if it is out of the range it will be of the max size of that axis*/
        public void Start()
        {
            int direction;
            int position;
            string[] origin = new string[3];
            StringBuilder sbMove = new StringBuilder();
            input.RoverInput(ref corner, ref origin, ref sbMove, cardinalPoints);

            for (int i = 0; i < sbMove.Length; i++)
            {
                if (sbMove[i].ToString() == "M")
                {
                    string value = dicMovements[origin[2]];
                    direction = value[0] == 'p' ? 1 : -1;
                    position = Convert.ToInt32(value[1].ToString());
                    int max = corner[position];
                    origin[position] = (Convert.ToInt32(origin[position]) + direction).ToString();
                    origin[position] = Convert.ToInt32(origin[position]) > max
                          || Convert.ToInt32(origin[position]) < max * -1 ? corner[position].ToString() : origin[position];
                }
                else
                {
                    origin[2] = MoveCardinalPoint(origin[2], sbMove[i].ToString());
                }
            }
            Console.WriteLine("\nThe end Position: \n" + "[" + origin[0] + "," + origin[1] + "," + origin[2] + "]");

            Console.WriteLine("\nDo you want to try again? y/n");
            if (Console.ReadLine() == "y")
                Start();
        }
    }
}
