using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataLayer;
using TransferObject;

namespace BusinessLayer
{
    public class ToursBL
    {
        private ToursDL tourdl;

        public ToursBL()
        {
            tourdl = new ToursDL();
        }

        public List<Tour> GetTours()
        {
            try
            {
                return tourdl.GetTour();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public List<Tour> SearchTourByName(string keyword)
        {
            try
            {
                return tourdl.SearchTourByName(keyword);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public List<Tour> GetTourByType(string tourType)
        {
            return tourdl.GetTourByType(tourType); 
        }

        public Tour GetTourByID(string maTour)
        {
            return tourdl.GetTourByID(maTour); 
        }
    }
}
