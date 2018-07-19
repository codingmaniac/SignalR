// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.SignalR.Protocol
{
    public class StreamDataMessage : HubMessage
    {
        public object Item { get; }
        public string StreamId { get; }

        public StreamDataMessage(string streamId, object item)
        {
            StreamId = streamId;
            Item = item;
        }

        public override string ToString()
        {
            return $"StreamDataMessage {{ {nameof(StreamId)}: \"{StreamId}\", {nameof(Item)}: {Item ?? "<<null>>"} }}";
        }
    }
}
