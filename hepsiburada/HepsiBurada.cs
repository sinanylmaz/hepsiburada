using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hepsiburada
{
    class HepsiBurada

    {

        public static int north = 1;
    	public static int east = 2;
    	public static int south= 3;
    	public static int west = 4;
        public static string _north = "N";
        public static string _east = "E";
        public static string _south = "S";
        public static string _west = "W";
        public static string _left = "L";
        public static string _right = "R";
        public static string _moveForward = "M";
        int x = 0, y = 0, rotation = north;


        static void Main(string[] args)
        {
            HepsiBurada hb = new HepsiBurada();
            int maxTour;
            int locationX;
            int locationY;
            int _rotation;
            string _move;
            //alanın hep (5,5) olduğu varsayılmaktadır.
            Console.Write("Please enter max Tour  :");
            maxTour = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < maxTour; i++)
            {
                Console.Write("Please enter location x (Only integer) :");
                locationX = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter location y (Only integer) :");
                locationY = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter rotation (for North enter 1  for East enter 2  for South enter 3  for West enter 4) (Only integer) :");
                _rotation = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter move (Only 'L','R','M' ):");
                _move = Console.ReadLine();
                hb.SetLocation(locationX, locationY, _rotation);
                hb.move(_move.ToUpper());
                Console.WriteLine(hb.WriteResult());
                Console.Write("Next -> press anything");
                Console.ReadLine();
            }
           
        }
        public void SetLocation(int x, int y, int rotation)
        {
            this.x = x;
            this.y = y;
            this.rotation = rotation;
        }
        public string WriteResult()
        {
            string direction = _north;
            if (rotation == north)
            {
                direction = _north;
            }
            else if (rotation == east)
            {
                direction = _east;
            }
            else if (rotation == south)
            {
                direction = _south;
            }
            else if (rotation == west)
            {
                direction = _west;
            }
            return x  + " " +  y  + " "  + direction;
        }
        public void move(String commands)
        {
            for (int idx = 0; idx < commands.Count(); idx++)
            {
                if (commands.ElementAt(idx).ToString().Equals(_left))
                {
                    turnLeft();
                }
                else if (commands.ElementAt(idx).ToString().Equals(_right))
                {
                    turnRight();
                }
                else if (commands.ElementAt(idx).ToString().Equals(_moveForward))
                {
                    moveForward();
                }
            }
        }
        private void moveForward()
        {
            if (rotation == north)
            {
                y++;
            }
            else if (rotation == east)
            {
                x++;
            }
            else if (rotation == south)
            {
               y--;
            }
            else if (rotation == west)
            {
                x--;
            }
        }
        private void turnLeft()
        {
            if ((rotation - 1) < north)
            {
                rotation=west;
            }
            else{
                rotation -= 1;
            }
        }
        private void turnRight()
        {
            if ((rotation + 1) > west)
            {
                rotation = north;
            }
            else{
                rotation += 1;
            }
        }
    }

    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string expected = "";
            //var result = HepsiBurada.setLocation();
            //Assert.
        }
    }
}
