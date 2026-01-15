/*
An interface to load Assets and Store them
*/

public interface AssetHandler<T>
{
    public Result LoadAsset(string assetName);
    public Result StoreAsset(string assetName, Asset<T> asset);
    public Asset<T> Get(string assetName);
}
