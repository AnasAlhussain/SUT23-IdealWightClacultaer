using SUT23_IdealWightClacultaer;

namespace IdealWeightCalculater.MSTest
{
    [TestClass]
    public class WeightCalculaterTests
    {

        //Given_When_Then
        [TestMethod]
        public void GetIdealBodyWeigh_Gender_M_And_Height180_Return_72_5()
        {
            //AAA 
            // Arrange (input)
            WeightCalculater systemUnderTesting = new WeightCalculater()
            {
                Height = 180,
                Gender = 'm'
            };

            //Act
           var actual = systemUnderTesting.GetIdealBodyWeight();
            var expected = 72.5;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetIdealBodyWieght_Gender_F_And_Height180_return_65()
        {
            //Arrange 
            WeightCalculater sut = new WeightCalculater()
            {
                Gender = 'w',
                Height = 170
            };

            //Act 
            var actual = sut.GetIdealBodyWeight();
            var expected = 60;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Divide_PositiveNumbers_ResturnPsoitve()
        {
            // Arrange 
            int numerator = 20;
            int denominator = 4;

            // Act 
            WeightCalculater cal = new WeightCalculater();
           var actual= cal.Divide(numerator, denominator);
            var exp = 5;

            // Assert 
            Assert.AreEqual(exp, actual);
        }


        [TestMethod]
        public void Divide_PostiveNumber_REturnNegative()
        {
            // Arrange 
            int numerator = 20;
            int denominator = -4;

            // Act 
            WeightCalculater cal = new WeightCalculater();
            var actual = cal.Divide(numerator, denominator);
            var exp = -5;

            // Assert 
            Assert.AreEqual(exp, actual);
        }


    }
}