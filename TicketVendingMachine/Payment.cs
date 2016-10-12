using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3.TicketVendingMachine
{
    public static class Payment
    {
        static float price;

        public static void newPayment(UIInfo info, float p)
        {
            price = p;

            // Pay
            switch (info.Payment)
            {
                case UIPayment.CreditCard:
                    creditCard();
                    break;
                case UIPayment.DebitCard:
                    debitCard();
                    break;
                case UIPayment.Cash:
                    cash();
                    break;
            }
        }

        private static void creditCard()
        {
            CreditCard c = new CreditCard();
            c.Connect();
            int ccid = c.BeginTransaction(price);
            c.EndTransaction(ccid);
        }

        private static void debitCard()
        {
            DebitCard d = new DebitCard();
            d.Connect();
            int dcid = d.BeginTransaction(price);
            d.EndTransaction(dcid);
        }

        private static void cash()
        {
            IKEAMyntAtare2000 coin = new IKEAMyntAtare2000();
            coin.starta();
            coin.betala((int)Math.Round(price * 100));
            coin.stoppa();
        }
    }
}
