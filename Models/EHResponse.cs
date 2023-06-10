using System.Reflection;

namespace EndpointHelper.Models
{
    public class EHResponse
    {
        public Type? Type { get; set; }
        public bool IsGeneric { get; set; }
        public bool IsNullable { get; set; }
        public bool IsString { get; set; }
        public bool IsClass { get; set; }
        public bool IsModel { get; set; }
        public bool IsException { get; set; }

        public IEnumerable<PropertyInfo>? Properties => Type?.GetProperties();
        public string? Name
        {
            get
            {
                if (Type is not null)
                {
                    if (IsGeneric)
                    {
                        if (IsNullable)
                            return $"{Type.Name}?";
                        return $"{Type.Name}[]";
                    }
                    return Type.Name;
                }
                return default;
            }
        }

        public EHResponse(Type? typeOfObject)
        {
            if (typeOfObject is not null)
            {
                IsGeneric = typeOfObject.IsGenericType;
                Type = IsGeneric ? typeOfObject.GetGenericArguments().First() : typeOfObject;
                IsNullable = IsNullableType(typeOfObject);
                IsString = IsStringType(typeOfObject);
                IsClass = typeOfObject.IsClass && !IsString;
                IsModel = IsClass && !IsNullable;
            }
        }
        private bool IsStringType(Type typeOfObject)
        {
            return typeOfObject.FullName.ToLower().Contains("string");
        }
        private bool IsNullableType(Type typeOfObject)
        {
            return typeOfObject.FullName.ToLower().Contains("nullable");
        }
    }
}