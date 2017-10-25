using Securities.Service;
using Securities.Data;
using System;
using System.Collections.Generic;
using Xunit;

namespace Securities.UnitTest
{
    public class StockManagerTest
    {
        private readonly IStockManager _stockManager;

        public StockManagerTest()
        {
            this._stockManager = new StockManager();
        }

        [Fact]
        public void GetStockListTest()
        {
            List<Stock> _expects;

            _expects = new List<Stock>();
            _expects.Add(new Stock() { Id = 1, ISIN = "TW0001101004", Code = "1101", Name = "¥xªd" });
            _expects.Add(new Stock() { Id = 2, ISIN = "TW0001102002", Code = "1102", Name = "¨Èªd" });
            _expects.Add(new Stock() { Id = 3, ISIN = "TW0001103000", Code = "1103", Name = "¹Åªd" });
            _expects.Add(new Stock() { Id = 4, ISIN = "TW0001104008", Code = "1104", Name = "Àôªd" });
            _expects.Add(new Stock() { Id = 5, ISIN = "TW0001108009", Code = "1108", Name = "©¯ºÖ" });

            var _actuals = this._stockManager.GetStockList();
            
            Assert.Equal(_expects, _actuals);
        }
    }
}
