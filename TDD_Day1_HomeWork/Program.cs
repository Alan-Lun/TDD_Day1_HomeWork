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
            List<int> _intGetSumByCostList = _iasItemPrice.GetSumByCostList(_dmItemPriceList, 3);
            List<int> _intGetSumByRevenueList = _iasItemPrice.GetSumByRevenueList(_dmItemPriceList,4);

            string _strGroupByCostList = "", _strGroupByRevenueList="";

            for(int i=0;i< _intGetSumByCostList.Count;i++)
            {
                if(i== (_intGetSumByCostList.Count-1))
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

            Console.WriteLine("Cost總和："+ _strGroupByCostList);
            Console.WriteLine("Revenue總和："+ _strGroupByRevenueList);
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