using NewsWebsite.Common.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace NewsWebsite.XUnitTest.Common
{
  public class UrlValidateAttributeTest
   {
	  private readonly UrlValidateAttribute _validate;

	  public UrlValidateAttributeTest()
	  {
		 _validate = new UrlValidateAttribute("/", @"\", " ");
	  }
	  [Fact]
	  public void IsValidTest1()
	  {
		 Assert.True(_validate.IsValid("خبرورزشی"));
	  }

	  [Theory]
	  [InlineData("خبر ورزشی")]
	  [InlineData("خبر / ورزشی")]
	  [InlineData(@"خبر\ورزشی")]
	  public void IsValidTest2(string testValue)
	  {
		 Assert.True(_validate.IsValid(testValue));
	  }
   }
}
