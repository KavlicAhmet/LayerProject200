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
    public class EfAboutDal : GenericRepository<About>, IAboutDal
    {
        public EfAboutDal(ProjectContext context) : base(context)
        {
        }
    }
}
