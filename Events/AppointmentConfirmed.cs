using DomainEventsConsole.Interfaces;
using DomainEventsConsole.Model;
using System;

namespace DomainEventsConsole.Events
{
    public class AppointmentConfirmed : IDomainEvent
    {
        public Appointment Appointment { get; set; }
        public DateTime DateOccurred { get; private set; }

        public AppointmentConfirmed(Appointment appointment, DateTime dateConfirmed)
        {
            Appointment = appointment;
            DateOccurred = dateConfirmed;
        }
        public AppointmentConfirmed(Appointment appointment) : this(appointment, DateTime.Now)
        {
        }
    }
}