namespace HomeWork3_11_4; 
public  class ArrayList {
    private List<object> list = new List<object>();
    
    public void Add(object ob) {
        list.Add(ob);
    }
    public void Clear() { 
        list.Clear();
    }
    public void Remove(object ob) {
        list.Remove(ob);
    }
    
}
