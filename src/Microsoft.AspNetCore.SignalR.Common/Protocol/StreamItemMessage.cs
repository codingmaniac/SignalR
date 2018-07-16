// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.SignalR.Protocol
{
    public class StreamItemMessage : HubInvocationMessage
    {
        public object Item { get; }

        public StreamItemMessage(string invocationId, object item) : base(invocationId)
        {
            Item = item;
        }

        public override string ToString()
        {
            return $"StreamItem {{ {nameof(InvocationId)}: \"{InvocationId}\", {nameof(Item)}: {Item ?? "<<null>>"} }}";
        }
    }

    public class ParamStreamMessage : HubMessage
    {
        public object Item { get; }
        public string StreamId { get; }

        public ParamStreamMessage(string streamId, object item)
        {
            StreamId = streamId;
            Item = item;
        }

        public override string ToString()
        {
            return $"StreamItemTwo {{ {nameof(StreamId)}: \"{StreamId}\", {nameof(Item)}: {Item ?? "<<null>>"} }}";
        }
    }
}
