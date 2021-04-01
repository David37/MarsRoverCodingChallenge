using System;

namespace MarsRoverChallenge
{
    public class MarsRover
    {
        private readonly string _instructions;
        private readonly (int x, int y) _plateauCoords;
        private char[] directions = {'S','W','N','E'};
        private (int x, int y) coords;
        private int currentDirectionsIndex;
        

        public MarsRover(string plateauCoords, string startingPos, string instructions="")
        {
            _instructions = instructions;
            Int32.TryParse(plateauCoords.Split(" ")[0], out _plateauCoords.x);
            Int32.TryParse(plateauCoords.Split(" ")[1], out _plateauCoords.y);
            Int32.TryParse(startingPos.Split(" ")[0], out coords.x);
            Int32.TryParse(startingPos.Split(" ")[1], out coords.y);
            currentDirectionsIndex = Array.IndexOf(directions, startingPos.Split(" ")[2].ToCharArray()[0]);
        }

        // Turns the Mars Rover so that it faces the left from its current direction
        public void turnLeft()
        {
            currentDirectionsIndex = currentDirectionsIndex - 1 < 0 
                ? directions.Length-1 
                : currentDirectionsIndex - 1;
        }

        // Turns the Mars Rover so that it faces the right from its current direction
        public void turnRight()
        {
            currentDirectionsIndex = currentDirectionsIndex + 1 >= directions.Length
                ? 0
                : currentDirectionsIndex + 1;

        }

        // Moves the Mars Rover forward depending on the direction it is currently facing
        public void stepForward()
        {
            switch(directions[currentDirectionsIndex]){
                case 'N' : 
                    coords.y += coords.y + 1 <= _plateauCoords.y ? 1 
                    : throw new Exception("Out of Plateua bounds"); 
                    break;
                case 'E' : 
                    coords.x+= coords.x + 1 <= _plateauCoords.x ? 1 
                    : throw new Exception("Out of Plateua bounds");
                    break;
                case 'S' : 
                    coords.y-= coords.y - 1 >= 0 ? 1 
                    : throw new Exception("Out of Plateua bounds");
                    break;
                case 'W' : 
                    coords.x-= coords.x - 1 >= 0 ? 1 
                    : throw new Exception("Out of Plateua bounds");
                    break;
                default: throw new Exception("Invalid direction");
            }

        }

        // Moves the Mars Rover from a given string of instructions
        public void moveRover(string instructions){
            foreach (char instruction in instructions)
            {
                switch(instruction){
                    case 'L' : turnLeft(); break;
                    case 'R' : turnRight(); break;
                    case 'M' : stepForward(); break;
                    default: throw new Exception("Invalid instruction");
                }
            }
        }

        // Moves the Mars Rovers from the orginal set of instructions
        public void moveRover(){
            foreach (char instruction in _instructions)
            {
                switch(instruction){
                    case 'L' : turnLeft(); break;
                    case 'R' : turnRight(); break;
                    case 'M' : stepForward(); break;
                    default: throw new Exception("Invalid instruction");
                }
            }            
        }

        // Gets the rovers current direction
        public char getDirection()
        {
            return directions[currentDirectionsIndex];
        }

        // Gets the rovers current X and Y coordinates
        public (int,int) getCoords()
        {
            return (coords.x, coords.y);
        }

        // Gets the rovers current position in format of "X-coordinate Y-coordinate direction"
        public string getRoverPosition()
        {
            return coords.x.ToString() + " " + coords.y.ToString() + " " + directions[currentDirectionsIndex].ToString();
        }

        public (int,int) getPlateauCoordinates()
        {
            return (_plateauCoords.x, _plateauCoords.y);
        }
    }
}
