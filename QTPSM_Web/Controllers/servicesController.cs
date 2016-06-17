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
using QTPSM_Web.Models;

namespace QTPSM_Web.Controllers
{
    [RoutePrefix("api/services")]
    public class servicesController : ApiControllerBase
    {
        private PSMContext db = new PSMContext();

        private readonly IEntityBaseRepository<service> _efpRepository;
        public servicesController(IEntityBaseRepository<service> efpRepository
            , IEntityBaseRepository<QTPSM.Entities.Error> errorsRepository, IUnitOfWork unitOfWork)
            : base(errorsRepository, unitOfWork)
        {
            _efpRepository = efpRepository;
        }

        [AllowAnonymous]
        [Route("active")]
        public HttpResponseMessage GetActiveServices(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                var efps = _efpRepository.FindBy(p => p.active).ToList();

                var efpsVM = Mapper.Map<IEnumerable<service>, IEnumerable<servicesViewModel>>(efps);

                response = request.CreateResponse(HttpStatusCode.OK, efpsVM);

                return response;
            });
        }

        // GET: api/services
        public IQueryable<service> Getservices()
        {
            return db.services;
        }

        // GET: api/services/5
        [ResponseType(typeof(service))]
        public async Task<IHttpActionResult> Getservice(int id)
        {
            service service = await db.services.FindAsync(id);
            if (service == null)
            {
                return NotFound();
            }

            return Ok(service);
        }

        // PUT: api/services/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putservice(int id, service service)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != service.id)
            {
                return BadRequest();
            }

            db.Entry(service).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!serviceExists(id))
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

        // POST: api/services
        [ResponseType(typeof(service))]
        public async Task<IHttpActionResult> Postservice(service service)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.services.Add(service);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = service.id }, service);
        }

        // DELETE: api/services/5
        [ResponseType(typeof(service))]
        public async Task<IHttpActionResult> Deleteservice(int id)
        {
            service service = await db.services.FindAsync(id);
            if (service == null)
            {
                return NotFound();
            }

            db.services.Remove(service);
            await db.SaveChangesAsync();

            return Ok(service);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool serviceExists(int id)
        {
            return db.services.Count(e => e.id == id) > 0;
        }
    }
}