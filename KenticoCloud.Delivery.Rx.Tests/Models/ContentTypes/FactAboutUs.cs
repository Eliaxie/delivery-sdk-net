// This code was generated by a kontent-generators-net tool 
// (see https://github.com/Kentico/kontent-generators-net).
// 
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated. 
// For further modifications of the class, create a separate file with the partial class.

using System.Collections.Generic;

namespace KenticoKontent.Delivery.Rx.Tests
{
    public partial class FactAboutUs
    {
        public const string Codename = "fact_about_us";
        public const string TitleCodename = "title";
        public const string DescriptionCodename = "description";
        public const string ImageCodename = "image";

        public string Title { get; set; }
        public string Description { get; set; }
        public IEnumerable<Asset> Image { get; set; }
        public ContentItemSystemAttributes System { get; set; }
    }
}