using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SessionCart.Web.DAL;
using SessionCart.Web.Models;
using SessionCart.Web.Extensions;

namespace SessionCart.Web.Controllers
{
    public class StoreController : Controller
    {
        /* Steps
          1. StoreController Create Index Action
          2. Index View  Create an Index View for Store/Index
         (Test)
          3. DI - Store Controller
          4. DI - Startup
          5. Store Controller - update Index action to get a list of products and send it to the view via a model
          6. Store/Index view - display the products
         (Test)
          7. Store/Index view - add form tag with an add to cart button POST pass product id in the form
          8. Store Controller POST  action take the product id and add it to the cart
          9. Store Controler create a ViewCart action
          10 Create a ViewCart view let's be empty
          (Test)
          11 Make the ViewCart show a table for the items
          12 Pass the cart into ViewCart in storecontroller
          (Test)
          13 add a remove from cart button to the end of every row in the ViewCart
          14 Store Controller POST to handle removing the item
          (Test)
          15 add a total cost to the ViewCart

       */

        //Step 3
        private IProductDAO dao;
        public StoreController(IProductDAO dao)
        {
            this.dao = dao;
        }

       
        //Step 1
        public ActionResult Index()
        {
            //Step 5
            var allProducts = dao.GetProducts();
            return View(allProducts);
        }

        //Step 8
        [HttpPost]
        public IActionResult AddToCart(Product product,int quantity)
        {
            //get all of the product info for the product id, the form only sent the id
            product = dao.GetProduct(product.Id);       

            //add whatever product product id is for to the shopping cart
            ShoppingCart shoppingCart = GetActiveShoppingCart();
            shoppingCart.AddToCart(product, quantity);

            //everytime we change the cart, we need to save it in the session again
            SaveActiveShoppingCart(shoppingCart);

            return RedirectToAction("ViewCart");
        }

        //Step 9
        public IActionResult ViewCart()
        {
            ShoppingCart cart = GetActiveShoppingCart();
            return View(cart);
        }

        //Step 14
        public IActionResult RemoveFromCart(int id)
        {
            

            //Get the cart
            ShoppingCart cart = GetActiveShoppingCart();

            //get the item with id id
            Product removeMe = dao.GetProduct(id);
            TempData["msg"] = "Too bad! You're going to need that "+removeMe.Name;

            //remove the item
            cart.RemoveOne(removeMe);

            //Save the cart
            SaveActiveShoppingCart(cart);

            //redirect to action
            return RedirectToAction("ViewCart");
        }

        private ShoppingCart GetActiveShoppingCart()
        {
            //try and get the cart from the session
            ShoppingCart cart = HttpContext.Session.Get<ShoppingCart>("Shopping_Cart");
         
            if (cart==null) //the shopping cart does NOT exist
            {
                cart = new ShoppingCart();
                SaveActiveShoppingCart(cart);
            }

            return cart;
        }

        private void SaveActiveShoppingCart(ShoppingCart cart)
        {
            HttpContext.Session.Set("Shopping_Cart", cart);
        }

        
    }
}