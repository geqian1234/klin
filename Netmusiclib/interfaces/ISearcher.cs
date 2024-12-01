using Netmusiclib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netmusiclib.interfaces
{
    public interface ISearcher
    {
        Task<ServiceResponse<FilteredSearchResultModel>> Search(string query,int page=1);
    }
}
