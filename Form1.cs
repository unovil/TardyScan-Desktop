using Microsoft.Extensions.Configuration;

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