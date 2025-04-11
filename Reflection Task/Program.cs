using System;
using System.Reflection;
namespace Reflection_Task;

internal class Program
{
    static void Main(string[] args)
    {
        Type userType = typeof(User);

      User user = new User();
        FieldInfo idField = userType.GetField("id" , BindingFlags.NonPublic | BindingFlags.Instance);
        FieldInfo nameField = userType.GetField("name" , BindingFlags.NonPublic | BindingFlags.Instance);
        FieldInfo surnameField = userType.GetField("surname", BindingFlags.NonPublic | BindingFlags.Instance);
        FieldInfo ageField = userType.GetField("age" , BindingFlags.NonPublic | BindingFlags.Static);

        idField.SetValue(user, 5);
        nameField.SetValue(user, "Aysun");
        surnameField.SetValue(user, "Mahmudlu");
        ageField.SetValue(null, 19);

        Console.WriteLine($" id : {idField.GetValue(user)}");
        Console.WriteLine($"name : {nameField.GetValue(user)}");
        Console.WriteLine($" surname : {surnameField.GetValue(user)}");
        Console.WriteLine($"age : {ageField.GetValue(null)}");

        MethodInfo GetFullNameMethod = userType.GetMethod("GetFullName" , BindingFlags.Public | BindingFlags.Instance);
        GetFullNameMethod.Invoke(user, null);

        MethodInfo ChangeAgeMethod = userType.GetMethod("ChangeAge" , BindingFlags.Public| BindingFlags.Static);
        ChangeAgeMethod.Invoke(null, [24]);

        

    }
}
