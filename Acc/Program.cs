using Acc.BL;
using Acc.DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

#region Defaults
// Add services to the container.
builder.Services.AddControllersWithViews();
#endregion
#region DataBase
var connectionString = builder.Configuration.GetConnectionString("StudentCourseTask");
builder.Services.AddDbContext<AccContext>(
    option => option.UseSqlServer(connectionString)
    );
#endregion
#region Repo
builder.Services.AddScoped<IStudentRepo, StudentRepo>();
builder.Services.AddScoped<ICourseRepo, CourseRepo>();
builder.Services.AddScoped<IStudentCourceRepo, StudentCourceRepo>();
builder.Services.AddScoped<ITeacherRepo, TeacherRepo>();
#endregion
#region Managers
builder.Services.AddScoped<IStudentManager, StudentManager>();
builder.Services.AddScoped<ICourseManager, CourseManager>();
#endregion
#region AutoMapper
builder.Services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
