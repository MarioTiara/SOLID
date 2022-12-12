using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoLibrary
{

    public class Chor : IChor
    {
        private readonly ILogger _logger;
        private readonly IMessageSender _messagesender;
        public string ChoreName { get; set; }
        public IPerson Owner { get; set; }
        public double HoursWorked { get; private set; }
        public bool IsComplete { get; private set; }

        public Chor(ILogger logger, IMessageSender messageSender)
        {
            _logger = logger;
            _messagesender = messageSender;
        }
        public void Performance(double hours)
        {
            HoursWorked += hours;
            _logger.Log($"Performed work on {ChoreName}");
        }

        public void CompleteChor()
        {
            IsComplete = true;

            _logger.Log($"Completed {ChoreName}");
            _messagesender.SendEmail(Owner, $"The Chore {ChoreName} is complete");
        }
    }
}