using ApplicationService.Interface.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.ItemDomainModels;


namespace ApplicationService.Service.Item
{
    public class AS_ItemPrice : IAS_ItemPrice
    {


        /// <summary>
        /// 取得Cost指定數量群組總和
        /// </summary>
        /// <param name="dmItemPriceList">商品列表</param>
        /// <param name="GroupNum">幾筆一組</param>
        /// <returns>回傳群組列表結果</returns>
        public List<int> GetSumByCostList(List<DM_ItemPrice> dmItemPriceList, int GroupNum)
        {
            int _intCount = 0;
            List<int> _intList = new List<int>();
            if(dmItemPriceList.Count/ GroupNum!=0)
            {
                _intCount = (dmItemPriceList.Count / GroupNum) + 1;
            }
            else
            {
                _intCount = (dmItemPriceList.Count / GroupNum);
            }

            for (int i = 0; i < _intCount; i++)
            {
                _intList.Add(dmItemPriceList.Skip(i* GroupNum).Take(GroupNum).Sum(x => x.Cost));
            }

            return _intList;

        }

        /// <summary>
        /// 透過反射取的dmItemPrice指定欄位加總
        /// </summary>
        /// <param name="dmItemPriceList">商品列表</param>
        /// <param name="intGroupNum">幾筆一組</param>
        /// <param name="enumPropertyName">DM_ItemPrice欄位名稱</param>
        /// <returns>回傳群組列表結果</returns>
        public List<int> GetSumBydmItemPrice(List<DM_ItemPrice> dmItemPriceList, int intGroupNum, DM_ItemPriceEnum enumPropertyName)
        {
            return this.GetSumBydmItemPrice(dmItemPriceList, intGroupNum, enumPropertyName.ToString());
        }

        /// <summary>
        /// 透過反射取的dmItemPrice指定欄位加總
        /// </summary>
        /// <param name="dmItemPriceList">商品列表</param>
        /// <param name="intGroupNum">幾筆一組</param>
        /// <param name="strPropertyName">DM_ItemPrice欄位名稱</param>
        /// <returns>回傳群組列表結果</returns>
        public List<int> GetSumBydmItemPrice(List<DM_ItemPrice> dmItemPriceList, int intGroupNum, string strPropertyName)
        {
            int _intCount = 0;
            List<int> _intList = new List<int>();
            if (dmItemPriceList.Count / intGroupNum != 0)
            {
                _intCount = (dmItemPriceList.Count / intGroupNum) + 1;
            }
            else
            {
                _intCount = (dmItemPriceList.Count / intGroupNum);
            }

            for (int i = 0; i < _intCount; i++)
            {
                _intList.Add(dmItemPriceList.Skip(i * intGroupNum).Take(intGroupNum).Sum(x => (int)x.GetType().GetProperty(strPropertyName).GetValue(x, null)));
            }

            return _intList;
        }

        /// <summary>
        /// 取得Revenue指定數量群組總和
        /// </summary>
        /// <param name="dmItemPriceList">商品列表</param>
        /// <param name="GroupNum">幾筆一組</param>
        /// <returns>回傳群組列表結果</returns>
        public List<int> GetSumByRevenueList(List<DM_ItemPrice> dmItemPriceList, int GroupNum)
        {
            int _intCount = 0;
            List<int> _intList = new List<int>();
            if (dmItemPriceList.Count / GroupNum != 0)
            {
                _intCount = (dmItemPriceList.Count / GroupNum) + 1;
            }
            else
            {
                _intCount = (dmItemPriceList.Count / GroupNum);
            }

            
            for (int i = 0; i < _intCount; i++)
            {
                _intList.Add(dmItemPriceList.Skip(i * GroupNum).Take(GroupNum).Sum(x => x.Revenue));
            }

            return _intList;

        }
    }
}
