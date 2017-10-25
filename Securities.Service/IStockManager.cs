using Securities.Data;
using System.Collections.Generic;

namespace Securities.Service
{

    /// <summary>
    /// 定義有價證券清單服務的實作方法
    /// </summary>
    public interface IStockManager
    {
        /// <summary>
        /// 取得所有有價證劵清單
        /// </summary>
        IEnumerable<Stock> GetStockList();
    }
}
