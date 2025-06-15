/********************************************
Programmer: AbstractAvival
Date: June 16, 2025

Class Description: 
Game state base class. Serves as the main template for all other 
game states.
********************************************/
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Monogame_Game_Mechanics.Handlers;
using Monogame_Game_Mechanics.Locales;

namespace Monogame_Game_Mechanics.States
{
	public abstract class GameState
	{
		protected GameState( Microsoft.Xna.Framework.Content.ContentManager contentIn, ref GraphicsDeviceManager graphicsIn, 
							 int stateHeightIn, int stateWidthIn )
		{
			Content = contentIn;
			graphics = graphicsIn;
			isInitialized = false;
			stateHeight = stateHeightIn;
			stateWidth = stateWidthIn;
		}

		public abstract void ClearContents();
		public void Enter( StateHandler stateHandler, ResolutionHandler resolutionHandler, LocaleManager localeManager )
		{
			if( !isInitialized ) 
			{
				InitializeState( stateHandler, resolutionHandler, localeManager );
			}
		}

		public abstract void InitializeState( StateHandler stateHandler, ResolutionHandler resolutionHandler, LocaleManager localeManager );
		public abstract void UpdateLogic( StateHandler stateHandler, KeyboardState keyboard, float elapsedGameTime );
		public abstract void Render( ref SpriteBatch spriteBatch );

		public Microsoft.Xna.Framework.Content.ContentManager Content { get; }
		protected GraphicsDeviceManager graphics;
		protected bool isInitialized;
		protected int stateHeight;
		protected int stateWidth;
	}
}
