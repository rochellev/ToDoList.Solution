using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ToDoList.Models;

namespace ToDoList.Test
{
    [TestClass]
    public class ProgramTest
    {
        string description1 = "pick up socks";
        string description2 = "wash dishes";
        [TestMethod]
        public void GetId_ItemsInstantiateWininAnIdAndGetterReturns_Int()
        {
            string description = "pick up socks";
            Item newItem = new Item(description);

            int result = newItem.Id;

            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void Find_ReturnsCorrectItem_Item()
        {
            Item.ClearAll();
            Item item1 = new Item(description1);
            Item item2 = new Item(description2);

            Item result = Item.Find(1);

            Assert.AreEqual(item1, result);
        }
    }
}