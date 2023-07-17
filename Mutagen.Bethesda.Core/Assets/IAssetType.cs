﻿using System.Reflection;
using Mutagen.Bethesda.Plugins.Assets;
using Noggog;
namespace Mutagen.Bethesda.Assets;

/// <summary>
/// File types that can be associated with Asset type
/// </summary>
public interface IAssetType
{
#if NET7_0_OR_GREATER
    static virtual IAssetType Instance => null!;
#endif

    /// <summary>
    /// Base folder(s) relative to the game's data directory
    /// </summary>
    string BaseFolder { get; }

    /// <summary>
    /// File extension this asset type is associated with
    /// </summary>
    IEnumerable<string> FileExtensions { get; }

    private static readonly Dictionary<GameCategory, Dictionary<string,Dictionary<string,IAssetType>>> Types;

    static IAssetType()
    {
        Types = new Dictionary<GameCategory, Dictionary<string,Dictionary<string,IAssetType>>>();

        var assetTypeType = typeof(IAssetType);
        foreach (var type in assetTypeType.GetInheritingFromInterface())
        {
            if (type.Namespace == null) continue;

            GameCategory gameCategory;
            switch (type.Namespace.TrimStart("Mutagen.Bethesda.")) {
                case "Oblivion.Assets":
                    gameCategory = GameCategory.Oblivion;
                    break;
                case "Skyrim.Assets":
                    gameCategory = GameCategory.Skyrim;
                    break;
                case "Fallout4.Assets":
                    gameCategory = GameCategory.Fallout4;
                    break;
                default:
                    continue;
            }

            var instanceProperty = type.GetProperty("Instance", BindingFlags.Public | BindingFlags.Static);
            if (instanceProperty?.GetValue(null) is not IAssetType assetType) continue;

            var gameTypes = Types.GetOrAdd(gameCategory);
            foreach (var extension in assetType.FileExtensions)
            {
                var baseFolders = gameTypes.GetOrAdd(extension, () => new Dictionary<string, IAssetType>());
                baseFolders.TryAdd(assetType.BaseFolder, assetType);
            }
        }
    }

    /// <summary>
    /// Parse asset type by game release and path
    /// </summary>
    /// <param name="gameCategory">Release of the game this asset comes from</param>
    /// <param name="path">Path of the asset</param>
    /// <returns>Instance of the parsed asset type or null if no asset type could be determined</returns>
    public static IAssetType? GetAssetType(GameCategory gameCategory, string path)
    {
        // Get dictionary for game category
        if (!Types.TryGetValue(gameCategory, out var gameTypes)) return null;

        // Get dictionary for file extension
        if (!gameTypes.TryGetValue(Path.GetExtension(path), out var folders)) return null;

        // Get asset type from base folder
        var dataRelativePath = AssetLink.ConvertToDataRelativePath(path);
        foreach (var (baseFolder, assetType) in folders)
        {
            if (dataRelativePath.StartsWith(baseFolder, AssetLink.PathComparison))
            {
                return assetType;
            }
        }

        return null;
    }
}