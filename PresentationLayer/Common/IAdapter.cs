using Ninject.Modules;
using Ninject.Planning.Bindings;
using System.Collections.Generic;

namespace PresentationLayer
{
    public interface IAdapter
    {
        void LoadConfig(IDIContainer container);
        void Registry<TInterface, TInstance>() where TInstance : class, TInterface;
        void RegistryInstance<TInstance>() where TInstance : class;
        void RegistryInstanceToConst<TInterface, TImplementation>(TImplementation implementation) where TImplementation:TInterface;

        TInstance GetInstanse<TInstance>();
        TInterface GetInstanseWithInterface<TInterface>();
    }
}