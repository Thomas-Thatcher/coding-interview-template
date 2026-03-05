using System;
using System.Collections.Generic;
using System.Text;

namespace CodeInterview.Tests
{
    [TestClass]
    public class CommonHelperTests
    {
        [TestMethod]
        public void GetHash_StringInput_ReturnsExpectedHash()
        {
            // Arrange
            var input = "Hello, World!";
            var expectedHash = "dffd6021bb2bd5b0af676290809ec3a53191dd81c7f70a4b28688a362182986f";
            // Act
            var actualHash = CodeInterview.Business.CommonHelpers.GetHash(input);
            Console.WriteLine(actualHash);
            // Assert
            Assert.AreEqual(expectedHash, actualHash);
        }

        [TestMethod]
        public void GetHash_ObjectInput_ReturnsExpectedHash()
        {
            // Arrange
            var input = new { Name = "Alice", Age = 30 };
            var expectedHash = "44f51f617abef62a3d518fd1f97213e606f99a6465369ddfc9669b31d267c708";
            // Act
            var actualHash = CodeInterview.Business.CommonHelpers.GetHash(input);
            Console.WriteLine(actualHash);

            // Assert
            Assert.AreEqual(expectedHash, actualHash);
        }
    } 
}
