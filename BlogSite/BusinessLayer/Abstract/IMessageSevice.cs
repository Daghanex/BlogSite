﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMessageSevice:IGenericService<Message2>
    {
        List<Message2> GetInboxListByWriter(int p);
    }
}
