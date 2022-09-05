using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventtos.API.Data;
using ProEventtos.API.Models;

namespace ProEventtos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventtoController : ControllerBase
    {
        private readonly DataContext _context;
        public EventtoController(DataContext  context)
        {
            _context = context;
        }
        [HttpGet]  
        public IEnumerable<Eventto> Get()
        {
         return _context.Eventtos;
        }

        [HttpGet("{id}")]  
        public Eventto GetById(int id)
        { 
         //return _context.Eventtos.Where(Eventto => Eventto.EventtoID == id );
         return _context.Eventtos.FirstOrDefault(Eventto => Eventto.EventtoID == id );
        }


        [HttpPost]
        public string Post()
        {
           return "exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
           return $"exemplo de Put = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
                return $"exemplo de Delete = {id}";
        }

      //   public IEnumerable<Eventto> _eventto = new Eventto[]
      //      { 
      //         new Eventto()
      //             {
      //                EventtoID = 1,
      //                Tema = "Angular 11 e .NET 5",
      //                Local = "Belo Horizonte",
      //                Lote = "Primeiro Lote",
      //                QtdePessoas = 250,
      //                DataEventto = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
      //             },
      //         new Eventto()
      //             {
      //                EventtoID = 2,
      //                Tema = "Angular e Suas novidades",
      //                Local = "São Paulo",
      //                Lote = "Segundo Lote",
      //                QtdePessoas = 300,
      //                DataEventto = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy")
      //             }

      //      };


    }
}

