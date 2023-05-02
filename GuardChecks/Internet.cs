using System.Globalization;

namespace TardyQuery.GuardChecks {
    internal class Internet {
        internal static async Task<bool> IsConnectedToInternet(int timeoutMs = 10000, string? url = null) {

            // try to ping websites
            try {
                url ??= CultureInfo.InstalledUICulture switch { 
                    { Name: var n } when n.StartsWith("fa") => "http://www.aparat.com", // Iran
                    { Name: var n } when n.StartsWith("zh") => "http://www.baidu.com",  // China
                                                          _ => "http://www.gstatic.com/generate_204" // everywhere else
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
