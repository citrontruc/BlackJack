/*
An interface to define an Asset.
*/

public interface Asset<T> : IDisposable
{
    public void Load(string assetName);
    public T GetAssetValue();
}
