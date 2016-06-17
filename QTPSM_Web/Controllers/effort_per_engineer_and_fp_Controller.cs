using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using QTPSM_Web.Models;
using QTPSM_Web.Infrastructure.Core;
using AutoMapper;
using QTPSM.Data.Repositories;
using QTPSM.Entities;
using QTPSM.Data.Infrastructure;

namespace QTPSM_Web.Controllers
{
    [RoutePrefix("api/effort_per_engineer_and_fp")]
    public class effort_per_engineer_and_fpController : ApiControllerBase
    {
        private readonly IEntityBaseRepository<effort_per_engineer_and_fp> _efpRepository;
        private PSMContext db = new PSMContext();

        public effort_per_engineer_and_fpController(IEntityBaseRepository<effort_per_engineer_and_fp> efpRepository
            , IEntityBaseRepository<QTPSM.Entities.Error> errorsRepository, IUnitOfWork unitOfWork)
            : base(errorsRepository, unitOfWork)
        {
            _efpRepository = efpRepository;
        }

        [AllowAnonymous]
        [Route("all")]
        public HttpResponseMessage Geteffort_per_engineer_and_fp(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                var efps = _efpRepository.GetAll().OrderByDescending(m => m.id).ToList();

                IEnumerable<effort_per_engineer_and_fpViewModel> efpsVM = Mapper.Map<IEnumerable<effort_per_engineer_and_fp>, IEnumerable<effort_per_engineer_and_fpViewModel>>(efps);

                response = request.CreateResponse(HttpStatusCode.OK, efpsVM);

                return response;
            });
        }

        // GET: api/effort_per_engineer_and_fp/5
        [ResponseType(typeof(effort_per_engineer_and_fp))]
        public async Task<IHttpActionResult> Geteffort_per_engineer_and_fp(int id)
        {
            effort_per_engineer_and_fp effort_per_engineer_and_fp = await db.effort_per_engineer_and_fp.Where(p => p.id == id).FirstOrDefaultAsync();
            if (effort_per_engineer_and_fp == null)
            {
                return NotFound();
            }

            return Ok(effort_per_engineer_and_fp);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool effort_per_engineer_and_fpExists(int id)
        {
            return db.effort_per_engineer_and_fp.Count(e => e.id == id) > 0;
        }
    }
}