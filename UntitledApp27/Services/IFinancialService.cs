using UntitledApp27.Models.Financial;

namespace UntitledApp27.Financial
{
    public interface IFinancialService
    {
        Task<List<BoxOfficeRevenueType>> GetBoxOfficeRevenue();
    }
}