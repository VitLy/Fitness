namespace PresentationLayer
{
    public interface IAdapter
    {
        void Registry<TInterface, TInstance>() where TInstance : class, TInterface;
        void RegistryInstance<TInstance>() where TInstance : class;
        void RegistryInstanceToConst<TInterface, TImplementation>(TImplementation implementation) where TImplementation:TInterface;

        TInstance GetInstanse<TInstance>();
        TInterface GetInstanseWithInterface<TInterface>();
    }
}