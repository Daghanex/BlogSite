﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageSevice
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public Message2 GetById(int id)
        {
             return _messageDal.GetById(id);
        }

        public List<Message2> GetInboxListByWriter(int p)
        {
            return _messageDal.GetListWithMessageByWriter(p);
        }
        public List<Message2> GetSendBoxListByWriter(int p)
        {
            return _messageDal.GetSendBoxListByWriter(p);
        }

        public List<Message2> GetList()
        {
            return _messageDal.GetListAll();
        }

        public void TAdd(Message2 t)
        {
            _messageDal.Insert(t);
        }

        public void TDelete(Message2 t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Message2 t)
        {
            throw new NotImplementedException();
        }
    }
}
