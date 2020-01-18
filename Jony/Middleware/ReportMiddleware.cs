using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Jony2.Middleware
{
    public class ReportMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly string ReportFormat = "txt";
        private readonly string _folder;
        public ReportMiddleware(RequestDelegate next,string folder)
        {
            _next = next;
            _folder = folder;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            
            string report = context.Request.Query["report"];
            if (!string.IsNullOrWhiteSpace(report))
            {
                string file = Path.Combine(_folder, $"{report}.{ReportFormat}");
                var responcefile = Directory.GetFiles(file, "*.txt", SearchOption.TopDirectoryOnly)
                                                            .Where(x => x == file).FirstOrDefault();
                if (String.IsNullOrEmpty(responcefile))
                {
                  await  context.Response.WriteAsync("file is not exits");
                }
                else
                {
                    //read and send data view
                    var bytes = File.ReadAllBytes(responcefile);
                    await context.Response.Body.WriteAsync(bytes, 0, bytes.Length);
                }
            }
            else
            {
                await _next(context);//HttpContext-e otur
            }
            
          
        }
    }
}
