using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Transbank.Webpay.WebpayPlus;
using WebAPI.Models;
using Transbank.Webpay.WebpayPlus.Responses;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebpayPlusController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public WebpayPlusController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        public CreateResponse Post(TransactionRequest trans)
        {
            var random = new Random();
            var buyOrder = random.Next(999999999).ToString();
            var sessionId = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString().PadLeft(2, '0')
                        + DateTime.Now.Day.ToString().PadLeft(2, '0') + '-' + DateTime.Now.Hour.ToString().PadLeft(2, '0') + DateTime.Now.Minute.ToString().PadLeft(2, '0')
                        + DateTime.Now.Second.ToString().PadLeft(2, '0') + "-" + random.Next(999999999).ToString();
            //var amount = random.Next(1000, 999999);
            var returnUrl = "http://localhost:4200/ReturnPage";

            var response = Transaction.Create(buyOrder,sessionId,trans.Amount,returnUrl);

            return response;

            //return new JsonResult("Created Successfully");
        }
    }
}
