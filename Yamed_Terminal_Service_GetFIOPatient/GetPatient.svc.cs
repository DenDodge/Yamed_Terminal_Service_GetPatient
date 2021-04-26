using System;
using System.Linq;
using Yamed_Terminal_Service_GetPatient.DBContext;
using Yamed_Terminal_Service_GetPatient.Models;

namespace Yamed_Terminal_Service_GetPatient
{
    public class Yamed_Service : IGetPatient
    { 
        public Patient GetPatient(string NPolis)
        {
            Patient patient = null;
            using (srz_miniEntities1 db = new srz_miniEntities1())
            {
                PEOPLE people = db.PEOPLE.Where(p => p.ENP == NPolis).FirstOrDefault();
                if (people != null)
                    patient = new Patient
                    {
                        FIO = people.FAM + " " + people.IM + " " + people.OT,
                        Birthday = people.DR.Value,
                        SexPat = (Sex)people.W,
                        NPolis = people.ENP
                    };
            }
            return patient;
        }
    }
}
