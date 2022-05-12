using System;
using NUnit.Framework;

namespace Summator.Tests
{
	public class Tests
	{
		[Test]
		public void Test_Sum_TwoPossitiveNumbers()
		{
			//Arrange
			int[] nums = new int[]{3, 9 };
			//Act
			int result = Summator.Sum(nums);
			//Assert
			Assert.That(result == 12);
		}
		[Test]
		public void Test_Sum_OnePossitiveNumbers()
		{
			//Arrange
			int[] nums = new int[] { 3 };
			//Act
			int result = Summator.Sum(nums);
			//Assert
			Assert.That(result == 3);
		}
		[Test]
		public void Test_Sum_TwoNegative()
		{
			//Arrange
			int[] nums = new int[] { -3, -9 };
			//Act
			int result = Summator.Sum(nums);
			//Assert
			Assert.That(result == -12);
		}
		[Test]
		public void Test_Sum_OnePossitiveOneNegative()
		{
			//Arrange
			int[] nums = new int[] { 3, -9 };
			//Act
			int result = Summator.Sum(nums);
			//Assert
			Assert.That(result == -6);
		}
		[Test]
		public void Test_Sum_OneNegativeOnePossitive()
		{
			//Arrange
			int[] nums = new int[] { -3, 7 };
			//Act
			int result = Summator.Sum(nums);
			//Assert
			Assert.That(result == 4);
		}
		[Test]
		public void Test_Sum_OnePossitvieOneNegativeAndZero()
		{
			//Arrange
			int[] nums = new int[] { 3, -6, 0 };
			//Act
			int result = Summator.Sum(nums);
			//Assert
			Assert.That(result == -3);   
		}
	}
}