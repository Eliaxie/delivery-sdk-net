﻿using System;
using System.Collections.Generic;
using Kentico.Kontent.Delivery.ContentItems;
using Kentico.Kontent.Delivery.ContentTypes.Element;
using Kentico.Kontent.Delivery.TaxonomyGroups;

namespace Kentico.Kontent.Delivery.Tests.Models
{
    public class CompleteContentItemModel
    {
        public string TextField { get; set; }
        public string RichTextField { get; set; }
        public decimal? NumberField { get; set; }
        public IEnumerable<MultipleChoiceOption> MultipleChoiceFieldAsRadioButtons { get; set; }
        public IEnumerable<MultipleChoiceOption> MultipleChoiceFieldAsCheckboxes { get; set; }
        public DateTime? DateTimeField { get; set; }
        public IEnumerable<Asset> AssetField { get; set; }
        public IEnumerable<Homepage> LinkedItemsField { get; set; }
        public IEnumerable<TaxonomyTerm> CompleteTypeTaxonomy { get; set; }
        public string CustomElementField { get; set; }
        public ContentItemSystemAttributes System { get; set; }
    }
}