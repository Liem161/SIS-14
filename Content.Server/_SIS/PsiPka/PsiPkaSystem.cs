// SPDX-FileCopyrightText: 2026 SIS-14 contributors
//
// SPDX-License-Identifier: AGPL-3.0-or-later

using Content.Shared.Actions;

namespace Content.Server._SIS.PsiPka;

public sealed class PsiPkaSystem : EntitySystem
{
    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<PsiPkaComponent, GetItemActionsEvent>(GetPsiPkaAction);
    }

    private void GetPsiPkaAction(EntityUid uid, PsiPkaComponent component, GetItemActionsEvent args)
    {
        args.AddAction(ref component.StrikeActionEntity, component.StrikeAction);
    }
}
