/*
An interface to define an Asset.
*/

namespace BlackJack.Assets;

public interface IAsset<T> : IDisposable
{
    public void Load(string assetName);
    public T GetAssetValue();
}