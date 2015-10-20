﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTypes;

namespace CheckoutService
{
    public class CheckoutController
    {
        public delegate void CheckoutDelegate(Order order);

        public CheckoutDelegate CheckoutProcessing = null;

        private bool requestPayment()
        {
            // Payment processing goes here

            // Payment logic is not implemented in this example
            // - simply return true
            return true;
        }

        public void StartCheckoutProcessing(Order order)
        {
            // Perform the checkout processing
            if (this.requestPayment() && this.CheckoutProcessing != null)
            {
                this.CheckoutProcessing(order);
            }
        }
    }
}
