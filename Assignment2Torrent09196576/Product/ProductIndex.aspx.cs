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
        protected List<Product> fridge;
        protected List<Product> bakery;
        protected List<Product> Frozen;
        protected List<Product> pantry;
        protected List<Product> beer;
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

            try
            {
                ////Assuming user comes back after several hours. several < 12.
                ////Read the cookie from Request.
                HttpCookie myCookie = Request.Cookies["Customer"];
                if (myCookie == null)
                {
                    //No cookie found or cookie expired.
                    //Can read product
                   
                }

                ////ok - cookie is found.
                ////Gracefully check if the cookie has the key-value as expected.
                if (!string.IsNullOrEmpty(myCookie.Values["Customer_id"]))
                {
                    int userId = int.Parse(myCookie.Values["Customer_id"].ToString());
                    //Yes userId is found. Mission accomplished

                    var adminOrCustomer = _context.Customers.SingleOrDefault(m => m.Id == userId );

                    if (adminOrCustomer.Role == "Admin")
                    {
                        Response.Redirect("/Admin/Product/ProductAdminIndex.aspx");
                    }


                }
            }
            catch (Exception)
            {

               
            }
            



            try
            {
                string strStatus = Request.QueryString["status"].ToString();
                if (strStatus.ToUpper() == "ADD TO CART")
                    Response.Write("You product is add to your cart successfully"); // remenber to create flash message html with absolute property
            }
            catch (Exception)
            {

                
            }
           
            
             query = _context.Products.ToList();
            SelectProduct(query);





        }

        public void SelectProduct(List<Product> query)
        {
            
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


           var  request = Request.Params["fname"];

          

            var result =
                        from Product in _context.Products
                        where SqlFunctions.PatIndex("%"+request+"%", Product.Name) > 0
                        select Product;


            resultList = result.ToList();

          

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            query = _context.Products.OrderByDescending(m => m.Price).ToList();

            SelectProduct(query);




        }

      
    }
}