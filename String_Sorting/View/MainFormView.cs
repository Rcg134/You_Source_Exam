// <copyright file="MainFormView.cs" company="Yousource">
// Copyright (c) Yousource. All rights reserved.
// </copyright>

namespace String_Sorting
{
    using String_Sorting.Model;
    using static String_Sorting.Model.SortingModel;

    public partial class MainFormView : Form
    {
        private readonly DictionaryEnumsMapper _dictionaryEnumsMapper;

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

        private void Cmb_SortList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Lbl_SortedString_Click(object sender, EventArgs e)
        {
        }
    }
}
