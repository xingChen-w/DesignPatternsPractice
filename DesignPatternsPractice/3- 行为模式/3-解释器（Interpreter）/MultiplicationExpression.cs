﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Interpreter
{
    /// <summary>
    /// 乘法，非终结符表达式
    /// </summary>
    public class MultiplicationExpression : IExpression
    {
        private List<IExpression> ExpressionList { set; get; } = new List<IExpression>();

        public MultiplicationExpression(List<IExpression> expressions)
        {
            this.ExpressionList = expressions;
        }

        public double Interpret()
        {

            double sum = this.ExpressionList.FirstOrDefault().Interpret();

            for (int i = 1, len = this.ExpressionList.Count; i < len; i++)
            {
                sum *= this.ExpressionList[i].Interpret();
            }

            return sum;
        }
    }
}
