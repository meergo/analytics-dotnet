using System;

namespace Meergo.Model
{
    /// <summary>
    /// Providers is a context object that helps specify which providers this action should go to.
    /// </summary>
    public class Providers : Dict
    {
        public Providers ()
        {
        }

        /// <summary>
        /// Allows you to specify whether by default every provider is enabled, or none are. Useful for disabling
        /// every provider except for a few specified ones.
        /// </summary>
        /// <param name="enabled">If set to <c>false</c>, then every provider is disabled by default unless otherwise specified.
        /// True is default.</param>
        /// <returns>The Providers object for chaining.</returns>
        public Providers SetDefault(bool enabled) {
            this.Add ("all", enabled);
            return this;
        }

        /// <summary>
        /// Specifies whether this provider is enabled or disabled.
        /// </summary>
        /// <param name="providerName">The provider name.
        /// <param name="enabled">True for enabled, false for disabled.</param>
        /// <returns>The Providers object for chaining.</returns>
        public Providers SetEnabled(string providerName, bool enabled) {
            this.Add (providerName, enabled);
            return this;
        }

    }
}
