using UnrealBuildTool;

public class NarrativeClientTarget : TargetRules
{
	public NarrativeClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Narrative");
	}
}
