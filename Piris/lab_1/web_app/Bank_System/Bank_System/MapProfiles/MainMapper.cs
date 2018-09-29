using AutoMapper;

namespace Bank_System.MapProfiles
{
    public class MainMapper
    {
        public static MapperConfiguration MapperConfiguration { get; set; } = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile(typeof(ClientMapProfile));
        });        
    }
}