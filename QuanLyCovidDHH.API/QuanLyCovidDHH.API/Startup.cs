using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using QuanLyCovidDHH.API.System;
using QuanLyCovidDHH.BAL.Account;
using QuanLyCovidDHH.BAL.Interface;
using QuanLyCovidDHH.BAL.Service;
using QuanLyCovidDHH.DAL.Interface;
using QuanLyCovidDHH.DAL.Repository;
using QuanLyCovidDHH.Domain.Account;

namespace QuanLyCovidDHH.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();

            services.AddDbContext<AccountDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("WebAppDbContextConnection")));

            services.AddDefaultIdentity<AppUser>()
                       .AddEntityFrameworkStores<AccountDbContext>() // Thêm triển khai EF lưu trữ thông tin về Idetity (theo AppDbContext -> MS SQL Server).
                       .AddDefaultTokenProviders(); // Thêm Token Provider - nó sử dụng để phát sinh token (reset password, confirm email ...)


            services.AddTransient<SignInManager<AppUser>, SignInManager<AppUser>>();
            services.AddTransient<UserManager<AppUser>, UserManager<AppUser>>();
            services.AddTransient<IUserService, UserService>();

            services.AddTransient<IFileUploadService, FileUploadService>();
            services.AddTransient<IFileUploadRepository, FileUploadRepository>();

            services.AddTransient<ITruongService, TruongService>();
            services.AddTransient<ITruongRepository, TruongRepository>();
            services.AddTransient<IKhoaService, KhoaService>();
            services.AddTransient<IKhoaRepository, KhoaRepository>();
            services.AddTransient<IKhoaHocService, KhoaHocService>();
            services.AddTransient<IKhoaHocRepository, KhoaHocRepository>();
            services.AddTransient<ISinhVienService, SinhVienService>();
            services.AddTransient<ISinhVienRepository, SinhVienRepository>();
            services.AddTransient<IVaccineService, VaccineService>();
            services.AddTransient<IVaccineRepository, VaccineRepository>();
            services.AddTransient<IChiTietTiemService, ChiTietTiemService>();
            services.AddTransient<IChiTietTiemRepository, ChiTietTiemRepository>();
            services.AddTransient<IKhaiBaoXetNghiemService, KhaiBaoXetNghiemService>();
            services.AddTransient<IKhaiBaoXetNghiemRepository, KhaiBaoXetNghiemRepository>();
            services.AddTransient<IKhaiBaoCachLyService, KhaiBaoCachLyService>();
            services.AddTransient<IKhaiBaoCachLyRepository, KhaiBaoCachLyRepository>();
            services.AddTransient<IBenhAnService, BenhAnService>();
            services.AddTransient<IBenhAnRepository, BenhAnRepository>();
            services.AddTransient<IBenhNenService, BenhNenService>();
            services.AddTransient<IBenhNenRepository, BenhNenRepository>();  
            services.AddTransient<IHauCovidService, HauCovidService>();
            services.AddTransient<IHauCovidRepository, HauCovidRepository>();
            services.AddTransient<ISoTheoDoiService, SoTheoDoiService>();
            services.AddTransient<ISoTheoDoiRepository, SoTheoDoiRepository>();
            services.AddTransient<IRoleService, RoleService>();
            services.AddTransient<IRoleRepository, RoleRepository>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "QuanLyCovidDHH.API", Version = "v1", Description = "" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "QuanLyCovidDHH.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            //app.UseAuthentication(); // xác thực danh tính
            app.UseAuthorization();// xác thực quyền truy cập


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
