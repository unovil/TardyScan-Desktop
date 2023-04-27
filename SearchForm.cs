using Microsoft.Extensions.Configuration;
using TardyQuery.Models;
using Postgrest.Responses;

using static Postgrest.Constants;

namespace TardyQuery {

    public partial class FormSearch : Form {
        public FormSearch() {
            InitializeComponent();
        }

        Supabase.Client supabase;
        private void FormSearch_Load(object sender, EventArgs e) {
            Task supabaseInit = SupabaseInit();
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

            supabase = new Supabase.Client(url, key, options);
            await supabase.InitializeAsync();
        }

        private async void recordSearch(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(comboBoxSearchOptions.Text)) {
                MessageBox.Show("Search category is empty!");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtBoxSearchTerm.Text)) {
                MessageBox.Show("Search term is empty!");
                return;
            }

            string searchCategory = comboBoxSearchOptions.Text.Trim();
            string searchTerm = txtBoxSearchTerm.Text;

            ModeledResponse<Student> result = await supabase
              .From<Student>()
              .Select(x => new object[] { x.Name, x.Section, x.LrnId, x.TardyDatetimeList })
              .Filter(x => x.Name, Operator.ILike, searchTerm + ",%")
              .Get();

            if (result == null) {
                MessageBox.Show("No results found!");
                return;
            }

            foreach (Student student in result.Models) {
                txtBoxResultName.Text = student.Name;
                txtBoxResultSection.Text = student.Section;
                txtBoxResultLrn.Text = student.LrnId;
            }

        }
    }
}