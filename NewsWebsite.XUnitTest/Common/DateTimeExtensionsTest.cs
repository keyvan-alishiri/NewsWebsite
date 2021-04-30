using NewsWebsite.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace NewsWebsite.XUnitTest.Common
{
  public class DateTimeExtensionsTest
   {


	  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///
	  [Theory]
	  [MemberData(nameof(TestData))]
	  public void IsLeapYearTest(DateTime miladidate ,bool isLeap)
	  {
		 Assert.Equal(isLeap,NewsWebsite.Common.DateTimeExtensions.IsLeapYear(miladidate));
	  }

	  public static IEnumerable<object[]> TestData()
	  {
		 yield return new object[] { new DateTime(2019, 12, 23), false };
		 yield return new object[] { new DateTime(2020, 12, 23), true };
	  }

	  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///





	  ///  ///  ///  ///  ///  ///  ///  ///  InlineData  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///
	  [Theory]
	  [InlineData("dfdfdf",false)]
	  [InlineData("1398/10/12",true)]
	  public void CheckShamsiDateTimeTest(string persionDateTime,bool result)
	  {
		 Assert.Equal(result, NewsWebsite.Common.DateTimeExtensions.CheckShamsiDateTime(persionDateTime).IsShamsi);
	  }


	 






	  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  /// ClassData Test  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///
	  [Theory]
	  [ClassData(typeof(DateTimeResultClassData))]

	  public void CheckShamsiDateTimeTest2(NewsWebsite.Common.DateTimeResult resultTest)
	  {
		 var result = NewsWebsite.Common.DateTimeExtensions.CheckShamsiDateTime(resultTest.searchText);
		 Assert.Equal(result.IsShamsi, result.IsShamsi);
		 Assert.Equal(result.MiladiDate, result.MiladiDate);
	  }


	  

   }

   ///  ///  ///  ///  ///  ///   ///  ///  /// ClassData For use in CheckShamsiDateTimeTest2 MethodTest ///  ///  ///  ///  ///  ///  ///  ///  ///
   public class DateTimeResultClassData : IEnumerable<object[]>
   {
	  public IEnumerator<object[]> GetEnumerator()
	  {
		 yield return new object[] {
				new DateTimeResult
				{
				   searchText="1398/10/02",
				   IsShamsi=true,
				   MiladiDate= new DateTime(2019,12,23),
				}
			};

		 yield return new object[] {
				 new DateTimeResult
				{
				   searchText="kfjdj",
				   IsShamsi=false,
				   MiladiDate= null,
				}
		 };
	  }
	  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
   }

   ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///  ///
}
