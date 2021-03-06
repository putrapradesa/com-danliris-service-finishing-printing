﻿using Com.Danliris.Service.Finishing.Printing.Lib.Models.DOSales;
using Com.Danliris.Service.Production.Lib.Utilities.BaseInterface;
using System.Threading.Tasks;

namespace Com.Danliris.Service.Finishing.Printing.Lib.BusinessLogic.Interfaces.DOSales
{
    public interface IDOSalesFacade : IBaseFacade<DOSalesModel>
    {
        Task<DOSalesDetailModel> GetDOSalesDetail(string productName);

        //ReadResponse<DOSalesViewModel> GetReport(int page, int size, string code, int productionOrderId, DateTime? dateFrom, DateTime? dateTo, int offSet);

        //List<DOSalesViewModel> GetReport(string code, int productionOrderId, DateTime? dateFrom, DateTime? dateTo, int offSet);
    }
}
