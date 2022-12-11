using JStoC.Content;
using JStoC.Models;
using Newtonsoft.Json;
using System.Linq.Expressions;


foreach (var item in await GetUser())
{
    Console.WriteLine(item.Adress);
}


static async Task<List<User>> GetUser()
{
    List<User> users = default;
    string SourceURL = "https://jsonplaceholder.typicode.com/users";
    try
    {

        using (HttpClient client = new HttpClient())
        {
            using (HttpResponseMessage response = await client.GetAsync(SourceURL))
            {
                using (HttpContent content = response.Content)
                {
                    string data = await content.ReadAsStringAsync();
                    if (data != null)
                    {
                       users = JsonConvert.DeserializeObject<List<User>>(data);

                    }
                    else
                    {
                        Console.WriteLine("No data on here!");
                    }
                }

            }


        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

   return users;
}


