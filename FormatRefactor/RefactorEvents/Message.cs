namespace Events
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Events;

    public static class Message
    {
        private static StringBuilder output = new StringBuilder();

        public static StringBuilder Output { get; set; }

        public static void EventAdded()
        {
            output.Append("Event added" + Environment.NewLine);
        }

        public static void EventDeleted(int count)
        {
            if (count == 0)
            {
                NoEventsFound();
            }
            else
            {
                output.AppendFormat("{0} events deleted {1}", count, Environment.NewLine);
            }
        }

        public static void NoEventsFound()
        {
            output.Append("No events found" + Environment.NewLine);
        }

        public static void PrintEvent(Event eventToPrint)
        {
            if (eventToPrint != null)
            {
                output.Append(eventToPrint + Environment.NewLine);
            }
        }
    }
}
