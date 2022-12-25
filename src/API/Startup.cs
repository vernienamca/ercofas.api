using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.EntityFrameworkCore;
using ERCOFAS.Api.Infrastructure.Data;
using ERCOFAS.ApplicationCore.Entities.Security;
using ERCOFAS.ApplicationCore.Interfaces;
using ERCOFAS.ApplicationCore.Services;

namespace ERCOFAS.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.

        services.AddCors();

            services.AddMvc(options => options.EnableEndpointRouting = false);

            services.AddControllers().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = "http://localhost:55653",
                ValidAudience = "http://localhost:55653",
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("KeyForSignInSecret@1234"))
            };
        });

            services.AddControllers();

            services.AddDbContext<ERCOFASContext>(options =>
              options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.Configure<TokenKeys>(Configuration.GetSection("TokenOptions"));

            services.AddScoped(typeof(ISettingsRepository), typeof(SettingsRepository));
            services.AddScoped(typeof(IRoleRepository), typeof(RoleRepository));
            services.AddScoped(typeof(IPageRepository), typeof(PageRepository));
            services.AddScoped(typeof(IManageRoleRepository), typeof(ManageRoleRepository));
            services.AddScoped(typeof(IRERClassificationRepository), typeof(RERClassificationRepository));
            services.AddScoped(typeof(IRequirementsRepository), typeof(RequirementsRepository));
            services.AddScoped(typeof(IDocumentsNeededRepository), typeof(DocumentsNeededRepository));
            services.AddScoped(typeof(ICaseNatureRepository), typeof(CaseNatureRepository));
            services.AddScoped(typeof(ICaseTypeRepository), typeof(CaseTypeRepository));
            services.AddScoped(typeof(IPreFilingRequestRepository), typeof(PreFilingRequestRepository));

            services.AddScoped(typeof(ISettingsService), typeof(SettingsService));
            services.AddScoped(typeof(IRoleService), typeof(RoleService));
            services.AddScoped(typeof(IPageService), typeof(PageService));
            services.AddScoped(typeof(IManageRoleService), typeof(ManageRoleService));
            services.AddScoped(typeof(IRERClassificationService), typeof(RERClassificationService));
            services.AddScoped(typeof(IDocumentsNeededService), typeof(DocumentsNeededService));
            services.AddScoped(typeof(IPreFilingRequestService), typeof(PreFilingRequestService));
        }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseCors(
            options => options.WithOrigins("localhost:3000").AllowAnyMethod().AllowAnyOrigin().AllowAnyHeader()
        );

        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseHttpsRedirection();

        app.UseRouting();

        app.UseAuthentication();

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
}
