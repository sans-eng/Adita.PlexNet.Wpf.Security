
using System;
using System.Security.Claims;
using System.Windows;
using Adita.PlexNet.Core.Security.Claims;
using Adita.PlexNet.Core.Security.Principals;
using ApplicationIdentity = Adita.PlexNet.Core.Security.Claims.ApplicationIdentity;

namespace Adita.PlexNet.Wpf.Security.Sample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            ApplicationIdentity applicationIdentity = new("password");
            applicationIdentity.AddClaim(new(ClaimTypes.Role, "Admin"));

            ApplicationPrincipal applicationPrincipal = new(applicationIdentity);
            AppDomain.CurrentDomain.SetThreadPrincipal(applicationPrincipal);
        }
    }
}
