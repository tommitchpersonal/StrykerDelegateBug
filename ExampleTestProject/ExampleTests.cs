using StrykerDelegateBug;

namespace ExampleTestProject
{
    public class ExampleTests
    {
        [Test]
        public void ExampleTest()
        {
            DelegateExample.OutputString("Test String");
            Assert.Pass();
        }
    }
}