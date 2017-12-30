using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AzureFunctions.Extensions.GoogleBigQuery.ComponentTests {
    [TestClass]
    public class BigQueryServiceTests {

        [TestMethod]
        public void InsertRecord_NullablesNulls() {

            //Arrange
            TestBigQueryRow testBigQueryRow = new TestBigQueryRow(DateTime.UtcNow, "insertId_1") {
                IntValue = 1,
                IntNullableValue = null
            };


            //Act

            //Assert

        }

    }
}