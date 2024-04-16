using UnrealBuildTool;

public class Submerged_GSClientTarget : TargetRules
{
	public Submerged_GSClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Submerged_GS");
	}
}
