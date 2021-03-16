using NewAdminV2App.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewAdminV2App.Shared.Repository
{
    public interface IHttpService
    {
        Task<int> Count(string search);
        Task<IEnumerable<School>> GetSchoolENV1(int skip, int take, string orderBy, string direction, string search);
        Task<IEnumerable<School>> GetSchoolENV2(int skip, int take, string orderBy, string direction, string search);
    }
}
