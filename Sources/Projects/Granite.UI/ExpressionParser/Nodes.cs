using System;
using System.Collections.Generic;
using System.Linq;
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


    partial class LambdaNode
    {

    }

    partial class DotExpressionNode
    {

    }

    partial class NegExpressionNode
    {

    }

    partial class NotExpressionNode
    {

    }

    partial class MulExpressionNode
    {

    }

    partial class DivExpressionNode
    {

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

    }

    partial class SubExpressionNode
    {

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

    }

    partial class NeqExpressionNode
    {

    }

    partial class GtExpressionNode
    {

    }

    partial class GteqExpressionNode
    {

    }

    partial class LtExpressionNode
    {

    }

    partial class LteqExpressionNode
    {

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

    }

    partial class OrExpressionNode
    {

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
 
    }

    partial class ParExpressionNode
    {

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

    }

    partial class ExpressionListNode
    {
        public List<ExpressionNode> GetParameters()
        {
            var parameters = new List<ExpressionNode>();
            GetParameters(parameters);
            return parameters;
        }

        public abstract void GetParameters(List<ExpressionNode> parameters);
    }

    partial class EmptyExpressionListNode
    {
        public override void GetParameters(List<ExpressionNode> parameters)
        {

        }
    }

    partial class SingleExpressionListNode
    {
        public override void GetParameters(List<ExpressionNode> parameters)
        {
            parameters.Add(P0);
        }
    }

    partial class MultipleExpressionListNode
    {
        public override void GetParameters(List<ExpressionNode> parameters)
        {
            parameters.Add(P0);
            P2.GetParameters(parameters);
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
