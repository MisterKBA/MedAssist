using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALEntityPatient
{
    public class EFPatient
    {
        public List<selectPatientById_Result> selectPatientById(int Id)
        {
            try
            {
                MedAssistV2Entities medAssistV2 = new MedAssistV2Entities();
                List<selectPatientById_Result> list = medAssistV2.selectPatientById(Id).ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<selectAllMaison_Result> selectAllMaisons()
        {
            try
            {
                MedAssistV2Entities medAssistV2 = new MedAssistV2Entities();
                List<selectAllMaison_Result> list = medAssistV2.selectAllMaison().ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<selectSpecialiteByDate_Result> selectSpecialiteByDates(int Id,DateTime date)
        {
            try
            {
                MedAssistV2Entities medAssistV2 = new MedAssistV2Entities();
                List<selectSpecialiteByDate_Result> list = medAssistV2.selectSpecialiteByDate(date,Id).ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<selectHeureConsultationPlan_Result> selectHeureConsultationPlans(int IdMe,int IdM ,DateTime date)
        {
            try
            {
                MedAssistV2Entities medAssistV2 = new MedAssistV2Entities();
                List<selectHeureConsultationPlan_Result> list = medAssistV2.selectHeureConsultationPlan(date, IdMe,IdM).ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<selectHeureConsultationCons_Result> selectHeureConsultationCons(int IdS, int IdM, DateTime date)
        {
            try
            {
                MedAssistV2Entities medAssistV2 = new MedAssistV2Entities();
                List<selectHeureConsultationCons_Result> list = medAssistV2.selectHeureConsultationCons(date, IdS, IdM).ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<selectMedecinPlan_Result> selectMedecinPlans(int IdS, int IdM, DateTime date)
        {
            try
            {
                MedAssistV2Entities medAssistV2 = new MedAssistV2Entities();
                List<selectMedecinPlan_Result> list = medAssistV2.selectMedecinPlan(date, IdM, IdS).ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<selectMedecinCon_Result> selectMedecinCons(DateTime date,int IdM,int IdS)
        {
            try
            {
                MedAssistV2Entities medAssistV2 = new MedAssistV2Entities();
                List<selectMedecinCon_Result> list = medAssistV2.selectMedecinCon(date, IdM, IdS).ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<selectHeureConsultationConsMat_Result> selectMedecinConsMat(int IdMe, int IdM, DateTime date)
        {
            try
            {
                MedAssistV2Entities medAssistV2 = new MedAssistV2Entities();
                List<selectHeureConsultationConsMat_Result> list = medAssistV2.selectHeureConsultationConsMat(date, IdMe, IdM).ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<selectHeureConsultationConsAp_Result> selectMedecinConsAp(int IdMe, int IdM, DateTime date)
        {
            try
            {
                MedAssistV2Entities medAssistV2 = new MedAssistV2Entities();
                List<selectHeureConsultationConsAp_Result> list = medAssistV2.selectHeureConsultationConsAp(date, IdMe, IdM).ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void prendreRvdMode1(int idPatient,int idMedecin,int idMaison,int idSpecialite, DateTime date, TimeSpan heure) 
        {
            MedAssistV2Entities medAssistV2 = new MedAssistV2Entities();
            medAssistV2.AddRDVMode1(idPatient, idMedecin, idMaison, idSpecialite, date, heure);
        }
        public void ConfirmeRvdMode1(int idPatient, int idMedecin, int idMaison, int idSpecialite, DateTime date, TimeSpan heure)
        {
            MedAssistV2Entities medAssistV2 = new MedAssistV2Entities();
            medAssistV2.AddRDVMode1(idPatient, idMedecin, idMaison, idSpecialite, date, heure);
        }
        public List<selectRDVPatientByPaHeDa_Result> selectRDVPatientByPaHeDas(int idPatient,DateTime date,TimeSpan heure) 
        {
            try
            {
                MedAssistV2Entities medAssistV2 = new MedAssistV2Entities();
                List<selectRDVPatientByPaHeDa_Result> list = medAssistV2.selectRDVPatientByPaHeDa(idPatient,date,heure).ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<selectMedecinByDateMaison_Result> selectMedecinByDateMaisons( DateTime date, int idMaison)
        {
            try
            {
                MedAssistV2Entities medAssistV2 = new MedAssistV2Entities();
                List<selectMedecinByDateMaison_Result> list = medAssistV2.selectMedecinByDateMaison(date, idMaison).ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<selectPatientRDV_Result> selectPatientRDVs(int Id) 
        {
            try
            {
                MedAssistV2Entities medAssistV2 = new MedAssistV2Entities();
                List<selectPatientRDV_Result> list = medAssistV2.selectPatientRDV(Id).ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void EditerRDV(DateTime date,int idMedecin,int idMaison,int idSPecialite,int idConsultation,int IdRDV,TimeSpan anHeure,TimeSpan heure)
        {
            try
            {
                MedAssistV2Entities medAssistV2Entities = new MedAssistV2Entities();
                medAssistV2Entities.UpdateRDVMode1(anHeure,IdRDV,idConsultation,idMedecin,idMaison,idSPecialite,date,heure);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void SupprimerRDV(TimeSpan heure,int idPlanning,int idConsultation,DateTime date,int idLocal) 
        {
            try
            {
                MedAssistV2Entities medAssistV2Entities = new MedAssistV2Entities();
                medAssistV2Entities.DeleteRDVMode1(heure,idPlanning,idConsultation,date,idLocal);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<selectAllMedecin_Result> selectAllMedecins()
        {
            try
            {
                MedAssistV2Entities medAssistV2 = new MedAssistV2Entities();
                List<selectAllMedecin_Result> list = medAssistV2.selectAllMedecin().ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<selectMaisonByMedecin_Result> selectMaisonByMedecins(int Id)
        {
            try
            {
                MedAssistV2Entities medAssistV2 = new MedAssistV2Entities();
                List<selectMaisonByMedecin_Result> list = medAssistV2.selectMaisonByMedecin(Id).ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<selectSpecialiteByMaisonMedecin_Result> selectSpecialiteByMaisonMedecins(int idMedecin,int idMaison)
        {
            try
            {
                MedAssistV2Entities medAssistV2 = new MedAssistV2Entities();
                List<selectSpecialiteByMaisonMedecin_Result> list = medAssistV2.selectSpecialiteByMaisonMedecin(idMedecin,idMaison).ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<selectDatePresence_Result> selectDatePresences(int idMedecin, int idMaison)
        {
            try
            {
                MedAssistV2Entities medAssistV2 = new MedAssistV2Entities();
                List<selectDatePresence_Result> list = medAssistV2.selectDatePresence(idMedecin, idMaison).ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void EditerRDV1(DateTime date, int idMedecin, int idMaison, int idSPecialite, int idConsultation, int IdRDV, TimeSpan anHeure, TimeSpan heure,int idPlanning)
        {
            try
            {
                MedAssistV2Entities medAssistV2Entities = new MedAssistV2Entities();
                medAssistV2Entities.UpdateRDVMode2(anHeure, IdRDV, idConsultation, idMedecin, idMaison, idSPecialite, date, heure,idPlanning);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<selectPatientRDVAndDate_Result> selectPatientRDVAndDates(int idPatient, DateTime date)
        {
            try
            {
                MedAssistV2Entities medAssistV2 = new MedAssistV2Entities();
                List<selectPatientRDVAndDate_Result> list = medAssistV2.selectPatientRDVAndDate(idPatient, date).ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
