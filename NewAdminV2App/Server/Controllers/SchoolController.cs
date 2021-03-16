using Microsoft.AspNetCore.Mvc;
using NewAdminV2App.Shared.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminV2App.Server.Controllers
{
    [Route("api/environments")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        private readonly IHttpService _repo;
        public int skip, take;
        public string orderBy, direction, search;

        public SchoolController(IHttpService repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public async Task<int> count()
        {
            return await _repo.Count(search);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var schools = await _repo.GetSchoolENV1(skip, take, orderBy, direction, search);
            return (IActionResult)schools;
        }
        [HttpGet]
        public async Task<IActionResult> Get1()
        {
            var schools = await _repo.GetSchoolENV2(skip, take, orderBy, direction, search);
            return (IActionResult)schools;
        }

    }
}
