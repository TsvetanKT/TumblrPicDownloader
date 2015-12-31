namespace TumblrPicDownloader
{
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    public static class ConcurrentDictionaryExtended
    {
        public static bool Remove<TKey, TValue>(
          this ConcurrentDictionary<TKey, TValue> self, TKey key)
        {
            return ((IDictionary<TKey, TValue>)self).Remove(key);
        }
    }
}
