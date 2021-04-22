using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fislab_Project
{
    public class calculate_glb
    {
        public void calculateS()
        {
            c_glb glb = new c_glb();
            glb.s = glb.velocity * glb.time;
        }
        public void calculateV()
        {
            c_glb glb = new c_glb();
            glb.velocity = glb.s / glb.time;
        }
        public void calculateT ()
        {
            c_glb glb = new c_glb();
            glb.time = glb.s / glb.velocity;
        }
    }
}