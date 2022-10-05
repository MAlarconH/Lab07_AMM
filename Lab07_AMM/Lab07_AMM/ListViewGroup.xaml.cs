using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab07_AMM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroup : ContentPage
    {
        private ObservableCollection<DbzGroup> group { get; set; }

        public ListViewGroup()
        {
            InitializeComponent();

            group = new ObservableCollection<DbzGroup>();
            var saiyanGroup = new DbzGroup() { LongName = "Saiyans", ShortName = "S" };
            var humansGroup = new DbzGroup() { LongName = "Humans", ShortName = "H" };
            saiyanGroup.Add(new Dbz() { Name = "Goku", IsSaiyan = true, Age = 34 });
            saiyanGroup.Add(new Dbz() { Name = "Vegeta", IsSaiyan = true, Age = 48 });
            saiyanGroup.Add(new Dbz() { Name = "Gohan", IsSaiyan = true, Age = 23 });
            saiyanGroup.Add(new Dbz() { Name = "Trunks", IsSaiyan = true, Age = 14 });
            saiyanGroup.Add(new Dbz() { Name = "Goten", IsSaiyan = true, Age = 13 });
            humansGroup.Add(new Dbz() { Name = "Bulma", IsSaiyan = false, Age = 47 });
            humansGroup.Add(new Dbz() { Name = "Krilin", IsSaiyan = false, Age = 44 });

            group.Add(saiyanGroup); group.Add(humansGroup);
            lstView.ItemsSource = group;
        }
    }
}