using API.Data;
using API.Entities;
using API.Interfaceses;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class AnimalControllser : BaseApiController
    {
        DataContext _dataContext;
        IGenericRepository<Animal> _genericRepository;

        public AnimalControllser(DataContext dataContext, IGenericRepository<Animal> genericRepository)
        {
            _dataContext = dataContext;
            _genericRepository = genericRepository;
        }

        [HttpGet]
        public IEnumerable<Animal> GetAnimals() => _genericRepository.Get();


        [HttpGet("{id}")]
        public Animal GetAnimal(long id) => _genericRepository.FindById(id);
    }
}
