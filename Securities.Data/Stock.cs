using System;

namespace Securities.Data
{
    /// <summary>
    /// 有價證券
    /// </summary>
    public class Stock
    {
        /// <summary>
        /// 識別碼
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// ISIN 國際證卷識別碼
        /// </summary>
        public string ISIN { get; set; }

        /// <summary>
        /// 代碼
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 名稱
        /// </summary>
        public string Name { get; set; }


        /*
         * 移除或註解 Equals 方法
         * 在 xUnit 測試會出現 Assert.Equal Fail 錯誤
         */
        #region 複寫下列方法可在單元測試時驗證結果

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            StringComparison _comparison;
            Stock _item;

            _comparison = StringComparison.OrdinalIgnoreCase;
            _item = obj as Stock;

            if (this.Id != _item.Id)
                return false;

            if (string.Equals(this.ISIN, _item.ISIN, _comparison) == false)
                return false;

            if (string.Equals(this.Code, _item.Code, _comparison) == false)
                return false;

            if (string.Equals(this.Name, _item.Name, _comparison) == false)
                return false;

            return true;
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode() 
                    ^ this.ISIN.GetHashCode() 
                    ^ this.Code.GetHashCode() 
                    ^ this.Name.GetHashCode();
        }

        #endregion

    }

}
