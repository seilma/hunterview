using Domain;
using ServicesPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceSpecifique
{
    public interface IMessageSpecifique:IService<Message>
    {
    }
}
