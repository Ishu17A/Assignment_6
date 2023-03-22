using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_6
{
    public class Person
    {
        public int userid { get; set; }
        public int id { get; set; }
       
        public string name { get; set; }
        public string cccc { get; set; }  
       public Person(int userid , int id , string name , string ccc) { 
        this.userid = userid;
            this.id = id;   
        this.name = name;
            this.cccc = ccc;

        }
    }


    public class Program
    {
        static async Task Main(string[] args)
        {

                                                   /* Assignment_6 */



            /*  get request */

         var client = new HttpClient();
         var result = await client.GetStringAsync(@"https://jsonplaceholder.typicode.com/posts");
         Console.WriteLine(result);


            /* post request */

            var person = new Person( 10001 ,  12, "John Doe", "gardener");
            var json = JsonConvert.SerializeObject(person);

            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var url = @"https://jsonplaceholder.typicode.com/posts";
            var client1 = new HttpClient();
            var response = await client1.PostAsync(url, data);
            var result1 = await response.Content.ReadAsStringAsync();
            Console.WriteLine(result1);


            /* Put request */

            var person3 = new Person(10001, 12, "John Doe", "gardener");
            var json3 = JsonConvert.SerializeObject(person3);
            var data3 = new StringContent(json3, Encoding.UTF8, "application/json");
            var url1 = @"https://jsonplaceholder.typicode.com/posts/1";
            var client2 = new HttpClient();



            var response2 = await client2.PutAsync(url1, data3);
            var result3 = await response.Content.ReadAsStringAsync();

            Console.WriteLine(result3);



   


























            Console.ReadLine();
        }
    }
}
