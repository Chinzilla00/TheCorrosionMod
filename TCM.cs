using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;

namespace ExampleMod
{
    public class ExampleMod : Mod
    {
        public ExampleMod()
        {

        }

        public override void Load()
        {

            On.Terraria.GameContent.UI.Elements.UIGenProgressBar.DrawSelf += UIGenProgressBarDrawSelf;

            if (!Main.dedServ)
            {

            }
        }

        private void UIGenProgressBarDrawSelf(On.Terraria.GameContent.UI.Elements.UIGenProgressBar.orig_DrawSelf orig, Terraria.GameContent.UI.Elements.UIGenProgressBar self, SpriteBatch spriteBatch)
        {
            
        }

        public override void Unload()
        {
            if (!Main.dedServ)
            {

            }
        }
    }
}