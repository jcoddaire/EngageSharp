using System;
using System.Collections.Generic;
using System.Linq;
using EngageSharp.Models;
using EngageSharp.Models.Organization;
using EngageSharpAPI.Interfaces;

namespace EngageSharp
{
    class Program
    {
        /// <summary>
        /// The maximum number of records that can be returned at once from the API.        
        /// </summary>
        private const int API_PAGING_COUNT = 500;

        /// <summary>
        /// The amount of time in milliseconds to wait when an API request fails due to rate limiting.
        /// </summary>
        private const int API_REQUEST_WAIT_TIME = 30000;

        static void Main(string[] args)
        {
            Console.WriteLine("Engage API wrapper demo!");

            // ideally you read these in from a config or secrets file or whatever.

            string url = @"https://mit.campuslabs.com/engage/api/";
            string key = "THIS IS YOUR SECRET KEY";

            IEngageApi engageService = new EngageApi(url, key);

            // FYI you may want to limit this somehow, particularly if you are calling it many times.
            var allOrgs = GetOrganizations(engageService);

        }

        /// <summary>
        /// Gets all student organizations from the Engage API.
        /// </summary>
        /// <param name="engageApi">The engage API object.</param>
        /// <returns>
        /// A list of organizations.
        /// </returns>
        private static IEnumerable<Organization> GetOrganizations(IEngageApi engageApi)
        {
            var result = new List<Organization>();

            var currentPage = 1;
            int totalPages = 0;

            do
            {
                var data = GetOrganizationAPIData(engageApi, currentPage);
                if (data != null)
                {
                    totalPages = data.TotalPages;

                    // LogInfoMessage($"Getting organization data - page {currentPage} of {totalPages}.");

                    if (data != null && data.Items != null && data.Items.Count > 0)
                    {
                        result.AddRange(data.Items);
                    }

                    currentPage++;
                }

            } while (currentPage <= totalPages);


            return result.AsEnumerable();
        }


        /// <summary>
        /// Gets the organization API data.
        /// </summary>
        /// <param name="engageApi">The engage API.</param>
        /// <param name="currentPage">The current page.</param>
        /// <returns></returns>
        private static EngageObject<Organization> GetOrganizationAPIData(IEngageApi engageApi, int currentPage, int errorCount = 0)
        {
            try
            {
                return engageApi.GetOrganizations(0, string.Empty, false, string.Empty, string.Empty, string.Empty, null, null, currentPage, API_PAGING_COUNT);
            }
            catch (Exception ex)
            {
                if (errorCount <= 0)
                {
                    SleepAPIRequests();
                    return GetOrganizationAPIData(engageApi, currentPage, 1);
                }
                else
                {
                    // LOG THE ERROR
                    return null;
                }
            }
        }


        /// <summary>
        /// The API is rate limited. Only 180 requests can be sent per minute.
        /// if we exceed those limits, wait a while.
        /// </summary>
        private static void SleepAPIRequests()
        {
            // LogInfoMessage($"Rate limit exceeded! Waiting for {(API_REQUEST_WAIT_TIME / 1000)} seconds...");

            System.Threading.Thread.Sleep(API_REQUEST_WAIT_TIME);

            // LogInfoMessage("Resuming!");
        }
    }
}
