using Backend.Application.AppSettings;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace BackendTemplate.DependencyExtensions
{
  /* public static class JWTAuthentication
   {
     public static void AddJWTAuthentication(this WebApplicationBuilder builder)
     {
       var jwtSettings = new JWTSettings();
       builder.Configuration.Bind("Jwt", jwtSettings);
       builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
               .AddJwtBearer(options =>
               {
                 options.TokenValidationParameters = new TokenValidationParameters
                 {
                   ValidateIssuer = true,
                   ValidateAudience = true,
                   ValidateLifetime = true,
                   ValidIssuer = jwtSettings.Issuer,
                   ValidAudience = jwtSettings.Audience,
                   IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.SecretKey))
                 };
               });
     }
   }*/

  public static class JWTAuthentication
  {
    public static void AddJWTAuthentication(this WebApplicationBuilder builder)
    {
      var jwtSettings = builder.Configuration.GetSection("Jwt").Get<JWTSettings>();

      builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
          .AddJwtBearer(options =>
          {
            options.TokenValidationParameters = BuildTokenValidationParameters(jwtSettings);
          });
    }

    private static TokenValidationParameters BuildTokenValidationParameters(JWTSettings jwtSettings)
    {
      return new TokenValidationParameters
      {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidIssuer = jwtSettings.Issuer,
        ValidAudience = jwtSettings.Audience,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.SecretKey))
      };
    }
  }

}




