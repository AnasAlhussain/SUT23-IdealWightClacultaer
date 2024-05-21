using FluentAssertions;
using SUT23_IdealWightClacultaer;

namespace IdealWeightCalculater.MSTest
{
    [TestClass]
    public class WeightCalculaterTests
    {

        //Given_When_Then
        [TestMethod]
        [Description("This test about checking if ideal body weight ")]
        [Owner("Anas + Tobias")]
        [Priority(1)]
        [TestCategory("Weight Category")]
        public void GetIdealBodyWeigh_Gender_M_And_Height180_Return_72_5()
        {
            //AAA 
            // Arrange (input)
            WeightCalculater systemUnderTesting = new WeightCalculater()
            {
                Height = 140,
                Gender = 'm'
            };

            //Act
            var actual = systemUnderTesting.GetIdealBodyWeight();
            var expected = 72.5;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [Owner("Reidar")]
        [Priority(2)]
        [TestCategory("Weight Category")]
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

        //[TestMethod]
        //[TestCategory("Divide Övning")]
        //[Priority(3)]
        //public void Divide_PositiveNumbers_ResturnPsoitve()
        //{
        //    // Arrange 
        //    int numerator = 20;
        //    int denominator = 4;

        //    // Act 
        //    WeightCalculater cal = new WeightCalculater();
        //   var actual= cal.Divide(numerator, denominator);
        //    var exp = 5;

        //    // Assert 
        //    Assert.AreEqual(exp, actual);
        //}


        //[TestMethod]
        //public void Divide_PostiveNumber_REturnNegative()
        //{
        //    // Arrange 
        //    int numerator = 20;
        //    int denominator = -4;

        //    // Act 
        //    WeightCalculater cal = new WeightCalculater();
        //    var actual = cal.Divide(numerator, denominator);
        //    var exp = -5;

        //    // Assert 
        //    Assert.AreEqual(exp, actual);
        //}


        //[TestMethod]
        //public void Assert_Test()
        //{
        //    //Assert.AreEqual(100, 100);
        //    //Assert.AreNotEqual(100, 100);

        //    WeightCalculater cal1 = new WeightCalculater();
        //    WeightCalculater cal2 = new WeightCalculater();

        //    Assert.AreNotSame(cal1, cal2);
        //    Assert.AreSame(cal1, cal1);

        //    Assert.IsInstanceOfType(cal1,typeof(WeightCalculater));

        //    cal1 = null;
        //    //Assert.IsNotNull(cal1);
        //    Assert.IsNull(cal1);


        //    Assert.IsTrue(100 == 10 + 90);
        //    Assert.IsFalse(100 == 10 + 90);

        //}



        //[TestMethod]
        //public void StringAssert_Test()
        //{
        //    string name = "Tobias";

        //    StringAssert.Contains(name, "ias");


        //    StringAssert.EndsWith(name, "s");

        //    StringAssert.StartsWith(name, "m");
        //}




        //[TestMethod]
        //public void CollectionAssert_Test()
        //{
        //    List<string> name = new List<string>() { "Anas", "Tobias", "Sara" };
        //    List<string> name1 = new List<string>() { "Reidar", "Sara", "Tobias" };

        //    CollectionAssert.AllItemsAreNotNull(name);
        //    CollectionAssert.AllItemsAreInstancesOfType(name,typeof(string));

        //    CollectionAssert.Contains(name, "Sara");

        //   // CollectionAssert.AreEqual(name, name1);
        //    //CollectionAssert.AreEquivalent(name, name1);
        //}


        //[TestMethod]
        //public void FluentAssertion_Test()
        //{
        //    string name = "Tobias";

        //    name.Should().StartWith("T").And.EndWith("s");

        //    int number = 11;
        //    number.Should().BeLessThanOrEqualTo(11);
        //    number.Should().BeGreaterThan(10);

        //    List<string> names = new List<string>() {  };

        //    //names.Should().HaveCount(5);
        //    names.Should().NotBeEmpty();

        //}



    }
}