using GalaSoft.MvvmLight.Command;
using PlantasClient.Claces;
using PlantasClient.Paginas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PlantasClient.ViewModels
{
    public class MenuItemViewModel : Menu
    {
       public ICommand NavigateCommand
        {
            get { return new RelayCommand(Navigate); }
        }

        private void Navigate()
        {
            App.Master.IsPresented = false;
            switch (PageName)
            {
                case "EnfermedadesPage":
                    App.Navigator.PushAsync(new EnfermedadesPage());
                    break;
                case "HierbasPage":
                    App.Navigator.PushAsync(new HierbasPage());
                    break;
                case "ConsultasPage":
                    App.Navigator.PushAsync(new ConsultasPage());
                    break;
                case "UbicacionPage":
                    App.Navigator.PushAsync(new UbicacionPage());
                    break;
                default:
                    break;
            }
        }
    }
}
