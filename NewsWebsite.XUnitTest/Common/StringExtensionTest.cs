using Xunit;


namespace NewsWebsite.XUnitTest.Common
{
   public class StringExtensionTest
   {
	  [Fact]
	  public void CombineWithTest()
	  {
		 string[] testArray = { "Hello", "Asp", "Core" };
		 Assert.Equal("Hello,Asp,Core", NewsWebsite.Common.StringExtensions.CombineWith(testArray, ','));
	  }

	  [Theory] 
	  [InlineData("2", "۲")]
	  [InlineData("3", "۳")]
	  [InlineData("4","error")]
	  public void En2FaTest(string englishNumber,string persionNumber)
	  {
		 Assert.Equal(persionNumber, NewsWebsite.Common.StringExtensions.En2Fa(englishNumber));
	  }


   }
}
