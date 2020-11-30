using System;
using System.Collections.Generic;
using System.Text;

namespace Part2_Project
{
    enum OrderStatus {InProgress , Pending, Delivered }
    class Order:IShoppingBag
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }

        public List<TransactionItem> transactionItems { get; set; }
        public void AddItem(TransactionItem  item) {
            transactionItems.Add(item);
        }
        public void DeleteItem(TransactionItem item) {
            transactionItems.Remove(item);
        }
        public void UpdateQuantity(TransactionItem item, int quantity) {
            item.Quantity = quantity;
        }

        public string PrintShoppingBag()
        {
            string s = $"ID = {ID} , Date: {Date}, Status: {Status}";
            foreach (TransactionItem i in transactionItems)
                s += $" , {i.ID} :  , {i.Item} , {i.Quantity}";
            return s;
        }
           
    }
        
}

