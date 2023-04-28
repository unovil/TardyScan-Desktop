using System.Globalization;

namespace TardyQuery.GuardChecks {
    internal class Internet {
        internal static async Task<bool> IsConnectedToInternet(int timeoutMs = 10000, string url = null) {
            try {
                url ??= CultureInfo.InstalledUICulture switch { 
                    { Name: var n } when n.StartsWith("fa") => // Iran
                        "http://www.aparat.com", 
                    { Name: var n } when n.StartsWith("zh") => // China
                        "http://www.baidu.com",
                    _ =>
                        "http://www.gstatic.com/generate_204",
                };

                using var httpClient = new HttpClient() { Timeout = TimeSpan.FromMilliseconds(timeoutMs) };
                using var response = await httpClient.GetAsync(url);
                return true;
            }
            catch {
                return false;
            }
        }
    }
    
    
}
