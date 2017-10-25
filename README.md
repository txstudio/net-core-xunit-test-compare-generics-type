# 使用 xUnit 對泛型集合進行 Assert.Equal 比較驗證

此專案情境為模擬有價證卷資料服務，並撰寫進行值物件比對的單元測試。

類別庫專案使用 .NET Standard v2.0 建立。

## 專案目的

使用 Assert.Equal 進行驗證時，若驗證項目為自行建立之物件（值物件），
需在物件中複寫 Equals 與 GetHashCode 方法並撰寫比較相關的程式碼內容
（可參考 [Securities.Data](https://github.com/txstudio/net-core-xunit-test-compare-generics-type/tree/master/Securities.Data) 類別庫原始程式碼的 [Stock.cs](https://github.com/txstudio/net-core-xunit-test-compare-generics-type/blob/master/Securities.Data/Stock.cs) 程式碼區塊）

未複寫並實作方法時進行 Assert.Equal 比較會顯示驗證失敗
（雖然物件的屬性皆相同）

>　取得程式碼後可自行註解複寫的方法實作並比較差異。

## 使用流程
- 取得範例程式碼
- 進行單元測試
- 移除 Stock 類別複寫的 Equals 與 GetHashCode 方法
- 重新執行單元測試
- 比較有無複寫 Equals 與 GetHashCode 方法結果

### 架構
|專案名稱|類型|名稱|
|--|--|--|
|Securities.Data|.NET Standard 2.0|資料物件|
|Securities.Service|.NET Standard 2.0|有價證卷存取服務|
|Securities.UnitTest|.NET Core xUnit 單元測試專案|使用 xUnit 的單元測試專案|


### 套件參考

套件會因版本不同在實際呈現可能會有所差異。

|名稱|版本|
|--|--|
|System.Collections|4.3.0|
|Microsoft.NET.Test.Sdk|15.3.0-preview-20170628-02|
|xunit|2.2.0|
|xunit.runner.visualstudio|2.2.0|

