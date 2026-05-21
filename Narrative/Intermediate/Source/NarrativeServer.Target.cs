using UnrealBuildTool;

public class NarrativeServerTarget : TargetRules
{
	public NarrativeServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Narrative");
	}
}
