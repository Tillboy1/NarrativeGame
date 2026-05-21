using UnrealBuildTool;

public class NarrativeEditorTarget : TargetRules
{
	public NarrativeEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Narrative");
	}
}
