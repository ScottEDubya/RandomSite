using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RandomSite.Core
{
    public class JSONSerializationHelper : ISerializationHelper
    {
        public string GetStringFromObject(object toSerialize)
        {
            if (toSerialize == null)
            {
                throw new ArgumentNullException(nameof(toSerialize));
            }

            var serialized = JsonConvert.SerializeObject(toSerialize);

            return serialized;
        }

        public TObjectType GetObjectFromString<TObjectType>(string json)
        {
            if (string.IsNullOrWhiteSpace(json))
            {
                throw new ArgumentNullException(nameof(json));
            }

            var deserialized = JsonConvert.DeserializeObject<TObjectType>(json);

            return deserialized;
        }

        public bool IsJSONObject(string json)
        {
            var deserialized = JsonConvert.DeserializeObject<JObject>(json);

            return deserialized != null;
        }

    }
}
