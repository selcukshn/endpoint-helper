namespace EndpointHelper.Models
{
    public class EHParameter
    {

        public string ParameterName { get; set; }
        public Type ParameterType { get; set; }
        public bool Required { get; set; }
        public EHParameter(string parameterName, Type parameterType, bool required = false)
        {
            ParameterName = parameterName;
            ParameterType = parameterType;
            Required = required;
        }
    }
}