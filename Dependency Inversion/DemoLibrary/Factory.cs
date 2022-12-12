using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Factory
    {
        public static IPerson CreatePerson(){
            return new Person();
        }

        public static ILogger CreateLoger(){
            return new Logger();
        }

        public static IMessageSender CreateMessager(){
            return new Emailer();
        }

        public static IChor CreateChor(){
            return new Chor(CreateLoger(), CreateMessager());
        }
    }
}