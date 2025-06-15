using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Monogame_Game_Mechanics.Handlers;

namespace Monogame_Game_Mechanics
{
	public class Game1 : Game
	{	 
		public Game1()
		{
			_graphics = new GraphicsDeviceManager( this );
			resolutionHandler = new ResolutionHandler( _graphics );
			Content.RootDirectory = "Content";
			stateHandler = new StateHandler();
			IsMouseVisible = true;
		}

		protected override void Initialize()
		{
			// TODO: Add your initialization logic here
			base.Initialize();
			stateHandler.Initialize( Content, Window, ref _graphics, ref resolutionHandler );
		}

		protected override void LoadContent()
		{
			_spriteBatch = new SpriteBatch( GraphicsDevice );
			// TODO: use this.Content to load your game content here
		}

		protected override void Update( GameTime gameTime )
		{
			if( GamePad.GetState( PlayerIndex.One ).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown( Keys.Escape ) )
				Exit();

			// TODO: Add your update logic here

			stateHandler.GetCurrentState().UpdateLogic( stateHandler, Keyboard.GetState(), ( float )gameTime.ElapsedGameTime.TotalSeconds );
			base.Update( gameTime );
		}

		protected override void Draw( GameTime gameTime )
		{
			GraphicsDevice.Clear( Color.CornflowerBlue );

			_spriteBatch.Begin();

			stateHandler.GetCurrentState().Render( ref _spriteBatch );

			_spriteBatch.End();

			base.Draw( gameTime );
		}

		private GraphicsDeviceManager _graphics;
		private ResolutionHandler resolutionHandler;
		private SpriteBatch _spriteBatch;
		private StateHandler stateHandler;
	}
}
