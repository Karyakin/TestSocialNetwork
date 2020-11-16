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
    public class AnimalsController : BaseApiController
    {
        IEnimalRepository<Animal> _enimalRepository;

        public AnimalsController(DataContext dataContext, IEnimalRepository<Animal> enimalRepository) //IGenericRepository<Animal> genericRepository)
        {
            _enimalRepository = enimalRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Animal>> GetAnimals() => await _enimalRepository.Get();
        
        [HttpGet("{id}")]
        public async Task<Animal> GetAnimal(long id) => await _enimalRepository.FindById(id);
      
        public async Task<Animal> GetByBreed(string breed) => (Animal)await _enimalRepository.GetByBreed(breed);
    }
}
