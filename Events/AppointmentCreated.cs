using DomainEventsConsole.Interfaces;
using DomainEventsConsole.Model;
using System;

namespace DomainEventsConsole.Events
{
    public class AppointmentCreated : IDomainEvent
    {
        public Appointment Appointment { get; set; }
        public DateTime DateOccurred { get; private set; }

        public AppointmentCreated(Appointment appointment, DateTime dateCreated)
        {
            Appointment = appointment;
            DateOccurred = dateCreated;
        }

        public AppointmentCreated(Appointment appointment) : this(appointment, DateTime.Now)
        {
        }
    }
}