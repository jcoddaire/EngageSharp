using EngageSharpAPI.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using RestSharp;
using RestSharp.Serializers;
using System;
using System.Diagnostics;
using System.Net;

namespace EngageSharp
{
    /// <summary>
    /// Base Class for APIs
    /// </summary>
	public partial class EngageApi : IEngageApi
    {
        readonly string _baseUrl;
        readonly string _secretKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="EngageApi" /> class.
        /// </summary>
        /// <param name="baseUrl">The API endpoint.</param>
        /// <param name="secretKey">The account's private key.</param>
        public EngageApi(string baseUrl, string secretKey)
        {
            _baseUrl = baseUrl;
            _secretKey = secretKey;            
        }

        /// <summary>
        /// Execute the Call to the Engage API. All methods return this base method.
        /// </summary>
        /// <typeparam name="T">The model or type to bind the return response.</typeparam>
        /// <param name="request">The RestRequest request.</param>
        /// <returns>Response data from the API call.</returns>
        private T Execute<T>(RestRequest request, int page, int pageSize) where T : new()
        {
            if (string.IsNullOrWhiteSpace(_baseUrl))
            {
                throw new InvalidProgramException("Improper configuration: baseUrl must have a value.");
            }
            if (string.IsNullOrWhiteSpace(_secretKey))
            {
                throw new InvalidProgramException("Improper configuration: secretKey must have a value.");
            }

            var client = new RestClient();
            client.BaseUrl = new Uri(_baseUrl);

            client.AddDefaultHeader("Accept", "application/json");
            client.AddDefaultHeader("X-Engage-Api-Key", _secretKey);

            if (page > 0)
            {
                request.AddParameter("page", page);
            }
            if(pageSize > 0)
            {   
                request.AddParameter("pageSize", pageSize);
            }

            request.RequestFormat = DataFormat.Json;
            var serializer = new JsonSerializer();
            serializer.Converters.Add(new StringEnumConverter());
            request.JsonSerializer = new EngageJsonSerializer(serializer);
            request.Timeout = 30000;

            IRestResponse<T> execute = client.Execute<T>(request);
            
            checkResponse(execute);

            T response = JsonConvert.DeserializeObject<T>(execute.Content);
            return response;
        }

        /// <summary>
        /// Checks the response.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <exception cref="EngageSharp.EngageException"></exception>
        private void checkResponse(IRestResponse response)
        {
            int code = (int)response.StatusCode;
            if (code >= 400)
            {
                throw new EngageException(response);
            }
            if(code <= 0)
            {
                // no connection.
                throw new WebException($"The API endpoint is not accessible. Please check your internet connection. URL: {_baseUrl}");
            }
        }
    }
}