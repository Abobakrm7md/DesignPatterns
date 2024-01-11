using StrategyPattern.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.StrategyInterface
{
    public interface ISearchStrategy
    {
        T BuildSearchResult<T>(string query) where T : class;
    }
}
