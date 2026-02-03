using CD_Basic_App_GitHub;
using Xunit;
namespace CD_Basic_App_Core.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestNameProperty()
        {
            Class1 tp = new Class1();

            var result = tp.Name;

            Assert.Equal("[Cayden Dick] - The Code Master", result);

        }
    }
}