using Assignment2Torrent09196576.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2Torrent09196576
{
    public partial class TrolleyShow : System.Web.UI.Page
    {
        private ApplicationDbContext _context;

        public TrolleyShow()
        {
            _context = new ApplicationDbContext();
        }
        public override void Dispose()
        {
            base.Dispose();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            var productId = int.Parse(Request.Params["id"]);
            var dbproduct = _context.Products.Single(m => m.Id == productId);


            //var product = new Product();
            //product.Id = dbproduct.Id;
            //product.Name = dbproduct.Name;
            //product.Description = dbproduct.Description;
            //product.Price = dbproduct.Price;
            //product.Discount = dbproduct.Discount;
            //// I will add two books to one library
            ////var book1 = new Book();
            ////var book2 = new Book();

            //var trolley = new Trolley();
            //_context.Trolleys.Add(trolley);

            //_context.SaveChanges();

            //// I create the library 
            ////var lib = new Library();

            //// I create two Library2Book which I need them 
            //// To map between the books and the library
            ////var b2lib1 = new Library2Book();
            ////var b2lib2 = new Library2Book();

            //var cart = new ProductTrolley();

   
            //cart.ProductId = dbproduct.Id;
            //cart.TrolleyId = trolley.Id;
           

          

            //_context.SaveChanges();











            //trolley.ProductTrolleys.Add(productTrolley);



            // Mapping the first book to the library.
            // Changed b2lib2.Library to b2lib1.Library
            //b2lib1.Book = book1;
            //b2lib1.Library = lib;

            //// I map the second book to the library.
            //b2lib2.Book = book2;
            //b2lib2.Library = lib;

            //// Linking the books (Library2Book table) to the library
            //lib.Library2Books.Add(b2lib1);
            //lib.Library2Books.Add(b2lib2);

            //// Adding the data to the DbContext.
            //myDb.Libraries.Add(lib);

            //myDb.Books.Add(book1);
            //myDb.Books.Add(book2);

            //// Save the changes and everything should be working!
            //myDb.SaveChanges();


           
            var troll = new Trolley { Name = "Future Person" };
            troll.ProductTrolleys = new List<ProductTrolley>
            {
              new ProductTrolley {
                Product = dbproduct    
              }
            };

            //Now add this book, with all its relationships, to the database
            _context.Trolleys.Add(troll);
            _context.SaveChanges();

        }
    }
}