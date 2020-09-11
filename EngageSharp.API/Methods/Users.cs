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
        public EngageObject<User> GetUsers(int userId = 0, string username = "", string cardId = "", string sisId = "", string affiliation = "", string enrollmentStatus = "", string schoolOfEnrollment = "", string status = "", 
            DateTime? createdOnStart = null, DateTime? createdOnEnd = null, int page = 1, int pageSize = 100)
        {
            var request = new RestRequest();
            request.Resource = "/Users";

            if (userId > 0)
            {
                request.AddParameter("userId", userId);
            }
            if (!string.IsNullOrWhiteSpace(cardId))
            {
                request.AddParameter("cardId", cardId);
            }
            if (!string.IsNullOrWhiteSpace(sisId))
            {
                request.AddParameter("sisId", sisId);
            }
            if (!string.IsNullOrWhiteSpace(affiliation))
            {
                request.AddParameter("affiliation", affiliation);
            }
            if (!string.IsNullOrWhiteSpace(enrollmentStatus))
            {
                request.AddParameter("enrollmentStatus", enrollmentStatus);
            }
            if (!string.IsNullOrWhiteSpace(schoolOfEnrollment))
            {
                request.AddParameter("schoolOfEnrollment", schoolOfEnrollment);
            }
            if (!string.IsNullOrWhiteSpace(status))
            {
                request.AddParameter("status", status);
            }
            if (createdOnStart != null)
            {
                //TODO: parse the dateTime object to a UNIX style time (float).
                request.AddParameter("createdOnStart", createdOnStart);
            }
            if (createdOnEnd != null)
            {
                //TODO: parse the dateTime object to a UNIX style time (float).
                request.AddParameter("createdOnEnd", createdOnEnd);
            }

            return Execute<EngageObject<User>>(request, page, pageSize);
        }
    }
}
