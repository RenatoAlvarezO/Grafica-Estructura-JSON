using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenTK;

namespace JSONSerializer
{
    public class Object3D
    {
        public HashSet<Face> ListOfFaces { get; set; }

        public Vertex Center { get; set; }

        public Object3D(HashSet<Face> listOfFaces, Vertex center)
        {
            ListOfFaces = listOfFaces;
            Center = center;
            SetCenter(center);
        }

        public void SetCenter(Vertex newCenter)
        {
            Center = newCenter;
            foreach (var face in ListOfFaces)
                face.Center = Center;
        }

        public void Draw(int TextureType)
        {
            foreach (var face in ListOfFaces)
                face.Draw(TextureType);
        }

        public HashSet<Face> getListOfFaces()
        {
            return this.ListOfFaces;
        }
    }
}