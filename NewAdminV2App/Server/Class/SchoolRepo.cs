using NewAdminV2App.Client.DapperClass;
using NewAdminV2App.Shared;
using NewAdminV2App.Shared.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace NewAdminV2App.Server.Class
{
    public class SchoolRepo : IHttpService
    {
        // private readonly AppContext _context;
        private readonly DapperManager _dapper;
        public SchoolRepo(DapperManager dapper)
        {
            _dapper = dapper;
        }
        public async Task<int> Count(string search)
        {
            var totSchool = await Task.FromResult(_dapper.Get<int>($"select COUNT(*) from [Schools] WHERE SchoolName like '%{search}%'", null,
                    commandType: CommandType.Text));
            return totSchool;
        }
        public async Task<IEnumerable<School>> GetSchoolENV1(int skip, int take, string orderBy, string direction = "DESC", string search = "")
        {
            var schools = await Task.FromResult(_dapper.GetAll<School>($"SELECT * FROM [Schools] WHERE SchoolName like '%{search}%' ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY;", null, commandType: CommandType.Text));
            return schools;
        }
        public async Task<IEnumerable<School>> GetSchoolENV2(int skip, int take, string orderBy, string direction = "DESC", string search = "")
        {
            var schools = await Task.FromResult(_dapper.GetAllENV2<School>($"SELECT * FROM [Schools] WHERE SchoolName like '%{search}%' ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY;", null, commandType: CommandType.Text));
            return schools;
        }
    }
}


