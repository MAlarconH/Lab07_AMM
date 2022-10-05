using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Lab07_AMM
{
    public class Dbz
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsSaiyan { get; set; }
        public string Image { get; set; }
        public Dbz()
        {
        }
    }

    public class DbzGroup : ObservableCollection<Dbz>
    {
        public string LongName { get; set; }
        public string ShortName { get; set; }
    }
}
