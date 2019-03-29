using Ninject;

namespace ServiceLayer.Commmon
{
    public class NinjectAdapter : IAdapter 
    {
        private readonly StandardKernel kernel = new StandardKernel();
        private global::UI.NinjectBindingConfig ninjectBindingConfig;

        public NinjectAdapter(global::UI.NinjectBindingConfig ninjectBindingConfig)
        {
            this.ninjectBindingConfig = ninjectBindingConfig;
        }

        public void Registry<TInterface, TInstance>() where TInstance : class, TInterface
        {
            kernel.Bind<TInterface>().To<TInstance>().InSingletonScope();
        }

        public void RegistryInstance<TInstance>() where TInstance : class
        {
           kernel.Bind<TInstance>().ToSelf().InSingletonScope();
        }
        
        public TInstance GetInstanse<TInstance>()
        {
            return this.kernel.Get<TInstance>();
        }

        public TInterface GetInstanseWithInterface<TInterface>()
        {
            return kernel.Get<TInterface>();
        }

        public void RegistryInstanceToConst<TInterface, TImplementation>(TImplementation implementation)
            where TImplementation : TInterface
        {
            kernel.Bind<TInterface>().ToConstant(implementation).InSingletonScope();
        }
    }
}
