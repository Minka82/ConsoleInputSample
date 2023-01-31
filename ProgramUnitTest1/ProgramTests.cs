namespace ProgramUnitTest1
{
    public class ProgramTests
    {
     
        [Test]
        public void Test_ProgramSum_TwoPositiveNumbers()
        {
            //Arrange
            string input = "5 10 12";

            var writer = new StringWriter();
            Console.SetOut(writer); // Redirect Console.Out

            var reader = new StringReader(input);
            Console.SetIn(reader); // Redirect Console.In

            //Act
            Program.Main();
                        
            //Assert




        }
    }
}