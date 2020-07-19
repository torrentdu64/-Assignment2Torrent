using Assignment2Torrent09196576.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;    
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace Assignment2Torrent09196576
{
    public partial class ProductIndex : System.Web.UI.Page
    {

        protected List<Product> dbProducts;
        protected List<Product> query;
        protected List<Product> meats;
        protected List<Product> drinks;
        protected List<Product> fruits;
        protected List<Product> discounts;
        public TextBox TextBox1;
        protected List<Product> resultList;

        
        private ApplicationDbContext _context;

        public object LoginView1 { get; private set; }
        public object MainContent { get; private set; }

        public ProductIndex()
        {
            _context = new ApplicationDbContext();
        }
        public override void Dispose()
        {
            base.Dispose();
        }

        protected void Page_Load(object sender, EventArgs e)
        {


            //var query = _context.Products
            //     .GroupBy(p => p.Category)
            //     .Select(g => new { product = g.ToList() , count = g.Count()}).ToList();

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
               



            //dbProducts = _context.Products.ToList();

            


              


            //dbProduct = new List<String>();
            //foreach (var item in dbProducts)
            //{
            //    dbProduct.Add(item.Name);
            //}



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var query = Request.Params["fname"];

            //var test = LoginView1.Equals("TextBox1").ToString();
            //var tete = Equals(TextBox1).ToString();

         
               
           

            

           

            var result =
                        from Product in _context.Products
                        where SqlFunctions.PatIndex("%"+query+"%", Product.Name) > 0
                        select Product;


            resultList = result.ToList();

            //Response.Redirect("/ProductIndex.aspx");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var query = _context.Products.OrderByDescending(m => m.Price).ToList();
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

        //public  List<Product> Products()
        //{
        //    var dbProducts = _context.Products.ToList();

        //    return dbProducts;
        //}

    }
}