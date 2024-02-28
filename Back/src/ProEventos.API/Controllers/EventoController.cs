using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public IEnumerable<Evento> _evento = new Evento[]
        {
                new Evento()
                {

                 EventoId = 1,
                 Local = "Belo Horizonte", 
                 DataEvento = DateTime.Now.AddDays(2).ToString(),
                 Tema = "Angular e .Net 5",
                 QtdPessoas = 20,
                 Lote = "1° Lote",
                 ImagemURL = "Foto.jpg",

                },
            
                new Evento()
                {
                 EventoId = 2,
                 Local = "Salvador", 
                 DataEvento = DateTime.Now.AddDays(3).ToString(),
                 Tema = "Angular e .Net 5",
                 QtdPessoas = 30,
                 Lote = "1° Lote",
                 ImagemURL = "FotoEvento.jpg",

                }
        };

        public EventoController()
        {
            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento; 
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id) ;
        }

        [HttpPost]
        public string Post()
        {
            return "exemplo de post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de put com id {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de delete com id {id}";
        }
    }
}
