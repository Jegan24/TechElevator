using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingListAPI.Models;
using ShoppingListAPI.Services;

namespace ShoppingListAPI.Controllers
{
    [Route("api/groceries")]
    [ApiController]
    public class GroceriesController : ControllerBase
    {
        private IDataAccessLayer<Item> dal;
        public GroceriesController(IDataAccessLayer<Item> dataAccess)
        {
            dal = dataAccess;
        }

        [HttpGet]
        public List<Item> GetAll()
        {
            return dal.GetAll();
        }

        [HttpGet("{id}", Name = "GetItem")]
        public ActionResult<Item> GetItem(int id)
        {
            var item = dal.Get(id);
            if(item != null)
            {
                return item;
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult Insert([FromBody] Item item)
        {
            dal.Add(item);
            return CreatedAtRoute("GetItem", new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, Item item)
        {
            ActionResult result = NoContent();
            if(dal.Get(id) != null)
            {
                dal.Update(item); 
            }
            else
            {
                result = NotFound();
            }

            return result;
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            ActionResult result = NoContent();
            if (dal.Get(id) != null)
            {
                dal.Delete(id);
            }
            else
            {
                result = NotFound();
            }

            return result;
        }
    }
}