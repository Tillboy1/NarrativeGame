using UnrealBuildTool;

public class NarrativeTarget : TargetRules
{
	public NarrativeTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Narrative");
	}
}
