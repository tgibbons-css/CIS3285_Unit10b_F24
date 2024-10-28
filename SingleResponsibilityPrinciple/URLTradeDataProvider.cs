using SingleResponsibilityPrinciple.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class URLTradeDataProvider : ITradeDataProvider
    {
        public URLTradeDataProvider(string url, ILogger logger)
        {
        }

        public IEnumerable<string> GetTradeData()
        {
            throw new NotImplementedException();
        }
    }
}
