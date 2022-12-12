using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public interface IMessageSender
    {
        void SendEmail(IPerson person, string message);
    }
}