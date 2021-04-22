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
    class c_parabola
    {
        private double _vo;
        private double _vt;
        private double _h;
        private double _hmax;
        private double _s;
        private double _smax;
        private double _gravity;
        private double _alpha;

        public double vo
        {
            get { return _vo; }
            set { _vo = value; }
        }
        public double vt
        {
            get { return _vt; }
            set { _vt = value; }
        }
        public double h
        {
            get { return _h; }
            set { _h = value; }
        }
        public double hmax
        {
            get { return _hmax; }
            set { _hmax = value; }
        }
        public double s
        {
            get { return _s; }
            set { _s = value; }
        }
        public double smax
        {
            get { return _smax; }
            set { _smax = value; }
        }
        public double gravity
        {
            get { return _gravity; }
            set { _gravity = value; }
        }
        public double alpha
        {
            get { return _alpha; }
            set { _alpha = value; }
        }
        public c_parabola() { }
        public c_parabola(double Vo, double Vt, double H, double Hmax, double S, double Smax, double Gravity, double Alpha)
        {
            vo = Vo;
            vt = Vt;
            h = H;
            hmax = Hmax;
            s = S;
            smax = Smax;
            gravity = Gravity;
            alpha = Alpha;
        }
    }
}