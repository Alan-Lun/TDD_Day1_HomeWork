using DomainModel.ItemDomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Interface.Item
{
    public interface IAS_ItemPrice
    {
        /// <summary>
        /// 取得Cost指定數量群組總和
        /// </summary>
        /// <param name="dmItemPriceList">商品列表</param>
        /// <param name="GroupNum">幾筆一組</param>
        /// <returns>回傳群組列表結果</returns>
        List<int> GetSumByCostList(List<DM_ItemPrice> dmItemPriceList,int GroupNum);
        /// <summary>
        /// 取得Revenue指定數量群組總和
        /// </summary>
        /// <param name="dmItemPriceList">商品列表</param>
        /// <param name="GroupNum">幾筆一組</param>
        /// <returns>回傳群組列表結果</returns>
        List<int> GetSumByRevenueList(List<DM_ItemPrice> dmItemPriceList, int GroupNum);

        /// <summary>
        /// 透過反射取的dmItemPrice指定欄位加總
        /// </summary>
        /// <param name="dmItemPriceList">商品列表</param>
        /// <param name="intGroupNum">幾筆一組</param>
        /// <param name="strPropertyName">DM_ItemPrice欄位名稱</param>
        /// <returns>回傳群組列表結果</returns>
        List<int> GetSumBydmItemPrice(List<DM_ItemPrice> dmItemPriceList, int intGroupNum, string strPropertyName);

        /// <summary>
        /// 透過反射取的dmItemPrice指定欄位加總
        /// </summary>
        /// <param name="dmItemPriceList">商品列表</param>
        /// <param name="intGroupNum">幾筆一組</param>
        /// <param name="enumPropertyName">DM_ItemPrice欄位名稱</param>
        /// <returns>回傳群組列表結果</returns>
        List<int> GetSumBydmItemPrice(List<DM_ItemPrice> dmItemPriceList, int intGroupNum, DM_ItemPriceEnum enumPropertyName);


    }
}
