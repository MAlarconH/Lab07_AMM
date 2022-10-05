using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab07_AMM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewCode : ContentPage
    {
        public ListViewCode()
        {
            InitializeComponent();
        }

        private void Button_Clicked(Object sender, EventArgs e)
        {
            listView.ItemsSource = new String[]
                {
                    "mono",
                    "monodroid",
                    "monotouch",
                    "monorail",
                    "monodevelop",
                    "monotone",
                    "monopoly",
                    "monomodal",
                    "mononucleosis"
                };

        }
    }
}