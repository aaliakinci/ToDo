using AKNProje.ToDo.DAL.Interface;
using AKNProje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AKNProje.ToDo.DAL.Concrete.EntityFrameworkcore.Repositories
{
   public class EfAciliyetRepository:EfGenericRepository<Aciliyet>,IAciliyetDAL
    {
    }
}
