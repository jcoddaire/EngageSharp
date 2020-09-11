using EngageSharp.Models;
using EngageSharp.Models.Organization;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EngageSharp
{
    public partial class EngageApi
    {
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
        public EngageObject<Organization> GetOrganizations(int organizationId = 0, string status = "", bool excludeHiddenOrganizations = true, string category = "", string type = "", string name = "", DateTime? modifiedOnStart = null, DateTime? modifiedOnEnd = null, int page = 1, int pageSize = 100)
        {
            var request = new RestRequest();
            request.Resource = "/Organizations";

            if (organizationId > 0)
            {
                request.AddParameter("organizationId", organizationId);
            }
            if (!string.IsNullOrWhiteSpace(status))
            {
                request.AddParameter("status", status);
            }
            
            request.AddParameter("excludeHiddenOrganizations", excludeHiddenOrganizations);
            
            if (!string.IsNullOrWhiteSpace(category))
            {
                request.AddParameter("category", category);
            }
            if (!string.IsNullOrWhiteSpace(type))
            {
                request.AddParameter("type", type);
            }
            if (!string.IsNullOrWhiteSpace(name))
            {
                request.AddParameter("name", name);
            }
            if (modifiedOnStart != null)
            {
                //TODO: parse the dateTime object to a UNIX style time (float).
                request.AddParameter("modifiedOnStart", modifiedOnStart);
            }
            if (modifiedOnEnd != null)
            {
                //TODO: parse the dateTime object to a UNIX style time (float).
                request.AddParameter("modifiedOnEnd", modifiedOnEnd);
            }

            return Execute<EngageObject<Organization>>(request, page, pageSize);
        }

        /// <summary>
        /// Extracts the organizational categories into a unique list.
        /// </summary>
        /// <param name="organizations">The organizations.</param>
        /// <returns>A unique list of categories.</returns>
        public IEnumerable<Category> ExtractCategories(IEnumerable<Organization> organizations)
        {
            var result = new List<Category>();

            foreach (var org in organizations)
            {
                if (org.Categories != null && org.Categories.Count() > 0)
                {
                    foreach (var cat in org.Categories)
                    {
                        if (!result.Exists(x => x.ID == cat.ID))
                        {
                            result.Add(cat);
                        }
                    }
                }
            }

            return result.AsEnumerable();
        }
    }
}
