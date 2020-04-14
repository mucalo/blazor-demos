using Blazor.Demos.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor.Demos.Shared.Services
{
    public class UserInfoService
    {
        /// <summary>
        /// Gets the full name from the UserInfo object
        /// </summary>
        /// <param name="userInfo">Object from which to get the name from</param>
        /// <param name="startsWithFirstName">Defines if the first name or last name should go first (John Doe vs. Doe John)</param>
        /// <returns></returns>
        public string GetFullName(UserInfo userInfo, bool startsWithFirstName = true)
        {
            return startsWithFirstName ? string.Format("{0} {1}", userInfo.FirstName, userInfo.LastName) : string.Format("{0} {1}", userInfo.LastName, userInfo.FirstName);
        }

        /// <summary>
        /// Gets the full name from the UserInfo object followed by the email address in ()
        /// </summary>
        /// <param name="userInfo">Object from which to get the name from</param>
        /// <param name="startsWithFirstName">Defines if the first name or last name should go first (John Doe vs. Doe John)</param>
        /// <returns></returns>
        public string GetFullNameWithEmail(UserInfo userInfo, bool startsWithFirstName = true)
        {
            return string.Format("{0} {1}", 
                GetFullName(userInfo, startsWithFirstName), 
                string.IsNullOrEmpty(userInfo.Email) ? string.Empty : string.Format("({0})", userInfo.Email));
        }
    }
}
