﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DocumentReader
    {
        public async Task<int> RetrieveDocsHomePage()
        {
            var client = new HttpClient();
            byte[] content = await client.GetByteArrayAsync("https://docs.microsoft.com/");

            Console.WriteLine($"{nameof(RetrieveDocsHomePage)}: Finished downloading.");
            return content.Length;
        }
    }
}
