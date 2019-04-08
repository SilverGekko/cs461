using UnrealBuildTool;

public class PressVRTarget : TargetRules
{
	public PressVRTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("PressVR");
	}
}
