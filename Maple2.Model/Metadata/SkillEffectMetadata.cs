﻿using Maple2.Model.Enum;

namespace Maple2.Model.Metadata;

public record SkillEffectMetadata(
    int FireCount,
    SkillEffectMetadata.Skill[] Skills,
    SkillEffectMetadataCondition? Condition,
    SkillEffectMetadataSplash? Splash
) {
    public record Skill(int Id, int Level, int LinkId = 0);
}

public record SkillEffectMetadataCondition(
    SkillEntity Owner,
    SkillEntity Target,
    int OverlapCount,         // Skill only
    bool DependOnDamageCount, // Skill only
    bool RandomCast,          // AdditionalEffect only
    bool ActiveByIntervalTick // AdditionalEffect only
);

public record SkillEffectMetadataSplash(
    int Interval,
    int Delay,
    int RemoveDelay,
    bool UseDirection,
    bool ImmediateActive,
    bool NonTargetActive,
    bool OnlySensingActive,         // Skill only
    bool DependOnCasterState,       // Skill only
    bool Independent,               // Skill only
    SkillEffectMetadataChain? Chain // AdditionalEffect only
);

public record SkillEffectMetadataChain(float Distance);
