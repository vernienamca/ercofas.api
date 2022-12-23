using ERCOFAS.ApplicationCore.Entities.Security;
using ERCOFAS.ApplicationCore.Entities.Structure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERCOFAS.Api.Infrastructure.Data
{
    public class ERCOFASContext : DbContext
    {
        #region Variables

        public DbSet<Role> Roles { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<PageAccess> PageAccess { get; set; }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<RERClassification> RERClassifications { get; set; }
        public DbSet<Requirements> Requirements { get; set; }
        public DbSet<DocumentsNeeded> DocumentsNeeded { get; set; }
        public DbSet<CaseType> CaseTypes { get; set; }
        public DbSet<CaseNature> CaseNatures { get; set; }
        public DbSet<PreFilingStatus> PreFilingStatus { get; set; }
        public DbSet<UserStatus> UserStatus { get; set; }
        public DbSet<PreFilingRequest> PreFilingRequests { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Hearing> Hearings { get; set; }
        public DbSet<HearingType> HearingTypes { get; set; }

        #endregion Variables

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ERCOFASContext"/> class.
        /// </summary>
        /// <param name="options">The database context options.</param>
        public ERCOFASContext(DbContextOptions<ERCOFASContext> options) : base(options)
        {
        }

        #endregion Constructor

        #region Protected

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Role>(ConfigureRole);
            builder.Entity<Page>(ConfigurePage);
            builder.Entity<UserRole>(ConfigureUserRole);
            builder.Entity<PageAccess>(ConfigurePageAccess);
            builder.Entity<Settings>(ConfigureSettings);
            builder.Entity<RERClassification>(ConfigureRERClassification);
            builder.Entity<Requirements>(ConfigureRequirements);
            builder.Entity<DocumentsNeeded>(ConfigureDocumentsNeeded);
            builder.Entity<CaseType>(ConfigureCaseType);
            builder.Entity<CaseNature>(ConfigureCaseNature);
            builder.Entity<PreFilingStatus>(ConfigurePreFilingStatus);
            builder.Entity<UserStatus>(ConfigureUserStatus);
            builder.Entity<PreFilingRequest>(ConfigurePreFilingRequest);
            builder.Entity<User>(ConfigureUser);
            builder.Entity<Hearing>(ConfigureHearing);
            builder.Entity<HearingType>(ConfigureHearingType);
        }

        #endregion Protected

        #region Private

        private void ConfigureRole(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Role");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.RoleName)
                .HasMaxLength(150)
                .IsRequired(true);

            builder.Property(x => x.Description)
                .HasMaxLength(250)
                .IsRequired(true);

            builder.Property(x => x.CreatedBy).IsRequired(true);
            builder.Property(x => x.DateCreated).IsRequired(true);
            builder.Property(x => x.UpdatedBy).IsRequired(false);
            builder.Property(x => x.DateUpdated).IsRequired(false);
        }

        private void ConfigurePage(EntityTypeBuilder<Page> builder)
        {
            builder.ToTable("Page");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.PageName)
                .HasMaxLength(150)
                .IsRequired(true);

            builder.Property(x => x.Description)
                .HasMaxLength(250)
                .IsRequired(true);

            builder.Property(x => x.UrlPath)
                .HasMaxLength(150)
                .IsRequired(true);

            builder.Property(x => x.ParentMenu)
                .HasMaxLength(50)
                .IsRequired(false);

            builder.Property(x => x.Icon)
                .HasMaxLength(50)
                .IsRequired(false);

            builder.Property(x => x.Order).IsRequired(true);
            builder.Property(x => x.IsParent).IsRequired(false);
            builder.Property(x => x.IsVisible).IsRequired(true);
            builder.Property(x => x.AccessibleByAll).IsRequired(true);
            builder.Property(x => x.IsActive).IsRequired(true);
            builder.Property(x => x.DateCreated).IsRequired(true);
        }

        private void ConfigureUserRole(EntityTypeBuilder<UserRole> builder)
        {
            builder.ToTable("UserRole");

            builder.HasKey(x => new { x.Id, x.UserId, x.RoleId });
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.CreatedBy).IsRequired(true);
            builder.Property(x => x.DateCreated).IsRequired(true);
            builder.Property(x => x.UpdatedBy).IsRequired(false);
            builder.Property(x => x.DateUpdated).IsRequired(false);
        }

        private void ConfigurePageAccess(EntityTypeBuilder<PageAccess> builder)
        {
            builder.ToTable("PageAccess");

            builder.HasKey(x => new { x.Id, x.PageId, x.RoleId });
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.CanCreate).IsRequired(true);
            builder.Property(x => x.CanRead).IsRequired(true);
            builder.Property(x => x.CanUpdate).IsRequired(true);
            builder.Property(x => x.CanDelete).IsRequired(true);
            builder.Property(x => x.CreatedBy).IsRequired(true);
            builder.Property(x => x.DateCreated).IsRequired(true);
            builder.Property(x => x.UpdatedBy).IsRequired(false);
            builder.Property(x => x.DateUpdated).IsRequired(false);
        }

        private void ConfigureSettings(EntityTypeBuilder<Settings> builder)
        {
            builder.ToTable("Settings");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.CompanyName)
                .HasMaxLength(200)
                .IsRequired(true);

            builder.Property(x => x.EmailAddress)
                .HasMaxLength(150)
                .IsRequired(true);

            builder.Property(x => x.PhoneNumber)
                .HasMaxLength(100)
                .IsRequired(true);

            builder.Property(x => x.MobileNumber)
                .HasMaxLength(100)
                .IsRequired(true);

            builder.Property(x => x.Address)
                .HasMaxLength(350)
                .IsRequired(true);

            builder.Property(x => x.AboutUs).IsRequired(false);
            builder.Property(x => x.Website)
                .HasMaxLength(150)
                .IsRequired(false);

            builder.Property(x => x.ERNumberPrefix)
                .HasMaxLength(25)
                .IsRequired(true);

            builder.Property(x => x.SMTPFromEmail)
                .HasMaxLength(150)
                .IsRequired(true);

            builder.Property(x => x.SMTPFromName)
                .HasMaxLength(200)
                .IsRequired(true);

            builder.Property(x => x.SMTPUsername)
                .HasMaxLength(150)
                .IsRequired(true);

            builder.Property(x => x.SMTPPassword)
                .HasMaxLength(150)
                .IsRequired(true);

            builder.Property(x => x.SMTPServerName)
                .HasMaxLength(100)
                .IsRequired(true);

            builder.Property(x => x.SMTPPort).IsRequired(true);
            builder.Property(x => x.EnableSSL).IsRequired(false);
            builder.Property(x => x.OTPAPIKey)
                .HasMaxLength(150)
                .IsRequired(true);

            builder.Property(x => x.OTPClientID)
                .HasMaxLength(150)
                .IsRequired(true);

            builder.Property(x => x.OTPUsername)
                .HasMaxLength(150)
                .IsRequired(false);

            builder.Property(x => x.OTPPassword)
                .HasMaxLength(150)
                .IsRequired(false);

            builder.Property(x => x.MinPasswordLength).IsRequired(true);
            builder.Property(x => x.MinSpecialCharacters).IsRequired(true);
            builder.Property(x => x.MaxSignOnAttempts).IsRequired(true);
            builder.Property(x => x.EnforcePasswordHistory).IsRequired(true);
            builder.Property(x => x.ActivationLinkExpiresIn)
                .HasMaxLength(150)
                .IsRequired(false);

            builder.Property(x => x.BaseUrl)
                .HasMaxLength(150)
                .IsRequired(false);

            builder.Property(x => x.CreatedBy).IsRequired(true);
            builder.Property(x => x.DateCreated).IsRequired(true);
            builder.Property(x => x.UpdatedBy).IsRequired(false);
            builder.Property(x => x.DateUpdated).IsRequired(false);
        }

        private void ConfigureRERClassification(EntityTypeBuilder<RERClassification> builder)
        {
            builder.ToTable("RERClassification");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Description)
                .HasMaxLength(250)
                .IsRequired(true);

            builder.Property(x => x.UserTypeId).IsRequired(false);
            builder.Property(x => x.CreatedBy).IsRequired(true);
            builder.Property(x => x.DateCreated).IsRequired(true);
            builder.Property(x => x.UpdatedBy).IsRequired(false);
            builder.Property(x => x.DateUpdated).IsRequired(false);
        }

        private void ConfigureRequirements(EntityTypeBuilder<Requirements> builder)
        {
            builder.ToTable("Requirements");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name)
                .HasMaxLength(250)
                .IsRequired(true);

            builder.Property(x => x.CreatedBy).IsRequired(true);
            builder.Property(x => x.DateCreated).IsRequired(true);
            builder.Property(x => x.UpdatedBy).IsRequired(false);
            builder.Property(x => x.DateUpdated).IsRequired(false);
        }

        private void ConfigureDocumentsNeeded(EntityTypeBuilder<DocumentsNeeded> builder)
        {
            builder.ToTable("DocumentsNeeded");

            builder.HasKey(x => new { x.Id, x.RequirementsId });
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Purpose)
                .HasMaxLength(50)
                .IsRequired(true);

            builder.Property(x => x.IsRequired).IsRequired(true);
            builder.Property(x => x.Description)
               .HasMaxLength(250)
               .IsRequired(false);

            builder.Property(x => x.CreatedBy).IsRequired(true);
            builder.Property(x => x.DateCreated).IsRequired(true);
            builder.Property(x => x.UpdatedBy).IsRequired(false);
            builder.Property(x => x.DateUpdated).IsRequired(false);
        }

        private void ConfigureCaseType(EntityTypeBuilder<CaseType> builder)
        {
            builder.ToTable("CaseType");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Description)
                .HasMaxLength(150)
                .IsRequired(true);

            builder.Property(x => x.Acronym).IsRequired(false);
            builder.Property(x => x.CreatedBy).IsRequired(true);
            builder.Property(x => x.DateCreated).IsRequired(true);
            builder.Property(x => x.UpdatedBy).IsRequired(false);
            builder.Property(x => x.DateUpdated).IsRequired(false);
        }

        private void ConfigureCaseNature(EntityTypeBuilder<CaseNature> builder)
        {
            builder.ToTable("CaseNature");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Description)
                .HasMaxLength(150)
                .IsRequired(true);

            builder.Property(x => x.CaseTypeId).IsRequired(true);
            builder.Property(x => x.CreatedBy).IsRequired(true);
            builder.Property(x => x.DateCreated).IsRequired(true);
            builder.Property(x => x.UpdatedBy).IsRequired(false);
            builder.Property(x => x.DateUpdated).IsRequired(false);
        }

        private void ConfigurePreFilingStatus(EntityTypeBuilder<PreFilingStatus> builder)
        {
            builder.ToTable("PreFilingStatus");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Description)
                .HasMaxLength(150)
                .IsRequired(true);

            builder.Property(x => x.CreatedBy).IsRequired(true);
            builder.Property(x => x.DateCreated).IsRequired(true);
            builder.Property(x => x.UpdatedBy).IsRequired(false);
            builder.Property(x => x.DateUpdated).IsRequired(false);
        }

        private void ConfigureUserStatus(EntityTypeBuilder<UserStatus> builder)
        {
            builder.ToTable("UserStatus");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Description)
                .HasMaxLength(150)
                .IsRequired(true);

            builder.Property(x => x.CreatedBy).IsRequired(true);
            builder.Property(x => x.DateCreated).IsRequired(true);
            builder.Property(x => x.UpdatedBy).IsRequired(false);
            builder.Property(x => x.DateUpdated).IsRequired(false);
        }

        private void ConfigurePreFilingRequest(EntityTypeBuilder<PreFilingRequest> builder)
        {
            builder.ToTable("PreFilingRequest");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.RequestSubject)
                .HasMaxLength(350)
                .IsRequired(true);

            builder.Property(x => x.UserId).IsRequired(true);
            builder.Property(x => x.CaseTypeId).IsRequired(true);
            builder.Property(x => x.CaseNatureId).IsRequired(true);
            builder.Property(x => x.PreFilingStatusId).IsRequired(true);
            builder.Property(x => x.Remarks).IsRequired(false);
            builder.Property(x => x.DateFiled).IsRequired(true);
        }

        private void ConfigureUser(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.RegistrationId).IsRequired(true);
            builder.Property(x => x.UserStatusId).IsRequired(true);
            builder.Property(x => x.LastName)
                .HasMaxLength(35)
                .IsRequired(true);

            builder.Property(x => x.FirstName)
                .HasMaxLength(35)
                .IsRequired(true);

            builder.Property(x => x.EmailAddress)
                .HasMaxLength(50)
                .IsRequired(true);

            builder.Property(x => x.Password)
                .HasMaxLength(500)
                .IsRequired(true);

            builder.Property(x => x.AvatarUrl)
                .HasMaxLength(250)
                .IsRequired(false);

            builder.Property(x => x.SignOnAttempts).IsRequired(true);
            builder.Property(x => x.PasswordToken)
                .HasMaxLength(250)
                .IsRequired(false);

            builder.Property(x => x.CreatedBy).IsRequired(true);
            builder.Property(x => x.DateCreated).IsRequired(true);
            builder.Property(x => x.UpdatedBy).IsRequired(false);
            builder.Property(x => x.DateUpdated).IsRequired(false);
        }

        private void ConfigureHearing(EntityTypeBuilder<Hearing> builder)
        {
            builder.ToTable("Hearing");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Description)
                .HasMaxLength(150)
                .IsRequired(false);
     
            builder.Property(x => x.HearingType).IsRequired(false);
            builder.Property(x => x.Schedule).IsRequired(false);
            builder.Property(x => x.MeetingLink)
                .HasMaxLength(150).IsRequired(false);
            builder.Property(x => x.CreatedBy).IsRequired(true);
            builder.Property(x => x.DateCreated).IsRequired(true);
            builder.Property(x => x.UpdatedBy).IsRequired(false);
            builder.Property(x => x.DateUpdated).IsRequired(false);
        }

        private void ConfigureHearingType(EntityTypeBuilder<HearingType> builder)
        {
            builder.ToTable("HearingType");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Description)
                .HasMaxLength(150)
                .IsRequired(false);

            builder.Property(x => x.Name)
                .HasMaxLength(150).IsRequired(true);
            builder.Property(x => x.CreatedBy).IsRequired(true);
            builder.Property(x => x.DateCreated).IsRequired(true);
            builder.Property(x => x.UpdatedBy).IsRequired(false);
            builder.Property(x => x.DateUpdated).IsRequired(false);
        }

        #endregion Private
    }
}
