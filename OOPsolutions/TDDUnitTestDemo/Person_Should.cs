using FluentAssertions;
using OOPsReview;
namespace TDDUnitTestDemo
{
    public class Person_Should
    {
        //consists of
        //Attribute title
        //Fact which does one test and is usually set up and coded within the test
        //Theory which allows for multiple test data stream applied to the same test
        [Fact]
        public void Create_an_Instance_With_First_And_Last_Name()
        {
            //fluent assertion extends our capability of checking a result

            //AREAS
            //Arrange(setup)
            string firstName = "Kingsley";
            string lastName = "Wosu";
            //Act(execution) SUT - subject under test
            Person sut = new Person(firstName,lastName);
            //Assert (testing of the action)
            sut.FirstName.Should().Be(firstName);
            sut.LastName.Should().Be(lastName);

        }
    }
}