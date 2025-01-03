public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a disposed object
        using (var context = new MyDbContext())
        {
            // ... some database operations ...
        }

        // Trying to access context after it's disposed
        var data = context.MyTable.FirstOrDefault();
    }
}