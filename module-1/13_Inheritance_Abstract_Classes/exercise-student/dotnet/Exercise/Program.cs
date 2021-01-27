using System;
using System.Collections.Generic;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //uncomment after step 1:
            //List<Wall> walls = new List<Wall>();

            while (true)
            {
                Console.WriteLine("[1] Add a wall");
                Console.WriteLine("[2] Calculate paint required (and Exit)");
                Console.WriteLine("Please choose >>> ");
                string userChoice = Console.ReadLine();

                Console.WriteLine();

                if (userChoice == "1")
                {
                    //uncomment after step 1:
                    //Wall newWall = null;

                    Console.WriteLine("What's the name of the new wall?");
                    string name = Console.ReadLine();

                    Console.WriteLine("What color is the wall?");
                    string color = Console.ReadLine();

                    Console.WriteLine("What kind of wall?");
                    Console.WriteLine("[1] Rectangle");
                    Console.WriteLine("[2] Square");
                    Console.WriteLine("[3] Triangle");
                    string shapeChoice = Console.ReadLine();

                    if (shapeChoice == "1")
                    {
                        Console.WriteLine("Enter wall height >>> ");
                        int height = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter wall length >>> ");
                        int length = int.Parse(Console.ReadLine());

                        //uncomment after step 2:
                        //newWall = new RectangleWall(name, color, height, length);
                    }
                    else if (shapeChoice == "2")
                    {
                        Console.WriteLine("Enter wall side length >>> ");
                        int sideLength = int.Parse(Console.ReadLine());

                        //uncomment after step 4:
                        //newWall = new SquareWall(name, color, sideLength);
                    }
                    else if (shapeChoice == "3")
                    {
                        Console.WriteLine("Enter wall height >>> ");
                        int height = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter wall base >>> ");
                        int triangleBase = int.Parse(Console.ReadLine());

                        //uncomment after step 3:
                        //newWall = new TriangleWall(name, color, height, triangleBase);
                    }

                    //uncomment after step 2:
                    //Console.WriteLine($"Added {newWall} wall - {newWall.GetArea()} square feet");
                    //walls.Add(newWall);
                }
                else if (userChoice == "2")
                {
                    IDictionary<string, int> colorChoiceAreas = new Dictionary<string, int>();

                    int totalArea = 0;
                    //uncomment after step 2:
                    //for (int i = 0; i < walls.Count; i++)
                    //{
                    //    Wall wall = walls[i];
                    //    int wallArea = wall.GetArea();

                    //    Console.WriteLine($"Wall {i + 1}: {wall} - {wallArea} square feet");

                    //    totalArea += wallArea;
                    //    colorChoiceAreas.TryGetValue(wall.Color, out int currentColorArea);
                    //    colorChoiceAreas[wall.Color] = currentColorArea + wallArea;
                    //}

                    Console.WriteLine("===============================");
                    Console.WriteLine("Total Area: " + totalArea + " square feet");

                    // 1 gallon of paint covers 400 square feet
                    foreach (KeyValuePair<string, int> colorEntry in colorChoiceAreas)
                    {
                        double gallonsRequiredForColor = (double)colorEntry.Value / 400;
                        Console.WriteLine($"{colorEntry.Key} Paint Required: {gallonsRequiredForColor} gallons");
                    }

                    return;
                }
            }
        }
    }
}
