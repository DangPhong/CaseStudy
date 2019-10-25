using QLCafe.Domain.Requets;
using QLCafe.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLCafe.DAL.Interface
{
    public interface IBillDetailReponsitory
    {
        IList<BillDetail> BillDetailGetByID(int Id);
        IList<BillDetailsView> BillDetailsView(int Id);
        int BillDetailAddByID(BillDetailAdd request);
        bool BillDetailDelete(int Id);
        bool Pay(int Id);
    }
}
