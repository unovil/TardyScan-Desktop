using Postgrest.Responses;
using System.Diagnostics;
using TardyQuery.Models;
using static Postgrest.Constants;
using static TardyQuery.GuardChecks.Internet;

namespace TardyQuery {
    public partial class FormSearch : Form {
        #pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public FormSearch() => InitializeComponent();
        #pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        Supabase.Client supabase;
        private void FormSearch_Load(object sender, EventArgs e) {
            Task supabaseInit = new SupabaseFunctions().SupabaseInit(supabase);
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
                  .Select(x => new object[] { x.Name, x.Section, x.LrnId, x.TardyDatetimeList ?? new ArraySegment<DateTime>() })
                  .Filter(x => x.Name, Operator.ILike, "^(" + searchTerm + "),")
                  .Get();
            }
            else if (searchCategory == comboBoxSearchOptions.Items[1].ToString()) { // lrn
                result = await supabase
                 .From<Student>()
                 .Select(x => new object[] { x.Name, x.Section, x.LrnId, x.TardyDatetimeList ?? new ArraySegment<DateTime>() })
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

                if (student.TardyDatetimeList is null) { continue; }
                foreach (DateTime tardyDate in student.TardyDatetimeList) {
                    Debug.Print(tardyDate.ToString());
                }
            }
        }

    }
}