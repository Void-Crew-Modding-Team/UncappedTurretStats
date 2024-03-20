using VoidManager.MPModChecks;

namespace UncappedTurretStats
{
    public class VoidManagerPlugin : VoidManager.VoidPlugin
    {
        public override MultiplayerType MPType => MultiplayerType.All;

        public override string Author => "Dragon";

        public override string Description => "Removes turret stat caps. Probably other stat caps too.";
    }
}
