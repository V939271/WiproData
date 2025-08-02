using System;
using System.Reflection;

// Define your custom attribute class here
// Complete Step 1:............
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property)]

public class InfoAttribute : Attribute
{
    public string Description { get; }
    public int Version { get; }

    public InfoAttribute(string description, int version)
    {
        Description = description;
        Version = version;
    }
}

// Example usage of the custom attribute
// Complete Step 2:............
[Info("This is a sample class.", 1)]
class SampleClass
{
    [Info("This is a sample property.", 3)]
    public string SampleProperty { get; set; }

    [Info("This is a sample method.", 2)]
    public void SampleMethod()
    {

    }
}

class Program
{
    static void Main(string[] args)
    {
        // Implement scenarios to demonstrate attribute usage
        // Complete Step 3:............
        Type type = typeof(SampleClass);

        InfoAttribute classAttr = (InfoAttribute)Attribute.GetCustomAttribute(type, typeof(InfoAttribute));
        if (classAttr != null)
        {
            Console.WriteLine($"Class Description: {classAttr.Description}, Version: {classAttr.Version}");
        }

        foreach (MethodInfo method in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
        {
            InfoAttribute methodAttr = (InfoAttribute)Attribute.GetCustomAttribute(method, typeof(InfoAttribute));
            if (methodAttr != null)
            {
                Console.WriteLine($"Method Description: {methodAttr.Description}, Version: {methodAttr.Version}");
            }
        }

        foreach (PropertyInfo prop in type.GetProperties())
        {
            InfoAttribute propAttr = (InfoAttribute)Attribute.GetCustomAttribute(prop, typeof(InfoAttribute));
            if (propAttr != null)
            {
                Console.WriteLine($"Property Description: {propAttr.Description}, Version: {propAttr.Version}");
            }
        }
    }
}