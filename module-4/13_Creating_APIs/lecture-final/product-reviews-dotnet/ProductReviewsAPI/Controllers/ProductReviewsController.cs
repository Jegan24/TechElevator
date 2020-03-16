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
        //GET - all, one review
        //PUT - update a review
        //POST - create a review
        //DELETE - to delete a review

        private IDataAccessLayer<ProductReview> dal;

        public ProductReviewsController(IDataAccessLayer<ProductReview> dal)
        {
            this.dal = dal;
        }

        /// <summary>
        /// Retrieves a summary of all the reviews
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<ProductReview> GetAll()
        {
            return dal.GetAll();
        }

        /// <summary>
        /// Gets a single product review
        /// </summary>
        /// <param name="id">the id of the produt review to retrevie</param>
        /// <returns></returns>
        [HttpGet("{id}",Name ="GetProductReview")]
        public ActionResult<ProductReview> GetProductReview (int id)
        {
            var review = dal.Get(id);
            if (review != null) //if we found it
            {
                return review; //return the review
            }

            //we get this from our parent
            return NotFound();
        }

        /// <summary>
        /// Creates a product review
        /// </summary>
        /// <param name="productReview">the review to create</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Create([FromBody] ProductReview productReview)
        {
            dal.Add(productReview);

            //using parent's created at route and passing in: 1. The name of the action the client uses to get the resource
            //2. the input parameter needed to get the resource 3. the new object that was created
            //throw new Exception();
            return CreatedAtRoute("GetProductReview", new { id = productReview.Id }, productReview);
        }

        /// <summary>
        /// update a review
        /// </summary>
        /// <param name="id">the review to update</param>
        /// <param name="updatedReview">the updates</param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public ActionResult Update(int id, ProductReview updatedReview)
        {
            //get the existing review
            var exstingReview = dal.Get(id);

            //if it doesn't exist, return 404
            if (exstingReview==null)
            {
                return NotFound();
            }

            //change the fields we want to change
            exstingReview.Name = updatedReview.Name;
            exstingReview.Title = updatedReview.Title;
            exstingReview.Review = updatedReview.Review;


            //save it back to the dal
            dal.Update(exstingReview);

            //return a 204 on success
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var review = dal.Get(id);
            if (review == null)
            {
                return NotFound();
            }
            dal.Delete(id);
            return NoContent();
        }


    }
}