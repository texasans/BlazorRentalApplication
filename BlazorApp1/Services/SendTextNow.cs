using System;
using System.Collections.Generic;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
class Example
{
    static void Main(string[] args)
    {
        var accountSid = "ACea0585cbd61988ebdce5637614048a0b";
        var authToken = "fa9d8f9cfe0cbddff5c0b7029e25dd6e";
        TwilioClient.Init(accountSid, authToken);
        var messageOptions = new CreateMessageOptions(
          new PhoneNumber("+18328937816"));
        messageOptions.From = new PhoneNumber("+18324029085");
        messageOptions.Body = "habla falsito millonario futuro millonario ";
        var message = MessageResource.Create(messageOptions);
        Console.WriteLine(message.Body);
    }
}