﻿namespace Eshopworld.Core
{
    using System.Collections.Generic;
    using JetBrains.Annotations;
    using Newtonsoft.Json;

    /// <summary>
    /// The base class from all BigBrother anonymous class based events that are going to be
    /// tracked by AI as Telemetry Events.
    /// </summary>
    internal class AnonymousTelemetryEvent : TelemetryEvent
    {
        /// <summary>
        /// Initializes a new instance of <see cref="AnonymousTelemetryEvent"/>.
        /// </summary>
        /// <param name="payload"></param>
        internal AnonymousTelemetryEvent([NotNull] object payload)
        {
            Payload = payload;
        }

        /// <summary>
        /// Gets and sets the anonymous class as an <see cref="object"/> that originated this event.
        /// </summary>
        [JsonIgnore]
        [NotNull] internal object Payload { get; }

        /// <summary>
        /// Always returns true since this is indeed an anonymous event.
        /// </summary>
        public bool IsAnonymous => true;

        /// <summary>
        /// Converts the anonymous payload to a <see cref="IDictionary{TKey,TValue}"/> by using JSonConvert twice (both directions).
        /// </summary>
        /// <returns>The converted <see cref="IDictionary{String, String}"/>.</returns>
        internal override IDictionary<string, string> ToStringDictionary()
        {
            return ToUnionStringDictionary(Payload);
        }
    }
}
