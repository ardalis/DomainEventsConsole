using DomainEventsConsole.Model;
using MediatR;
using System;

namespace DomainEventsConsole.Events
{
    public class AppointmentCreated : INotification
    {
        public Appointment Appointment { get; set; }
        public System.DateTime DateOccurred { get; private set; }

        public AppointmentCreated(Appointment appointment, DateTime dateCreated)
        {
            this.Appointment = appointment;
            this.DateOccurred = dateCreated;
        }

        public AppointmentCreated(Appointment appointment) : this(appointment, DateTime.Now)
        {
        }
    }
}