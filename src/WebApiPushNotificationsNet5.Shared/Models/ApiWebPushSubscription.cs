using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiPushNotificationsNet5.Shared.Models
{
    public class ApiWebPushSubscription
    {
        [Key] public string Endpoint { get; set; }
        public string P256DH { get; set; }
        public string Auth{ get; set; }
        public int Id { get; set; }
        public string ExpirationTime { get; set; }
//        public IDictionary<string, string> Keys { get; set; }
    }
}
