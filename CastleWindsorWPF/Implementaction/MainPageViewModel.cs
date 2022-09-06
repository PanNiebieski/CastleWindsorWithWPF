using CastleWindsorWPF.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleWindsorWPF.Implementaction
{
    public class MainPageViewModel : IMainPageViewModel
    {
        public IMainPageModel ViewModel { get; set; }

        public MainPageViewModel() { }
        public IMainPageModel Get()
        {
            ViewModel.MainLabel.Text = "Castle.Windsor";
            ViewModel.MainLabel.Size = 36;

            ViewModel.SubLabel.Text = "Inversion of Control";
            ViewModel.SubLabel.Size = 16;

            return ViewModel;

        }
    }

}
