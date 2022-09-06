using Castle.MicroKernel.Registration;
using CastleWindsorWPF.Implementaction;
using CastleWindsorWPF.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parameter = CastleWindsorWPF.Implementaction.Parameter;

namespace CastleWindsorWPF
{
    public class Installers : IWindsorInstaller
    {

        public void Install(Castle.Windsor.IWindsorContainer container,
            Castle.MicroKernel.SubSystems.Configuration.IConfigurationStore store)
        {

            //rejestracja próśb
            container.Register(
                // gdy zapytam o ILabel
                Component.For<ILabel>().
                //to mam dać ci to
                ImplementedBy<Label>());

            container.Register(Component.For<IMainPageModel>()
                .ImplementedBy<MainPageModel>());

            container.Register(Component.For<IMainPageViewModel>().
                ImplementedBy<MainPageViewModel>());

            container.Register(Component.For<IShell>()
                .ImplementedBy<Shell>());

            container.Register(Component.For<IParameters>().
            ImplementedBy<Parameter>()
            .LifestyleSingleton());

            container.Register(Component.For<IMethods>().
                ImplementedBy<Methods>()
                .LifestyleSingleton());

            container.Register(Component.For<ICalculator>().
                ImplementedBy<Calcuator>()
                .LifestyleSingleton());

            container.Register(Component.For<MainWindow>().LifestyleTransient());
        }

    }
}
