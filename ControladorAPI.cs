using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MicroondasDigital
{
    public class ControladorAPI
    {
        private readonly string apiBaseUrl = "https://sua-api.com/";
        private string token;

        public async Task<bool> Autenticar(string usuario, string senha)
        {
            string senhaHash = GerarHashSHA1(senha);
            using HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + senhaHash);

            var response = await client.GetAsync(apiBaseUrl + "autenticacao");

            if (response.IsSuccessStatusCode)
            {
                token = await response.Content.ReadAsStringAsync();
                return true;
            }

            return false;
        }

        private string GerarHashSHA1(string input)
        {
            using SHA1 sha1 = SHA1.Create();
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashBytes = sha1.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            foreach (byte b in hashBytes) sb.Append(b.ToString("X2"));
            return sb.ToString();
        }
    }
}