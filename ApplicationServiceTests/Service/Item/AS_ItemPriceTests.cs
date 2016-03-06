using ApplicationService.Interface.Item;
using DomainModel.ItemDomainModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ExpectedObjects;

namespace ApplicationService.Service.Item.Tests
{
    [TestClass()]
    public class AS_ItemPriceTests
    {
        [TestMethod()]
        public void GetSumByCostListTest_frist_ListdmItemPrice_second_3_should_be_ListintItemWith4Item()
        {
            //arrange 初始化
            List<DM_ItemPrice> first = new List<DM_ItemPrice>
            {
                new DM_ItemPrice {Id=1,Cost=1,Revenue=11,SellPrice=21 },
                new DM_ItemPrice {Id=2,Cost=2,Revenue=12,SellPrice=22 },
                new DM_ItemPrice {Id=3,Cost=3,Revenue=13,SellPrice=23 },
                new DM_ItemPrice {Id=4,Cost=4,Revenue=14,SellPrice=24 },
                new DM_ItemPrice {Id=5,Cost=5,Revenue=15,SellPrice=25 },
                new DM_ItemPrice {Id=6,Cost=6,Revenue=16,SellPrice=26 },
                new DM_ItemPrice {Id=7,Cost=7,Revenue=17,SellPrice=27 },
                new DM_ItemPrice {Id=8,Cost=8,Revenue=18,SellPrice=28 },
                new DM_ItemPrice {Id=9,Cost=9,Revenue=19,SellPrice=29 },
                new DM_ItemPrice {Id=10,Cost=10,Revenue=20,SellPrice=30 },
                new DM_ItemPrice {Id=11,Cost=11,Revenue=21,SellPrice=31 }
            };

            int second = 3;

            List<int> expected = new List<int>() { 6, 15, 24, 21 };

            //act 測試目標行為
            IAS_ItemPrice _iasItemPrice = new AS_ItemPrice();
            var actual = _iasItemPrice.GetSumByCostList(first, second);

            //assert 驗證目標行為
            expected.ToExpectedObject().ShouldEqual(actual);


            //Assert.Fail();
        }

        [TestMethod()]
        public void GetSumByRevenueListTest_first_ListdmItemPrice_second_4_should_be_ListintItemWith3Item()
        {
            //arrange 初始化
            List<DM_ItemPrice> first = new List<DM_ItemPrice>
            {
                new DM_ItemPrice {Id=1,Cost=1,Revenue=11,SellPrice=21 },
                new DM_ItemPrice {Id=2,Cost=2,Revenue=12,SellPrice=22 },
                new DM_ItemPrice {Id=3,Cost=3,Revenue=13,SellPrice=23 },
                new DM_ItemPrice {Id=4,Cost=4,Revenue=14,SellPrice=24 },
                new DM_ItemPrice {Id=5,Cost=5,Revenue=15,SellPrice=25 },
                new DM_ItemPrice {Id=6,Cost=6,Revenue=16,SellPrice=26 },
                new DM_ItemPrice {Id=7,Cost=7,Revenue=17,SellPrice=27 },
                new DM_ItemPrice {Id=8,Cost=8,Revenue=18,SellPrice=28 },
                new DM_ItemPrice {Id=9,Cost=9,Revenue=19,SellPrice=29 },
                new DM_ItemPrice {Id=10,Cost=10,Revenue=20,SellPrice=30 },
                new DM_ItemPrice {Id=11,Cost=11,Revenue=21,SellPrice=31 }
            };

            int second = 4;

            List<int> expected = new List<int>() { 50, 66, 60 };

            //act 測試目標行為
            IAS_ItemPrice _iasItemPrice = new AS_ItemPrice();
            var actual = _iasItemPrice.GetSumByRevenueList(first, second);

            //assert 驗證目標行為
            expected.ToExpectedObject().ShouldEqual(actual);



            //Assert.Fail();
        }


    }
}