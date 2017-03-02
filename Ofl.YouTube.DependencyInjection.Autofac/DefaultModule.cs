using System;
using Autofac;
using Ofl.YouTube.V3;

namespace Ofl.YouTube.DependencyInjection.Autofac
{
    public class DefaultModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // Validate parameters.
            if (builder == null) throw new ArgumentNullException(nameof(builder));

            // Bind.
            builder.RegisterType<YouTubeClient>().As<IYouTubeClient>();
            builder.RegisterType<YouTubeUtilities>().As<IYouTubeUtilities>();
        }
    }
}
