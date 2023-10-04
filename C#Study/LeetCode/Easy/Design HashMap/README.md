# Intuition
My first approach was to make MyHashMap similar to an indexer.

# Approach
Since keys and values are all integers, I just needed to declare an integer array. However, to handle initialization, I declared it as an int? (nullable integer) array, which is initially initialized as null.
Additionally, even though the problem gave a range for keys and values (0 <= key, value <= 10^6), I added the `Array.Resize` code to avoid an Index out of boundary error.

# Complexity
- Time complexity: $$O(1)$$ (If the array was resized, $$O(n)$$)

- Space complexity: $$O(1)$$

# Code
```
public class MyHashMap
{
    private int?[] array;

    public MyHashMap()
    {
        array = new int?[1000001];
    }
    
    public void Put(int key, int value)
    {
        if (key >= array.Length){
            Array.Resize<int?>(ref array, key+1);
        }
        array[key] = value;
    }
    
    public int Get(int key)
    {
        return (array[key] ?? -1);
    }
    
    public void Remove(int key)
    {
        array[key] = null;
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */
```

# Code Before
```
public class MyHashMap {

    private int[] array;

    public MyHashMap() {
        array = new int[1000001];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = -1;
        }
    }
    
    public void Put(int key, int value) {
        array[key] = value;
    }
    
    public int Get(int key) {
        return array[key];
    }
    
    public void Remove(int key) {
        array[key] = -1;
    }
}
```
If I declare an array with the data type of int, the initial data will be 0, so I had to set all 0s to -1.
