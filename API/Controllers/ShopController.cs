using API.Entities;
using API.Interfaceses;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class ShopController : BaseApiController
    {
        IShopReposytory<Shop> _shopReposytory;
        public ShopController(IShopReposytory<Shop> shopReposytory)
        {
            _shopReposytory = shopReposytory;
        }

        [HttpGet]
        public async Task<IEnumerable<Shop>> GetShop() => await _shopReposytory.Get();
        
        [HttpGet("{id}")]
        public async Task<Shop> GetById(long id) => await _shopReposytory.FindById(id);

        public async Task<IEnumerable<Shop>> GrtByName(string name) => await _shopReposytory.GetByName(name);

    }
}
