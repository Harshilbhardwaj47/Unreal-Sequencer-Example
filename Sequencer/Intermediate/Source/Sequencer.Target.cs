using UnrealBuildTool;

public class SequencerTarget : TargetRules
{
	public SequencerTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Sequencer");
	}
}
