using Microsoft.AspNetCore.Mvc;
using PS2022.BLL.Dto;
using PS2022.BLL.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PS2022.Presentation.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]

    public class PatientController : ControllerBase
    {
        private IPatientService _service;

        public PatientController(IPatientService service)
        {
            _service = service;
        }

        // Registration?
        // I add patients thru this mechanism?
        // Create user -> returns userId -> use userId to create patient
        // Create userservice, add some users to database
        [HttpPost]
        public ActionResult Create(PatientDTO patient)
        {
            PatientDTO createdPatient = _service.Create(patient);

            return new JsonResult(createdPatient);
        }

        [HttpGet]
        public ActionResult GetAll() 
        {
            List<PatientDTO> patients = _service.GetAll();

            return new JsonResult(patients);
        }
    }
}
