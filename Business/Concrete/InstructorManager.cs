using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class InstructorManager : IGenericService<Instructor>
    {
        private readonly IGenericDal<Instructor> _instrucotDal;

        public InstructorManager(IGenericDal<Instructor> instrucotDal)
        {
            _instrucotDal = instrucotDal;
        }

        public void Add(Instructor item)
        {
            _instrucotDal.Add(item);
        }

        public List<Instructor> GetAll()
        {
            return _instrucotDal.GetAll();
        }

        public Instructor GetByID(int id)
        {
           return _instrucotDal.GetByID(id);
        }

        public void Remove(Instructor item)
        {
            _instrucotDal.Remove(item);
        }

        public void Update(Instructor item)
        {
            _instrucotDal.Update(item);
        }
    }
}
