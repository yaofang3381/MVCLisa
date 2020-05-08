using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCLisaBLL.Managers;
using MVCLisaBLL.Managers.Interfaces;


namespace MVCLisa.App_Start
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver()
        {
            kernel = new StandardKernel();
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        /// <summary>
        /// 添加绑定
        /// </summary>
        private void AddBindings()
        {
            //添加方式如下：左边括号里的是接口，后边括号里的实现接口的类
         kernel.Bind<IRoleManager>().To<RoleManager>();
        }
    }
}