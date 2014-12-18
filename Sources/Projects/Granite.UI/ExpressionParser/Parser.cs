using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Granite.UI.ExpressionParser
{
    partial class Parser
    {
        public struct StackItem
        {
            private readonly Node m_node;
            private readonly int m_state;

            public StackItem(Node node, int state)
            {
                m_node = node;
                m_state = state;
            }

            public Node Node { get { return m_node; } }
            public int State { get { return m_state; } }
        }

        public static LambdaExpression Parse(LambdaParsingContext context, string s)
        {
            var lambdaNode = Parse(new Tokenizer(s));

            var parameters = new ParameterExpression[] {
                Expression.Parameter(context.ModelType, "m")
            };

            var expression = lambdaNode.P2.GetExpression(new ExpressionParsingContext(context, parameters));

            return Expression.Lambda(expression, parameters);
        }
    }

    public sealed class ParseException : Exception
    {
        private readonly int m_position;

        public ParseException(int position, string message)
            : base(message)
        {
            m_position = position;
        }

        public int Position { get { return m_position; } }
    }
}
