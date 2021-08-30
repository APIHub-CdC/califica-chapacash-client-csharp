using Newtonsoft.Json.Converters;

namespace IO.CalificaChapacashCsharp.Client
{
    public class RCCPMDateConverter : IsoDateTimeConverter
    {
        public RCCPMDateConverter()
        {
            DateTimeFormat = "yyyy-MM-dd";
        }
    }
}
