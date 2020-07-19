using Assignment2Torrent09196576.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2Torrent09196576
{
    public partial class ProductAdmin : System.Web.UI.Page
    {
        private ApplicationDbContext _context;

        protected List<Product> dbProducts;
        protected List<Product> query;
        protected List<Product> meats;
        protected List<Product> drinks;
        protected List<Product> fruits;
        protected List<Product> discounts;
        public TextBox TextBox1;
        protected List<Product> resultList;

        public ProductAdmin()
        {
            _context = new ApplicationDbContext();
        }
        public override void Dispose()
        {
            base.Dispose();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            var query = _context.Products.ToList();
            meats = new List<Product>();
            foreach (var item in query)
            {
                if (item.Category == "Meat")
                {
                    Product p = new Product();
                    p.Id = item.Id;
                    p.Name = item.Name;
                    p.Description = item.Description;
                    p.Price = item.Price;
                    meats.Add(p);
                }
            }
            drinks = new List<Product>();
            foreach (var item in query)
            {
                if (item.Category == "Drinks")
                {
                    Product p = new Product();
                    p.Id = item.Id;
                    p.Name = item.Name;
                    p.Description = item.Description;
                    p.Price = item.Price;
                    drinks.Add(p);
                }
            }
            fruits = new List<Product>();
            foreach (var item in query)
            {
                if (item.Category == "Fruit")
                {
                    Product p = new Product();
                    p.Id = item.Id;
                    p.Name = item.Name;
                    p.Description = item.Description;
                    p.Price = item.Price;
                    fruits.Add(p);
                }
            }
            discounts = new List<Product>();
            foreach (var item in query)
            {
                if (item.Discount != null)
                {
                    Product p = new Product();
                    p.Id = item.Id;
                    p.Name = item.Name;
                    p.Description = item.Description;
                    p.Price = item.Price;
                    p.Discount = item.Discount;
                    discounts.Add(p);
                }
            }
        }
    }
}