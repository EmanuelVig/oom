using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task4.Storage.Definition;
using Task4.Storage.Implementation;

namespace Task4.Storage.Integrationstest
{
    [TestClass]
    public class UnitTest1
    {
        private IStorageAccess<string> _fileSave;

        [TestInitialize]
        public void Initialize()
        {
            _fileSave = new FileStorage("Test.txt");
        }
        [DeploymentItem(@"Test.txt")]
        [TestMethod]
        public void TestMethod1()
        {
            string input = "bbbbbbbbbbbbb";
            _fileSave.StoreValue(input);
            var output = _fileSave.SelectAll();
           Assert.AreEqual(output, input);
        }
    }
}
