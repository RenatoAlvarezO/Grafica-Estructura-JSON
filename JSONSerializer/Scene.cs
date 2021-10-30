using System;
using System.Collections.Generic;

namespace JSONSerializer
{
    public class Scene
    {
        private HashSet<Object3D> listOfObject3Ds;
        public Vertex Center;

        public Scene(HashSet<Object3D> listOfObject3Ds, Vertex center)
        {
            this.listOfObject3Ds = listOfObject3Ds;
            Center = center;
            foreach (var object3D in this.listOfObject3Ds)
            {
                object3D.Center = center;
            }
        }

        public void Draw(int TextureType)
        {
            foreach (var object3D in listOfObject3Ds)
                object3D.Draw(TextureType);
        }
    }
}