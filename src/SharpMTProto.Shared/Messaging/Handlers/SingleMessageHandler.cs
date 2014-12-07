﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SingleMessageHandler.cs">
//   Copyright (c) 2013-2014 Alexander Logger. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace SharpMTProto.Messaging.Handlers
{
    using System;
    using System.Collections.Immutable;
    using Schema;

    public abstract class SingleMessageHandler<TMessage> : MessageHandler where TMessage : class
    {
        private static readonly ImmutableArray<Type> MessageTypesInternal = ImmutableArray.Create(typeof (TMessage));

        public override bool CanHandle(IMessage message)
        {
            return message.Body is TMessage;
        }

        public override ImmutableArray<Type> MessageTypes
        {
            get { return MessageTypesInternal; }
        }
    }
}
