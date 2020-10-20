using NUnit.Framework;

namespace GardenRover.Tests
{
    public class GardenRoverTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void CanProvideCurrentLocationAsString()
        {
            //Given
            Grass grass = new Grass(5, 5);
            Coordinates startingPosition = new Coordinates(3, 3);

            //When
            GardenRover GardenRover = new GardenRover(grass, "N", startingPosition);

            //Then
            Assert.AreEqual("3 3 N", GardenRover.CurrentLocation());
        }
    }
}