using UnrealBuildTool;

public class Submerged_GSServerTarget : TargetRules
{
	public Submerged_GSServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Submerged_GS");
	}
}
