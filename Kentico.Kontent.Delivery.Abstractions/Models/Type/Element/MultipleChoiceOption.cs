﻿using Newtonsoft.Json;

namespace Kentico.Kontent.Delivery
{
    /// <summary>
    /// Represents an option of a Multiple choice content element.
    /// </summary>
    public sealed class MultipleChoiceOption
    {
        /// <summary>
        /// Gets the name of the option.
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
        }

        /// <summary>
        /// Gets the codename of the option.
        /// </summary>
        [JsonProperty("codename")]
        public string Codename
        {
            get;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipleChoiceOption"/> class with the specified JSON data.
        /// </summary>
        /// <param name="name">Name of the option.</param>
        /// <param name="codename">Code name of the option.</param>
        [JsonConstructor]
        internal MultipleChoiceOption(string name, string codename)
        {
            Name = name;
            Codename = codename;
        }
    }
}
