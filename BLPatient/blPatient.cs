using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLPatient
{
    public class blPatient
    {
        public string SelectPatientById(int Id)
        {
            try
            {
                DALEntityPatient.EFPatient eFPatient = new DALEntityPatient.EFPatient();
                List<DALEntityPatient.selectPatientById_Result> list = eFPatient.selectPatientById(Id);
                string JsonToReturn = JsonConvert.SerializeObject(list, Formatting.Indented);
                return JsonToReturn;
            }

            catch (Exception)
            {

                throw;
            }
        }
        public string SelectSelectMaisons()
        {
            try
            {
                DALEntityPatient.EFPatient eFPatient = new DALEntityPatient.EFPatient();
                List<DALEntityPatient.selectAllMaison_Result> list = eFPatient.selectAllMaisons();
                string JsonToReturn = JsonConvert.SerializeObject(list, Formatting.Indented);
                return JsonToReturn;
            }

            catch (Exception)
            {

                throw;
            }
        }
        public string SelectSpecByDate(DateTime date,int Id)
        {
            try
            {
                DALEntityPatient.EFPatient eFPatient = new DALEntityPatient.EFPatient();
                List<DALEntityPatient.selectSpecialiteByDate_Result> list = eFPatient.selectSpecialiteByDates(Id,date);
                string JsonToReturn = JsonConvert.SerializeObject(list, Formatting.Indented);
                return JsonToReturn;
            }

            catch (Exception)
            {

                throw;
            }
        }
        public string SelectHeureConsultationByMMatin(DateTime date, int IdMe,int IdM)
        {
            try
            {
                string JsonToReturn;
                DALEntityPatient.EFPatient eFPatient = new DALEntityPatient.EFPatient();
                List<DALEntityPatient.selectHeureConsultationPlan_Result> listplan = eFPatient.selectHeureConsultationPlans(IdMe,IdM, date);
                List<DALEntityPatient.selectHeureConsultationConsMat_Result> listconMa = eFPatient.selectMedecinConsMat(IdMe, IdM, date);               
                if (listconMa.Any())
                {
                    JsonToReturn = JsonConvert.SerializeObject(listconMa, Formatting.Indented);
                    return JsonToReturn;
                }

                else 
                {
                    JsonToReturn = JsonConvert.SerializeObject(listplan, Formatting.Indented);
                    return JsonToReturn;
                }
            }

            catch (Exception)
            {

                throw;
            }
        }
        public string SelectHeureConsultationByMMidi(DateTime date, int IdMe, int IdM)
        {
            try
            {
                string JsonToReturn;
                DALEntityPatient.EFPatient eFPatient = new DALEntityPatient.EFPatient();
                List<DALEntityPatient.selectHeureConsultationPlan_Result> listplan = eFPatient.selectHeureConsultationPlans(IdMe, IdM, date);              
                List<DALEntityPatient.selectHeureConsultationConsAp_Result> listconAp = eFPatient.selectMedecinConsAp(IdMe, IdM, date);
                if (listconAp.Any())
                {
                    JsonToReturn = JsonConvert.SerializeObject(listconAp, Formatting.Indented);
                    return JsonToReturn;
                }

                else
                {
                    JsonToReturn = JsonConvert.SerializeObject(listplan, Formatting.Indented);
                    return JsonToReturn;
                }
            }

            catch (Exception)
            {

                throw;
            }
        }

        public string SelectMedecinPlanning(DateTime date, int IdM,int IdS)
        {
            try
            {
                DALEntityPatient.EFPatient eFPatient = new DALEntityPatient.EFPatient();
                List<DALEntityPatient.selectMedecinPlan_Result> list = eFPatient.selectMedecinPlans(IdS,IdM,date);
                string JsonToReturn = JsonConvert.SerializeObject(list, Formatting.Indented);
                return JsonToReturn;
            }

            catch (Exception)
            {

                throw;
            }
        }
        public string SelectMedecinConsultation(DateTime date, int IdM, int IdS)
        {
            try
            {
                DALEntityPatient.EFPatient eFPatient = new DALEntityPatient.EFPatient();
                List<DALEntityPatient.selectMedecinCon_Result> list = eFPatient.selectMedecinCons(date,IdM,IdS);
                string JsonToReturn = JsonConvert.SerializeObject(list, Formatting.Indented);
                return JsonToReturn;
            }

            catch (Exception)
            {

                throw;
            }
        }
        public string SelectHeureConsultationMAt(DateTime date, int IdM, int IdMe)
        {
            try
            {
                DALEntityPatient.EFPatient eFPatient = new DALEntityPatient.EFPatient();
                List<DALEntityPatient.selectHeureConsultationConsMat_Result> list = eFPatient.selectMedecinConsMat(IdMe,IdM,date);         //int IdMe,int IdM ,DateTime date
                string JsonToReturn = JsonConvert.SerializeObject(list, Formatting.Indented);
                return JsonToReturn;
            }

            catch (Exception)
            {

                throw;
            }
        }
        public string SelectHeureConsultationAp(DateTime date, int IdM, int IdMe)
        {
            try
            {
                DALEntityPatient.EFPatient eFPatient = new DALEntityPatient.EFPatient();
                List<DALEntityPatient.selectHeureConsultationConsAp_Result> list = eFPatient.selectMedecinConsAp(IdMe, IdM, date);
                string JsonToReturn = JsonConvert.SerializeObject(list, Formatting.Indented);
                return JsonToReturn;
            }

            catch (Exception)
            {

                throw;
            }
        }
        public string SelectMedecinByDateMaison(DateTime date,int IdM) 
        {
            try
            {
                DALEntityPatient.EFPatient eFPatient = new DALEntityPatient.EFPatient();
                List<DALEntityPatient.selectMedecinByDateMaison_Result> list = eFPatient.selectMedecinByDateMaisons(date,IdM);
                string JsonToReturn = JsonConvert.SerializeObject(list, Formatting.Indented);
                return JsonToReturn;
            }

            catch (Exception)
            {

                throw;
            }
        }
        public void AddPRDVMode1(string PlanningJson)
        {
            try
            {
                List<dynamic> listPlanning = JsonConvert.DeserializeObject<List<dynamic>>(PlanningJson);
                foreach (dynamic item in listPlanning)
                {
                    //idPatient, idMedecin, idMaison, idSpecialite, date, heure 
                    int idPatient = int.Parse(item.idPatient.Value);
                    int idMedecin = int.Parse(item.idMedecin.Value);
                    int idMaison = int.Parse(item.idMaison.Value);
                    int idSpecialite = int.Parse(item.idSpecialite.Value);
                    DateTime date = DateTime.Parse(item.date.Value);
                    TimeSpan heure = TimeSpan.Parse(item.heure.Value);
                    DALEntityPatient.EFPatient efPatient = new DALEntityPatient.EFPatient();
                    efPatient.prendreRvdMode1(idPatient, idMedecin, idMaison, idSpecialite, date, heure);
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
        public string SelectRDVPatientCreer(int idPatient,DateTime date,TimeSpan heure)
        {
            try
            {
                DALEntityPatient.EFPatient eFPatient = new DALEntityPatient.EFPatient();
                List<DALEntityPatient.selectRDVPatientByPaHeDa_Result> list = eFPatient.selectRDVPatientByPaHeDas(idPatient,date,heure);
                string JsonToReturn = JsonConvert.SerializeObject(list, Formatting.Indented);
                return JsonToReturn;
            }

            catch (Exception)
            {

                throw;
            }
        }
        public string SelectPatientRDV(int id)
        {
            try
            {
                DALEntityPatient.EFPatient eFPatient = new DALEntityPatient.EFPatient();
                List<DALEntityPatient.selectPatientRDV_Result> list = eFPatient.selectPatientRDVs(id);
                string JsonToReturn = JsonConvert.SerializeObject(list, Formatting.Indented);
                return JsonToReturn;
            }

            catch (Exception)
            {

                throw;
            }
        }
        public void UpdateRDV(string RDVJson)
        {
            try
            {
                List<dynamic> listRDV = JsonConvert.DeserializeObject<List<dynamic>>(RDVJson);
                foreach (dynamic item in listRDV)
                {
                    TimeSpan anHeure = TimeSpan.Parse(item.anHeure.Value);
                    int idPlanningRDV = int.Parse(item.idRDV.Value);
                    int idConsultation = int.Parse(item.idConsultation.Value);
                    int idMedecin = int.Parse(item.idMedecin.Value);
                    int idMaison = int.Parse(item.idMaison.Value);
                    int idSpecialite = int.Parse(item.idSpecialite.Value);
                    DateTime date = DateTime.Parse(item.date.Value);
                    TimeSpan heure = TimeSpan.Parse(item.heure.Value);
                    DALEntityPatient.EFPatient eFPatient = new DALEntityPatient.EFPatient();
                    eFPatient.EditerRDV(date,idMedecin,idMaison,idSpecialite,idConsultation,idPlanningRDV,anHeure,heure);
                    
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void DeleteRDV(string RDVJson)
        {
            try
            {
                List<dynamic> listRDV = JsonConvert.DeserializeObject<List<dynamic>>(RDVJson);
                foreach (dynamic item in listRDV)
                {
                    
                    int idPlanningRDV = int.Parse(item.idRDV.Value);
                    int idConsultation = int.Parse(item.idConsultation.Value);
                    int idLocal = int.Parse(item.idlocal.Value);
                    DateTime date = DateTime.Parse(item.date.Value);
                    TimeSpan heure = TimeSpan.Parse(item.heure.Value);
                    DALEntityPatient.EFPatient eFPatient = new DALEntityPatient.EFPatient();
                    eFPatient.SupprimerRDV(heure,idPlanningRDV,idConsultation,date,idLocal);

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public string SelectAllMedecin()
        {
            try
            {
                DALEntityPatient.EFPatient eFPatient = new DALEntityPatient.EFPatient();
                List<DALEntityPatient.selectAllMedecin_Result> list = eFPatient.selectAllMedecins();
                string JsonToReturn = JsonConvert.SerializeObject(list, Formatting.Indented);
                return JsonToReturn;
            }

            catch (Exception)
            {

                throw;
            }
        }
        public string SelectMaisonByMedecin(int idMedecin)
        {
            try
            {
                DALEntityPatient.EFPatient eFPatient = new DALEntityPatient.EFPatient();
                List<DALEntityPatient.selectMaisonByMedecin_Result> list = eFPatient.selectMaisonByMedecins(idMedecin);
                string JsonToReturn = JsonConvert.SerializeObject(list, Formatting.Indented);
                return JsonToReturn;
            }

            catch (Exception)
            {

                throw;
            }
        }
        public string SelectSpecialiteByMaisonByMedecin(int idMedecin,int idMaison)
        {
            try
            {
                DALEntityPatient.EFPatient eFPatient = new DALEntityPatient.EFPatient();
                List<DALEntityPatient.selectSpecialiteByMaisonMedecin_Result> list = eFPatient.selectSpecialiteByMaisonMedecins(idMedecin,idMaison);
                string JsonToReturn = JsonConvert.SerializeObject(list, Formatting.Indented);
                return JsonToReturn;
            }

            catch (Exception)
            {

                throw;
            }
        }
        public string SelectDateDePresence(int idMedecin, int idMaison)
        {
            try
            {
                DALEntityPatient.EFPatient eFPatient = new DALEntityPatient.EFPatient();
                List<DALEntityPatient.selectDatePresence_Result> list = eFPatient.selectDatePresences(idMedecin, idMaison);
                string JsonToReturn = JsonConvert.SerializeObject(list, Formatting.Indented);
                return JsonToReturn;
            }

            catch (Exception)
            {

                throw;
            }
        }
        public void UpdateRDV1(string RDVJson)
        {
            try
            {
                List<dynamic> listRDV = JsonConvert.DeserializeObject<List<dynamic>>(RDVJson);
                foreach (dynamic item in listRDV)
                {
                    TimeSpan anHeure = TimeSpan.Parse(item.anHeure.Value);
                    int idPlanningRDV = int.Parse(item.idRDV.Value);
                    int idConsultation = int.Parse(item.idConsultation.Value);
                    int idMedecin = int.Parse(item.idMedecin.Value);
                    int idMaison = int.Parse(item.idMaison.Value);
                    int idSpecialite = int.Parse(item.idSpecialite.Value);
                    DateTime date = DateTime.Parse(item.date.Value);
                    TimeSpan heure = TimeSpan.Parse(item.heure.Value);
                    int idPlanningMed = int.Parse(item.idPlanningMed.Value);
                    DALEntityPatient.EFPatient eFPatient = new DALEntityPatient.EFPatient();
                    eFPatient.EditerRDV1(date, idMedecin, idMaison, idSpecialite, idConsultation, idPlanningRDV, anHeure, heure,idPlanningMed);

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public string SelectRDVPatientAndDate(int idPatient, DateTime date)
        {
            try
            {
                DALEntityPatient.EFPatient eFPatient = new DALEntityPatient.EFPatient();
                List<DALEntityPatient.selectPatientRDVAndDate_Result> list = eFPatient.selectPatientRDVAndDates(idPatient, date);
                string JsonToReturn = JsonConvert.SerializeObject(list, Formatting.Indented);
                return JsonToReturn;
            }

            catch (Exception)
            {

                throw;
            }
        }
    }
}
//anHeure, IdRDV, idConsultation, idMedecin, idMaison, idSPecialite, date, heure,idPlanning