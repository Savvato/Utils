namespace Savvato.Utils.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StringUtilsTests
    {
        [DataTestMethod]
        [DataRow("snake_case_string", "snakeCaseString")]
        [DataRow("_snake_case_string", "_snakeCaseString")]
        [DataRow("__snake_case_string", "__snakeCaseString")]
        [DataRow("__snake__case_string", "__snakeCaseString")]
        [DataRow("__sNaKe__BrokEnCase_string", "__snakeBrokencaseString")]
        public void StringUtils_FromSnakeCaseToCamelCase(string input, string requiredOutput)
        {
            // Act
            string result = StringUtils.FromSnakeCaseToCamelCase(input);

            // Assert
            Assert.AreEqual(requiredOutput, result);
        }

        [DataTestMethod]
        [DataRow("camelCaseString", "camel_case_string")]
        [DataRow("_camelCaseString", "_camel_case_string")]
        [DataRow("__camelCaseString", "__camel_case_string")]
        [DataRow("__camelCase_String", "__camel_case_string")]
        [DataRow("__camelCase_string", "__camel_case_string")]
        public void StringUtils_FromCamelCaseToSnakeCase(string input, string requiredOutput)
        {
            // Act
            string result = StringUtils.FromCamelCaseToSnakeCase(input);

            // Assert
            Assert.AreEqual(requiredOutput, result);
        }
    }
}
