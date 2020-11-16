using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using API.Interfaceses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    
    public class TrainsController : BaseApiController
    {
        ITrainsReposytory<Train> _trainsReposytory;
        public TrainsController(ITrainsReposytory<Train> trainsReposytory)
        {
            _trainsReposytory = trainsReposytory;
        }

        [HttpGet]
        public async Task<IEnumerable<Train>> GetTrains() => await _trainsReposytory.Get();

        [HttpGet("{id}")]
        public async Task<Train> GetTrain(long id) =>await _trainsReposytory.FindById(id);

        public async Task<IEnumerable<Train>> GetByBrand(string brand) => await _trainsReposytory.GetByBrand(brand);


    }
}
