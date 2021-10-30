using System.Drawing;
using System.Collections.Generic;
using OpenTK.Graphics.OpenGL;

namespace JSONSerializer
{
    public class Face
    {
        public HashSet<Vertex> ListOfVertices { get; set; }
        public int FaceColor { get; set; }
        public Vertex Center { get; set; }


        public Face(HashSet<Vertex> listOfVertices, int faceColor, Vertex center)
        {
            ListOfVertices = listOfVertices;
            FaceColor = faceColor;
            Center = center;
        }

        public void Draw(int TextureType)
        {
            Color drawingColor = Color.FromArgb(FaceColor);
            GL.Color4(drawingColor);
            GL.Begin((PrimitiveType) TextureType);
            foreach (var vertex in ListOfVertices)
            {
                GL.Vertex3(vertex.X + Center.X, vertex.Y + Center.Y, vertex.Z + Center.Z);
            }

            GL.End();
            GL.Flush();

        }
        
    }
}