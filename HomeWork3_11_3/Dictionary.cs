namespace HomeWork3_11_3;

public class Dictionary<K, V> where K : notnull {
    private List<K> keys = new List<K>();
    private List<V> values = new List<V>();

    public void Add(K key, V value) {
        if (keys.Contains(key)) {
            throw new Exception("ключ вже існує в цій колекції");
        } else {
            keys.Add(key);
            values.Add(value);
        }
    }

    public V this[K key] {
        get {
            for (int i = 0; i < keys.Count; i++) {
                var k = keys[i];
                if (k.Equals(key)) {
                    return values[i];
                }
            }

            throw new Exception("ключ не знайдено в цій колекції");
        }
    }
    public int Count {
        get {
            return keys.Count;
        }
    }

}