using Core.DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
   public interface ICategoryDal:IEntityRepository<Category>
    {
        
    }
    //List<Category> GetAll( );
    //void Add(Category category);
    //void Delete(Category category);
    //void Update(Category category);
}
