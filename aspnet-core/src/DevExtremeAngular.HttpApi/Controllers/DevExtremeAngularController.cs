using DevExtremeAngular.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace DevExtremeAngular.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class DevExtremeAngularController : AbpControllerBase
{
    protected DevExtremeAngularController()
    {
        LocalizationResource = typeof(DevExtremeAngularResource);
    }
}
