using Postgrest.Responses;
using System.Diagnostics;
using TardyQuery.Models;
using static Postgrest.Constants;
using static TardyQuery.GuardChecks.Internet;

namespace TardyQuery {
    public partial class FormSearch : Form {
        public FormSearch() => InitializeComponent();


        Supabase.Client supabase;
        private void FormSearch_Load(object sender, EventArgs e) {
            // init supabase
            var supabaseFunctions = new SupabaseFunctions();
            Task<Supabase.Client> supabaseInitTask = Task.Run(async () => await supabaseFunctions.SupabaseInit());
            supabaseInitTask.ContinueWith(task => {
                if (task.IsCompletedSuccessfully) {
                    supabase = task.Result;
                }
                else {
                    MessageBox.Show("Some error occured!");
                    return;
                }
            }, TaskScheduler.FromCurrentSynchronizationContext());

            // init datagridview columns
            dgvTardy.AutoGenerateColumns = false;
            dgvTardy.Columns.Add("DateColumn", "Tardy Date");
            dgvTardy.Columns["DateColumn"].DataPropertyName = "TardyDate";
            dgvTardy.Columns.Add("TimeColumn", "Time");
            dgvTardy.Columns["TimeColumn"].DataPropertyName = "TardyTime";
        }

        // on change of any input, hide the search outcome label
        private void Input_Change(object sender, EventArgs e) {
            labelSearchOutcome.ForeColor = Color.Black;
            labelSearchOutcome.Text = "";
            labelSearchOutcome.Visible = false;
        }

        // on click of search button
        private async void recordSearch(object sender, EventArgs e) {
            string searchCategory = comboBoxSearchOptions.Text;
            string searchTerm = txtBoxSearchTerm.Text.Trim();

            // check internet connection
            if ((await IsConnectedToInternet()) == false) {
                MessageBox.Show("No internet connection!");
                return;
            }

            // check if search category is empty
            ModeledResponse<Student> result;
            if (searchCategory == comboBoxSearchOptions.Items[0].ToString()) { // last name
                result = await supabase
                  .From<Student>()
                  .Select(x => new object[] { x.Name, x.Section, x.LrnId, x.TardyDatetimeList })
                  .Filter(x => x.Name, Operator.ILike, searchTerm + "%")
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

            // check if search term is empty
            if (string.IsNullOrWhiteSpace(searchTerm)) {
                MessageBox.Show("Search term is empty!");
                return;
            }

            // check if query is found
            if (result.Models.Count == 0) {
                labelSearchOutcome.ForeColor = Color.Red;
                labelSearchOutcome.Text = "Query not found!";
                labelSearchOutcome.Visible = true;

                // clear everything
                txtBoxResultName.Text = "";
                txtBoxResultSection.Text = "";
                txtBoxResultLrn.Text = "";
                dgvTardy.DataSource = null;
                dgvTardy.Refresh();
                return;
            }
            else {
                labelSearchOutcome.ForeColor = Color.Green;
                labelSearchOutcome.Text = "Query found!";
                labelSearchOutcome.Visible = true;
            }

            // generate results and display
            foreach (Student student in result.Models) {
                txtBoxResultName.Text = student.Name;
                txtBoxResultSection.Text = student.Section;
                txtBoxResultLrn.Text = student.LrnId;

                dgvTardy.DataSource = GetSeparateTardyDateTimeList(student.TardyDatetimeList);
                dgvTardy.Refresh();
            }
        }

        // convert DateTime[] to List<TardyDateTime>
        private List<TardyDateTime>? GetSeparateTardyDateTimeList(DateTime[]? dateTimeList) {
            List<TardyDateTime> tardyDateTimeList = new List<TardyDateTime>();
            if (dateTimeList is null) { return null; }
            foreach (DateTime tardyDate in dateTimeList) {
                Debug.Print(tardyDate.ToString());
                Debug.Print(DateOnly.FromDateTime(tardyDate).ToString());
                Debug.Print(TimeOnly.FromDateTime(tardyDate).ToString());

                // add to list
                tardyDateTimeList.Add(new TardyDateTime() {
                    TardyDate = DateOnly.FromDateTime(tardyDate).ToString(),
                    TardyTime = TimeOnly.FromDateTime(tardyDate).ToString()
                });
            }

            return tardyDateTimeList;
        }
    }
}