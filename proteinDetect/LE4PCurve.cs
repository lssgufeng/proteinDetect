﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace proteinDetect
{
    /// <summary>
    /// Description of LE4PCurve.
    /// </summary>
    [Serializable]
    public class LE4PCurve : curveBase
    {
        //计算结果中，D为曲线最大值，A为最小值
        //这里面的ABCD并不是和曲线表达式中相对应的。
        public double A;
        public double B;
        public double C;
        public double D;
        public double[] cf = new double[4];

        public LE4PCurve()
        {

        }

        public LE4PCurve(double a, double b, double c, double d, double ss, double rs, double df, double rm, double ad)
            : base(ss, rs, df, ad, rm)
        {
            this.A = a;
            this.B = b;
            this.C = c;
            this.D = d;
            this.cf[0] = this.A;
            this.cf[1] = this.B;
            this.cf[2] = this.C;
            this.cf[3] = this.D;
        }

        public double mA
        {
            get
            {
                return this.A;
            }
        }

        public double mB
        {
            get
            {
                return this.B;
            }
        }

        public double mC
        {
            get
            {
                return this.C;
            }
        }

        public double mD
        {
            get
            {
                return this.D;
            }
        }
    }
}
