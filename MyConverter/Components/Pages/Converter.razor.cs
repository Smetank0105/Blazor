using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace MyConverter.Components.Pages
{
    public partial class Converter
    {
        string left { get; set; } = "";
        string right { get; set; } = "";
        int from_base { get; set; } = 10;
        int to_base { get; set; } = 10;
        void ConvertToBaseFromBase()
        {
            try
            {
                long temp = Convert.ToInt64(left, from_base);
                right = Convert.ToString(temp, to_base);
            }
            catch (Exception ex) { }
        }
    }
}
