using  Microsoft.Xna.Framework.Graphics;
using System.Numerics;

namespace monogame2
{
   class Shapes
   {
       Texture2D texture; 
       Vector2 position;
       
       public void Draw(SpriteBatch spriteBatch)
       {
           Rectangle rectangle = new Rectangle((int)position.x, (int)position.y, 100, 50);
           spriteBatch.Draw(texture, rectangle, Color.White);
       }
       virtual public void Update() 
       {
   
       }
   }
}
   