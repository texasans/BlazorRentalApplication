using System;
using System.Collections.Generic;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.TwiML.Messaging;
using Twilio.Types;

namespace BlazorApp1.Services
{
    public class TextMessage
    {
        public string phoneNumberTo { get; set; }
        public string phoneNumberFrom { get; set; } = "+18324029085";
        public string myMessage { get; set; }
        public void send(string phoneNumberTo, string phoneNumberFrom, string myMessage)
        {
            var accountSid = "ACea0585cbd61988ebdce5637614048a0b";
            var authToken = "21ad421d53ca1a61dd125db55ee03e1a";

            //var authToken = "fa9d8f9cfe0cbddff5c0b7029e25dd6e";

            TwilioClient.Init(accountSid, authToken);
            var messageOptions = new CreateMessageOptions(
              new PhoneNumber(phoneNumberTo));
            messageOptions.From = new PhoneNumber(phoneNumberFrom);
            messageOptions.Body = myMessage;
            try {
                var message = MessageResource.Create(messageOptions);
                Console.WriteLine(message.Body);
            }
            catch (Exception e) {
                throw;
            }
        }
    }
}
