using System;
using System.Collections.Concurrent;
using System.Linq;

namespace Specs.Util
{
    public static class ReflectionUtil
    {
        private static readonly ConcurrentDictionary<string, Type> typeByNameCache = new ConcurrentDictionary<string, Type>();

        public static Type GetTypeByName(string typeName)
        {
            string systemTypeName;
            if (typeName == "int")
            {
                systemTypeName = "Int32";
            }
            else if (typeName == "bool")
            {
                systemTypeName = "Boolean";
            }
            else
            {
                systemTypeName = typeName[0].ToString().ToUpperInvariant() + typeName.Substring(1);
            }

            Type type;
            if (typeByNameCache.TryGetValue(systemTypeName, out type))
            {
                return type;
            }

            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                type = assembly.GetTypes().FirstOrDefault(t => t.Name == systemTypeName);
                if (type != null)
                {
                    typeByNameCache.TryAdd(systemTypeName, type);
                    return type;
                }
            }

            throw new ArgumentException("Type " + systemTypeName + " couldn't be found.", "propertyTypeName");
        }
    }
}
