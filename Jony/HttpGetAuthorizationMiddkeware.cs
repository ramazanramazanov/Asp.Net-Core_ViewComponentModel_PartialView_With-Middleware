using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Jony2
{
    public class HttpGetAuthorizationMiddkeware
    {
        private readonly RequestDelegate _next;
        public HttpGetAuthorizationMiddkeware(RequestDelegate request)
        {
            _next = request;
        }

        public async Task  Invoke(HttpContext context)
        {
         
            
            string url = context.Request.Query["report"];
            string aa = url + ".txt";

            
            var b = Directory.GetFiles("Files").Where(x => x.Contains(aa)).FirstOrDefault();
            
            if (File.Exists(b))
            {
                await context.Response.WriteAsync("url is  true");
            }
            else
            {
                await context.Response.WriteAsync("url is  false");
            }
            // string url = context.Request.Query["report"]; // query urlden oturulen parametr 

            //if (url == "facebook.com") 
            //{
            //   await _next(context);   //   /? url = facebook.com--bele axtaris ver
            //}
            //else
            //{
            //   await context.Response.WriteAsync("url is not true");
            //}
            //// using Microsoft.AspNetCore.Http;  startupda qos
        }
    }
}
