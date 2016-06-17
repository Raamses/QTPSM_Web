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
using QTPSM.Data.Infrastructure;
using QTPSM.Data.Repositories;
using QTPSM.Entities;
using QTPSM_Web.Infrastructure.Core;
using QTPSM_Web.Models;
using AutoMapper;

namespace QTPSM_Web.Controllers
{
    [RoutePrefix("api/finance_period")]
    public class finance_periodController : ApiControllerBase
    {
        private PSMContext db = new PSMContext();

        private readonly IEntityBaseRepository<finance_period> _efpRepository;
        public finance_periodController(IEntityBaseRepository<finance_period> efpRepository
            , IEntityBaseRepository<QTPSM.Entities.Error> errorsRepository, IUnitOfWork unitOfWork)
            : base(errorsRepository, unitOfWork)
        {
            _efpRepository = efpRepository;
        }


        [AllowAnonymous]
        [Route("current")]
        public HttpResponseMessage GetCurrentFinancePeriod(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                var efps = _efpRepository.FindBy(p => p.is_current_period == true).FirstOrDefault();

                var efpsVM = Mapper.Map<finance_period, finance_periodViewModel>(efps);

                response = request.CreateResponse(HttpStatusCode.OK, efpsVM);

                return response;
            });
        }

        // GET: api/finance_period
        public IQueryable<finance_period> Getfinance_period()
        {
            return db.finance_period;
        }

        // GET: api/finance_period/5
        [ResponseType(typeof(finance_period))]
        public async Task<IHttpActionResult> Getfinance_period(int id)
        {
            finance_period finance_period = await db.finance_period.FindAsync(id);
            if (finance_period == null)
            {
                return NotFound();
            }

            return Ok(finance_period);
        }

        // PUT: api/finance_period/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putfinance_period(int id, finance_period finance_period)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != finance_period.id)
            {
                return BadRequest();
            }

            db.Entry(finance_period).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!finance_periodExists(id))
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

        // POST: api/finance_period
        [ResponseType(typeof(finance_period))]
        public async Task<IHttpActionResult> Postfinance_period(finance_period finance_period)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.finance_period.Add(finance_period);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = finance_period.id }, finance_period);
        }

        // DELETE: api/finance_period/5
        [ResponseType(typeof(finance_period))]
        public async Task<IHttpActionResult> Deletefinance_period(int id)
        {
            finance_period finance_period = await db.finance_period.FindAsync(id);
            if (finance_period == null)
            {
                return NotFound();
            }

            db.finance_period.Remove(finance_period);
            await db.SaveChangesAsync();

            return Ok(finance_period);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool finance_periodExists(int id)
        {
            return db.finance_period.Count(e => e.id == id) > 0;
        }
    }
}