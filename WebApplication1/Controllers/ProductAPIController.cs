using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductAPIController : ApiController
    {
        public IEnumerable<Product> Get()
        {
            return Product.GetData(5);
        }
    }
}
