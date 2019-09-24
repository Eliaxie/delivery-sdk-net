﻿namespace Kentico.Kontent.Delivery.InlineContentItems
{
    internal class ReplaceWithWarningAboutUnknownItemResolver : IInlineContentItemsResolver<UnknownContentItem>
    {
        public string Resolve(UnknownContentItem item)
            => $"Content type '{item.Type}' has no corresponding model.";
    }
}
