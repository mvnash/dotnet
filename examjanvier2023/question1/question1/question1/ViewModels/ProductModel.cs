using question1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question1.ViewModels
{
    class ProductModel : INotifyPropertyChanged
    {
        private readonly Product _product;

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

            }
        }

        public ProductModel(Product product)
        {
            _product = product;
        }

        public int ProductId
        {
            get { return _product.ProductId; }
        }

        public string ProductName
        {
            get { return _product.ProductName; }
            set { _product.ProductName = value; OnPropertyChanged("ProductInfo"); }
        }

        public string ProductInfo
        {
            get { return ProductId + ProductName; }
        }

        public string CategoryName
        {
            get { return _product.Category?.CategoryName ?? ""; }
        }

        public string ContactName { get { return _product.Supplier?.ContactName ?? ""; } }

        
    }
}
