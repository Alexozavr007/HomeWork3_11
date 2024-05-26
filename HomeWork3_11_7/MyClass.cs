namespace HomeWork3_11_7; 

public class MyClass<T> where T : new() {
    
    public static T FacrotyMethod() {
        return new T();
    }

}
