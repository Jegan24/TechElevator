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
    }
}