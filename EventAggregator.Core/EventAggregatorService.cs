using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Events;

namespace EventAggregator.Core
{
    public static class EventAggregatorService
    {
        private static Prism.Events.EventAggregator _eventAggregatorService;

        private static readonly object _syncRoot = new object();

        public static Prism.Events.EventAggregator EventService
        {
            get
            {
                lock (_syncRoot)
                {
                    return _eventAggregatorService ?? (_eventAggregatorService = new Prism.Events.EventAggregator());
                }
            }
        }
    }
}
