using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Domain;
using ServicesPattern;
using Data.Infrastructure;

namespace ServiceSpecifique
{
    public class ServiceMessage : Service<Message>, IMessageSpecifique
    {
        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork uof = new UnitOfWork(dbf);
        public ServiceMessage():base(uof)
        {

        }
        public IEnumerable<Message> getMessageBySender(User u)
        {
            return GetMany(M => M.Sender == u);

        }
        public IEnumerable<Message> getMessageByReceiver(User u)
        {
            return GetMany(M => M.Receiver == u);

        }
        public IEnumerable<Message> getMessageBySeenByuser(User u)
        {
            return GetMany(M => M.Receiver == u && M.Seen==true);

        }
        public IEnumerable<Message> getMessageByUnSeenByuser(User u)
        {
            return GetMany(M => M.Receiver == u && M.Seen == false);

        }

        




    }
}
