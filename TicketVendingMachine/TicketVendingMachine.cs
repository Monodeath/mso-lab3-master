using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3.TicketVendingMachine
{
    public static class TicketVendingMachine
    {
        public static void newSale(UIInfo info)
        {
            makeSale(info);
            makePayment(info);
        }

        private static void makeSale(UIInfo info)
        {
            Sale.newSale(info);
        }

        private static void makePayment(UIInfo info)
        {
            Sale.makePayment(info);
        }
    }
}
