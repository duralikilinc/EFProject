using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryFramework.Core.Utilities.Common
{
    public class WcfProxy<T>
    {
        public static T CreateChannel()
        {
            // MVC nin web config den  ulaş.
            string baseAdress = ConfigurationManager.AppSettings["ServiceAddress"];
            string address = string.Format(baseAdress, typeof(T).Name.Substring(1));

            var binding = new BasicHttpBinding();
            var channel=new ChannelFactory<T>(binding,address);

            return channel.CreateChannel();
        }
    }
}
