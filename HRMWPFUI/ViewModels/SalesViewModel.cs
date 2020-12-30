using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace HRMWPFUI.ViewModels
{
    public class SalesViewModel : Screen
    {
        private BindingList<string> _products;
        private BindingList<string> _cart;
        private int _itemQuantity;

        public BindingList<string> Products
        {
            get => _products;
            set
            {
                _products = value;
                NotifyOfPropertyChange(() => Products);
            }
        }

        public BindingList<string> Cart
        {
            get => _cart;
            set
            {
                _cart = value;
                NotifyOfPropertyChange(() => Cart);
            }
        }

        public int ItemQuantity
        {
            get => _itemQuantity;
            set
            {
                _itemQuantity = value;
                NotifyOfPropertyChange(() => ItemQuantity);
            }
        }

        public string SubTotal =>
            // Replace with calculation
            "$0.00";

        public string Tax =>
            // Replace with calculation
            "$0.00";

        public string SubToTotaltal =>
            // Replace with calculation
            "$0.00";

        public bool CanAddToCart
        {
            get
            {
                // Make sure something is selected
                // Make sure there is an item quantity

                return false;
            }
        }

        public void AddToCart()
        {

        }

        public bool CanRemoveFromCart
        {
            get
            {
                // Make sure something is selected

                return false;
            }
        }

        public void RemoveFromCart()
        {

        }

        public bool CanCheckOut
        {
            get
            {
                // Make sure something is something in the cart

                return false;
            }
        }

        public void CheckOut()
        {

        }
    }
}
