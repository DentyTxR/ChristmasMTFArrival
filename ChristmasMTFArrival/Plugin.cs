using Exiled.API.Features;
using System;
using MapEvent = Exiled.Events.Handlers.Map;

namespace ChristmasMTFArrival
{

    public class ChristmasMTFArrivalPlugin : Plugin<Config>
    {
        public EventHandler EventHandler;
        public static ChristmasMTFArrivalPlugin Singleton;

        public override string Name { get; } = "ChristmasMTFArrivalPlugin";
        public override string Author { get; } = "Denty";
        public override string Prefix { get; } = "ChristmasMtfArrival";
        public override Version Version { get; } = new Version(1, 1, 1);
        public override Version RequiredExiledVersion { get; } = new Version(6, 0, 0);

        public override void OnEnabled()
        {
            Singleton = this;
            EventHandler = new EventHandler();

            //EnableEvents
            MapEvent.AnnouncingNtfEntrance += EventHandler.AnnouncingNtfEntrance;
        }

        public override void OnDisabled()
        {
            //DisableEvents
            MapEvent.AnnouncingNtfEntrance -= EventHandler.AnnouncingNtfEntrance;

            Singleton = null;
            base.OnDisabled();
        }
    }
}