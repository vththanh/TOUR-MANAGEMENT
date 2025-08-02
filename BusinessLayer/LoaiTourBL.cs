using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace BusinessLayer
{
    public class LoaiTourBL
    {
        private LoaiTourDL dal;

        public LoaiTourBL()
        {
            dal = new LoaiTourDL();
        }

        public List<LoaiTour> GetAllLoaiTour()
        {
            return dal.GetAll();
        }
    }
}
