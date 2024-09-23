namespace String_Sorting
{
    using System.DirectoryServices;
    using System.Linq.Expressions;
    using String_Sorting.Model;
    using static String_Sorting.Model.SortingModel;

    public partial class MainFormView : Form
    {
        private readonly ISortStrategyRepository _sortStrategyRepository;
        private readonly DictionaryEnumsMapper _dictionaryEnumsMapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainFormView"/> class.
        /// </summary>
        public MainFormView(DictionaryEnumsMapper dictionaryEnumsMapper)
        {
            this.InitializeComponent();
            this._dictionaryEnumsMapper = dictionaryEnumsMapper;
        }

        private void MainViewForm_Load(object sender, EventArgs e)
        {
            this.Txt_Input.Focus();
            this.Cmb_SortList.DataSource = Enum.GetValues(typeof(SortingStrategy));
        }

        private void Cmb_SortList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Btn_ExecuteSort_Click(object sender, EventArgs e)
        {
            if (this.Cmb_SortList.SelectedItem is SortingStrategy selectedStrategy)
            {
                var sortModel = new SortingModel
                {
                    InputString = this.Txt_Input.Text,
                };

                var output = this._dictionaryEnumsMapper.Sort(sortModel, selectedStrategy);

                this.Lbl_SortedString.Text = output;
            }
        }

        private void Lbl_SortedString_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
