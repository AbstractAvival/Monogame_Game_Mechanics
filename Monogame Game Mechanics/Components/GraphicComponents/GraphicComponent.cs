using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Monogame_Game_Mechanics.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame_Game_Mechanics.Components.GraphicComponents
{
	public class GraphicComponent
	{
		public GraphicComponent() {}

		public GraphicComponent( Texture2D textureIn )
		{
			texture = textureIn;
		}

		virtual public Vector2 GetDrawingCoordinates( BaseObject baseObject )
		{
			return new Vector2( baseObject.Position.X - ( baseObject.Width / 2 ), baseObject.Position.Y - ( baseObject.Height / 2 ) );
		}

		virtual public Vector2 GetTextureDimensions()
		{
			return new Vector2( texture.Width, texture.Height );
		}

		virtual public void Render( BaseObject baseObject, ref SpriteBatch spriteBatch )
		{
			spriteBatch.Draw( texture, GetDrawingCoordinates( baseObject ), Color.White );
		}

		virtual public void Render( BaseObject baseObject, ref SpriteBatch spriteBatch, Rectangle boundaryDimensions )
		{
			Vector2 drawingCoordinates = GetDrawingCoordinates( baseObject );
			spriteBatch.Draw( texture, new Vector2( drawingCoordinates.X - boundaryDimensions.Left, drawingCoordinates.Y - boundaryDimensions.Top ), Color.White );
		}

		protected Texture2D texture;
	}
}
