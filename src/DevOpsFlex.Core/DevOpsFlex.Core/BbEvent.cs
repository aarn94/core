﻿namespace DevOpsFlex.Core
{
    /// <summary>
    /// Base class for all events pushed by the telemetry platform. Can't be inherited directly but is base
    /// to all the classes that you can inherit from.
    /// </summary>
    public class BbEvent
    {
        /// <summary>
        /// Stores the internal correlation vector.
        /// </summary>
        internal string CorrelationVector { get; set; }

        /// <summary>
        /// Internally initializes an instance of <see cref="BbEvent"/>.
        /// </summary>
        internal BbEvent() { }
    }
}
