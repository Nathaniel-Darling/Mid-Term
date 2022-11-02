using UnrealBuildTool;

public class MidtermTarget : TargetRules
{
	public MidtermTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Midterm");
	}
}
