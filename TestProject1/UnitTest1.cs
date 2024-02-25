using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp27.Core;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestDisplaySquare()
    {
        int sideLength = 3;
        char symbol = '*';

    }

    [TestMethod]
    public void TestIsPalindrome()
    {
        // Arrange
        int palindromeNumber = 121;

        // Act
        bool result = PalindromeChecker.IsPalindrome(palindromeNumber);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void TestIsNotPalindrome()
    {
        // Arrange
        int nonPalindromeNumber = 123;

        // Act
        bool result = PalindromeChecker.IsPalindrome(nonPalindromeNumber);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void TestFilterArray()
    {
        // Arrange
        int[] originalArray = { 1, 2, 6, -1, 88, 7, 6 };
        int[] filterArray = { 6, 88, 7 };

        // Act
        int[] resultArray = ArrayFilter.FilterArray(originalArray, filterArray);

        // Assert
        CollectionAssert.AreEqual(new int[] { 1, 2, -1 }, resultArray);
    }
}
