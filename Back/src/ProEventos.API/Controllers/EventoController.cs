using System;
using System.Linq;
using ProEventos.API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ProEventos.API.Data;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly DataContext _context; 
        public EventoController(DataContext context)
        { 
            _context = context;           
        }

        [HttpGet("registro")]
        public Evento Get()
        {     
            return _context.Eventos.FirstOrDefault();
        }

        [HttpGet("lista")]
        public IEnumerable<Evento> GetListaEvento()
        {
            return _context.Eventos;
        } 

        [HttpGet("lista/{id}")]
        public IEnumerable<Evento> GetListaEvento(int id)
        {
            return _context.Eventos.Where(x => x.EventoId == id);
        } 


        [HttpPost]
        public String Post()
        {     
            return "Exemplo de Post";     
        }

        [HttpPut("{id}")]
        public String Put(int id)
        {     
            return $"Exemplo de Put com id: {id}";     
        }

        [HttpDelete("{id}")]
        public String Delete(int id)
        {     
            return $"Exemplo de Delete com id: {id}";     
        }
    }
}

/*
public IEnumerable<Evento> _evento = new Evento[]{
                new Evento(){
                    EventoId = 1,
                    Tema = "Angular 11 e .Net 5",
                    Local = "RJ",
                    QtdePessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    ImagemURL = "foto.png"
                },
                new Evento(){
                    EventoId = 2,
                    Tema = "Angular kkkkkkkk",
                    Local = "SP",
                    QtdePessoas = 1000,
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                    ImagemURL = "foto.png"
                }
            };
*/