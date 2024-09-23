using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Sorting_Test
{
    public class SortTestModel
    {
        private string _expectedOutput;
        public string? exepectedInput
        {
            get => this._expectedOutput;
            set
            {
                _expectedOutput = value.ToLower();
            }
        }
        public string? expectedOutput { get; set; }
    }
}
