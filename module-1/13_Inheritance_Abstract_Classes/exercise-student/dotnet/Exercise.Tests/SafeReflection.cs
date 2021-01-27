using System;
using System.Reflection;

public class SafeReflection
{
    public static Type GetType(string className, string @namespace = "")
    {
        Type retType = null;
        try
        {
            retType = Type.GetType(className);

            if (retType == null)
            {
                retType = Type.GetType($"{@namespace}.{className}, {@namespace}");
            }

            if (retType == null)
            {
                string thisNamespace = Assembly.GetExecutingAssembly().EntryPoint.DeclaringType.Namespace;
                retType = Type.GetType($"{thisNamespace}.{className}, {thisNamespace}");
            }
        }
        catch (Exception) { }

        return retType;
    }

    public static object CreateInstance(Type type, object[] parameters)
    {
        if (type == null) return null;
        try
        {
            return Activator.CreateInstance(type, parameters);
        }
        catch (Exception)
        {
            return null;
        }
    }

    public static bool HasConstructor(Type type, Type[] parameters)
    {
        if (type == null) return false;
        try
        {
            ConstructorInfo constructorInfo = type.GetConstructor(parameters);
            return constructorInfo != null;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public static bool HasMethod(Type type, string methodName)
    {
        if (type == null) return false;
        try
        {
            MethodInfo method = type.GetMethod(methodName);
            return method != null;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public static object InvokeMethod(object instance, string methodName, object[] parameters)
    {
        if (instance == null) return null;
        try
        {
            MethodInfo method = instance.GetType().GetMethod(methodName);
            return method.Invoke(instance, parameters);
        }
        catch (Exception)
        {
            return null;
        }
    }

    public static object GetPropertyValue(object instance, string propName)
    {
        if (instance == null) return null;
        object retVal = new object();
        foreach (PropertyInfo prop in GetProperties(instance.GetType()))
        {
            if (prop.Name == propName)
            {
                retVal = prop.GetValue(instance);
            }
        }
        return retVal;
    }

    public static void SetPropertyValue(object instance, string propName, object propValue)
    {
        if (instance == null) return;
        foreach (PropertyInfo prop in GetProperties(instance.GetType()))
        {
            if (prop.Name == propName && prop.CanWrite)
            {
                try
                {
                    prop.SetValue(instance, propValue);
                }
                catch (Exception) { }
            }
        }
    }

    private static PropertyInfo[] GetProperties(Type type)
    {
        return type.GetProperties();
    }
}
