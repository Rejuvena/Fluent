﻿#region License
// Copyright (C) 2021 Tomat and Contributors, MIT License
#endregion

using Terraria.ID;
using Terraria.ModLoader;

namespace Fluent.API.Defaults
{
    public class HoneyLiquid : ModLiquid
    {
        public override int WaterfallLength => 2;

        public override float DefaultOpacity => 0.95f;

        internal HoneyLiquid()
        {
            Type = LiquidID.Honey;
            ((ILoadable) this).Load(ModContent.GetInstance<Fluent>());
            ContentInstance.Register(this);
        }
    }
}