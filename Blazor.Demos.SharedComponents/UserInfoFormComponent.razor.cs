using Blazor.Demos.Shared.Models;
using Blazor.Demos.Shared.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor.Demos.SharedComponents
{
    public class UserInfoFormComponentBase : ComponentBase
    {
        [Inject]
        protected UserInfoService UserInfoService { get; set; }
        protected UserInfo UserInfo { get; set; } = new UserInfo();

        /// <summary>
        /// Event for the parent component to set that is going to provide it with review info if review submission is successful.
        /// </summary>
        [Parameter]
        public EventCallback<UserInfo> OnUserInfoSubmitted { get; set; }

        public void SubmitUserInfo()
        {
            OnUserInfoSubmitted.InvokeAsync(UserInfo);
        }
    }
}
