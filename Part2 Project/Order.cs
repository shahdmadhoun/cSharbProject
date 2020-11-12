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
        public void AddItem() { }
        public void DeleteItem() { }
        public void UpdateQuantity() { }

        public void PrintShoppingBag()
        {
            Console.WriteLine();
        }
        
    }
}
