using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http.Filters;
using Newtonsoft.Json.Serialization;

public class CamelCasedMethodAttribute : ActionFilterAttribute
{
    private static JsonMediaTypeFormatter _camelCasingFormatter = new JsonMediaTypeFormatter();

    static CamelCasedMethodAttribute()
    {
        _camelCasingFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
    }

    public override void OnActionExecuted(HttpActionExecutedContext httpActionExecutedContext)
    {
        var objectContent = httpActionExecutedContext.Response.Content as ObjectContent;
        if (objectContent != null)
        {
            if (objectContent.Formatter is JsonMediaTypeFormatter)
            {
                httpActionExecutedContext.Response.Content = new ObjectContent(objectContent.ObjectType, objectContent.Value, _camelCasingFormatter);
            }
        }
    }
}