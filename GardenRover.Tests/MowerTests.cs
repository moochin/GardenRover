using NUnit.Framework;

namespace GardenRover.Tests
{
    public class MowerTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void CanProvideCurrentPositionAsString()
        {
            //Given
            Coordinates startingLocation = new Coordinates(3, 3);
            string initialHeading = "N";

            //When
            Mower mower = new Mower(startingLocation, initialHeading);

            //Then
            Assert.AreEqual("3 3 N", gardenRover.CurrentPosition());
        }
    }
}