using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Lab3;

namespace UnitTestsLab3
{
    [TestClass]
    public class CirkularLinkedListTest
    {
        [TestMethod]
        public void CreateEmptyList_AddItem()
        {
            CircularLinkedList<int> l = new CircularLinkedList<int>();
            l.Add(1);
        }
        [TestMethod]
        public void CreateEmptyList_RemoveItemFromEmptyList()
        {
            CircularLinkedList<int> l = new CircularLinkedList<int>();
            l.Remove(1);
        }
        [TestMethod]
        public void CreateList_AddItem_RemoveByIndex()
        {
            CircularLinkedList<int> l = new CircularLinkedList<int>();
            l.Add(1);
            l.Add(2);
            l.Remove(l[0]);
        }
        [TestMethod]
        public void CreateEmptyList_AddItem_RemoveItem()
        {
            CircularLinkedList<int> l = new CircularLinkedList<int>();
            l.Add(1);
            l.Remove(1);
        }
        [TestMethod]
        public void CreateList_AddItem_RemoveItem()
        {
            CircularLinkedList<int> l = new CircularLinkedList<int>();
            l.Add(1);
            l.Remove(1);
        }
        [TestMethod]
        public void CreateList_AddItem_CheckContains()
        {
            CircularLinkedList<int> l = new CircularLinkedList<int>();
            l.Add(1);
            l.Contains(1);
        }
        [TestMethod]
        public void CreateList_AddItems_ClearList()
        {
            CircularLinkedList<int> l = new CircularLinkedList<int>();
            l.Add(1);
            l.Add(2);
            l.Add(3);
            l.Clear();
        }
        [TestMethod]
        public void CreateList_AddItem_GetItemByCurrentIndex()
        {
            CircularLinkedList<int> l = new CircularLinkedList<int>();
            l.Add(1);
            int i = l[0];
        }
        [TestMethod]
        public void CreateList_AddItem_GetItemByWrongIndex()
        {
            CircularLinkedList<int> l = new CircularLinkedList<int>();
            l.Add(1);
            int i = l[3];
        }
    }
}
