using System;
using RestSharp;

namespace EngageSharp
{
    public class EngageException : Exception
    {
        private string message;

        public IRestResponse Response;

        public EngageException(IRestResponse response)
        {
            Response = response;
            message = "Unexpected response status " + ((int)response.StatusCode).ToString() + " with body:\n" + response.Content;
        }

        public override string Message
        {
            get { return message; }
        }
    }
}
