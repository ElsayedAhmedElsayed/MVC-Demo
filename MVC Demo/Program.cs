namespace mvcdemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            //app.MapGet("/", () => "Hello Dev!");

            app.UseRouting();

            app.UseStaticFiles();

            #region Parameters with Routing

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/Home", async context =>
            //    {
            //        await context.Response.WriteAsync("You are at Home Page");
            //    });

            //    endpoints.MapGet("/Products", async context =>
            //    {
            //        await context.Response.WriteAsync("You are at Products Page");
            //    });
            //    endpoints.MapGet("/Products/{ID:int?}", async context =>
            //    {
            //        var id =context.Request.RouteValues["ID"];

            //        if (id is not null)
            //        {
            //            int data =Convert.ToInt32(id);
            //            await context.Response.WriteAsync($"You are at Products Page ,id=>{data}");
            //        }
            //        else
            //        {
            //            await context.Response.WriteAsync("You are at Products Page ");
            //        }
            //    });

            //    endpoints.MapGet("/Books/{ID}/{Author:alpha:minlength(5):maxlength(50)}", async context =>
            //    {
            //        int id = Convert.ToInt32(context.Request.RouteValues["ID"]);
            //        string name = context.Request.RouteValues["Author"].ToString();

            //        await context.Response.WriteAsync($"You are at Books Page id => {id} ,Author => {name} ");
            //    });

            //}); 
            #endregion

            #region Action Result
            app.MapControllerRoute(
                name: "default",
                pattern: "/{Controller=Home}/{Action=Index}",
                defaults: new { Controller = "Home", Action = "Index" }
                );
            //app.MapControllerRoute(
            //    name: "default",
            //    pattern: "/{Controller=Home}/{Action=AboutUs}",
            //    defaults: new { Controller = "Home", Action = "AboutUs" }
            //    ); 
            #endregion

            //app.Run(async (HttpContext) => { await HttpContext.Response.WriteAsync("Your Requested Page not Found"); });
            app.Run();

        }
    }
}