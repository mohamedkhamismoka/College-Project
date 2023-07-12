


var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddControllersWithViews();




/*Dependecy injection*/

builder.Services.AddScoped<IStudent, StudentRepo>();
builder.Services.AddScoped<IDepartment, DepartmentRepo>();
builder.Services.AddScoped<ITeacher, TeacherRepo>();
builder.Services.AddScoped<ICourse, CourseRepo>();
builder.Services.AddScoped<IPayment, PaymentRepo>();
builder.Services.AddScoped<IstudentCourse, StudentCourseRepo>();
builder.Services.AddScoped<Mailsender, sender>();
builder.Services.AddAutoMapper(x => x.AddProfile(new DomainProfile()));

//file of auto  mapper info
builder.Services.AddAutoMapper(x => x.AddProfile(new DomainProfile()));

//to get connection string
builder.Services.AddDbContextPool<DataBase>(opts =>
opts.UseSqlServer(builder.Configuration.GetConnectionString("sharp")));







// Configure the HTTP request pipeline.
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//--end localization
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();

app.UseAuthorization();


app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});


app.Run();









