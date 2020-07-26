using Assignment2Torrent09196576.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
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
        protected List<Product> fridge;
        protected List<Product> bakery;
        protected List<Product> Frozen;
        protected List<Product> pantry;
        protected List<Product> beer;



      
        



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
            try
            {
                HttpCookie myCookie = Request.Cookies["Customer"];
                if (myCookie == null)
                {
                  
                    Response.Redirect("Login.aspx");
                }

                
                if (!string.IsNullOrEmpty(myCookie.Values["Customer_id"]))
                {
                    int userId = int.Parse(myCookie.Values["Customer_id"].ToString());
                    
                    var adminOrCustomer = _context.Customers.Single(m => m.Id == userId );

                   if (adminOrCustomer.Role == "Customer")
                    {
                        Response.Redirect("ProductIndex.aspx");
                    }


                }
            }
            catch (Exception)
            {

               // redirec error page
            }

            
 
                       
  
                
             var query = _context.Products.ToList();
            meats = new List<Product>();
            foreach (var item in query)
            {
                if (item.Category == "Meat & Seafood")
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
                if (item.Category == "Fruit & Veg")
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
            fridge = new List<Product>();
            foreach (var item in query)
            {
                if (item.Category == "Fridge & Deli")
                {
                    Product p = new Product();
                    p.Id = item.Id;
                    p.Name = item.Name;
                    p.Description = item.Description;
                    p.Price = item.Price;

                    fridge.Add(p);
                }
            }
            bakery = new List<Product>();
            foreach (var item in query)
            {
                if (item.Category == "Bakery")
                {
                    Product p = new Product();
                    p.Id = item.Id;
                    p.Name = item.Name;
                    p.Description = item.Description;
                    p.Price = item.Price;

                    bakery.Add(p);
                }
            }
            Frozen = new List<Product>();
            foreach (var item in query)
            {
                if (item.Category == "Frozen")
                {
                    Product p = new Product();
                    p.Id = item.Id;
                    p.Name = item.Name;
                    p.Description = item.Description;
                    p.Price = item.Price;

                    Frozen.Add(p);
                }
            }
            pantry = new List<Product>();
            foreach (var item in query)
            {
                if (item.Category == "Pantry")
                {
                    Product p = new Product();
                    p.Id = item.Id;
                    p.Name = item.Name;
                    p.Description = item.Description;
                    p.Price = item.Price;

                    pantry.Add(p);
                }
            }
            beer = new List<Product>();
            foreach (var item in query)
            {
                if (item.Category == "Beer & Wine")
                {
                    Product p = new Product();
                    p.Id = item.Id;
                    p.Name = item.Name;
                    p.Description = item.Description;
                    p.Price = item.Price;

                    beer.Add(p);
                }
            }             
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            var queryName = Request.Params["fname"];

            var catQuery = Request.Params["Pcategory"];

            //IQueryable<Product> resultName = null;
            if (queryName != "" )
            {
               var  resultName =
                      from Product in _context.Products
                      where SqlFunctions.PatIndex("%" + queryName + "%", Product.Name) > 0
                      select Product;

                resultList = resultName.ToList();
            }

            if (catQuery != "null")
            {
                var resultName =
                     from Product in _context.Products
                     where SqlFunctions.PatIndex("%" + catQuery + "%", Product.Category) > 0
                     select Product;

                resultList = resultName.ToList();
            }
          


           
        }
    }
}