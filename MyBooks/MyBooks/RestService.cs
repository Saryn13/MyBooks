using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Net.Http;


namespace MyBooks
{
    public class RestService : IRestService
    {
        HttpClient client;


        public RestService()
        {
            
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
        }

    }
}
