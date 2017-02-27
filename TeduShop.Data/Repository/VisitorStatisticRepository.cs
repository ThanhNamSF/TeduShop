using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repository
{
    public interface IVisitorStatisticsRepository : IReponsitory<VisitorStatistic>
    {

    }

    public class VisitorStatisticRepository : RepositoryBase<VisitorStatistic>, IVisitorStatisticsRepository
    {
        public VisitorStatisticRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
