﻿using Newtonsoft.Json.Linq;

namespace Kentico.Kontent.Delivery.Abstractions
{
    /// <summary>
    /// Defines the contract for mapping content items to models.
    /// </summary>
    public interface IModelProvider
    {
        /// <summary>
        /// Builds a model based on given JSON input.
        /// </summary>
        /// <typeparam name="T">Strongly typed content item model.</typeparam>
        /// <param name="item">Content item data.</param>
        /// <param name="linkedItems">Linked items.</param>
        /// <returns>Strongly typed POCO model of the generic type.</returns>
        T GetContentItemModel<T>(JToken item, JToken linkedItems);
    }
}