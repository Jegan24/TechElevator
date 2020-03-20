using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductReviewsAPI.Models;
using ProductReviewsAPI.Services;

namespace ProductReviewsAPI.Controllers
{
    [Route("api/reviews")]
    [ApiController]
    public class ProductReviewsController : ControllerBase
    {
        private IDataAccessLayer<ProductReview> dal;

        public ProductReviewsController(IDataAccessLayer<ProductReview> dal)
        {
            this.dal = dal;
        }

        [HttpGet]
        public List<ProductReview> GetAll()
        {
            return dal.GetAll();
        }

        [HttpGet("{id}", Name = "GetProductReview")]
        public ActionResult<ProductReview> GetProductReview(int id)
        {
            var review = dal.Get(id);
            if (review != null)
            {
                return review;
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult Create([FromBody] ProductReview productReview)
        {
            int initialCount = dal.GetAll().Count;
            dal.Add(productReview);
            int newCount = dal.GetAll().Count;
            //newCount = initialCount;
            if (newCount > initialCount)
            {
                return CreatedAtRoute("GetProductReview", new { id = productReview.Id }, productReview);
            }
            return UnprocessableEntity();
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, ProductReview productReview)
        {
            ActionResult result = NoContent();
            var existingReview = dal.Get(id);
            if(existingReview  == null)
            {
                result = NotFound();
            }
            productReview.Id = existingReview.Id;
            dal.Update(productReview);

            return result;
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            ActionResult theResult = NoContent();
            if(dal.Get(id) != null)
            {
                dal.Delete(id);
            }
            else
            {
                theResult = NotFound();
            }

            return theResult;

        }
    }
}