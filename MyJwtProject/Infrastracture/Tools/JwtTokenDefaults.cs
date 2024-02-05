namespace MyJwtProject.Infrastracture.Tools
{
    public class JwtTokenDefaults
    {
        /* 
         ValidAudience = "http://localhost",
		ValidIssuer = "http://localhost",
		ClockSkew = TimeSpan.Zero,
		IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("furkan1")),
		ValidateIssuerSigningKey = true,
		ValidateLifetime= true,
         */
        public const string ValidAudience = "http://localhost";
        public const string ValidIssuer = "http://localhost";
        public const string Key = "furkan1furkan1furkan1432412312312311423furkan1";
        public const int Expire = 5;
        
    }
}
