using CadastroUsuarios.Data;
using CadastroUsuarios.Models;
using Microsoft.AspNetCore.Mvc;

namespace CadastroUsuarios.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsuarioController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Usuarios.ToList());
        }

        [HttpPost]
        public IActionResult Post(Usuario usuario)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _context.Usuarios.Add(usuario);
            _context.SaveChanges();

            return Ok(usuario);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Usuario usuario)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var usuarioExistente = _context.Usuarios.Find(id);

            if (usuarioExistente == null)
                return NotFound();

            usuarioExistente.Nome = usuario.Nome;
            usuarioExistente.Email = usuario.Email;

            _context.SaveChanges();

            return Ok(usuarioExistente);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var usuario = _context.Usuarios.Find(id);

            if (usuario == null)
                return NotFound();

            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
