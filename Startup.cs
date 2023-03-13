// using cofinder.Models;
// using Microsoft.EntityFrameworkCore;
//
// namespace cofinder
// {
//     public class Startup
//     {
//         public Startup(IConfiguration configuration)
//         {
//             Configuration = configuration;
//         }
//
//         public IConfiguration Configuration { get; }
//
//         public void ConfigureServices(IServiceCollection services)
//         {
//
//             services.AddControllers();
//             services.AddDbContext<CoFinderContext>(options =>
//                 options.UseNpgsql(Configuration.GetConnectionString("test"))); 
//
//
//         }
//
//         public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
//         {
//             if (env.IsDevelopment())
//             {
//                 app.UseDeveloperExceptionPage();
//             }
//
//             app.UseHttpsRedirection();
//
//             app.UseRouting();
//
//             app.UseAuthorization();
//
//             app.UseEndpoints(endpoints =>
//             {
//                 endpoints.MapControllers();
//             });
//         }
//     }
// }
