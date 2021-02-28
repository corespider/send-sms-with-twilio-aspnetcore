using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Twilio.Rest.Api.V2010.Account;

namespace Twilio.SMS.DotNetCore.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            SendSMS("+19152282762", "+9199********", "Hey CoreSpider! this is a test message from Twilio test in ASP.NET Core");
        }
        public void SendSMS(string from, string to, string message)
        {
            var accountSid = "ACe48e040bd2237b16627c54cc32392902";
            var authToken = "75f9ab9f5729dfc6bf3341*****";
            TwilioClient.Init(accountSid, authToken);
            try
            {
                MessageResource response = MessageResource.Create(
                    body: message,
                    from: from,
                    to: to
                );
            }
            catch (Exception ex)
            {
            }
        }
    }
}
