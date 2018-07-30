using System.Net.Http;

namespace ServicoConsultaDados.ClienteHttp
{
    public class ClienteHttp
    {
        string tokenAcesso = "912c5f459b7ebebbb14be297d50c60a9";
        string cnpj = "15828398000126";

        public async void GetAllProdutos()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new System.Uri("http://localhost:50306/");
                using (var response = await client.GetAsync("api/values"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        //var dadodClientes = await response.Content.ReadAsStringAsync();
                        //RootObject obj = JsonConvert.DeserializeObject<RootObject>(dadodClientes);

                        //Console.WriteLine("Produto acessado e exibido.  Tecle algo para incluir um novo produto.");
                        //Console.ReadKey();
                    }
                    else
                    {

                    }
                }
            }
        }
    }
}
