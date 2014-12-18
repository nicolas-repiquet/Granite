using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Granite.UI.ExpressionParser
{
    public sealed class LambdaParsingContext
    {
        public Type ModelType { get; private set; }

        public LambdaParsingContext(Type modelType)
        {
            ModelType = modelType;
        }
    }

    public sealed class ExpressionParsingContext
    {
        public LambdaParsingContext Lambda { get; private set; }
        private readonly Dictionary<string, ParameterExpression> m_parameters;

        public ExpressionParsingContext(LambdaParsingContext lambda, ParameterExpression[] parameters)
        {
            Lambda = lambda;
            m_parameters = new Dictionary<string, ParameterExpression>();
            foreach (var parameter in parameters)
            {
                m_parameters.Add(parameter.Name, parameter);
            }
        }

        public ParameterExpression GetParameter(string name)
        {
            ParameterExpression param;

            if (m_parameters.TryGetValue(name, out param))
            {
                return param;
            }
            else
            {
                return null;
            }
        }
    }
}
