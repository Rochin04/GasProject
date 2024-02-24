using D_TECTOR.View.SensoresView;
using D_TECTOR.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace D_TECTOR.ViewModel.VMGas.VM_Sensores
{
    public class VMEncenderSensores : BaseViewModel
    {
        public VMEncenderSensores(INavigation navigation)
        {
            Navigation = navigation;
        }
        #region Process
        public async Task DetallesSensores()
        {
            await Navigation.PushModalAsync(new sensores());
        }
        public async Task Volver()
        {
            await Navigation.PushModalAsync(new TiempoReal());
        }
        #endregion
        #region Commands
        public ICommand SensoresCommand => new Command(async () => await DetallesSensores());
        public ICommand VolverCommand => new Command(async () => await Volver());
        #endregion
    }
}
