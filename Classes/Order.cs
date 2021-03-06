﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otlob.Classes
{
    public class Order
    {
        protected State state;
        protected List<OrderItem> items;
        protected DateTime initDate;
        protected DateTime deliveredDate;
        protected Resturant resturant;

        public Order()
        {
            items = new List<OrderItem>();
            initDate = new DateTime();
            deliveredDate = new DateTime();
            state = new DeliveringOrderToRestaurantState(this);
        }
        public virtual Resturant getResturant()
        {
            return resturant;
        }

        public virtual void setResturant(Resturant value)
        {
            resturant = value;
        }
        

        public DateTime getInitDate()
        {
            return initDate;
        }
        public void setInitDate(DateTime initDate)
        {
            this.initDate = initDate;
        }
        public DateTime getDeliveredDate()
        {
            return deliveredDate;
        }
        public void setDeliveredDate(DateTime deliveredDate)
        {
            this.deliveredDate = deliveredDate;
        }
        public State getState()
        {
            return state;
        }
        public void setState(State state)
        {
            this.state = state;
        }
        public virtual double getTotalPrice()
        {
            double ret = 0;
            for (int i = 0; i < items.Count; i++)
            {
                ret += (items[i].Getquantity() * items[i].Getprice());
            }
            return ret;
        }
        public virtual List<OrderItem> getItems()
        {
            return items;
        }
        public virtual void setItems(List<OrderItem> items)
        {
            this.items = items;
        }
    }
}
