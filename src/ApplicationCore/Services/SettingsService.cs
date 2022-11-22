using ERCOFAS.ApplicationCore.DTOs;
using ERCOFAS.ApplicationCore.Entities.Structure;
using ERCOFAS.ApplicationCore.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ERCOFAS.ApplicationCore.Services
{
    public class SettingsService : ISettingsService
    {
        #region Variables

        private readonly ISettingsRepository _repository;

        #endregion Variables

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="RoleRepository"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>
        public SettingsService(ISettingsRepository repository)
        {
            _repository = repository;
        }

        #endregion Constructor

        #region Public

        public IQueryable<Settings> Get()
        {
            return _repository.Get();
        }

        public async Task<Settings> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task<Settings> Add(SettingsDTO settingsDTO)
        {
            var settings = new Settings()
            {
                CompanyName = settingsDTO.CompanyName,
                EmailAddress = settingsDTO.EmailAddress,
                PhoneNumber = settingsDTO.PhoneNumber,
                MobileNumber = settingsDTO.MobileNumber,
                Address = settingsDTO.Address,
                AboutUs = settingsDTO.AboutUs,
                Website = settingsDTO.Website,
                ERNumberPrefix = settingsDTO.ERNumberPrefix,
                SMTPFromEmail = settingsDTO.SMTPFromEmail,
                SMTPFromName = settingsDTO.SMTPFromName,
                SMTPUsername = settingsDTO.SMTPUsername,
                SMTPPassword = settingsDTO.SMTPPassword,
                SMTPServerName = settingsDTO.SMTPServerName,
                SMTPPort = settingsDTO.SMTPPort,
                EnableSSL = settingsDTO.EnableSSL,
                OTPAPIKey = settingsDTO.OTPAPIKey,
                OTPClientID = settingsDTO.OTPClientID,
                OTPUsername = settingsDTO.OTPUsername,
                OTPPassword = settingsDTO.OTPPassword,
                MinPasswordLength = settingsDTO.MinPasswordLength,
                MinSpecialCharacters = settingsDTO.MinSpecialCharacters,
                MaxSignOnAttempts = settingsDTO.MaxSignOnAttempts,
                EnforcePasswordHistory = settingsDTO.EnforcePasswordHistory,
                ActivationLinkExpiresIn = settingsDTO.ActivationLinkExpiresIn,
                BaseUrl = settingsDTO.BaseUrl,
                CreatedBy = settingsDTO.CreatedBy,
                DateCreated = settingsDTO.DateCreated
            };

            try
            {
                return await _repository.Add(settings);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Settings> Update(SettingsDTO settingsDTO)
        {
            var settings = _repository.GetById(settingsDTO.Id).Result;
            settings.CompanyName = settingsDTO.CompanyName;
            settings.EmailAddress = settingsDTO.EmailAddress;
            settings.PhoneNumber = settingsDTO.PhoneNumber;
            settings.MobileNumber = settingsDTO.MobileNumber;
            settings.Address = settingsDTO.Address;
            settings.AboutUs = settingsDTO.AboutUs;
            settings.Website = settingsDTO.Website;
            settings.ERNumberPrefix = settingsDTO.ERNumberPrefix;
            settings.SMTPFromEmail = settingsDTO.SMTPFromEmail;
            settings.SMTPFromName = settingsDTO.SMTPFromName;
            settings.SMTPUsername = settingsDTO.SMTPUsername;
            settings.SMTPPassword = settingsDTO.SMTPPassword;
            settings.SMTPServerName = settingsDTO.SMTPServerName;
            settings.SMTPPort = settingsDTO.SMTPPort;
            settings.EnableSSL = settingsDTO.EnableSSL;
            settings.OTPAPIKey = settingsDTO.OTPAPIKey;
            settings.OTPClientID = settingsDTO.OTPClientID;
            settings.OTPUsername = settingsDTO.OTPUsername;
            settings.OTPPassword = settingsDTO.OTPPassword;
            settings.MinPasswordLength = settingsDTO.MinPasswordLength;
            settings.MinSpecialCharacters = settingsDTO.MinSpecialCharacters;
            settings.MaxSignOnAttempts = settingsDTO.MaxSignOnAttempts;
            settings.EnforcePasswordHistory = settingsDTO.EnforcePasswordHistory;
            settings.ActivationLinkExpiresIn = settingsDTO.ActivationLinkExpiresIn;
            settings.BaseUrl = settingsDTO.BaseUrl;
            settings.UpdatedBy = settingsDTO.UpdatedBy;
            settings.DateUpdated = settingsDTO.DateUpdated;

            return await _repository.Update(settings);
        }

        #endregion Public
    }
}
