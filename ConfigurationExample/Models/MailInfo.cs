using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationExample.Models
{
    public class MailInfo
    {
        public string Port { get; set; }

        public string Host { get; set; }

        public EmailInfo EmailInfo { get; set; }
    }
}
