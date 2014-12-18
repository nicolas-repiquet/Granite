using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Granite.UI.ExpressionParser
{
    public abstract class Node
    {
        public abstract int Position { get; }
    }

    public abstract class Token : Node
    {
        private readonly int m_position;

        public Token(int position)
        {
            m_position = position;
        }

        public override int Position { get { return m_position; } }
    }

    partial class ExpressionNode
    {
        public abstract Expression GetExpression(ExpressionParsingContext context);
    }

    partial class DotExpressionNode
    {
        public override Expression GetExpression(ExpressionParsingContext context)
        {
            var target = P0.GetExpression(context);
            var targetType = target.Type;

            var member = targetType.GetMember(P2.Value);

            return Expression.MakeMemberAccess(target, member[0]);
        }
    }

    partial class NegExpressionNode
    {
        public override Expression GetExpression(ExpressionParsingContext context)
        {
            return Expression.Negate(P1.GetExpression(context));
        }
    }

    partial class NotExpressionNode
    {
        public override Expression GetExpression(ExpressionParsingContext context)
        {
            return Expression.Not(P1.GetExpression(context));
        }
    }

    partial class MulExpressionNode
    {
        public override Expression GetExpression(ExpressionParsingContext context)
        {
            return Expression.Multiply(P0.GetExpression(context), P2.GetExpression(context));
        }
    }

    partial class DivExpressionNode
    {
        public override Expression GetExpression(ExpressionParsingContext context)
        {
            return Expression.Divide(P0.GetExpression(context), P2.GetExpression(context));
        }
    }

    partial class DotToken
    {
        public DotToken(int position)
            : base(position)
        {

        }
    }

    partial class MulToken
    {
        public MulToken(int position)
            : base(position)
        {

        }
    }

    partial class DivToken
    {
        public DivToken(int position)
            : base(position)
        {

        }
    }

    partial class NotToken
    {
        public NotToken(int position)
            : base(position)
        {

        }
    }

    partial class AddExpressionNode
    {
        public override Expression GetExpression(ExpressionParsingContext context)
        {
            return Expression.Add(P0.GetExpression(context), P2.GetExpression(context));
        }
    }

    partial class SubExpressionNode
    {
        public override Expression GetExpression(ExpressionParsingContext context)
        {
            return Expression.Subtract(P0.GetExpression(context), P2.GetExpression(context));
        }
    }

    partial class AddToken
    {
        public AddToken(int position)
            : base(position)
        {

        }
    }

    partial class SubToken
    {
        public SubToken(int position)
            : base(position)
        {

        }
    }

    partial class EqExpressionNode
    {
        public override Expression GetExpression(ExpressionParsingContext context)
        {
            return Expression.Equal(P0.GetExpression(context), P2.GetExpression(context));
        }
    }

    partial class NeqExpressionNode
    {
        public override Expression GetExpression(ExpressionParsingContext context)
        {
            return Expression.NotEqual(P0.GetExpression(context), P2.GetExpression(context));
        }
    }

    partial class GtExpressionNode
    {
        public override Expression GetExpression(ExpressionParsingContext context)
        {
            return Expression.GreaterThan(P0.GetExpression(context), P2.GetExpression(context));
        }
    }

    partial class GteqExpressionNode
    {
        public override Expression GetExpression(ExpressionParsingContext context)
        {
            return Expression.GreaterThanOrEqual(P0.GetExpression(context), P2.GetExpression(context));
        }
    }

    partial class LtExpressionNode
    {
        public override Expression GetExpression(ExpressionParsingContext context)
        {
            return Expression.LessThan(P0.GetExpression(context), P2.GetExpression(context));
        }
    }

    partial class LteqExpressionNode
    {
        public override Expression GetExpression(ExpressionParsingContext context)
        {
            return Expression.LessThanOrEqual(P0.GetExpression(context), P2.GetExpression(context));
        }
    }

    partial class EqToken
    {
        public EqToken(int position)
            : base(position)
        {

        }
    }

    partial class NeqToken
    {
        public NeqToken(int position)
            : base(position)
        {

        }

    }

    partial class GtToken
    {
        public GtToken(int position)
            : base(position)
        {

        }

    }

    partial class GteqToken
    {
        public GteqToken(int position)
            : base(position)
        {

        }

    }

    partial class LtToken
    {
        public LtToken(int position)
            : base(position)
        {

        }

    }

    partial class LteqToken
    {
        public LteqToken(int position)
            : base(position)
        {

        }

    }

    partial class AndExpressionNode
    {
        public override Expression GetExpression(ExpressionParsingContext context)
        {
            return Expression.AndAlso(P0.GetExpression(context), P2.GetExpression(context));
        }
    }

    partial class OrExpressionNode
    {
        public override Expression GetExpression(ExpressionParsingContext context)
        {
            return Expression.OrElse(P0.GetExpression(context), P2.GetExpression(context));
        }
    }

    partial class AndToken
    {
        public AndToken(int position)
            : base(position)
        {

        }

    }

    partial class OrToken
    {
        public OrToken(int position)
            : base(position)
        {

        }
    }

    partial class IdentifierToken
    {
        private readonly string m_value;

        public IdentifierToken(int position, string value)
            : base(position)
        {
            m_value = value;
        }

        public string Value { get { return m_value; } }
    }

    partial class IdentifierExpressionNode
    {
        public override Expression GetExpression(ExpressionParsingContext context)
        {
            return context.GetParameter(P0.Value);
        }
    }

    partial class TrueToken
    {
        public TrueToken(int position)
            : base(position)
        {

        }
    }

    partial class TrueExpressionNode
    {
        public override Expression GetExpression(ExpressionParsingContext context)
        {
            return Expression.Constant(true);
        }
    }

    partial class FalseToken
    {
        public FalseToken(int position)
            : base(position)
        {

        }
    }

    partial class FalseExpressionNode
    {
        public override Expression GetExpression(ExpressionParsingContext context)
        {
            return Expression.Constant(false);
        }
    }

    partial class NullToken
    {
        public NullToken(int position)
            : base(position)
        {

        }
    }


    partial class NullExpressionNode
    {
        public override Expression GetExpression(ExpressionParsingContext context)
        {
            return Expression.Constant(null);
        }
    }

    partial class ParExpressionNode
    {
        public override Expression GetExpression(ExpressionParsingContext context)
        {
            return P1.GetExpression(context);
        }
    }

    partial class OpeningParToken
    {
        public OpeningParToken(int position)
            : base(position)
        {

        }
    }

    partial class ClosingParToken
    {
        public ClosingParToken(int position)
            : base(position)
        {

        }
    }

    partial class StringExpressionNode
    {
        public override Expression GetExpression(ExpressionParsingContext context)
        {
            return Expression.Constant(P0.Value);
        }
    }

    partial class StringToken
    {
        private readonly string m_value;

        public StringToken(int position, string value)
            : base(position)
        {
            m_value = value;
        }

        public string Value { get { return m_value; } }
    }

    partial class NumberExpressionNode
    {
        public override Expression GetExpression(ExpressionParsingContext context)
        {
            return Expression.Constant(int.Parse(P0.Value, CultureInfo.InvariantCulture));
        }
    }

    partial class NumberToken
    {
        private readonly string m_value;

        public NumberToken(int position, string value)
            : base(position)
        {
            m_value = value;
        }

        public string Value { get { return m_value; } }
    }

    partial class CommaToken
    {
        public CommaToken(int position)
            : base(position)
        {

        }
    }

    partial class QuestionMarkToken
    {
        public QuestionMarkToken(int position)
            : base(position)
        {

        }
    }

    partial class CallExpressionNode
    {
        public override Expression GetExpression(ExpressionParsingContext context)
        {
            var call = P0 as DotExpressionNode;

            if (call != null)
            {
                return Expression.Call(call.P0.GetExpression(context), call.P2.Value, null, P2.GetExpressions(context));
            }
            else
            {
                return Expression.Invoke(P0.GetExpression(context), P2.GetExpressions(context));
            }
        }
    }

    partial class TernaryExpressionNode
    {
        public override Expression GetExpression(ExpressionParsingContext context)
        {
            return Expression.Condition(P0.GetExpression(context), P2.GetExpression(context), P4.GetExpression(context));
        }
    }

    partial class ExpressionListNode
    {
        public Expression[] GetExpressions(ExpressionParsingContext context)
        {
            var expressions = new List<Expression>();
            GetExpressions(context, expressions);
            return expressions.ToArray();
        }

        public abstract void GetExpressions(ExpressionParsingContext context, List<Expression> expressions);
    }

    partial class EmptyExpressionListNode
    {
        public override void GetExpressions(ExpressionParsingContext context, List<Expression> expressions)
        {

        }
    }

    partial class SingleExpressionListNode
    {
        public override void GetExpressions(ExpressionParsingContext context, List<Expression> expressions)
        {
            expressions.Add(P0.GetExpression(context));
        }
    }

    partial class MultipleExpressionListNode
    {
        public override void GetExpressions(ExpressionParsingContext context, List<Expression> expressions)
        {
            expressions.Add(P0.GetExpression(context));
            P2.GetExpressions(context, expressions);
        }
    }


    partial class ColonToken
    {
        public ColonToken(int position)
            : base(position)
        {

        }
    }

    partial class ArrowToken
    {
        public ArrowToken(int position)
            : base(position)
        {

        }
    }

    partial class LambdaNode
    {

    }

    partial class EndToken
    {
        public EndToken(int position)
            : base(position)
        {

        }
    }
}
