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
        protected List<Product> drinks;
        protected List<Product> fruits;
        protected List<Product> discounts;
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
            
        }
    }
}