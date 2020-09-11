using EngageSharp.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EngageSharp
{
    public partial class EngageApi
    {

        /// <summary>
        /// Gets the memberships.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <param name="userName">Name of the user.</param>
        /// <param name="currentMembershipsOnly">if set to <c>true</c> [current memberships only].</param>
        /// <param name="publicPrivacyFilter">if set to <c>true</c> [public privacy filter].</param>
        /// <param name="campusPrivacyFilter">if set to <c>true</c> [campus privacy filter].</param>
        /// <param name="includeDeletes">if set to <c>true</c> [include deletes].</param>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <param name="organizationId">The organization identifier.</param>
        /// <param name="positionTemplateId">The position template identifier.</param>
        /// <param name="positionTemplateName">Name of the position template.</param>
        /// <param name="modifiedOnStart">The modified on start.</param>
        /// <param name="modifiedOnEnd">The modified on end.</param>
        /// <param name="page">The page.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>An engage object with membership data.</returns>
        public EngageObject<Membership> GetMemberships(int userId = 0, string userName = "", bool currentMembershipsOnly = true, bool publicPrivacyFilter = false, bool campusPrivacyFilter = false, bool includeDeletes = false, DateTime? startDate = null, DateTime? endDate = null, 
            int organizationId = 0, int positionTemplateId = 0, string positionTemplateName = "", DateTime? modifiedOnStart = null, DateTime? modifiedOnEnd = null, int page = 1, int pageSize = 100)
        {
            var request = new RestRequest();
            request.Resource = "/Memberships";

            if (userId > 0)
            {
                request.AddParameter("userId", userId);
            }
            if (organizationId > 0)
            {
                request.AddParameter("organizationId", organizationId);
            }
            if (positionTemplateId > 0)
            {
                request.AddParameter("positionTemplateId", positionTemplateId);
            }

            if(startDate != null)
            {
                // TODO: convert to UNIX time - double / float.
                request.AddParameter("startDate", startDate);
            }
            if (endDate != null)
            {
                // TODO: convert to UNIX time - double / float.
                request.AddParameter("endDate", endDate);
            }
            if (modifiedOnStart != null)
            {
                // TODO: convert to UNIX time - double / float.
                request.AddParameter("modifiedOnStart", modifiedOnStart);
            }
            if (modifiedOnEnd != null)
            {
                // TODO: convert to UNIX time - double / float.
                request.AddParameter("modifiedOnEnd", modifiedOnEnd);
            }

            if (!string.IsNullOrWhiteSpace(userName))
            {
                request.AddParameter("userName", userName);
            }

            if (!string.IsNullOrWhiteSpace(positionTemplateName))
            {
                request.AddParameter("positionTemplateName", positionTemplateName);
            }

            // add flags:
            request.AddParameter("currentMembershipsOnly", currentMembershipsOnly);
            request.AddParameter("publicPrivacyFilter", publicPrivacyFilter);
            request.AddParameter("campusPrivacyFilter", campusPrivacyFilter);
            request.AddParameter("includeDeletes", includeDeletes);

            return Execute<EngageObject<Membership>>(request, page, pageSize);
        }
    }
}
