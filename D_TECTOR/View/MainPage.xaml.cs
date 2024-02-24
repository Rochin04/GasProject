using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D_TECTOR.ViewModel.VMGas;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace D_TECTOR.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new VMDetails(Navigation);
        }
    }
}