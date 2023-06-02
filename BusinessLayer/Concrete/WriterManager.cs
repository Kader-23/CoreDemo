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

        public List<Writer> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetWriterById(int id)
        {


            return _writerdal.GetListAll(x => x.WriterId == id);
        }

        public void TAdd(Writer t)
        {
            _writerdal.Insert(t);
        }

        public void TDelete(Writer t)
        {
            _writerdal.Delete(t);
        }

        public Writer TGetById(int id)
        {
           return _writerdal.GetByID(id);
        }

        public void TUpdate(Writer t)
        {
            _writerdal.Update(t);
        }

       

        ////public void WriterAdd(Writer writer)
        ////{
        ////    _writerdal.Insert(writer);
        ////}

        ////public void WriterDelete(Writer writer)
        ////{

        ////    _writerdal.Delete(writer);
        ////}

        ////public void WriterUpdate(Writer writer)
        ////{
        ////    _writerdal.Update(writer);
        ////}

        //public Writer GetById(int id)
        //{
        //    return _writerdal.GetByID(id);
        //}

        //public List<Writer> GetList()
        //{
        //    return _writerdal.GetListAll();
        //}

        //public List<Writer> GetBlogListByWriter(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public void TAdd(Writer t)
        //{
        //    _writerdal.Insert(t);
        //}

        //public void TDelete(Writer t)
        //{
        //    _writerdal.Delete(t);
        //}

        //public void TUpdate(Writer t)
        //{
        //    _writerdal.Update(t);
        //}

        //public Writer TGetById(int id)
        //{
        //    throw new NotImplementedException();
        //}

        ////public void WriterAdd(Writer writer)
        ////{
        ////    throw new NotImplementedException();
        ////}
    }
}