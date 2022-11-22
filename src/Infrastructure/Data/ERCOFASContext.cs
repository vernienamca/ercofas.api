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

        #endregion Private
    }
}
