using ApplicationService.Interface.Item;
using ApplicationService.Service.Item;
using DomainModel.ItemDomainModels;
using System;
using System.Collections.Generic;

namespace TDD_Day1_HomeWork
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<DM_ItemPrice> _dmItemPriceList = new List<DM_ItemPrice>();
            DM_ItemPrice _dmItemPrice = new DM_ItemPrice();

            _dmItemPriceList.Add(CreateData(1, 1, 11, 21));
            _dmItemPriceList.Add(CreateData(2, 2, 12, 22));
            _dmItemPriceList.Add(CreateData(3, 3, 13, 23));
            _dmItemPriceList.Add(CreateData(4, 4, 14, 24));
            _dmItemPriceList.Add(CreateData(5, 5, 15, 25));
            _dmItemPriceList.Add(CreateData(6, 6, 16, 26));
            _dmItemPriceList.Add(CreateData(7, 7, 17, 27));
            _dmItemPriceList.Add(CreateData(8, 8, 18, 28));
            _dmItemPriceList.Add(CreateData(9, 9, 19, 29));
            _dmItemPriceList.Add(CreateData(10, 10, 20, 30));
            _dmItemPriceList.Add(CreateData(11, 11, 21, 31));

            IAS_ItemPrice _iasItemPrice = new AS_ItemPrice();
            #region 第一版本
            List<int> _intGetSumByCostList = _iasItemPrice.GetSumByCostList(_dmItemPriceList, 3);
            List<int> _intGetSumByRevenueList = _iasItemPrice.GetSumByRevenueList(_dmItemPriceList,4);

            string _strGroupByCostList = "", _strGroupByRevenueList = "";

            for (int i = 0; i < _intGetSumByCostList.Count; i++)
            {
                if (i == (_intGetSumByCostList.Count - 1))
                {
                    _strGroupByCostList += _intGetSumByCostList[i];
                }
                else
                {
                    _strGroupByCostList += _intGetSumByCostList[i] + ",";
                }

            }

            for (int i = 0; i < _intGetSumByRevenueList.Count; i++)
            {

                if (i == (_intGetSumByRevenueList.Count - 1))
                {
                    _strGroupByRevenueList += _intGetSumByRevenueList[i];
                }
                else
                {
                    _strGroupByRevenueList += _intGetSumByRevenueList[i] + ",";
                }
            }

            #endregion

            #region 第二版本
            List<int> _intGetSumByCostList1 = _iasItemPrice.GetSumBydmItemPrice(_dmItemPriceList, 3,DM_ItemPriceEnum.Cost);
            List<int> _intGetSumByRevenueList2 = _iasItemPrice.GetSumBydmItemPrice(_dmItemPriceList, 4, "Revenue");

            
            string _strGroupByCostList1 = "", _strGroupByRevenueList2="";

           

            for (int i = 0; i < _intGetSumByCostList1.Count; i++)
            {
                if (i == (_intGetSumByCostList1.Count - 1))
                {
                    _strGroupByCostList1 += _intGetSumByCostList1[i];
                }
                else
                {
                    _strGroupByCostList1 += _intGetSumByCostList1[i] + ",";
                }

            }

            for (int i = 0; i < _intGetSumByRevenueList2.Count; i++)
            {

                if (i == (_intGetSumByRevenueList2.Count - 1))
                {
                    _strGroupByRevenueList2 += _intGetSumByRevenueList2[i];
                }
                else
                {
                    _strGroupByRevenueList2 += _intGetSumByRevenueList2[i] + ",";
                }
            }
            #endregion

            Console.WriteLine("Cost總和："+ _strGroupByCostList);
            Console.WriteLine("Revenue總和："+ _strGroupByRevenueList);
            Console.WriteLine("反射Cost總和：" + _strGroupByCostList1);
            Console.WriteLine("反射Revenue總和：" + _strGroupByRevenueList2);
            Console.Read();
        }

        public static DM_ItemPrice CreateData(int intId, int intCost, int intRevenue, int intSellPrice)
        {
            DM_ItemPrice _dmItemPrice = new DM_ItemPrice();
            _dmItemPrice.Id = intId;
            _dmItemPrice.Cost = intCost;
            _dmItemPrice.Revenue = intRevenue;
            _dmItemPrice.SellPrice = intSellPrice;
            return _dmItemPrice;
        }
    }
}