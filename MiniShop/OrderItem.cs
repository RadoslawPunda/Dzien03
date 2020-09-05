﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{
    class OrderItem
    {
        private Product product;
        private int qnty;

        public int Qnty { get { return qnty; } }
        public Product Product { get { return product; } }

        public OrderItem(Product p, int q)
        {
            product = p;
            qnty = q;
        }

    }
}
