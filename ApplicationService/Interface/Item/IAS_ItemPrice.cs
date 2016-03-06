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



    }
}
