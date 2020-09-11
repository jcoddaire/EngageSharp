using EngageSharp.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngageSharp.Models
{
    public class Membership
    {
        [JsonProperty("deleted")]
        public bool deleted { get; set; }

        [JsonProperty("membershipId")]
        public int membershipId { get; set; }

        [JsonProperty("organizationId")]
        public int organizationId { get; set; }

        [JsonProperty("organizationName")]
        public string organizationName { get; set; }

        [JsonProperty("organizationShortName")]
        public string organizationShortName { get; set; }

        [JsonProperty("positionTemplateId")]
        public int positionTemplateId { get; set; }

        [JsonProperty("positionTemplateName")]
        public string positionTemplateName { get; set; }

        [JsonProperty("positionTypeId")]
        public int positionTypeId { get; set; }

        [JsonProperty("positionTypeName")]
        public string positionTypeName { get; set; }

        [JsonProperty("positionId")]
        public int positionId { get; set; }

        [JsonProperty("positionName")]
        public string positionName { get; set; }

        [JsonProperty("userId")]
        public int userId { get; set; }

        [JsonProperty("username")]
        public string username { get; set; }

        [JsonProperty("userFirstName")]
        public string userFirstName { get; set; }

        [JsonProperty("userLastName")]
        public string userLastName { get; set; }

        [JsonProperty("userCampusEmail")]
        public string userCampusEmail { get; set; }

        [JsonProperty("positionRecordedStartDate")]
        [JsonConverter(typeof(EngageDateConverter))]
        public DateTime? positionRecordedStartDate { get; set; }

        [JsonProperty("positionRecordedEndDate")]
        [JsonConverter(typeof(EngageDateConverter))]
        public DateTime? positionRecordedEndDate { get; set; }

        [JsonProperty("positionReportedStartDate")]
        [JsonConverter(typeof(EngageDateConverter))]
        public DateTime? positionReportedStartDate { get; set; }

        [JsonProperty("positionReportedEndDate")]
        [JsonConverter(typeof(EngageDateConverter))]
        public DateTime? positionReportedEndDate { get; set; }

        [JsonProperty("reflection")]
        public string reflection { get; set; }

        [JsonProperty("userShownOnCampusRoster")]
        public bool userShownOnCampusRoster { get; set; }

        [JsonProperty("userShownOnPublicRoster")]
        public bool userShownOnPublicRoster { get; set; }
    }
}
