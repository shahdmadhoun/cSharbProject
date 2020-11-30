using System;
using System.Collections.Generic;
using System.Text;

namespace Part2_Project
{
    class TransactionItem
    {
        public int ID { get; set; }
        public int Quantity { get; set; }
        public Product Item { get; set; }
    }
}
