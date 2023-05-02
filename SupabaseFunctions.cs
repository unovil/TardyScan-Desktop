using Microsoft.Extensions.Configuration;

namespace TardyQuery {
    public class SupabaseFunctions {
        public async Task<Supabase.Client> SupabaseInit() {
            Supabase.Client supabase;

            // get supabase url and key from user secrets
            var builder = new ConfigurationBuilder();
            builder.AddUserSecrets<FormSearch>();
            var configuration = builder.Build();
            string url = configuration.GetSection("SUPABASE_URL").Value ?? string.Empty;
            string? key = configuration.GetSection("SUPABASE_KEY").Value;

            // init supabase connection
            var options = new Supabase.SupabaseOptions {
                AutoConnectRealtime = true
            };
            supabase = new Supabase.Client(url, key, options);
            await supabase.InitializeAsync();
            return supabase;
        }
    }
}
