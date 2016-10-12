using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3.TicketVendingMachine
{
    public class Ticket
    {
        public float price;

        public Ticket(int tableColumn, UIInfo info)
        {
            // Get number of tariefeenheden
            int tariefeenheden = getTarief(info.From, info.To);
            getPrice(tariefeenheden, tableColumn, info.Way);
        }

        private void getPrice(int tariefeenheden, int tableColumn, UIWay way)
        {
            // Get price
            price = PricingTable.getPrice(tariefeenheden, tableColumn);
            if (way == UIWay.Return)
            {
                price *= 2;
            }
        }

        private int getTarief(string from, string to)
        {
            return Tariefeenheden.getTariefeenheden(from, to);
        }
    }
}
