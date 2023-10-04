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
