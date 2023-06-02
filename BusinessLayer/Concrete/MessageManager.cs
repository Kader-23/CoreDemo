using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messsageDal;

        public MessageManager(IMessageDal messsageDal)
        {
            _messsageDal = messsageDal;
        }

        public List<Message> GetInboxListByWriter(string p)
        {
            return _messsageDal.GetListAll(x => x.Receiver==p);
           
        }

        public List<Message> GetList()
        {
            return _messsageDal.GetListAll();
        }

        public void TAdd(Message t)
        {
            _messsageDal.Insert(t);
        }

        public void TDelete(Message t)
        {
            _messsageDal.Delete(t);
        }

        public Message TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Message t)
        {
            _messsageDal.Update(t);
        }
    }
}
