public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a disposed object is avoided
        using (var context = new MyDbContext())
        {
            // All database operations are performed within the 'using' block
            var data = context.MyTable.FirstOrDefault();
            // ... other database operations ...
        }
    }
}