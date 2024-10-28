using SingleResponsibilityPrinciple.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class RestfulTradeDataProvider : ITradeDataProvider
    {
        public RestfulTradeDataProvider(string url, ILogger logger)
        {
        }

        public IEnumerable<string> GetTradeData()
        {
            throw new NotImplementedException();
        }
    }
}
