using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Monogame_Game_Mechanics.ObjectComponents.GraphicComponents;
using Monogame_Game_Mechanics.General.Enums;

namespace Monogame_Game_Mechanics.Objects
{
	public abstract class BaseObject
	{
		public BaseObject( float xPositionIn, float yPositionIn )
		{
			Graphics = null;
			Type = ObjectTypes.NoType;
			Position = new Vector2 ( xPositionIn, yPositionIn );
			Height = 0;
			Width = 0;

		}

		public BaseObject( ObjectTypes typeIn, float xPositionIn, float yPositionIn )
			:
			this( xPositionIn, yPositionIn )
		{
			Type = typeIn;
		}

		public BaseObject( GraphicComponent graphicsIn, ObjectTypes typeIn, float xPositionIn, float yPositionIn )
			:
			this( typeIn, xPositionIn, yPositionIn )
		{
			Graphics = graphicsIn;
			Height = Graphics.GetTextureDimensions().Y;
			Width = Graphics.GetTextureDimensions().X;
		}

		public BaseObject( GraphicComponent graphicsIn, ObjectTypes typeIn, Vector2 positionIn )
			:
			this( graphicsIn, typeIn, positionIn.X, positionIn.Y )
		{ }

		abstract public Rectangle GetHitBox();
		abstract public void Render( ref SpriteBatch spriteBatch );
		abstract public void Render( ref SpriteBatch spriteBatch, Rectangle boundaryDimensions );
		abstract public void Update( float elapsedGameTime );

		public GraphicComponent Graphics { get; set; }
		public ObjectTypes Type { get; private set; }
		public Vector2 Position { get; set; }
		public float Height { get; private set; }
		public float Width { get; private set; }
	}
}
