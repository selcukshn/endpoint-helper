using EndpointHelper.Models;
using Microsoft.AspNetCore.Components;

namespace EndpointHelper.Components.Request.Base
{
    public class EHRequest : ComponentBase
    {
        [CascadingParameter] public string? BaseAddress { get; set; }
        [Parameter] public string? RequestName { get; set; }
        [Parameter] public string? Endpoint { get; set; }
        [Parameter] public IEnumerable<EHParameter>? Parameters { get; set; }
        [Parameter] public Type? Body { get; set; }
        [Parameter] public Type? IsSuccess { get; set; }
        [Parameter] public Type? IsWarning { get; set; }
        [Parameter] public Type? IsError { get; set; }
    }
}