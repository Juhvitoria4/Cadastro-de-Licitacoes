using LicitacoesAPI.Data;
using LicitacaoAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Storage.Internal.Json;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore.Internal;

namespace LicitacaoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class LicitacaoController : ControllerBase
    {
        private readonly LicitacaoContext _context;
        public LicitacaoController(LicitacaoContext context)
        {
            _context = context;

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Licitacao>>> GetLicitacoes()
        {
            return await _context.Licitacoes.ToListAsync();
        }

        // GET: api/licitacao {id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Licitacao>> GetLicitacao(Guid id)
        {
            var licitacao = await _context.Licitacoes.FindAsync(id);

            if (licitacao == null)
            {
                return NotFound();
            }
            return licitacao;
        }

        // Post: api/licitacao
        [HttpPost]
        public async Task<ActionResult<Licitacao>> CreateLicitcao(Licitacao licitacao)
        {
            if (await _context.Licitacoes.AnyAsync(l => l.NumeroLicitacao == licitacao.NumeroLicitacao))
            {
                return BadRequest("essa licitaçao ja existe");
            }
            licitacao.DataHoraCadastro = DateTime.UtcNow;
            _context.Licitacoes.Add(licitacao);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetLicitacao), new { id = licitacao.Id }, licitacao);
        }

        // PUT: api/licitacao/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLicitacao(Guid id, Licitacao licitacao)
        {
            if (id != licitacao.Id)
                return BadRequest();

            var existsNumero = await _context.Licitacoes
                .AnyAsync(l => l.NumeroLicitacao == licitacao.NumeroLicitacao && l.Id != id);

            if (existsNumero)
                return BadRequest("Número da licitação já existe.");

            _context.Entry(licitacao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LicitacaoExists(id))
                    return NotFound();
                else
                    throw;
            }

            return NoContent();
        }

        // DELETE: api/licitacao/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLicitacao(Guid id)
        {
            var licitacao = await _context.Licitacoes.FindAsync(id);
            if (licitacao == null)
                return NotFound();

            _context.Licitacoes.Remove(licitacao);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LicitacaoExists(Guid id)
        {
            return _context.Licitacoes.Any(e => e.Id == id);
        }
    }
}




    
    

        