/********************************************
Programmer: Avival
Date: June 16, 2025

Class Description: 
Manages all of the GameStates in the game.
********************************************/
using Microsoft.Xna.Framework;
using Monogame_Game_Mechanics.General.Enums;
using Monogame_Game_Mechanics.Locales;
using Monogame_Game_Mechanics.States;

namespace Monogame_Game_Mechanics.Handlers
{
	public class StateHandler
	{
		public StateHandler()
		{
			localeManager = new LocaleManager();
			gameStates = new GameState[ maxStates ];
			currentState = GameStates.PlayState;
		}

		public void ChangeState( ResolutionHandler resolutionHandler, GameStates state )
		{
			gameStates[ ( int )currentState ].ClearContents();
			lastState = currentState;
			currentState = state;
			gameStates[ ( int )currentState ].Enter( this, resolutionHandler, localeManager );
		}

		public ref GameState GetCurrentState()
		{
			return ref gameStates[ ( int )currentState ];
		}

		public ref GameState GetLastState()
		{
			return ref gameStates[ ( int )lastState ];
		}

		public ref GameState GetState( GameStates state )
		{
			return ref gameStates[ ( int )state ];
		}

		public void Initialize( Microsoft.Xna.Framework.Content.ContentManager contentManager, GameWindow gameWindow, ref GraphicsDeviceManager graphics, ref ResolutionHandler resolutionHandler )
		{
			defaultStateHeight = graphics.PreferredBackBufferHeight;
			defaultStateWidth = graphics.PreferredBackBufferWidth;

			//Place game state instancing here.
			gameStates[ ( int )GameStates.MainMenuState ] = new BlankState( contentManager, ref graphics, defaultStateHeight, defaultStateWidth );
			gameStates[ ( int )GameStates.PlayState ] = new BlankState( contentManager, ref graphics, defaultStateHeight, defaultStateWidth );

			gameStates[ ( int )currentState ].Enter( this, resolutionHandler, localeManager );
		}

		private LocaleManager localeManager;
		private GameState[] gameStates;
		private GameStates currentState;
		private GameStates lastState;
		private const int maxStates = 2;
		private int defaultStateWidth;
		private int defaultStateHeight;
	}
}
