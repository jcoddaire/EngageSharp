using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngageSharp.Models.Organization
{
    public class Organization
    {
        [JsonProperty("organizationId")]
        public int OrganizationID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("shortName")]
        public string ShortName { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("addressStreet1")]
        public string AddressStreet1 { get; set; }

        [JsonProperty("addressStreet2")]
        public string AddressStreet2 { get; set; }

        [JsonProperty("addressCity")]
        public string AddressCity { get; set; }

        [JsonProperty("addressStateProvince")]
        public string AddressStateProvince { get; set; }

        [JsonProperty("addressZipPostal")]
        public string AddressZipPostal { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("faxNumber")]
        public string FaxNumber { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("externalWebsite")]
        public Uri ExternalWebsite { get; set; }

        [JsonProperty("facebookUrl")]
        public Uri FacebookURL { get; set; }

        [JsonProperty("twitterUrl")]
        public Uri TwitterURL { get; set; }

        [JsonProperty("flickrFeedUrl")]
        public Uri FilckrFeedURL { get; set; }

        [JsonProperty("youtubeChannelUrl")]
        public Uri YoutubeChannelURL { get; set; }

        [JsonProperty("googleCalendarUrl")]
        public Uri GoogleCalendarURL { get; set; }

        [JsonProperty("profileImageUrl")]
        public Uri ProfileImageURL { get; set; }

        [JsonProperty("profileUrl")]
        public Uri ProfileURL { get; set; }

        [JsonProperty("directoryVisibility")]
        public string DirectoryVisibility { get; set; }

        [JsonProperty("membershipType")]
        public string MembershipType { get; set; }

        [JsonProperty("typeId")]
        public int? TypeID { get; set; }

        [JsonProperty("typeName")]
        public string TypeName { get; set; }

        [JsonProperty("parentId")]
        public int? ParentID { get; set; }

        [JsonProperty("parentName")]
        public string ParentName { get; set; }

        [JsonProperty("primaryContactId")]
        public int? PrimaryContactID { get; set; }

        [JsonProperty("primaryContactName")]
        public string PrimaryContactName { get; set; }

        [JsonProperty("primaryContactCampusEmail")]
        public string PrimaryContactCampusEmail { get; set; }

        [JsonProperty("categories")]
        public List<Category> Categories { get; set; }

        [JsonProperty("customFields")]
        public List<CustomField> CustomFields { get; set; }

    }
}
