using StrategyPattern.ResponseModel;
using StrategyPattern.StrategyInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Context
{
    public class StrategyContext
    {
        private ISearchStrategy _searchStrategy;
        public StrategyContext(ISearchStrategy searchStrategy)
        {
            _searchStrategy = searchStrategy;
        }
        public void SetStrategy(ISearchStrategy searchStrategy)
        {
            _searchStrategy = searchStrategy;
        }
        public T GetResponse<T>() where T : class
        {
            var res = _searchStrategy.BuildSearchResult<T>("Itworx education");
            return res;
        }
    }
}
