using Exiled.API.Features;
using Exiled.Events.EventArgs;


namespace ChristmasMTFArrival
{
    public class EventHandler
    {
        public void AnnouncingNtfEntrance(AnnouncingNtfEntranceEventArgs ev)
        {
            if(ev.ScpsLeft == 0)
            {
                Log.Debug("Sending noSCPs Christmas MTF arrival cassie");

                ev.IsAllowed = false;
                Cassie.GlitchyMessage($"xmas_epsilon11 nato_{ev.UnitName[0]} {ev.UnitNumber} xmas_hasentered NoSCPsLeft", 0.05f, 0.05f);
                return;
            }
            if (ev.ScpsLeft > 0)
            {
                Log.Debug("Sending SCPsLeft Christmas MTF arrival cassie");

                ev.IsAllowed = false;
                Cassie.GlitchyMessage($"xmas_epsilon11 nato_{ev.UnitName[0]} {ev.UnitNumber} xmas_hasentered {ev.ScpsLeft} xmas_scpsubjects", 0.05f, 0.05f);
                return;
            }
        }
    }
}