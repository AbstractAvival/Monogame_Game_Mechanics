/********************************************
Programmer: AbstractAvival
Date: June 16, 2025

Class Description: 
Special state that serves as a placeholder for any other type 
of state. The BlankState has no real functionality.
********************************************/
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Monogame_Game_Mechanics.Handlers;
using Monogame_Game_Mechanics.Locales;

namespace Monogame_Game_Mechanics.States
{
	public class BlankState : GameState
	{
		public BlankState( Microsoft.Xna.Framework.Content.ContentManager contentIn, ref GraphicsDeviceManager graphicsIn, 
							int stateHeightIn, int stateWidthIn )
			:
			base( contentIn, ref graphicsIn, stateHeightIn, stateWidthIn )
		{ }

		public override void ClearContents() { }

		public override void InitializeState( StateHandler stateHandler, ResolutionHandler resolutionHandler, LocaleManager localeManager )
		{
			isInitialized = true;
		}

		public override void Render( ref SpriteBatch spriteBatch ) { }

		public override void UpdateLogic( StateHandler statehandler, KeyboardState state, float elapsedGameTime ) { }
	}
}
