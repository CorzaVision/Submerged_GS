using UnrealBuildTool;

public class Submerged_GSTarget : TargetRules
{
	public Submerged_GSTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Submerged_GS");
	}
}
