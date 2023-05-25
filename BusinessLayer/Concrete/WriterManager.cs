using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
  public class WriterManager:IWriterService
    {
        IWriterDal _writerdal;

        public WriterManager(IWriterDal writerdal)
        {
            _writerdal = writerdal;
        }

        public void WriterAdd(Writer writer)
        {
            _writerdal.Insert(writer);
        }

        public void WriterDelete(Writer writer)
        {

            _writerdal.Delete(writer);
        }

        public void WriterUpdate(Writer writer)
        {
            _writerdal.Update(writer);
        }

        public Writer GetById(int id)
        {
            return _writerdal.GetById(id);
        }

        public List<Writer> GetList()
        {
            return _writerdal.GetListAll();
        }

        public List<Writer> GetBlogListByWriter(int id)
        {
            throw new NotImplementedException();
        }
       
    }
}