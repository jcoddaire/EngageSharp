using EngageSharp.Models;
using EngageSharp.Models.Organization;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngageSharpAPI.Interfaces
{
    public interface IEngageApi
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
        EngageObject<Membership> GetMemberships(int userId = 0, string userName = "", bool currentMembershipsOnly = true, bool publicPrivacyFilter = false, bool campusPrivacyFilter = false, bool includeDeletes = false, DateTime? startDate = null, DateTime? endDate = null,
            int organizationId = 0, int positionTemplateId = 0, string positionTemplateName = "", DateTime? modifiedOnStart = null, DateTime? modifiedOnEnd = null, int page = 1, int pageSize = 100);

        /// <summary>
        /// Gets the organizations.
        /// </summary>
        /// <param name="organizationId">The organization identifier.</param>
        /// <param name="status">The status.</param>
        /// <param name="excludeHiddenOrganizations">if set to <c>true</c> [exclude hidden organizations].</param>
        /// <param name="category">The category.</param>
        /// <param name="type">The type.</param>
        /// <param name="name">The name.</param>
        /// <param name="modifiedOnStart">The modified on start.</param>
        /// <param name="modifiedOnEnd">The modified on end.</param>
        /// <param name="page">The page.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>A list of Organization objects.</returns>
        EngageObject<Organization> GetOrganizations(int organizationId = 0, string status = "", bool excludeHiddenOrganizations = true, string category = "", string type = "", string name = "", DateTime? modifiedOnStart = null, DateTime? modifiedOnEnd = null, int page = 1, int pageSize = 100);

        /// <summary>
        /// Gets the users.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <param name="username">The username.</param>
        /// <param name="cardId">The card identifier.</param>
        /// <param name="sisId">The sis identifier.</param>
        /// <param name="affiliation">The affiliation.</param>
        /// <param name="enrollmentStatus">The enrollment status.</param>
        /// <param name="schoolOfEnrollment">The school of enrollment.</param>
        /// <param name="status">The status.</param>
        /// <param name="createdOnStart">The created on start.</param>
        /// <param name="createdOnEnd">The created on end.</param>
        /// <param name="page">The page.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>A paginated list of users.</returns>
        EngageObject<User> GetUsers(int userId = 0, string username = "", string cardId = "", string sisId = "", string affiliation = "", string enrollmentStatus = "", string schoolOfEnrollment = "", string status = "",
            DateTime? createdOnStart = null, DateTime? createdOnEnd = null, int page = 1, int pageSize = 100);

        /// <summary>
        /// Extracts the organizational categories into a unique list.
        /// </summary>
        /// <param name="organizations">The organizations.</param>
        /// <returns>A unique list of categories.</returns>
        IEnumerable<Category> ExtractCategories(IEnumerable<Organization> organizations);
    }
}
