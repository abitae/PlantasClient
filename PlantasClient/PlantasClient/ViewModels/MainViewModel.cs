using GalaSoft.MvvmLight.Command;
using PlantasClient.Paginas;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PlantasClient.ViewModels
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            LoadMenu();
            LoadEnfermedades();
        }

        private void LoadEnfermedades()
        {
            Enfermedades = new ObservableCollection<EnfermedadesViewModel>();
            for (int i = 1; i < 5; i++)
            {
                Enfermedades.Add(new EnfermedadesViewModel()
                {
                    IdEnfermedad=1,
                    Nombre="Nemobre Enfermedad",
                    Definicion="Definicion Enfermedad"
                }
                    
                    );
            }
        }

        private void LoadMenu()
        {
            Menu = new ObservableCollection<MenuItemViewModel>();
            Menu.Add(new MenuItemViewModel()
            {
                Icon = "ic_shortcut_save.png",
                Title = "Enfermedades",
                PageName = "EnfermedadesPage"

            });
            Menu.Add(new MenuItemViewModel()
            {
                Icon = "ic_shortcut_save",
                Title = "Hierbas",
                PageName = "HierbasPage"

            });
            Menu.Add(new MenuItemViewModel()
            {
                Icon = "ic_shortcut_save",
                Title = "Consultas",
                PageName = "ConsultasPage"

            });
            Menu.Add(new MenuItemViewModel()
            {
                Icon = "ic_shortcut_save",
                Title = "Ubicacion",
                PageName = "UbicacionPage"

            });
        }

        public ObservableCollection<MenuItemViewModel> Menu { get; set; }
        public ObservableCollection<EnfermedadesViewModel> Enfermedades { get; set; }

        public ICommand GoToCommand
        {
            get { return new RelayCommand<string>(GoTo); }
        }

        private void GoTo(string PageName)
        {
            switch (PageName)
            {
                case "EnfermedadNewPage":
                    App.Navigator.PushAsync(new EnfermedadNewPage());
                    break;
                default:
                    break;
            }
        }
    }
}
