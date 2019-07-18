using UelintonBank.Domain.Entities;
using UelintonBank.Infra.Repositories;
using RestSharp;
using System.Threading;
using System.Threading.Tasks;

namespace UelintonBank
{
    public class MainStarter
    {
        public static void Main(string[] args)
        {
            MainStarter mainStarter = new MainStarter();

            Thread.Sleep(100);
            Thread thread = new Thread(new ThreadStart(mainStarter.CreditDebit));
            thread.Start();
        }
        public async Task HttpPost(Lancamentos lancamentos)
        {
            var client = new RestClient("https://localhost:44392/api/CreditDebit");
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("content-length", "65");
            request.AddHeader("accept-encoding", "gzip, deflate");
            request.AddHeader("Host", "localhost:44392");
            request.AddHeader("Postman-Token", "02605c58-3487-48d3-b813-07b8eb5be051,5dfd28bc-e961-417a-b2de-1ccc035a85c1");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("undefined", JsonConvert.SerializeObject(lancamentos), ParameterType.RequestBody);
            IRestResponse response = await client.ExecuteTaskAsync(request);
        }

        private TransactionRepository _entryAppervice;
        public async void CreditDebit()
        {
            _entryAppervice = new TransactionRepository();

            var lancamentos = _entryAppervice.GetLancamentos(0);

            if (lancamentos != null)
            {
                foreach (Lancamentos item in lancamentos)
                {
                    await HttpPost(item);
                }
            }
            else
            { return; }
        }
    }


}
