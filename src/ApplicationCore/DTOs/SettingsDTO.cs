using System;
using System.Text.Json.Serialization;

namespace ERCOFAS.ApplicationCore.DTOs
{
    public class SettingsDTO
    {
        /// <summary>
        /// Gets or sets the settings identifier.
        /// </summary>
        /// <value>
        /// The settings identifier.
        /// </value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the company name.
        /// </summary>
        /// <value>
        /// The company name.
        /// </value>
        public string CompanyName { get; set; }
        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        /// <value>
        /// The email address.
        /// </value>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        /// <value>
        /// The phone number.
        /// </value>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Gets or sets the mobile number.
        /// </summary>
        /// <value>
        /// The mobile number.
        /// </value>
        public string MobileNumber { get; set; }
        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        public string Address { get; set; }
        /// <summary>
        /// Gets or sets the about us.
        /// </summary>
        /// <value>
        /// The about us.
        /// </value>
        public string AboutUs { get; set; }
        /// <summary>
        /// Gets or sets the website.
        /// </summary>
        /// <value>
        /// The website.
        /// </value>
        public string Website { get; set; }
        /// <summary>
        /// Gets or sets the electronic registration number prefix.
        /// </summary>
        /// <value>
        /// The electronic registration number prefix.
        /// </value>
        public string ERNumberPrefix { get; set; }
        /// <summary>
        /// Gets or sets the SMTP from email.
        /// </summary>
        /// <value>
        /// The SMTP from email.
        /// </value>
        public string SMTPFromEmail { get; set; }
        /// <summary>
        /// Gets or sets the SMTP from name.
        /// </summary>
        /// <value>
        /// The SMTP from name.
        /// </value>
        public string SMTPFromName { get; set; }
        /// <summary>
        /// Gets or sets the SMTP username.
        /// </summary>
        /// <value>
        /// The SMTP username.
        /// </value>
        public string SMTPUsername { get; set; }
        /// <summary>
        /// Gets or sets the SMTP password.
        /// </summary>
        /// <value>
        /// The SMTP password.
        /// </value>
        public string SMTPPassword { get; set; }
        /// <summary>
        /// Gets or sets the SMTP server name.
        /// </summary>
        /// <value>
        /// The SMTP server name.
        /// </value>
        public string SMTPServerName { get; set; }
        /// <summary>
        /// Gets or sets the SMTP port.
        /// </summary>
        /// <value>
        /// The SMTP port.
        /// </value>
        public int SMTPPort { get; set; }
        /// <summary>
        /// Gets or sets the SMTP enable SSL.
        /// </summary>
        /// <value>
        /// The SMTP enable SSL.
        /// </value>
        public bool? EnableSSL { get; set; }
        /// <summary>
        /// Gets or sets the OTP api key.
        /// </summary>
        /// <value>
        /// The OTP api key.
        /// </value>
        public string OTPAPIKey { get; set; }
        /// <summary>
        /// Gets or sets the OTP client id.
        /// </summary>
        /// <value>
        /// The OTP client id.
        /// </value>
        public string OTPClientID { get; set; }
        /// <summary>
        /// Gets or sets the OTP username.
        /// </summary>
        /// <value>
        /// The OTP username.
        /// </value>
        public string OTPUsername { get; set; }
        /// <summary>
        /// Gets or sets the OTP password.
        /// </summary>
        /// <value>
        /// The OTP password.
        /// </value>
        public string OTPPassword { get; set; }
        /// <summary>
        /// Gets or sets the minimum password length.
        /// </summary>
        /// <value>
        /// The minimum password length.
        /// </value>
        public int MinPasswordLength { get; set; }
        /// <summary>
        /// Gets or sets the minimum special characters.
        /// </summary>
        /// <value>
        /// The minimum special characters.
        /// </value>
        public int MinSpecialCharacters { get; set; }
        /// <summary>
        /// Gets or sets the maximum sign on attempts.
        /// </summary>
        /// <value>
        /// The maximum sign on attempts.
        /// </value>
        public int MaxSignOnAttempts { get; set; }
        /// <summary>
        /// Gets or sets the enforce password history.
        /// </summary>
        /// <value>
        /// The enforce password history.
        /// </value>
        public int EnforcePasswordHistory { get; set; }
        /// <summary>
        /// Gets or sets the activation link expires in.
        /// </summary>
        /// <value>
        /// The activation link expires in.
        /// </value>
        public int? ActivationLinkExpiresIn { get; set; }
        /// <summary>
        /// Gets or sets the base url.
        /// </summary>
        /// <value>
        /// The base url.
        /// </value>
        public string BaseUrl { get; set; }
        /// <summary>
        /// Gets or sets the created by.
        /// </summary>
        /// <value>
        /// The created by.
        /// </value>
        public int CreatedBy { get; set; }
        /// <summary>
        /// Gets or sets the date created.
        /// </summary>
        /// <value>
        /// The date created.
        /// </value>
        public DateTime DateCreated { get; set; }
        /// <summary>
        /// Gets or sets the updated by.
        /// </summary>
        /// <value>
        /// The updated by.
        /// </value>
        public int? UpdatedBy { get; set; }
        /// <summary>
        /// Gets or sets the date updated.
        /// </summary>
        /// <value>
        /// The date updated.
        /// </value>
        public DateTime? DateUpdated { get; set; }
        /// <summary>
        /// Gets or sets the out settings.
        /// </summary>
        /// <value>
        /// The out settings.
        /// </value>
        [JsonIgnore]
        public SettingsDTO OutSettings { get; set; }
    }
}
