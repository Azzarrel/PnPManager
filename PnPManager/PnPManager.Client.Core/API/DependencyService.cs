using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PnPManager.Client.Core.API
{
  public static class DependencyService
  {
    public static IServiceProvider ServiceProvider { get; private set; }

    static DependencyService()
    {
      var serviceCollection = new ServiceCollection();

    }


    public static ServiceCollection GenerateServiceCollection()
    {
      var services = new ServiceCollection();
     
      //Services to Initialize


      return services;

    }

    public static void  GetStartupWindow()
    {

    }
      
  }
}
