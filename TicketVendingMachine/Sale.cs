using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3.TicketVendingMachine
{
    public static class Sale
    {
        static float total;
        static Ticket ticket;

        public static void newSale(UIInfo info)
        {
            ticket = new Ticket(ProductSpecification.tableColumn(info), info);
            getTotal();
        }

        public static void makePayment(UIInfo info)
        {
            Payment.newPayment(info, total);
        }

        private static void getTotal()
        {
            total = ticket.price;
        }
    }
}
