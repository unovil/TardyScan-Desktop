using Microsoft.Extensions.Configuration;
using TardyQuery.Models;
using Postgrest.Responses;

using static TardyQuery.GuardChecks.Internet;
using static Postgrest.Constants;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics;
using TardyQuery.GuardChecks;

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
            string searchCategory = comboBoxSearchOptions.Text.Trim();
            string searchTerm = txtBoxSearchTerm.Text;

            if ((await IsConnectedToInternet()) == false) {
                MessageBox.Show("No internet connection!");
                return;
            }

            ModeledResponse<Student> result;
            if (searchCategory == comboBoxSearchOptions.Items[0].ToString()) { // last name
                result = await supabase
                  .From<Student>()
                  .Select(x => new object[] { x.Name, x.Section, x.LrnId, x.TardyDatetimeList })
                  .Filter(x => x.Name, Operator.ILike, "^(" + searchTerm + "),")
                  .Get();
            }
            else if (searchCategory == comboBoxSearchOptions.Items[1].ToString()) { // lrn
                result = await supabase
                 .From<Student>()
                 .Select(x => new object[] { x.Name, x.Section, x.LrnId, x.TardyDatetimeList })
                 .Where(x => x.LrnId == searchTerm)
                 .Get();
            }
            else {
                MessageBox.Show("Search category is empty!");
                return;
            }

            if (string.IsNullOrWhiteSpace(searchTerm)) {
                MessageBox.Show("Search term is empty!");
                return;
            }            

            if (result == null) {
                MessageBox.Show("Error!");
                return;
            }

            if (result.Models.Count == 0) {
                labelSearchOutcome.ForeColor = Color.Red;
                labelSearchOutcome.Text = "Query not found!";
                labelSearchOutcome.Visible = true;
                return;
            }
            else {
                labelSearchOutcome.ForeColor = Color.Green;
                labelSearchOutcome.Text = "Query found!";
                labelSearchOutcome.Visible = true;
            }

            foreach (Student student in result.Models) {
                txtBoxResultName.Text = student.Name;
                txtBoxResultSection.Text = student.Section;
                txtBoxResultLrn.Text = student.LrnId;
                foreach (DateTime tardyDate in student.TardyDatetimeList) {
                    Debug.Print(tardyDate.ToString());
                }
            }
        }
    }
}