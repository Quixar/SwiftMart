using FluentEmail.Core;
using FluentEmail.Razor;
using FluentEmail.Smtp;
using System.Net.Mail;
using System.Text;
using System.Windows;

/// <summary>
/// Provides email sending functionality using FluentEmail.
/// Utilizes an SMTP client to send emails to users, including welcome emails after registration.
/// </summary>
namespace SwiftMart.EmailTools
{
    public class EmailService
    {

        /// <summary>
        /// Sends a welcome email to the user after registration.
        /// Utilizes the Gmail SMTP server and FluentEmail for email construction and sending.
        /// </summary>
        /// <param name="emailSend">The email address of the recipient.</param>
        /// <param name="name">The name of the recipient.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        /// <exception cref="Exception">Thrown if the email sending fails.</exception>
        public async Task Sender(string emailSend, string name)
        {
            try
            {
                var sender = new SmtpSender(() => new SmtpClient("smtp.gmail.com")
                {
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Port = 587,
                    Credentials = new System.Net.NetworkCredential("lmecomcompany@gmail.com", "mgspnfykrzjhwmmu")
                });

                Email.DefaultSender = sender;

                StringBuilder template = new StringBuilder();
                template.AppendLine($"Dear {name},");
                template.AppendLine("<p>Thank you for registering at SwiftMart. We hope you have a great shopping experience with us.</p>");
                template.AppendLine("- The SwiftMart Team");

                Email.DefaultRenderer = new RazorRenderer();

                var email = await Email
                    .From("lmecomcompany@gmail.com")
                    .To(emailSend, name)
                    .Subject("Welcome to SwiftMart!")
                    .UsingTemplate(template.ToString(), new { FirstName = name })
                    .SendAsync();

                if (!email.Successful)
                {
                    var errorMessages = string.Join("\n", email.ErrorMessages);
                    throw new Exception($"Email sending failed: {errorMessages}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in EmailService: {ex.Message}", ex);
            }
        }
    }
}
