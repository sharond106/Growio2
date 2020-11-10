// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class RollingEditorTarget : TargetRules
{
	public RollingEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
        bUsesSteam = true;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "Rolling" } );
	}
}
