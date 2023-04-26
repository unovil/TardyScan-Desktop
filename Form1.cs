using Microsoft.Extensions.Configuration;
using Postgrest.Attributes;
using Postgrest.Models;

[Table("cities")]
class City : BaseModel {
    [PrimaryKey("lrn_id")]
    public string? LrnId { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("section")]
    public string? Section { get; set; }

    [Column("tardy_datetimes")]
    public DateTime[]? TardyDatetimeList { get; set; }
}

namespace TardyQuery {

    public partial class FormSearch : Form {
        public FormSearch() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            Task supabaseClient = SupabaseInit();
        }

        private async Task SupabaseInit() {
            var builder = new ConfigurationBuilder();
            builder.AddUserSecrets<FormSearch>();
            var configuration = builder.Build();
            string url = configuration.GetSection("SUPABASE_URL").Value ?? string.Empty;
            string? key = configuration.GetSection("SUPABASE_KEY").Value;

            var options = new Supabase.SupabaseOptions {
                AutoConnectRealtime = true
            };

            var supabase = new Supabase.Client(url, key, options);
            await supabase.InitializeAsync();
        }

        private void FormSearch_Load(object sender, EventArgs e) {

        }

        private void recordSearch(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(comboBoxOptions.Text)) {
                MessageBox.Show("Search category is empty!");
                return;
            } else if (string.IsNullOrWhiteSpace(txtBoxName.Text)) {
                MessageBox.Show("Search term is empty!");
                return;
            }

            string searchCategory = comboBoxOptions.Text;
            string searchTerm = txtBoxName.Text;

        }
    }
}