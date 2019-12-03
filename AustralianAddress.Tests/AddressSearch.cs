using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using AustralianAddress.Repositories.SearchService;

namespace AustralianAddress.Tests
{
    [TestClass]
    public class AddressSearch
    {
        [TestMethod]
        [InlineData("key", "Street")]
        public void TestMethod1(string key)
        {
            AddressFilter getFilterResult = new AddressFilter();
            bool IsResult = false;
            var filterResult = getFilterResult.FilterByKey(key);           
            Assert.IsNull(filterResult);
            if (filterResult != null && filterResult.Any())
            {
                IsResult = true;
            }
            Assert.Equals(true, IsResult);
        }
    }
}
