using CustomError;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLMedecin
{
    public class blMedecin
    {
        public string SelectPlanningMedecinById(int Id)
        {
            try
            {
                DALEntityMedecin.EFMedecin medAssistV2 = new DALEntityMedecin.EFMedecin();
                List<DALEntityMedecin.SelectPlanningMedecin1_Result> list = medAssistV2.selectPlanningMedecins(Id);
                string JsonToReturn = JsonConvert.SerializeObject(list, Formatting.Indented);
                return JsonToReturn;
            }

            catch (Exception)
            {

                throw;
            }
        }
        public string SelectMedecinById(int Id)
        {
            try
            {
               
                DALEntityMedecin.EFMedecin medAssistV2 = new DALEntityMedecin.EFMedecin();
                List<DALEntityMedecin.SelectMedecin1_Result> list = medAssistV2.selectMedecins(Id);
                string JsonToReturn = JsonConvert.SerializeObject(list, Formatting.Indented);
                return JsonToReturn;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public string SelectMaisonMedecinById(int Id)
        {
            try
            {
                DALEntityMedecin.EFMedecin medAssistV2 = new DALEntityMedecin.EFMedecin();
                List<DALEntityMedecin.SelectMaisonMedecin1_Result> list = medAssistV2.selectMedecinMaison(Id);
                string JsonToReturn = JsonConvert.SerializeObject(list, Formatting.Indented);
                return JsonToReturn;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void AddPlanningMedecin(string PlanningJson)
        {
            try
            {
                List<dynamic> listPlanning = JsonConvert.DeserializeObject<List<dynamic>>(PlanningJson);
                foreach (dynamic item in listPlanning)
                {
                    DateTime date = DateTime.Parse(item.JourDePressence.Value);
                    TimeSpan debutM = TimeSpan.Parse(item.Heured.Value);
                    TimeSpan finM = TimeSpan.Parse(item.Heurefm.Value);
                    TimeSpan debutA = TimeSpan.Parse(item.Heureda.Value);
                    TimeSpan finA = TimeSpan.Parse(item.Heurefa.Value);
                    int IdMedecin = int.Parse(item.IDMedecin.Value);
                    int maisonM = int.Parse(item.IDMaisonM.Value);
                    DALEntityMedecin.EFMedecin eFMedecin = new DALEntityMedecin.EFMedecin();
                    eFMedecin.AjouterJourDePresence(date, debutM, finM, debutA, finA, maisonM, IdMedecin);
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
        public void UpdatePlanningMedecin(string PlanningJson)
        {
            try
            {
                List<dynamic> listPlanning = JsonConvert.DeserializeObject<List<dynamic>>(PlanningJson);
                foreach (dynamic item in listPlanning)
                {
                    int Id = int.Parse(item.PlanningId.Value);
                    TimeSpan debutM = TimeSpan.Parse(item.Heured.Value);
                    TimeSpan finM = TimeSpan.Parse(item.Heurefm.Value);
                    TimeSpan debutA = TimeSpan.Parse(item.Heureda.Value);
                    TimeSpan finA = TimeSpan.Parse(item.Heurefa.Value);
                    DALEntityMedecin.EFMedecin eFMedecin = new DALEntityMedecin.EFMedecin();
                    eFMedecin.EditerJourDePresence(Id, debutM, finM, debutA, finA);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void UpdatePlanningMedecinMatin(string PlanningJson)
        {
            try
            {
                List<dynamic> listPlanning = JsonConvert.DeserializeObject<List<dynamic>>(PlanningJson);
                foreach (dynamic item in listPlanning)
                {
                    int Id = int.Parse(item.PlanningId.Value);
                    TimeSpan debutM = TimeSpan.Parse(item.Heured.Value);
                    TimeSpan finM = TimeSpan.Parse(item.Heurefm.Value);
                    
                    DALEntityMedecin.EFMedecin eFMedecin = new DALEntityMedecin.EFMedecin();
                    eFMedecin.EditerJourDePresenceMatin(Id, debutM, finM);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void UpdatePlanningMedecinApres(string PlanningJson)
        {
            try
            {
                List<dynamic> listPlanning = JsonConvert.DeserializeObject<List<dynamic>>(PlanningJson);
                foreach (dynamic item in listPlanning)
                {
                    int Id = int.Parse(item.PlanningId.Value);
                    
                    TimeSpan debutA = TimeSpan.Parse(item.Heureda.Value);
                    TimeSpan finA = TimeSpan.Parse(item.Heurefa.Value);
                    DALEntityMedecin.EFMedecin eFMedecin = new DALEntityMedecin.EFMedecin();
                    eFMedecin.EditerJourDePresenceApres(Id,  debutA, finA);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void DeletePlanningMedecin(string PlanningJson)
        {
            try
            {
                List<dynamic> listPlanning = JsonConvert.DeserializeObject<List<dynamic>>(PlanningJson);
                foreach (dynamic item in listPlanning)
                {
                    int Id = int.Parse(item.PlanningId.Value);
                    DALEntityMedecin.EFMedecin eFMedecin = new DALEntityMedecin.EFMedecin();
                    eFMedecin.SupptimerJourDePresence(Id);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public string SelectSpecialiteMedecin(int Id)
        {
            try
            {
                DALEntityMedecin.EFMedecin medAssistV2 = new DALEntityMedecin.EFMedecin();
                List<DALEntityMedecin.SelectSpecialiteMedecin1_Result> list = medAssistV2.selectMedecinSpecialite(Id);
                string JsonToReturn = JsonConvert.SerializeObject(list, Formatting.Indented);
                return JsonToReturn;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public string SelectAllSpecialite(int Id) 
        {
            try
            {
                DALEntityMedecin.EFMedecin medAssistV2 = new DALEntityMedecin.EFMedecin();
                List<DALEntityMedecin.SelectAllSpecialite1_Result> list = medAssistV2.selectAllSpecialites();
                //List<DALEntityMedecin.SelectAllSpecialite_Result> list1 = new List<DALEntityMedecin.SelectAllSpecialite_Result>();
                //List<DALEntityMedecin.SelectSpecialiteMedecin_Result> list2 = medAssistV2.selectMedecinSpecialite(Id);
                //Vérification quelle spécialité le médecin a déjà
                /*foreach (var item in list)
                {
                    if(! list2.Any(c => c.IDSPecialite == item.IDSPecialite)) list1.Add(item);
                }*/
                string JsonToReturn = JsonConvert.SerializeObject(list, Formatting.Indented);
                return JsonToReturn;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public string SelectMaisonSpecMedecin(int Id,int idS)
        {
            try
            {
                DALEntityMedecin.EFMedecin medAssistV2 = new DALEntityMedecin.EFMedecin();
                List<DALEntityMedecin.SelectMaisonBySpecialiteByMedecin1_Result> list = medAssistV2.selectMaisonBySpecialiteByMedecin(Id,idS);
                List<DALEntityMedecin.SelectAllMaison1_Result> list1 = medAssistV2.selectAllMaison();
                List<DALEntityMedecin.SelectAllMaison1_Result> list2 = new List<DALEntityMedecin.SelectAllMaison1_Result>();
                foreach (var item in list1)
                {
                    if (!list.Any(c => c.IDMaisonM == item.IDMaisonM)) list2.Add(item);         
                }
                
                string JsonToReturn = JsonConvert.SerializeObject(list2, Formatting.Indented);
                return JsonToReturn;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public string SelectMaisonSpecMedecinEdition(int Id, int idS)
        {
            try
            {
                DALEntityMedecin.EFMedecin medAssistV2 = new DALEntityMedecin.EFMedecin();
                List<DALEntityMedecin.SelectMaisonBySpecialiteByMedecin1_Result> list = medAssistV2.selectMaisonBySpecialiteByMedecin(Id, idS);
                List<DALEntityMedecin.SelectAllMaison1_Result> list1 = medAssistV2.selectAllMaison();
                List<DALEntityMedecin.SelectAllMaison1_Result> list2 = new List<DALEntityMedecin.SelectAllMaison1_Result>();
                foreach (var item in list1)
                {
                    if (list.Any(c => c.IDMaisonM == item.IDMaisonM)) list2.Add(item);
                }

                string JsonToReturn = JsonConvert.SerializeObject(list2, Formatting.Indented);
                return JsonToReturn;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void AddSpecialite(string SpecialiteJson)
        {
            try
            {
                List<dynamic> listSpecialite = JsonConvert.DeserializeObject<List<dynamic>>(SpecialiteJson);
                foreach (dynamic item in listSpecialite)
                {
                    int idMedecin = int.Parse(item.idMedecin.Value);
                    int iDMaison = int.Parse(item.iDMaison.Value);
                    int idSpecialite = int.Parse(item.idSpecialite.Value);
                    int duree = int.Parse(item.duree.Value);                 
                    DALEntityMedecin.EFMedecin eFMedecin = new DALEntityMedecin.EFMedecin();
                    eFMedecin.AddSpecialite(idMedecin,iDMaison,idSpecialite,duree);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void UpdateSpecialite(string SpecialiteJson)
        {
            try
            {
                List<dynamic> listSpecialite = JsonConvert.DeserializeObject<List<dynamic>>(SpecialiteJson);
                foreach (dynamic item in listSpecialite)
                {
                    int idMedecin = int.Parse(item.idMedecin.Value);
                    int iDMaison = int.Parse(item.iDMaison.Value);
                    int idSpecialite = int.Parse(item.idSpecialite.Value);
                    int duree = int.Parse(item.duree.Value);
                    DALEntityMedecin.EFMedecin eFMedecin = new DALEntityMedecin.EFMedecin();
                    eFMedecin.UpdateSpecialite(idMedecin, iDMaison, idSpecialite, duree);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void DeleteSpecialite(string SpecialiteJson)
        {
            try
            {
                List<dynamic> listSpecialite = JsonConvert.DeserializeObject<List<dynamic>>(SpecialiteJson);
                foreach (dynamic item in listSpecialite)
                {
                    int idMedecin = int.Parse(item.idMedecin.Value);
                    int iDMaison = int.Parse(item.iDMaison.Value);
                    int idSpecialite = int.Parse(item.idSpecialite.Value);               
                    DALEntityMedecin.EFMedecin eFMedecin = new DALEntityMedecin.EFMedecin();
                    eFMedecin.DeleteSpecialite(idMedecin, iDMaison, idSpecialite);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public string SelectConsultationMedecin(int Id)
        {
            try
            {
                DALEntityMedecin.EFMedecin medAssistV2 = new DALEntityMedecin.EFMedecin();
                List<DALEntityMedecin.SelectConsultationMedecin_Result> list = medAssistV2.selectConsultationMedecins(Id);
                string JsonToReturn = JsonConvert.SerializeObject(list, Formatting.Indented);
                return JsonToReturn;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public string SelectConsultationMatinPremier(int Id)
        {
            try
            {
                DALEntityMedecin.EFMedecin medAssistV2 = new DALEntityMedecin.EFMedecin();
                List<DALEntityMedecin.SelectConsultationMedecinMatinPremier_Result> list = medAssistV2.selectConsultationMedecinMatinPremiers(Id);
                string JsonToReturn = JsonConvert.SerializeObject(list, Formatting.Indented);
                return JsonToReturn;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public string SelectConsultationMatinDernier(int Id)
        {
            try
            {
                DALEntityMedecin.EFMedecin medAssistV2 = new DALEntityMedecin.EFMedecin();
                List<DALEntityMedecin.SelectConsultationMedecinMatinDernier_Result> list = medAssistV2.selectConsultationMedecinMatinDerniers(Id);
                string JsonToReturn = JsonConvert.SerializeObject(list, Formatting.Indented);
                return JsonToReturn;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public string SelectConsultationApresMidiPremier(int Id)
        {
            try
            {
                DALEntityMedecin.EFMedecin medAssistV2 = new DALEntityMedecin.EFMedecin();
                List<DALEntityMedecin.SelectConsultationMedecinApresMidiPremier_Result> list = medAssistV2.selectConsultationMedecinApresMidiPremiers(Id);
                string JsonToReturn = JsonConvert.SerializeObject(list, Formatting.Indented);
                return JsonToReturn;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public string SelectConsultationApresMidiDernier(int Id)
        {
            try
            {
                DALEntityMedecin.EFMedecin medAssistV2 = new DALEntityMedecin.EFMedecin();
                List<DALEntityMedecin.SelectConsultationMedecinApresMidiDernier_Result> list = medAssistV2.selectConsultationMedecinApresMidiDerniers(Id);
                string JsonToReturn = JsonConvert.SerializeObject(list, Formatting.Indented);
                return JsonToReturn;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public string SelectConsultationByIdPlanning(int Id)
        {
            try
            {
                DALEntityMedecin.EFMedecin medAssistV2 = new DALEntityMedecin.EFMedecin();
                List<DALEntityMedecin.SelectConsultationByIdPlanning_Result> list = medAssistV2.selectConsultationByIdPlannings(Id);
                string JsonToReturn = JsonConvert.SerializeObject(list, Formatting.Indented);
                return JsonToReturn;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public string SelectConfirmation(int Id)
        {
            try
            {
                DALEntityMedecin.EFMedecin medAssistV2 = new DALEntityMedecin.EFMedecin();
                List<DALEntityMedecin.SelectConfirmation_Result> list = medAssistV2.selectConfirmations(Id);
                string JsonToReturn = JsonConvert.SerializeObject(list, Formatting.Indented);
                return JsonToReturn;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void UpdateConfirmation(string ConfirmationJson)
        {
            try
            {
                List<dynamic> listConfirmation = JsonConvert.DeserializeObject<List<dynamic>>(ConfirmationJson);
                foreach (dynamic item in listConfirmation)
                {
                    int idRDV = int.Parse(item.idRDV.Value);
                    int iDMedecin = int.Parse(item.idMedecin.Value);
                    int Confirmation = int.Parse(item.Confirmation.Value);
                    
                    DALEntityMedecin.EFMedecin eFMedecin = new DALEntityMedecin.EFMedecin();
                    eFMedecin.UpdateConfirmation(idRDV,iDMedecin,Confirmation);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
