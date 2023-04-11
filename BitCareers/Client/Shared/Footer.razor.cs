using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BitCareers.Client.Shared
{
    public partial class Footer
    {
        [Inject] IJSRuntime JsRuntime { get; set; }
        private async Task BackToTop()
        {
            await JsRuntime.InvokeVoidAsync("backToTop");
        }
    }
}
