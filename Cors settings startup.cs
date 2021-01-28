
//In startup.cs file on the method below define cors:

  public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddCors(options =>
            {
                options.AddPolicy("MyCorsPolicy",
                builder => builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
            });
        }
.....
......
  //Alempana otetaan Cors policy vielä käyttöön
  // Cors sallii muista palvelimista tulevat pyynnöt
  
App.UseCors("MyCorsPolicy");
