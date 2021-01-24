using MyApp.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace MyApp.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class MyAppPageModel : AbpPageModel
    {
        protected MyAppPageModel()
        {
            LocalizationResourceType = typeof(MyAppResource);
        }
    }
}