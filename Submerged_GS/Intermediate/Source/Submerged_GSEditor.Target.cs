using UnrealBuildTool;

public class Submerged_GSEditorTarget : TargetRules
{
	public Submerged_GSEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Submerged_GS");
	}
}
