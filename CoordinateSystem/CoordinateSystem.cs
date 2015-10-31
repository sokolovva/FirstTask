using System;
using System.IO;

namespace CoordinateSystem
{
class CoordinateSystem
{
    static void Main()

    {
          
            bool wrapped = false;

            Console.Write("X current position: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Y current position: ");
            int y = int.Parse(Console.ReadLine());

            Console.Write("Give directions: ");
            string inputDirections = System.Console.ReadLine();

            char[] directions = inputDirections.ToCharArray();
            int lenghtOfDirection = directions.Length;


            
            for (int i = 0; i<inputDirections.Length; i++)
            { 
              
                switch (directions[i])
                {
                    case '>':
                        x = LeftnRight(false, wrapped, x);
                            break;
                    case '<':
                        x  = LeftnRight(true, wrapped, x);
                        break;
                    case 'V':
                        y = UpnDown(false, wrapped, y);
                        break;
                    case '^':
                        y = UpnDown(true, wrapped, y);
                        break;
                    case '~':
                        wrapped =! wrapped;
                            break;
                    default: Console.WriteLine("Wrong directions :)!!");
                        break;

                } 

            }
            Console.WriteLine("X= {0} and Y= {1}", x,y);
        
 } 

        public static int LeftnRight (bool Left, bool wrapped, int x)
        {
            if (wrapped)
                Left = !Left;
            if (Left) x--;
            else x++;
            return x;

        }
        public static int UpnDown(bool Up, bool wrapped, int y)
        {
            if (wrapped)
                Up = !Up;
            if (Up) y--;
            else y++;
            return y;

        }
    }
}
