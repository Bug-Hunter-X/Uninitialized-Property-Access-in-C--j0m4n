public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Solution: Initialize the property

    public void MyMethod()
    {
        // Now MyProperty is guaranteed to have a value
        int value = MyProperty * 2;
    }

    public void MyMethod2()
    {
        // Alternative solution using null-conditional operator (if MyProperty were a reference type)
        int value = MyProperty.HasValue ? MyProperty.Value * 2 : 0;
    }
    public void MyMethod3()
    {
        //Another alternative using pattern matching
        int value = MyProperty is 0 ? 0 : MyProperty * 2;
    }
}