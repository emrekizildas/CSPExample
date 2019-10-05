using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CSPExample.Helper
{
    public static class NonceHelper
    {
        public static HtmlString Nonce(this IHtmlHelper helper)
        {
            string nonceValue = helper.ViewContext.HttpContext.Items["ScriptNonce"].ToString();
            return new HtmlString(nonceValue);
        }
    }
}
