using MarsRoverChallenge;
using NUnit.Framework;

namespace MarsRoverChallengeTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
 
        [Test]
        public void Test_turnLeft()
        {
            //Arrange
            MarsRover rover = new MarsRover("5 5", "1 2 N");

            //Act
            rover.turnLeft();

            //Assert 
            Assert.AreEqual('W', rover.getDirection());
        }

        [Test]
        public void Test_turnRight()
        {
            //Arrange
            MarsRover rover = new MarsRover("5 5", "1 2 N");

            //Act
            rover.turnRight();

            //Assert 
            Assert.AreEqual('E', rover.getDirection());
        }

        [Test]
        public void Test_stepForward()
        {
            //Arrange
            MarsRover rover = new MarsRover("5 5", "1 2 N");

            //Act
            rover.stepForward();

            //Assert 
            Assert.AreEqual((1,3), rover.getCoords());
            Assert.AreEqual('N', rover.getDirection());
        }

        [Test]
        public void Test_moveRover_WithConstructorInstructions()
        {
            //Arrange
            MarsRover rover = new MarsRover("5 5", "2 2 S", "LRLRMLMRMRMM");

            //Act
            rover.moveRover();

            //Assert
            Assert.AreEqual("1 0 W", rover.getRoverPosition());
        }

        [Test]
        public void Test_moveRover(){
            //Arrange
            MarsRover rover = new MarsRover("5 5", "3 3 E");

            //Act
            rover.moveRover("MMRMMRMRRM");

            //Assert
            Assert.AreEqual("5 1 E", rover.getRoverPosition());
        }
       

    }
}