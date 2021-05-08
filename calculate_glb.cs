using System;
namespace Fislab_project
{
    public class calculate_glb
    {
        public calculateS(){
            c_glb glb = new c_glb();
            glb.s = glb.velocity * glb.time;
        }
        public calculateV(){
            c_glb glb = new c_glb();
            glb.velocity = glb.s/glb.time;
        }
        public calculateT(){
            c_glb glb = new c_glb();
            glb.time = glb.s/glb.velocity;
        }
    }
}