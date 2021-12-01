
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class PatientController : ApiController
    {
        // GET api/Patient
        [Route("Patient/{Id}")]
        [HttpGet]
        public List<Models.Models.ModelSelectPatientRDV> GetPatient(int Id)
        {
            try
            {
                BLPatient.blPatient blPatient = new BLPatient.blPatient();
                string Json1 = blPatient.SelectPatientRDV(Id);
                List<Models.Models.ModelSelectPatientRDV> list1 = JsonConvert.DeserializeObject<List<Models.Models.ModelSelectPatientRDV>>(Json1);
                return list1;
            }
            catch (Exception)
            {

                throw;
            }
        }
        [Route("Patient/date/{Id}/{date}")]
        [HttpGet]
        public List<Models.Models.ModelSelectPatientRDV> GetPatientdate(int Id,DateTime date)
        {
            try
            {
                BLPatient.blPatient blPatient = new BLPatient.blPatient();
                string Json1 = blPatient.SelectRDVPatientAndDate(Id,date);
                List<Models.Models.ModelSelectPatientRDV> list1 = JsonConvert.DeserializeObject<List<Models.Models.ModelSelectPatientRDV>>(Json1);
                return list1;
            }
            catch (Exception)
            {

                throw;
            }
        }
        [Route("Patient/AddRDV")]
        [HttpPost]
        public void AddRDV([FromBody] JArray postData)
        {
            BLPatient.blPatient blPatient = new BLPatient.blPatient();
            blPatient.AddPRDVMode1(postData.ToString());

        }
        [Route("Patient/UpdateRDV")]
        [HttpPost]
        public void UpdateRDV([FromBody] JArray postData)
        {
            BLPatient.blPatient blPatient = new BLPatient.blPatient();
            blPatient.UpdateRDV(postData.ToString());

        }
        [Route("Patient/UpdateRDV1")]
        [HttpPost]
        public void UpdateRDV1([FromBody] JArray postData)
        {
            BLPatient.blPatient blPatient = new BLPatient.blPatient();
            blPatient.UpdateRDV1(postData.ToString());

        }
        [Route("Patient/DeleteRDV")]
        [HttpPost]
        public void DeleteRDV([FromBody] JArray deleteData)
        {
            BLPatient.blPatient blPatient = new BLPatient.blPatient();
            blPatient.DeleteRDV(deleteData.ToString());

        }

    }
}
