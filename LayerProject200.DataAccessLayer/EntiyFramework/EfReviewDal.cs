using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayerProject200.DataAccessLayer.Abstract;
using LayerProject200.DataAccessLayer.Context;
using LayerProject200.DataAccessLayer.Repositories;
using LayerProject200.EntityLayer.Concrete;

namespace LayerProject200.DataAccessLayer.EntiyFramework
{
    public class EfReviewDal : GenericRepository<Review>, IReviewDal
    {
        public EfReviewDal(ProjectContext context) : base(context)
        {
        }
    }
}
