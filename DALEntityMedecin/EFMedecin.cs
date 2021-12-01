using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALEntityMedecin
{
    public class EFMedecin
    {
        public List<SelectPlanningMedecin1_Result> selectPlanningMedecins(int Id) 
        {
            try
            {
                MedAssistV2Entities medAssistV2 = new MedAssistV2Entities();
                List<SelectPlanningMedecin1_Result> list = medAssistV2.SelectPlanningMedecin1(Id).ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<SelectMedecin1_Result> selectMedecins(int Id)
        {
            try
            {
                MedAssistV2Entities medAssistV2 = new MedAssistV2Entities();
                List<SelectMedecin1_Result> list = medAssistV2.SelectMedecin1(Id).ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<SelectMaisonMedecin1_Result> selectMedecinMaison(int Id)
        {
            try
            {
                MedAssistV2Entities medAssistV2 = new MedAssistV2Entities();
                List<SelectMaisonMedecin1_Result> list = medAssistV2.SelectMaisonMedecin1(Id).ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void AjouterJourDePresence(DateTime date, TimeSpan heured, TimeSpan heurefm, TimeSpan heureda, TimeSpan heurefa, int IDMaison, int IDMedecin)
        {
            try
            {
                MedAssistV2Entities medAssistV2 = new MedAssistV2Entities();
                medAssistV2.AddPlanningMedecin1(date,heured,heurefm,heureda,heurefa,IDMaison,IDMedecin);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void EditerJourDePresence(int Id, TimeSpan heured, TimeSpan heurefm, TimeSpan heureda, TimeSpan heurefa) 
        {
            try
            {
                MedAssistV2Entities medAssistV2Entities = new MedAssistV2Entities();
                medAssistV2Entities.UpdatePlanningMedecin1(Id, heured, heurefm, heureda, heurefa);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void EditerJourDePresenceMatin(int Id, TimeSpan heured, TimeSpan heurefm)
        {
            try
            {
                MedAssistV2Entities medAssistV2Entities = new MedAssistV2Entities();
                medAssistV2Entities.UpdatePlanningMedecinMatin(Id, heured, heurefm);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void EditerJourDePresenceApres(int Id, TimeSpan heureda, TimeSpan heurefa)
        {
            try
            {
                MedAssistV2Entities medAssistV2Entities = new MedAssistV2Entities();
                medAssistV2Entities.UpdatePlanningMedecinApres(Id,  heureda, heurefa);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void SupptimerJourDePresence(int Id)
        {
            try
            {
                MedAssistV2Entities medAssistV2Entities = new MedAssistV2Entities();
                medAssistV2Entities.deletePlanning1(Id);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<SelectSpecialiteMedecin1_Result> selectMedecinSpecialite(int Id)
        {
            try
            {
                MedAssistV2Entities medAssistV2 = new MedAssistV2Entities();
                List<SelectSpecialiteMedecin1_Result> list = medAssistV2.SelectSpecialiteMedecin1(Id).ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<SelectAllSpecialite1_Result> selectAllSpecialites()
        {

            MedAssistV2Entities medAssistV2 = new MedAssistV2Entities();
            List<SelectAllSpecialite1_Result> list = medAssistV2.SelectAllSpecialite1().ToList();
            return list;
        }
        public void AddSpecialite(Nullable<int> idMedecin, Nullable<int> iDMaison, Nullable<int> idSpecialite, Nullable<int> duree) 
        {
            try
            {
                MedAssistV2Entities medAssistV2Entities = new MedAssistV2Entities();
                medAssistV2Entities.AddSpecialite1(idMedecin, iDMaison, idSpecialite, duree);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<SelectAllMaison1_Result> selectAllMaison()
        {
            try
            {
                MedAssistV2Entities medAssistV2 = new MedAssistV2Entities();
                List<SelectAllMaison1_Result> list = medAssistV2.SelectAllMaison1().ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<SelectMaisonBySpecialiteByMedecin1_Result> selectMaisonBySpecialiteByMedecin(int idm,int ids)
        {
            try
            {
                MedAssistV2Entities medAssistV2 = new MedAssistV2Entities();
                List<SelectMaisonBySpecialiteByMedecin1_Result> list = medAssistV2.SelectMaisonBySpecialiteByMedecin1(idm,ids).ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void UpdateSpecialite(Nullable<int> idMedecin, Nullable<int> idMaison, Nullable<int> idSpecialise, Nullable<int> duree)
        {
            try
            {
                MedAssistV2Entities medAssistV2Entities = new MedAssistV2Entities();
                medAssistV2Entities.UpdateSpecialite1(idMedecin, idMaison, idSpecialise, duree);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void DeleteSpecialite(Nullable<int> idMedecin, Nullable<int> idMaison, Nullable<int> idSpecialite)
        {
            try
            {
                MedAssistV2Entities medAssistV2Entities = new MedAssistV2Entities();
                medAssistV2Entities.DeleteSpecialite1(idMedecin, idMaison, idSpecialite);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<SelectConsultationMedecin_Result> selectConsultationMedecins(int Id)
        {
            try
            {
                MedAssistV2Entities medAssistV2 = new MedAssistV2Entities();
                List<SelectConsultationMedecin_Result> list = medAssistV2.SelectConsultationMedecin(Id).ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<SelectConsultationMedecinMatinPremier_Result> selectConsultationMedecinMatinPremiers(int Id)
        {
            try
            {
                MedAssistV2Entities medAssistV2 = new MedAssistV2Entities();
                List<SelectConsultationMedecinMatinPremier_Result> list = medAssistV2.SelectConsultationMedecinMatinPremier(Id).ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<SelectConsultationMedecinMatinDernier_Result> selectConsultationMedecinMatinDerniers(int Id)
        {
            try
            {
                MedAssistV2Entities medAssistV2 = new MedAssistV2Entities();
                List<SelectConsultationMedecinMatinDernier_Result> list = medAssistV2.SelectConsultationMedecinMatinDernier(Id).ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<SelectConsultationMedecinApresMidiPremier_Result> selectConsultationMedecinApresMidiPremiers(int Id)
        {
            try
            {
                MedAssistV2Entities medAssistV2 = new MedAssistV2Entities();
                List<SelectConsultationMedecinApresMidiPremier_Result> list = medAssistV2.SelectConsultationMedecinApresMidiPremier(Id).ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<SelectConsultationMedecinApresMidiDernier_Result> selectConsultationMedecinApresMidiDerniers(int Id)
        {
            try
            {
                MedAssistV2Entities medAssistV2 = new MedAssistV2Entities();
                List<SelectConsultationMedecinApresMidiDernier_Result> list = medAssistV2.SelectConsultationMedecinApresMidiDernier(Id).ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<SelectConsultationByIdPlanning_Result> selectConsultationByIdPlannings(int Id)
        {
            try
            {
                MedAssistV2Entities medAssistV2 = new MedAssistV2Entities();
                List<SelectConsultationByIdPlanning_Result> list = medAssistV2.SelectConsultationByIdPlanning(Id).ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<SelectConfirmation_Result> selectConfirmations(int Id)
        {
            try
            {
                MedAssistV2Entities medAssistV2 = new MedAssistV2Entities();
                List<SelectConfirmation_Result> list = medAssistV2.SelectConfirmation(Id).ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void  UpdateConfirmation(int idRDV,int idMedecin,int Confirmation) 
        {
            try
            {
                MedAssistV2Entities medAssistV2Entities = new MedAssistV2Entities();
                medAssistV2Entities.AddRConfirmation(idRDV,idMedecin,Confirmation);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
