using System;
using System.Collections.Generic;

[Serializable]
public class DictionaryUnity<K, V>

{
    public List<KeyValuePairUnity<K, V>> dictionary;
    public DictionaryUnity()
    {
        dictionary = new List<KeyValuePairUnity<K, V>>();
    }

    public V this[K key]
    {
        get
        {
            foreach (var pair in dictionary)
            {
                if (!pair.key.Equals(key)) continue;
                return pair.value;
            }

            return default(V);
        }
        set
        {
            foreach (var pair in dictionary)
            {
                if (!pair.key.Equals(key)) continue;
                pair.value = value;
                break;
            }
        }
    }
}
