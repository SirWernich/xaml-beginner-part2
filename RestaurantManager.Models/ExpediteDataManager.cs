using System.Collections.Generic;
using System.ComponentModel;

namespace RestaurantManager.Models
{
    public class ExpediteDataManager : DataManager
    {

        protected override void OnDataLoaded()
        {
            this.OrderItems = base.Repository.Orders;
        }

        private List<Order> _orderItems;
        public List<Order> OrderItems
        {
            get { return _orderItems; }
            set
            {
                if (this._orderItems != value)
                {
                    this._orderItems = value;
                    this.OnPropertyChanged();
                }
            }
        }
    }
}
