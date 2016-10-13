using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3.TicketVendingMachine
{
    public static class ProductSpecification
    {
        private static int tableColumn;

        public static int TableColumn(UIInfo info)
        {
            // Compute the column in the table based on choices
            // First based on class
            tableColumn = Class(info.Class);
            // Then, on the discount
            Discount(info.Discount);
            return tableColumn;
        }

        private static int Class(UIClass FirstOrSecond)
        {
            switch (FirstOrSecond)
            {
                case UIClass.FirstClass:
                    return 3;
                default:
                    return 0;
            }
        }

        private static void Discount(UIDiscount discount)
        {
            switch (discount)
            {
                case UIDiscount.TwentyDiscount:
                    tableColumn += 1;
                    break;
                case UIDiscount.FortyDiscount:
                    tableColumn += 2;
                    break;
            }
        }
    }
}
