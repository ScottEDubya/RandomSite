namespace RandomSite.Core
{
    public interface ISerializationHelper
    {
        string GetStringFromObject(object toSerialize);
        TObjectType GetObjectFromString<TObjectType>(string text);
    }
}