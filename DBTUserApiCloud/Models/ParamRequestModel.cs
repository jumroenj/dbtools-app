using System.Security.Cryptography.X509Certificates;

namespace DBTUserApiCloud.Models
{
    public class ParamRequestModel
    {
        public string PARAM_ID { get; set; }
        public string PARAM_NAME { get; set; }

        public string PARAM_VALUE { get; set; }
    }
}