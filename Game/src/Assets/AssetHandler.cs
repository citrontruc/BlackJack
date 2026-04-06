/*
An interface to load Assets and Store them
*/

using BlackJack.Utils.Errors;

namespace BlackJack.Assets;

public interface IAssetHandler<T>
{
    public Result LoadAsset(string assetName);
    public Result StoreAsset(string assetName, IAsset<T> asset);
    public IAsset<T> Get(string assetName);
}
