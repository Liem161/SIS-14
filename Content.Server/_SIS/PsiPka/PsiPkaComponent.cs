// SPDX-FileCopyrightText: 2026 SIS-14 contributors
//
// SPDX-License-Identifier: AGPL-3.0-or-later

namespace Content.Server._SIS.PsiPka;

[RegisterComponent]
public sealed partial class PsiPkaComponent : Component
{
    [DataField("strikeActionEntity")]
    public EntityUid? StrikeActionEntity;

    [DataField("strikeAction")]
    public string StrikeAction = "ActionPsionikStrike";
}
