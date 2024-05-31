using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemNamespace
{
    internal class DiscountItem : Item
    {
        private double item_discount, discounted_price, payment_amount, change;


        public DiscountItem(string name, double price, int quantity, double discount) : base(name, price, quantity)
        {
            this.item_name = name;
            this.item_price = price;
            this.item_quantity = quantity;
            this.item_discount = discount;
        }
        
        public override double getTotalPrice()
        {
            item_discount = (item_discount * 0.01);
            discounted_price = item_price - (item_price * item_discount);
            total_price = discounted_price * item_quantity;
            return total_price;
        }

        public override void setPayment(double amount)
        {
            payment_amount = amount;
        }

        public double getChange()
        {
            change = payment_amount - total_price;
            return change;
        }
    }
}
