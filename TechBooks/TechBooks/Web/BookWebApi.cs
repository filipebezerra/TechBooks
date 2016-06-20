using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TechBooks.Web
{
    public static class BookWebApi
    {
        public async static Task<List<Models.BookSearch>> GetBooksByQuery(string query)
        {
            using (var httpClient = new HttpClient())
            {
                var json = await httpClient.GetStringAsync("http://it-ebooks-api.info/v1/search/" + query);
                return JsonConvert.DeserializeObject<BookSearchResponse>(json)?.Books;
            }
        }

        public async static Task<Models.BookDetails> GetBookById(long id)
        {
            using (var httpClient = new HttpClient())
            {
                var json = await httpClient.GetStringAsync("http://it-ebooks-api.info/v1/book/" + id);
                return JsonConvert.DeserializeObject<Models.BookDetails>(json);
            }
        }
    }
}
