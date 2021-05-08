using System;
namespace Fislab_project
{
    public class c_katrol: c_friction
    {
        private double _fs;
        private double _fk;
        public double Fs{get{return _fs;} set{_fs = value;}}
        public double Fk{get{return _fk;} set{_fk = value;}}
        public override double fs(){
            base.fs();
        }
        public override double fk(){
            base.fk();
        }
    }
}