﻿using System.Reflection;
using Newtonsoft.Json.Linq;

namespace Kentico.Kontent.Delivery.Abstractions
{
    /// <summary>
    /// Provides value conversion for the given property
    /// </summary>
    public interface IPropertyValueConverter
    {
        /// <summary>
        /// Gets the property value from property data
        /// </summary>
        /// <param name="property">Property info</param>
        /// <param name="elementData">Source element data</param>
        /// <param name="context">Context of the current resolving process</param>
        object GetPropertyValue(PropertyInfo property, JToken elementData, ResolvingContext context);
    }
}
