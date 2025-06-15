using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Monogame_Game_Mechanics.Handlers;
using Monogame_Game_Mechanics.Locales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame_Game_Mechanics.States
{
	public class PlayState : GameState
	{
		public PlayState( Microsoft.Xna.Framework.Content.ContentManager contentIn, ref GraphicsDeviceManager graphicsIn,
							 int stateHeightIn, int stateWidthIn )
			:
			base( contentIn, ref graphicsIn, stateHeightIn, stateWidthIn )
		{ }

		public override void ClearContents() { }

		public override void InitializeState( StateHandler stateHandler, ResolutionHandler resolutionHandler, LocaleManager localeManager )
		{
			isInitialized = true;
		}

		public override void Render( ref SpriteBatch spriteBatch )
		{

		}

		public override void UpdateLogic( StateHandler stateHandler, KeyboardState keyboard, float elapsedGameTime )
		{

		}
	}
}
