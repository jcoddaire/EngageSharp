using EngageSharp.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngageSharp.Models
{
    public class User
    {
        [JsonProperty("userId")]
        public int userId { get; set; }

        [JsonProperty("username")]
        public string username { get; set; }

        [JsonProperty("archivedUsername")]
        public string archivedUsername { get; set; }

        [JsonProperty("status")]
        public string status { get; set; }

        [JsonProperty("lastLogin")]
        [JsonConverter(typeof(EngageDateConverter))]
        public DateTime? lastLogin { get; set; }

        [JsonProperty("profilePictureUrl")]
        public string profilePictureUrl { get; set; }

        [JsonProperty("firstName")]
        public string firstName { get; set; }

        [JsonProperty("lastName")]
        public string lastName { get; set; }

        [JsonProperty("campusEmail")]
        public string campusEmail { get; set; }

        [JsonProperty("preferredEmail")]
        public string preferredEmail { get; set; }

        [JsonProperty("cardId")]
        public string cardId { get; set; }

        [JsonProperty("mobilePhone")]
        public string mobilePhone { get; set; }

        [JsonProperty("preferredFirstName")]
        public ValueObject preferredFirstName { get; set; }

        [JsonProperty("preferredLastName")]
        public string preferredLastName { get; set; }

        [JsonProperty("institutionProvidedFirstName")]
        public string institutionProvidedFirstName { get; set; }

        [JsonProperty("institutionProvidedMiddleName")]
        public string institutionProvidedMiddleName { get; set; }

        [JsonProperty("institutionProvidedLastName")]
        public string institutionProvidedLastName { get; set; }

        [JsonProperty("legalFirstName")]
        public string legalFirstName { get; set; }

        [JsonProperty("legalLastName")]
        public string legalLastName { get; set; }

        [JsonProperty("middleName")]
        public ValueObject middleName { get; set; }

        [JsonProperty("suffix")]
        public ValueObject suffix { get; set; }

        [JsonProperty("hometown")]
        public ValueObject hometown { get; set; }

        [JsonProperty("affiliation")]
        public ValueObject affiliation { get; set; }

        [JsonProperty("sisId")]
        public ValueObject sisId { get; set; }

        [JsonProperty("dateOfBirth")]
        public DateObject dateOfBirth { get; set; }

        [JsonProperty("sex")]
        public ValueObject sex { get; set; }

        [JsonProperty("race")]
        public ValueObject race { get; set; }

        [JsonProperty("ethnicity")]
        public ValueObject ethnicity { get; set; }

        [JsonProperty("enrollmentStatus")]
        public ValueObject enrollmentStatus { get; set; }

        [JsonProperty("currentTermEnrolled")]
        public ValueObject currentTermEnrolled { get; set; }

        [JsonProperty("currentTermGpa")]
        public ValueObject currentTermGpa { get; set; }

        [JsonProperty("previousTermEnrolled")]
        public ValueObject previousTermEnrolled { get; set; }

        [JsonProperty("previousTermGpa")]
        public ValueObject previousTermGpa { get; set; }

        [JsonProperty("creditHoursEarned")]
        public ValueObject creditHoursEarned { get; set; }

        [JsonProperty("anticipatedDateOfGraduation")]
        public DateObject anticipatedDateOfGraduation { get; set; }

        [JsonProperty("careerLevel")]
        public ValueObject careerLevel { get; set; }

        [JsonProperty("classStanding")]
        public ValueObject classStanding { get; set; }

        [JsonProperty("primarySchoolOfEnrollment")]
        public ValueObject primarySchoolOfEnrollment { get; set; }

        [JsonProperty("degreeSought")]
        public ValueObject degreeSought { get; set; }

        [JsonProperty("major")]
        public ValueObject major { get; set; }

        [JsonProperty("minor")]
        public ValueObject minor { get; set; }

        [JsonProperty("majorAdvisor")]
        public ValueObject majorAdvisor { get; set; }

        [JsonProperty("otherAdvisor")]
        public ValueObject otherAdvisor { get; set; }

        [JsonProperty("localResidencyStatus")]
        public ValueObject localResidencyStatus { get; set; }

        [JsonProperty("housingFacility")]
        public ValueObject housingFacility { get; set; }

        [JsonProperty("international")]
        public ValueObject international { get; set; }

        [JsonProperty("transfer")]
        public ValueObject transfer { get; set; }

        [JsonProperty("athlete")]
        public ValueObject athlete { get; set; }

        [JsonProperty("athleticParticipation")]
        public ValueObject athleticParticipation { get; set; }

        [JsonProperty("localPhoneCountryCode")]
        public string localPhoneCountryCode { get; set; }

        [JsonProperty("localPhone")]
        public string localPhone { get; set; }

        [JsonProperty("localPhoneExtension")]
        public string localPhoneExtension { get; set; }

        [JsonProperty("localStreet1")]
        public string localStreet1 { get; set; }

        [JsonProperty("localStreet2")]
        public string localStreet2 { get; set; }

        [JsonProperty("localStreet3")]
        public string localStreet3 { get; set; }

        [JsonProperty("localCity")]
        public string localCity { get; set; }

        [JsonProperty("localStateProvince")]
        public string localStateProvince { get; set; }

        [JsonProperty("localPostalCode")]
        public string localPostalCode { get; set; }

        [JsonProperty("localCountry")]
        public string localCountry { get; set; }

        [JsonProperty("homePhoneCountryCode")]
        public string homePhoneCountryCode { get; set; }

        [JsonProperty("homePhone")]
        public string homePhone { get; set; }

        [JsonProperty("homePhoneExtension")]
        public string homePhoneExtension { get; set; }

        [JsonProperty("homeStreet1")]
        public string homeStreet1 { get; set; }

        [JsonProperty("homeStreet2")]
        public string homeStreet2 { get; set; }

        [JsonProperty("homeStreet3")]
        public string homeStreet3 { get; set; }

        [JsonProperty("homeCity")]
        public string homeCity { get; set; }

        [JsonProperty("homeStateProvince")]
        public string homeStateProvince { get; set; }

        [JsonProperty("homePostalCode")]
        public string homePostalCode { get; set; }

        [JsonProperty("homeCountry")]
        public string homeCountry { get; set; }

        [JsonProperty("abroadPhoneCountryCode")]
        public string abroadPhoneCountryCode { get; set; }

        [JsonProperty("abroadPhone")]
        public string abroadPhone { get; set; }

        [JsonProperty("abroadPhoneExtension")]
        public string abroadPhoneExtension { get; set; }

        [JsonProperty("abroadStreet1")]
        public string abroadStreet1 { get; set; }

        [JsonProperty("abroadStreet2")]
        public string abroadStreet2 { get; set; }

        [JsonProperty("abroadStreet3")]
        public string abroadStreet3 { get; set; }

        [JsonProperty("abroadCity")]
        public string abroadCity { get; set; }

        [JsonProperty("abroadStateProvince")]
        public string abroadStateProvince { get; set; }

        [JsonProperty("abroadPostalCode")]
        public string abroadPostalCode { get; set; }

        [JsonProperty("abroadCountry")]
        public string abroadCountry { get; set; }

        [JsonProperty("customFields")]
        public List<CustomField> customFields { get; set; }
    }
}
