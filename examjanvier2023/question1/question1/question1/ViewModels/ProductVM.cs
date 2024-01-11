using Microsoft.EntityFrameworkCore;
using question1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication1.ViewModels;

namespace question1.ViewModels
{
    internal class ProductVM
    {
        private NorthwindContext context = new NorthwindContext();

        private ProductModel _selectedProduct;
        private DelegateCommand _abortProduct;
        private ObservableCollection<ProductModel> _ProductsList;


        public ObservableCollection<ProductModel> ProductsList { get { return _ProductsList = _ProductsList ?? loadProductList(); } }

        private ObservableCollection<ProductModel> loadProductList()
        {
            ObservableCollection<ProductModel> localCollection = new ObservableCollection<ProductModel>();
            foreach (var item in context.Products)
            {
                if (item.Discontinued != true )
                {
                    localCollection.Add(new ProductModel(item));
                }
            }

            return localCollection;
        }


        public ProductModel SelectedProduct
        {
            get { return _selectedProduct; }
            set { _selectedProduct = value; }

        }

        public DelegateCommand AbortProduct
        {
            get { return _abortProduct = _abortProduct ?? new DelegateCommand(abortProduct); }
        }

        private void abortProduct()
        {
            var productToRemove = context.Products.FirstOrDefault(p => p.ProductId == SelectedProduct.ProductId);
            if (productToRemove != null)
            {
                productToRemove.Discontinued = true;
                _ProductsList.Remove(_selectedProduct);
                context.SaveChanges();
            }
        }


    }
}
