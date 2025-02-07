﻿using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using EmployeeMgt.Configuration.Dto;

namespace EmployeeMgt.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : EmployeeMgtAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
