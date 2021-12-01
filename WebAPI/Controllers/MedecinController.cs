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
    public class MedecinController : ApiController
    {
        // GET api/Medecin
        [Route("Medecin/Planning/{Id}")]
        [HttpGet]
        public List<Models.Models.ModelSelectPlanningMed> GetMedecin(int Id)
        {
            try
            {
                BLMedecin.blMedecin blMedecin = new BLMedecin.blMedecin();
                string Json1 = blMedecin.SelectPlanningMedecinById(Id);
                List<Models.Models.ModelSelectPlanningMed> list1 = JsonConvert.DeserializeObject<List<Models.Models.ModelSelectPlanningMed>>(Json1);
                return list1;
            }
            catch (Exception)
            {

                throw;
            }
        }
        [Route("Medecin/PlanningRDV/{Id}")]
        [HttpGet]
        public List<Models.Models.ModelSelectConsultationMedecinById> GetMedecinRDV(int Id)
        {
            try
            {
                BLMedecin.blMedecin blMedecin = new BLMedecin.blMedecin();
                string Json1 = blMedecin.SelectConsultationMedecin(Id);
                List<Models.Models.ModelSelectConsultationMedecinById> list1 = JsonConvert.DeserializeObject<List<Models.Models.ModelSelectConsultationMedecinById>>(Json1);
                return list1;
            }
            catch (Exception)
            {

                throw;
            }
        }
        [Route("Medecin/AddPlanning")]
        [HttpPost]
        public void AddPlanning([FromBody] JArray postData)
        {
            try
            {
                BLMedecin.blMedecin blMedecin = new BLMedecin.blMedecin();
                blMedecin.AddPlanningMedecin(postData.ToString());
            }
            catch (Exception)
            {

                throw;
            }

        }
        [Route("Medecin/ConsultationMatinPremier/{Id}")]
        [HttpGet]
        public List<Models.Models.ModelSelectConsultationMedecinById> GetConsultationMatinPremier(int Id)
        {
            try
            {
                BLMedecin.blMedecin blMedecin = new BLMedecin.blMedecin();
                string Json1 = blMedecin.SelectConsultationMatinPremier(Id);
                List<Models.Models.ModelSelectConsultationMedecinById> list1 =
                    JsonConvert.DeserializeObject<List<Models.Models.ModelSelectConsultationMedecinById>>(Json1);
                return list1;
            }
            catch (Exception)
            {

                throw;
            }
        }
        [Route("Medecin/ConsultationMatinDernier/{Id}")]
        [HttpGet]
        public List<Models.Models.ModelSelectConsultationMedecinById> GetConsultationMatinDernier(int Id)
        {
            try
            {
                BLMedecin.blMedecin blMedecin = new BLMedecin.blMedecin();
                string Json1 = blMedecin.SelectConsultationMatinDernier(Id);
                List<Models.Models.ModelSelectConsultationMedecinById> list1 =
                    JsonConvert.DeserializeObject<List<Models.Models.ModelSelectConsultationMedecinById>>(Json1);
                return list1;
            }
            catch (Exception)
            {

                throw;
            }
        }
        [Route("Medecin/ConsultationApresMidiPremier/{Id}")]
        [HttpGet]
        public List<Models.Models.ModelSelectConsultationMedecinById> GetConsultationApresMidiPremier(int Id)
        {
            try
            {
                BLMedecin.blMedecin blMedecin = new BLMedecin.blMedecin();
                string Json1 = blMedecin.SelectConsultationApresMidiPremier(Id);
                List<Models.Models.ModelSelectConsultationMedecinById> list1 =
                    JsonConvert.DeserializeObject<List<Models.Models.ModelSelectConsultationMedecinById>>(Json1);
                return list1;
            }
            catch (Exception)
            {

                throw;
            }
        }
        [Route("Medecin/ConsultationApresMidiDernier/{Id}")]
        [HttpGet]
        public List<Models.Models.ModelSelectConsultationMedecinById> GetConsultationApresMidiDernier(int Id)
        {
            try
            {
                BLMedecin.blMedecin blMedecin = new BLMedecin.blMedecin();
                string Json1 = blMedecin.SelectConsultationApresMidiDernier(Id);
                List<Models.Models.ModelSelectConsultationMedecinById> list1 =
                    JsonConvert.DeserializeObject<List<Models.Models.ModelSelectConsultationMedecinById>>(Json1);
                return list1;
            }
            catch (Exception)
            {

                throw;
            }
        }
        [Route("Medecin/UpdateAllPlanning")]
        [HttpPost]
        public void UpdateAllPlanning([FromBody] JArray postData)
        {
            try
            {
                BLMedecin.blMedecin blMedecin = new BLMedecin.blMedecin();
                blMedecin.UpdatePlanningMedecin(postData.ToString());
            }
            catch (Exception)
            {

                throw;
            }

        }
        [Route("Medecin/UpdatePlanningMatin")]
        [HttpPost]
        public void UpdatePlanningMatin([FromBody] JArray postData)
        {
            try
            {
                BLMedecin.blMedecin blMedecin = new BLMedecin.blMedecin();
                blMedecin.UpdatePlanningMedecinMatin(postData.ToString());
            }
            catch (Exception)
            {

                throw;
            }

        }
        [Route("Medecin/UpdatePlanningApresMidi")]
        [HttpPost]
        public void UpdatePlanningApresMidi([FromBody] JArray postData)
        {
            try
            {
                BLMedecin.blMedecin blMedecin = new BLMedecin.blMedecin();
                blMedecin.UpdatePlanningMedecinApres(postData.ToString());
            }
            catch (Exception)
            {

                throw;
            }

        }
        [Route("Medecin/AddSpecialite")]
        [HttpPost]
        public void AddSpecialite([FromBody] JArray postData)
        {
            try
            {
                BLMedecin.blMedecin blMedecin = new BLMedecin.blMedecin();
                blMedecin.AddSpecialite(postData.ToString());
            }
            catch (Exception)
            {

                throw;
            }

        }
        [Route("Medecin/UpdateSpecialite")]
        [HttpPost]
        public void UpdateSpecialite([FromBody] JArray postData)
        {
            try
            {
                BLMedecin.blMedecin blMedecin = new BLMedecin.blMedecin();
                blMedecin.UpdateSpecialite(postData.ToString());
            }
            catch (Exception)
            {

                throw;
            }

        }
        [Route("Medecin/Consultation/{Id}")]
        [HttpGet]
        public List<Models.Models.ModelSelectConsultationMedecinById> GetMedecinConsultation(int Id)
        {
            try
            {
                BLMedecin.blMedecin blMedecin = new BLMedecin.blMedecin();
                string Json1 = blMedecin.SelectConsultationByIdPlanning(Id);
                List<Models.Models.ModelSelectConsultationMedecinById> list1 = JsonConvert.DeserializeObject<List<Models.Models.ModelSelectConsultationMedecinById>>(Json1);
                return list1;
            }
            catch (Exception)
            {

                throw;
            }
        }
        [Route("Medecin/DeletePlanning")]
        [HttpPost]
        public void DeletePlanning([FromBody] JArray postData)
        {
            try
            {
                BLMedecin.blMedecin blMedecin = new BLMedecin.blMedecin();
                blMedecin.DeletePlanningMedecin(postData.ToString());
            }
            catch (Exception)
            {

                throw;
            }

        }
        [Route("Medecin/Specialite/{Id}")]
        [HttpGet]
        public List<Models.Models.ModelSpecialiteMedecin> GetSpecialite(int Id)
        {
            try
            {
                BLMedecin.blMedecin blMedecin = new BLMedecin.blMedecin();
                string Json1 = blMedecin.SelectSpecialiteMedecin(Id);
                List<Models.Models.ModelSpecialiteMedecin> list1 = JsonConvert.DeserializeObject<List<Models.Models.ModelSpecialiteMedecin>>(Json1);
                return list1;
            }
            catch (Exception)
            {

                throw;
            }
        }
        [Route("Medecin/DeleteSpecialite")]
        [HttpPost]
        public void DeleteSpecialite([FromBody] JArray postData)
        {
            try
            {
                BLMedecin.blMedecin blMedecin = new BLMedecin.blMedecin();
                blMedecin.DeleteSpecialite(postData.ToString());
            }
            catch (Exception)
            {

                throw;
            }

        }
        [Route("Medecin/MedecinConsultation/{Id}")]
        [HttpGet]
        public List<Models.Models.ModelSelectConsultationMedecinById> GetMedecinMedConsultation(int Id)
        {
            try
            {
                BLMedecin.blMedecin blMedecin = new BLMedecin.blMedecin();
                string Json1 = blMedecin.SelectConsultationMedecin(Id);
                List<Models.Models.ModelSelectConsultationMedecinById> list1 = JsonConvert.DeserializeObject<List<Models.Models.ModelSelectConsultationMedecinById>>(Json1);
                return list1;
            }
            catch (Exception)
            {

                throw;
            }
        }
        [Route("Medecin/MedecinConfirmation/{Id}")]
        [HttpGet]
        public List<Models.Models.ModeleSelectConfirmation> GetMedecinConfirmation(int Id)
        {
            try
            {
                BLMedecin.blMedecin blMedecin = new BLMedecin.blMedecin();
                string Json1 = blMedecin.SelectConfirmation(Id);
                List<Models.Models.ModeleSelectConfirmation> list1 = JsonConvert.DeserializeObject<List<Models.Models.ModeleSelectConfirmation>>(Json1);
                return list1;
            }
            catch (Exception)
            {

                throw;
            }
        }
        [Route("Medecin/UpdateConfirmation")]
        [HttpPost]
        public void UpdateConfirmation([FromBody] JArray postData)
        {
            try
            {
                BLMedecin.blMedecin blMedecin = new BLMedecin.blMedecin();
                blMedecin.UpdateConfirmation(postData.ToString());
            }
            catch (Exception)
            {

                throw;
            }

        }
    }

}
