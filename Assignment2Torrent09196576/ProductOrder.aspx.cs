using Assignment2Torrent09196576.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2Torrent09196576
{
    public partial class ProductOrder : System.Web.UI.Page
    {
        protected List<Product> meats;
        private ApplicationDbContext _context;

        public ProductOrder()
        {
            _context = new ApplicationDbContext();
        }
        public override void Dispose()
        {
            base.Dispose();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            var query = _context.Products.OrderByDescending( m => m.Price).ToList();
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
        }
    }
}