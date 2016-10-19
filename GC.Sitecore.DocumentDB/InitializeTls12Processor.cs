using System.Security.Authentication;
using MongoDB.Driver;
using Sitecore.Analytics.Pipelines.UpdateMongoDriverSettings;

namespace GC.Sitecore.DocumentDB
{
    public class InitializeTls12Processor : UpdateMongoDriverSettingsProcessor
    {
        public override void UpdateSettings(UpdateMongoDriverSettingsArgs args)
        {
            args.MongoSettings.SslSettings = new SslSettings {EnabledSslProtocols = SslProtocols.Tls12};
        }
    }
}
