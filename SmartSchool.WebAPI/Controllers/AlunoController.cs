using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Models;
using System.Linq;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class AlunoController : ControllerBase
    {
        private readonly List<Aluno> Alunos = new List<Aluno>() {
            new Aluno() {
                Id = 1,
                Nome = "Marcos",
                Sobrenome = "Alemida",
                Telefone = "45123456"
            },
                new Aluno() {
                Id = 2,
                Nome = "Marta",
                Sobrenome = "Kente",
                Telefone = "45654321"
            },
            new Aluno() {
                Id = 3,
                Nome = "Lucas",
                Sobrenome = "Fernando",
                Telefone = "45123654"
            }
        };
        public AlunoController() { }

        [HttpGet]
        public IActionResult Get() 
        {
            return Ok(Alunos);
         }

            // api/aluno/1
        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id) 
        {
            var Aluno = Alunos.FirstOrDefault(a => a.Id == id);
            if (Aluno == null) return BadRequest ("O Aluno não foi encontrado"); 

            return Ok(Aluno);
         }

            // api/aluno/nome
        [HttpGet("{byName}")]
        public IActionResult GetByName(string nome, string Sobrenome) 
        {
            var Aluno = Alunos.FirstOrDefault(a => 
                a.Nome == nome && a.Sobrenome == Sobrenome
                );
            if (Aluno == null) return BadRequest ("O Aluno não foi encontrado"); 

            return Ok(Aluno);
         }

        // api/aluno
        [HttpPost]
        public IActionResult Post(Aluno aluno) 
        {
           return Ok(aluno);
        }

        // api/aluno    
        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno) 
        {
           return Ok(aluno);    
        }

        // api/aluno
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno) 
        {
           return Ok(aluno);
        }
        // api/aluno
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) 
        {
           return Ok();
        }
    }
}