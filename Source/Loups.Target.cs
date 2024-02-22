// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class LoupsTarget : TargetRules
{
	public LoupsTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V4;

		bUsesSteam = true;

        ExtraModuleNames.AddRange( new string[] { "Loups" } );
    }
}
