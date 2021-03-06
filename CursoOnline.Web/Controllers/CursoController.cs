using System.Linq;
using CursoOnline.Dominio._Base.Services;
using CursoOnline.Dominio.Cursos;
using CursoOnline.Dominio.Cursos.DTO;
using CursoOnline.Web.Util;
using Microsoft.AspNetCore.Mvc;

namespace CursoOnline.Web.Controllers
{
    public class CursoController : Controller
    {
        private readonly ArmazenadorCurso _armazenadorCurso;
        private readonly IRepository<Curso> _cursoRepository;

        public CursoController(ArmazenadorCurso armazenadorCurso, IRepository<Curso> cursoRepository)
        {
            _armazenadorCurso = armazenadorCurso;
            _cursoRepository = cursoRepository;
        }

        public IActionResult Index()
        {
            var cursos = _cursoRepository.Consultar();

            if (cursos.Any())
            {
                var dtos = cursos.Select(x => new CursoDto {
                    Id = x.Id,
                    Nome = x.Nome,
                    CargaHoraria = x.CargaHoraria,
                    PublicoAlvo = x.PublicoAlvo.ToString(),
                    Valor = x.Valor
                });
                
                return View("Index", PaginatedList<CursoDto>.Create(dtos, Request));
            }

            return View("Index", PaginatedList<CursoDto>.Create(null, Request));
        }

        public IActionResult Novo()
        {
            return View("NovoOuEditar", new CursoDto());
        }

        [HttpPost]
        public IActionResult Salvar(CursoDto model)
        {
            _armazenadorCurso.Armazenar(model);

            return Ok();
        }

        public IActionResult Editar(int id)
        {
            var curso = _cursoRepository.ObterPorId(id);
            var dto = new CursoDto {
                Id = curso.Id,
                Nome = curso.Nome,
                Descricao = curso.Descricao,
                CargaHoraria = curso.CargaHoraria,
                Valor = curso.Valor
            };

            return View ("NovoOuEditar", dto);
        }
    }
}