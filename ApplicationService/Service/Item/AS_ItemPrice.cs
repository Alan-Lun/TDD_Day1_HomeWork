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
