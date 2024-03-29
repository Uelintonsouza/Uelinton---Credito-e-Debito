﻿using UelintonBank.Domain.Entities;
using UelintonBank.Infra.Repositories;
using RestSharp;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace UelintonBank
{
    public class MainStarter
    {
        public static void Main(string[] args)
        {
            Initialize();
        }

        public static void Initialize()
        {
            Thread thread = new Thread(new ThreadStart(new MainStarter().InitializeThreads));
            thread.Start();
        }

        public void InitializeThreads()
        {
            Thread.Sleep(10);

            CreditDebit();
        }


        public async Task HttpPost(Lancamentos lancamentos)
        {
            var client = new RestClient("https://localhost:53457/api/TransactionCreditDebit");
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("content-length", "65");
            request.AddHeader("accept-encoding", "gzip, deflate");
            request.AddHeader("Host", "localhost:53947");
            request.AddHeader("Postman-Token", "02605c58-3487-48d3-b813-07b8eb5be051,5dfd28bc-e961-417a-b2de-1ccc035a85c1");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("undefined", Newtonsoft.Json.JsonConvert.SerializeObject(lancamentos), ParameterType.RequestBody);
            IRestResponse response = await client.ExecuteTaskAsync(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                lancamentos.Status = 1;
                _entryAppervice.Update(lancamentos);
            }
        }

        private TransactionRepository _entryAppervice = new TransactionRepository();
        private async void CreditDebit()
        {
            try
            {
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
            catch (Exception)
            {

                throw;
            }

        }
    }


}
