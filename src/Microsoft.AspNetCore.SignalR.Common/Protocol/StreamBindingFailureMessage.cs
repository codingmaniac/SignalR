using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Text;

namespace Microsoft.AspNetCore.SignalR.Protocol
{
    public class StreamBindingFailureMessage : HubMessage
    {
        public string Id { get; }
        public string Target { get; }
        public ExceptionDispatchInfo BindingFailure { get; }
        public StreamBindingFailureMessage(string id, string target, ExceptionDispatchInfo bindingFailure)
        {
            Id = id;
            Target = target;
            BindingFailure = bindingFailure;
        }


    }
}
