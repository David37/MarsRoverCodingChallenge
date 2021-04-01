﻿using System;
using System.Collections.Generic;

namespace MarsRoverChallenge
{
    class MarsRoverChallenge
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter plateau coordinates");
            string plateauCoordsString;
            (int x, int y) plateauCoords; 
            // Get valid plateau coordinates
            while(true)
            {
                plateauCoordsString = Console.ReadLine();
                var plateauCoordsArray= plateauCoordsString.Split(" ");
                if(plateauCoordsArray.Length == 0 || plateauCoordsArray.Length>2
                  || !Int32.TryParse(plateauCoordsString[0].ToString(), out  plateauCoords.x) 
                  || !Int32.TryParse(plateauCoordsString[1].ToString(), out  plateauCoords.y))
                {
                    Console.WriteLine("Please enter in valid plateau coordinates");
                    continue;
                }
                break;
            }

            List<MarsRover> rovers = new List<MarsRover>();

            // Get one or more rover starting position(s) and instructions
            do {
                
                Console.WriteLine("\n");
                string startingPos;

                // Get valid rover starting position
                while(true)
                {
                    Console.WriteLine("Enter rover starting position");
                    startingPos = Console.ReadLine();
                    string[] startingPosArray = startingPos.Split(" ");

                    if(startingPosArray.Length != 3)
                    {
                        Console.WriteLine("Please enter in a valid starting position");
                        continue;
                    }

                    int xCoord;
                    int yCoord;
                    char direction=startingPos[2];
                    
                    if(!Int32.TryParse(startingPosArray[0], out xCoord) 
                      || !Int32.TryParse(startingPosArray[1], out yCoord)
                      || xCoord > plateauCoords.x && xCoord < 0 
                      || yCoord > plateauCoords.y && yCoord < 0)
                        {
                            Console.WriteLine("Please enter valid starting position");
                            continue;
                        }
                    break;
                }

                Console.WriteLine("Enter in the instructions for the rover");
                string instructions = Console.ReadLine();
                rovers.Add(new MarsRover(plateauCoordsString, startingPos, instructions));
                Console.WriteLine("Would you like to enter in another rover");

            } while((Console.ReadLine()[0].ToString().ToUpper() == "Y"));

            // Move each rover sequentially and return print out their final positions
            foreach (var rover in rovers)
            {
                rover.moveRover();
                Console.WriteLine(rover.getRoverPosition()+"\n");
            }
        }
    }
}
