using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using QTPSM.Entities;
using QTPSM_Web.Infrastructure.Core;
using QTPSM.Data.Repositories;
using QTPSM.Data.Infrastructure;
using AutoMapper;

namespace QTPSM_Web.Controllers
{
    [RoutePrefix("api/exceedings")]
    public class scope_exceedingController : ApiControllerBase
    {
        private PSMContext db = new PSMContext();

        private readonly IEntityBaseRepository<scope_exceeding> _efpRepository;
        public scope_exceedingController(IEntityBaseRepository<scope_exceeding> efpRepository
            , IEntityBaseRepository<QTPSM.Entities.Error> errorsRepository, IUnitOfWork unitOfWork)
            : base(errorsRepository, unitOfWork)
        {
            _efpRepository = efpRepository;
        }

        // GET: api/scope_exceeding
        public IQueryable<scope_exceeding> Getscope_exceeding()
        {
            return db.scope_exceeding;
        }

        // GET: api/scope_exceeding/5
        [ResponseType(typeof(scope_exceeding))]
        public async Task<IHttpActionResult> Getscope_exceeding(int id)
        {
            scope_exceeding scope_exceeding = await db.scope_exceeding.FindAsync(id);
            if (scope_exceeding == null)
            {
                return NotFound();
            }

            return Ok(scope_exceeding);
        }

        // PUT: api/scope_exceeding/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putscope_exceeding(int id, scope_exceeding scope_exceeding)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != scope_exceeding.id)
            {
                return BadRequest();
            }

            db.Entry(scope_exceeding).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!scope_exceedingExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/scope_exceeding
        [ResponseType(typeof(scope_exceeding))]
        public async Task<IHttpActionResult> Postscope_exceeding(scope_exceeding scope_exceeding)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.scope_exceeding.Add(scope_exceeding);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = scope_exceeding.id }, scope_exceeding);
        }

        // DELETE: api/scope_exceeding/5
        [ResponseType(typeof(scope_exceeding))]
        public async Task<IHttpActionResult> Deletescope_exceeding(int id)
        {
            scope_exceeding scope_exceeding = await db.scope_exceeding.FindAsync(id);
            if (scope_exceeding == null)
            {
                return NotFound();
            }

            db.scope_exceeding.Remove(scope_exceeding);
            await db.SaveChangesAsync();

            return Ok(scope_exceeding);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool scope_exceedingExists(int id)
        {
            return db.scope_exceeding.Count(e => e.id == id) > 0;
        }
    }
}