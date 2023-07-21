using System;
using System.Collections.Generic;
using Mutagen.Bethesda.Assets;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Assets;
using Mutagen.Bethesda.Plugins.Records;
using Noggog;

namespace Mutagen.Bethesda;

public static class AssetLinkRemappingMixIn
{
    public static void Relink(this IAssetLink link, IReadOnlyDictionary<IAssetLinkGetter, string> mapping)
    {
        if (mapping.TryGetValue(link, out var replacement))
        {
            link.RawPath = replacement;
        }
    }

    private static TLinkType RelinkToNew<TLinkType, TAssetType>(this TLinkType link, IReadOnlyDictionary<IAssetLinkGetter, string> mapping)
        where TLinkType : IAssetLink<TLinkType, TAssetType>, new()
        where TAssetType : IAssetType
    {
        if (mapping.TryGetValue(link, out var replacement))
        {
            var clone = new TLinkType();
            clone.RawPath = replacement;
            return clone;
        }
        return link;
    }
    
    public static void RemapListedAssetLinks<TLinkType, TAssetType>(this IList<TLinkType> linkList, IReadOnlyDictionary<IAssetLinkGetter, string> mapping)
        where TLinkType : IAssetLink<TLinkType, TAssetType>, new()
        where TAssetType : IAssetType
    {
        for (int i = 0; i < linkList.Count; i++)
        {
            linkList[i] = linkList[i].RelinkToNew<TLinkType, TAssetType>(mapping);
        }
    }
    
    public static void RemapAssetLinks<TItem>(this IList<IAssetLinkContainer> linkList, IReadOnlyDictionary<IAssetLinkGetter, string> mapping, AssetLinkQuery query)
    {
        foreach (var item in linkList)
        {
            item.RemapAssetLinks(mapping, query);
        }
    }
    
    public static void RemapAssetLinks<TItem>(this IGenderedItemGetter<TItem?> gendered, IReadOnlyDictionary<IAssetLinkGetter, string> mapping, AssetLinkQuery query)
        where TItem : class, IAssetLinkContainer
    {
        gendered.Male?.RemapAssetLinks(mapping, query);
        gendered.Female?.RemapAssetLinks(mapping, query);
    }

    public static void RemapAssetLinks<TLinkType, TAssetType>(this IGenderedItem<TLinkType> gendered, IReadOnlyDictionary<IAssetLinkGetter, string> mapping)
        where TLinkType : IAssetLink<TLinkType, TAssetType>, new()
        where TAssetType : IAssetType
    {
        gendered.Male = gendered.Male.RelinkToNew<TLinkType, TAssetType>(mapping);
        gendered.Female = gendered.Female.RelinkToNew<TLinkType, TAssetType>(mapping);
    }

    public static void RemapAssetLinks<TMajorGetter>(this IReadOnlyCache<TMajorGetter, FormKey> cache, IReadOnlyDictionary<IAssetLinkGetter, string> mapping, AssetLinkQuery query)
        where TMajorGetter : class, IMajorRecordGetter, IAssetLinkContainer
    {
        foreach (var item in cache.Items)
        {
            item.RemapAssetLinks(mapping, query);
        }
    }
}