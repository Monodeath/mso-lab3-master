using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3.TicketVendingMachine
{
    public static class ProductSpecification
    {
        public static int tableColumn(UIInfo info)
        {
            // Compute the column in the table based on choices
            int tableColumn;
            // First based on class
            tableColumn = Class(info.Class);
            // Then, on the discount
            tableColumn = Discount(info.Discount, tableColumn);
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

        private static int Discount(UIDiscount discount, int tableColumn)
        {
            switch (discount)
            {
                case UIDiscount.TwentyDiscount:
                    return tableColumn + 1;
                case UIDiscount.FortyDiscount:
                    return tableColumn + 2;
                default:
                    return tableColumn;
            }
        }
    }
}
