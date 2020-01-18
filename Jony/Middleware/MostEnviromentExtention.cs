using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Jony2.Middleware
{
    public static class MostEnviromentExtention
    {
        public static string GetRootPath(this IHostEnvironment environment,string foldername)
        {
            return Path.Combine(environment.ContentRootPath, foldername);
            
        }
    }
}
