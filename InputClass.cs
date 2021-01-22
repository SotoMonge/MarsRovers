using System;
using System.Text;

namespace MarsRovers
{
    class InputClass
    {
        readonly ValidationClass validation;
        public InputClass()
        {
            validation = new ValidationClass();
        }

        //Size of the grid East for the axis x negative and positive and North for the axis y negative and positive
        public void GridInput(int[] corner)
        {
            Console.WriteLine("write the northern and eastern limits of the grid.");
            Console.WriteLine("East: ");
            corner[0] = validation.IsNumber();
            Console.WriteLine("North: ");
            corner[1] = validation.IsNumber();
            Console.WriteLine("Limits of the Grid: " + "[" + corner[0] + "," + corner[1] + "]");
        }

        /*If the origin are greater or less than the size of the grid, the origin on 
         * that axis will take the maximum or minimum size of the grid.*/
        public void RoverInput(ref int[] corner, ref string[] origin, ref StringBuilder sb, string[] cardinalPoints)
        {

            /****origin****/
            /*assigns the value of the origin of the rover on the x and y axes by 
            calling the IsNumber method to only assign integer values*/
            Console.WriteLine("\nwrite the Origin of the rover(x, y, cardinal Point).");
            Console.WriteLine("X: ");
            origin[0] = Convert.ToString(validation.IsNumber());
            origin[0] = Int32.Parse(origin[0]) > corner[0] || Int32.Parse(origin[0]) < corner[0] * -1 ? corner[0].ToString() : origin[0];
            Console.WriteLine("Y: ");
            origin[1] = Convert.ToString(validation.IsNumber());
            origin[1] = Int32.Parse(origin[1]) > corner[1] || Int32.Parse(origin[1]) < corner[1] * -1 ? corner[1].ToString() : origin[1];
            /****cardinal point****/
            /*assigns the cardinal point only with the four main cardinal points North, South, West and East
             calling the method IsCardinal to validate if only type some of the cardinal points with the first letter*/
            Console.WriteLine("Cardinal Point: ");
            origin[2] = validation.IsCardinal(cardinalPoints);
            Console.WriteLine("Origin: " + "[" + origin[0] + "," + origin[1] + "," + origin[2] + "]");

            /****Instructions****/
            /*Capture the instructions for the rover to move to left, right or to move forward*/
            Console.WriteLine("Instructions: ");
            sb.Append(validation.IsInstruction());
            Console.WriteLine("Instructions: " + sb);

        }
    }
}
