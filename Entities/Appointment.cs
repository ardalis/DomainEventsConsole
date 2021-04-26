using DomainEventsConsole.Events;
using DomainEventsConsole.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;

namespace DomainEventsConsole.Model
{
    public class Appointment : IEntity
    {
        public Guid Id { get; private set; }
        public string EmailAddress { get; private set; }
        public DateTime? ConfirmationReceivedDate { get; private set; }

        public List<INotification> Events { get; set; } = new List<INotification>();
        protected Appointment() : this(Guid.NewGuid())
        {
        }

        public Appointment(Guid id)
        {
            this.Id = id;
        }

        public static Appointment Create(string emailAddress)
        {
            Console.WriteLine("Appointment::Create()");

            var appointment = new Appointment();
            appointment.EmailAddress = emailAddress;

            // send an email - pretend there's 5-10 lines of code here to send an email
            // example:
            // using var client = new SmtpClient(_config.Hostname, _config.Port);
            // var mailMessage = new MailMessage();
            // mailMessage.To.Add(to);
            // mailMessage.From = new MailAddress(from);
            // mailMessage.Subject = subject;
            // mailMessage.IsBodyHtml = true;
            // mailMessage.Body = body;
            // client.Send(mailMessage);
            Console.WriteLine("Notification email sent to {0}", emailAddress);

            // update the user interface
            // pretend some code here pops up a notification in the UI
            // or sends a message via Blazor
            // Example:
            // string message = $"User {emailAddress} created an appointment.";
            // await HubContext.Clients.All.SendAsync("ReceiveMessage", message); 
            Console.WriteLine("User Interface informed appointment created for {0}", emailAddress);

            return appointment;
        }








        public void Confirm(DateTime dateConfirmed)
        {
            ConfirmationReceivedDate = dateConfirmed;


            Console.WriteLine("[UI] User Interface informed appointment for {0} confirmed at {1}",
                            EmailAddress,
                            ConfirmationReceivedDate.ToString());
        }
    }
}
