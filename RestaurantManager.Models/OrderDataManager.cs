using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RestaurantManager.Models
{
    public class OrderDataManager : DataManager
    {

        protected override void OnDataLoaded()
        {
            this.MenuItems = base.Repository.StandardMenuItems;

            this.CurrentlySelectedMenuItems = new List<MenuItem>
            {
                this.MenuItems[3],
                this.MenuItems[5]
            };
        }

        private List<MenuItem> _menuItems;
        private List<MenuItem> _currentlySelectedMenuItems;

        public List<MenuItem> MenuItems
        {
            get { return _menuItems; }
            set {
                if (this._menuItems != value)
                {
                    this._menuItems = value;
                    this.OnPropertyChanged();
                }
            }
        }
        public List<MenuItem> CurrentlySelectedMenuItems {
            get { return _currentlySelectedMenuItems; }
            set
            {
                if (this._currentlySelectedMenuItems != value)
                {
                    this._currentlySelectedMenuItems = value;
                    this.OnPropertyChanged();
                }
            }
        }
    }
}
