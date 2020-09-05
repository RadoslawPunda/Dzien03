using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{
    enum OrderStatus
    {
        NewOrder =10,
        Complet = 20,
        Confirmed = 30,
        Shipped = 40,
        Returned = 50,
        Cancelled = 60
    }
    class Order
    {
        private string orderNumber;
        private string customerName;
        private string shipAddress;
        private DateTime orderDate;
        private OrderStatus status = OrderStatus.NewOrder;
        private byte discount = 0;
        private List<OrderItem> items = new List<OrderItem>();
    }
}
