using Securities.Data;
using System.Collections.Generic;

namespace Securities.Service
{

    /// <summary>
    /// 取得有價證券清單的服務
    /// </summary>
    public sealed class StockManager : IStockManager
    {
        /// <summary>
        /// 取得所有有價證劵清單
        /// </summary>
        public IEnumerable<Stock> GetStockList()
        {
            List<Stock> _items;

            _items = new List<Stock>();
            _items.Add(new Stock() { Id = 1, ISIN = "TW0001101004", Code = "1101", Name = "台泥" });
            _items.Add(new Stock() { Id = 2, ISIN = "TW0001102002", Code = "1102", Name = "亞泥" });
            _items.Add(new Stock() { Id = 3, ISIN = "TW0001103000", Code = "1103", Name = "嘉泥" });
            _items.Add(new Stock() { Id = 4, ISIN = "TW0001104008", Code = "1104", Name = "環泥" });
            _items.Add(new Stock() { Id = 5, ISIN = "TW0001108009", Code = "1108", Name = "幸福" });

            return _items.ToArray();
        }
    }
}
