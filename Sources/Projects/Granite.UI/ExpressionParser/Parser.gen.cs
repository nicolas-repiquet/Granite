
namespace Granite.UI.ExpressionParser
{


using System.Collections.Generic;
using System.Linq;


// LambdaNode: LambdaParametersNode ArrowToken ExpressionNode EndToken
public sealed partial class LambdaNode : Node
{
    private readonly LambdaParametersNode m_p0;
    public LambdaParametersNode P0 {  get { return m_p0; } }
    private readonly ArrowToken m_p1;
    public ArrowToken P1 {  get { return m_p1; } }
    private readonly ExpressionNode m_p2;
    public ExpressionNode P2 {  get { return m_p2; } }
    private readonly EndToken m_p3;
    public EndToken P3 {  get { return m_p3; } }
    public LambdaNode(LambdaParametersNode p0, ArrowToken p1, ExpressionNode p2, EndToken p3)
    {
        m_p0 = p0;
        m_p1 = p1;
        m_p2 = p2;
        m_p3 = p3;
    }
    public override int Position { get { return m_p0.Position; } }
}

// LambdaParametersNode
public abstract partial class LambdaParametersNode : Node
{
}

// WithParenthesisLambdaParametersNode: OpeningParToken IdentifierListNode ClosingParToken
public sealed partial class WithParenthesisLambdaParametersNode : LambdaParametersNode
{
    private readonly OpeningParToken m_p0;
    public OpeningParToken P0 {  get { return m_p0; } }
    private readonly IdentifierListNode m_p1;
    public IdentifierListNode P1 {  get { return m_p1; } }
    private readonly ClosingParToken m_p2;
    public ClosingParToken P2 {  get { return m_p2; } }
    public WithParenthesisLambdaParametersNode(OpeningParToken p0, IdentifierListNode p1, ClosingParToken p2)
    {
        m_p0 = p0;
        m_p1 = p1;
        m_p2 = p2;
    }
    public override int Position { get { return m_p0.Position; } }
}

// OpeningParToken
public sealed partial class OpeningParToken : Token
{
}

// IdentifierListNode
public abstract partial class IdentifierListNode : Node
{
}

// EmptyIdentifierListNode: 
public sealed partial class EmptyIdentifierListNode : IdentifierListNode
{
    public EmptyIdentifierListNode()
    {
    }
    public override int Position { get { return 0; } }
}

// RealIdentifierListNode
public abstract partial class RealIdentifierListNode : IdentifierListNode
{
}

// SingleIdentifierListNode: ExpressionNode
public sealed partial class SingleIdentifierListNode : RealIdentifierListNode
{
    private readonly ExpressionNode m_p0;
    public ExpressionNode P0 {  get { return m_p0; } }
    public SingleIdentifierListNode(ExpressionNode p0)
    {
        m_p0 = p0;
    }
    public override int Position { get { return m_p0.Position; } }
}

// ExpressionNode
public abstract partial class ExpressionNode : Node
{
}

// DotExpressionNode: ExpressionNode DotToken IdentifierToken
public sealed partial class DotExpressionNode : ExpressionNode
{
    private readonly ExpressionNode m_p0;
    public ExpressionNode P0 {  get { return m_p0; } }
    private readonly DotToken m_p1;
    public DotToken P1 {  get { return m_p1; } }
    private readonly IdentifierToken m_p2;
    public IdentifierToken P2 {  get { return m_p2; } }
    public DotExpressionNode(ExpressionNode p0, DotToken p1, IdentifierToken p2)
    {
        m_p0 = p0;
        m_p1 = p1;
        m_p2 = p2;
    }
    public override int Position { get { return m_p0.Position; } }
}

// DotToken
public sealed partial class DotToken : Token
{
}

// IdentifierToken
public sealed partial class IdentifierToken : Token
{
}

// NegExpressionNode: SubToken ExpressionNode
public sealed partial class NegExpressionNode : ExpressionNode
{
    private readonly SubToken m_p0;
    public SubToken P0 {  get { return m_p0; } }
    private readonly ExpressionNode m_p1;
    public ExpressionNode P1 {  get { return m_p1; } }
    public NegExpressionNode(SubToken p0, ExpressionNode p1)
    {
        m_p0 = p0;
        m_p1 = p1;
    }
    public override int Position { get { return m_p0.Position; } }
}

// SubToken
public sealed partial class SubToken : Token
{
}

// NotExpressionNode: NotToken ExpressionNode
public sealed partial class NotExpressionNode : ExpressionNode
{
    private readonly NotToken m_p0;
    public NotToken P0 {  get { return m_p0; } }
    private readonly ExpressionNode m_p1;
    public ExpressionNode P1 {  get { return m_p1; } }
    public NotExpressionNode(NotToken p0, ExpressionNode p1)
    {
        m_p0 = p0;
        m_p1 = p1;
    }
    public override int Position { get { return m_p0.Position; } }
}

// NotToken
public sealed partial class NotToken : Token
{
}

// MulExpressionNode: ExpressionNode MulToken ExpressionNode
public sealed partial class MulExpressionNode : ExpressionNode
{
    private readonly ExpressionNode m_p0;
    public ExpressionNode P0 {  get { return m_p0; } }
    private readonly MulToken m_p1;
    public MulToken P1 {  get { return m_p1; } }
    private readonly ExpressionNode m_p2;
    public ExpressionNode P2 {  get { return m_p2; } }
    public MulExpressionNode(ExpressionNode p0, MulToken p1, ExpressionNode p2)
    {
        m_p0 = p0;
        m_p1 = p1;
        m_p2 = p2;
    }
    public override int Position { get { return m_p0.Position; } }
}

// MulToken
public sealed partial class MulToken : Token
{
}

// DivExpressionNode: ExpressionNode DivToken ExpressionNode
public sealed partial class DivExpressionNode : ExpressionNode
{
    private readonly ExpressionNode m_p0;
    public ExpressionNode P0 {  get { return m_p0; } }
    private readonly DivToken m_p1;
    public DivToken P1 {  get { return m_p1; } }
    private readonly ExpressionNode m_p2;
    public ExpressionNode P2 {  get { return m_p2; } }
    public DivExpressionNode(ExpressionNode p0, DivToken p1, ExpressionNode p2)
    {
        m_p0 = p0;
        m_p1 = p1;
        m_p2 = p2;
    }
    public override int Position { get { return m_p0.Position; } }
}

// DivToken
public sealed partial class DivToken : Token
{
}

// AddExpressionNode: ExpressionNode AddToken ExpressionNode
public sealed partial class AddExpressionNode : ExpressionNode
{
    private readonly ExpressionNode m_p0;
    public ExpressionNode P0 {  get { return m_p0; } }
    private readonly AddToken m_p1;
    public AddToken P1 {  get { return m_p1; } }
    private readonly ExpressionNode m_p2;
    public ExpressionNode P2 {  get { return m_p2; } }
    public AddExpressionNode(ExpressionNode p0, AddToken p1, ExpressionNode p2)
    {
        m_p0 = p0;
        m_p1 = p1;
        m_p2 = p2;
    }
    public override int Position { get { return m_p0.Position; } }
}

// AddToken
public sealed partial class AddToken : Token
{
}

// SubExpressionNode: ExpressionNode SubToken ExpressionNode
public sealed partial class SubExpressionNode : ExpressionNode
{
    private readonly ExpressionNode m_p0;
    public ExpressionNode P0 {  get { return m_p0; } }
    private readonly SubToken m_p1;
    public SubToken P1 {  get { return m_p1; } }
    private readonly ExpressionNode m_p2;
    public ExpressionNode P2 {  get { return m_p2; } }
    public SubExpressionNode(ExpressionNode p0, SubToken p1, ExpressionNode p2)
    {
        m_p0 = p0;
        m_p1 = p1;
        m_p2 = p2;
    }
    public override int Position { get { return m_p0.Position; } }
}

// EqExpressionNode: ExpressionNode EqToken ExpressionNode
public sealed partial class EqExpressionNode : ExpressionNode
{
    private readonly ExpressionNode m_p0;
    public ExpressionNode P0 {  get { return m_p0; } }
    private readonly EqToken m_p1;
    public EqToken P1 {  get { return m_p1; } }
    private readonly ExpressionNode m_p2;
    public ExpressionNode P2 {  get { return m_p2; } }
    public EqExpressionNode(ExpressionNode p0, EqToken p1, ExpressionNode p2)
    {
        m_p0 = p0;
        m_p1 = p1;
        m_p2 = p2;
    }
    public override int Position { get { return m_p0.Position; } }
}

// EqToken
public sealed partial class EqToken : Token
{
}

// NeqExpressionNode: ExpressionNode NeqToken ExpressionNode
public sealed partial class NeqExpressionNode : ExpressionNode
{
    private readonly ExpressionNode m_p0;
    public ExpressionNode P0 {  get { return m_p0; } }
    private readonly NeqToken m_p1;
    public NeqToken P1 {  get { return m_p1; } }
    private readonly ExpressionNode m_p2;
    public ExpressionNode P2 {  get { return m_p2; } }
    public NeqExpressionNode(ExpressionNode p0, NeqToken p1, ExpressionNode p2)
    {
        m_p0 = p0;
        m_p1 = p1;
        m_p2 = p2;
    }
    public override int Position { get { return m_p0.Position; } }
}

// NeqToken
public sealed partial class NeqToken : Token
{
}

// GtExpressionNode: ExpressionNode GtToken ExpressionNode
public sealed partial class GtExpressionNode : ExpressionNode
{
    private readonly ExpressionNode m_p0;
    public ExpressionNode P0 {  get { return m_p0; } }
    private readonly GtToken m_p1;
    public GtToken P1 {  get { return m_p1; } }
    private readonly ExpressionNode m_p2;
    public ExpressionNode P2 {  get { return m_p2; } }
    public GtExpressionNode(ExpressionNode p0, GtToken p1, ExpressionNode p2)
    {
        m_p0 = p0;
        m_p1 = p1;
        m_p2 = p2;
    }
    public override int Position { get { return m_p0.Position; } }
}

// GtToken
public sealed partial class GtToken : Token
{
}

// GteqExpressionNode: ExpressionNode GteqToken ExpressionNode
public sealed partial class GteqExpressionNode : ExpressionNode
{
    private readonly ExpressionNode m_p0;
    public ExpressionNode P0 {  get { return m_p0; } }
    private readonly GteqToken m_p1;
    public GteqToken P1 {  get { return m_p1; } }
    private readonly ExpressionNode m_p2;
    public ExpressionNode P2 {  get { return m_p2; } }
    public GteqExpressionNode(ExpressionNode p0, GteqToken p1, ExpressionNode p2)
    {
        m_p0 = p0;
        m_p1 = p1;
        m_p2 = p2;
    }
    public override int Position { get { return m_p0.Position; } }
}

// GteqToken
public sealed partial class GteqToken : Token
{
}

// LtExpressionNode: ExpressionNode LtToken ExpressionNode
public sealed partial class LtExpressionNode : ExpressionNode
{
    private readonly ExpressionNode m_p0;
    public ExpressionNode P0 {  get { return m_p0; } }
    private readonly LtToken m_p1;
    public LtToken P1 {  get { return m_p1; } }
    private readonly ExpressionNode m_p2;
    public ExpressionNode P2 {  get { return m_p2; } }
    public LtExpressionNode(ExpressionNode p0, LtToken p1, ExpressionNode p2)
    {
        m_p0 = p0;
        m_p1 = p1;
        m_p2 = p2;
    }
    public override int Position { get { return m_p0.Position; } }
}

// LtToken
public sealed partial class LtToken : Token
{
}

// LteqExpressionNode: ExpressionNode LteqToken ExpressionNode
public sealed partial class LteqExpressionNode : ExpressionNode
{
    private readonly ExpressionNode m_p0;
    public ExpressionNode P0 {  get { return m_p0; } }
    private readonly LteqToken m_p1;
    public LteqToken P1 {  get { return m_p1; } }
    private readonly ExpressionNode m_p2;
    public ExpressionNode P2 {  get { return m_p2; } }
    public LteqExpressionNode(ExpressionNode p0, LteqToken p1, ExpressionNode p2)
    {
        m_p0 = p0;
        m_p1 = p1;
        m_p2 = p2;
    }
    public override int Position { get { return m_p0.Position; } }
}

// LteqToken
public sealed partial class LteqToken : Token
{
}

// AndExpressionNode: ExpressionNode AndToken ExpressionNode
public sealed partial class AndExpressionNode : ExpressionNode
{
    private readonly ExpressionNode m_p0;
    public ExpressionNode P0 {  get { return m_p0; } }
    private readonly AndToken m_p1;
    public AndToken P1 {  get { return m_p1; } }
    private readonly ExpressionNode m_p2;
    public ExpressionNode P2 {  get { return m_p2; } }
    public AndExpressionNode(ExpressionNode p0, AndToken p1, ExpressionNode p2)
    {
        m_p0 = p0;
        m_p1 = p1;
        m_p2 = p2;
    }
    public override int Position { get { return m_p0.Position; } }
}

// AndToken
public sealed partial class AndToken : Token
{
}

// OrExpressionNode: ExpressionNode OrToken ExpressionNode
public sealed partial class OrExpressionNode : ExpressionNode
{
    private readonly ExpressionNode m_p0;
    public ExpressionNode P0 {  get { return m_p0; } }
    private readonly OrToken m_p1;
    public OrToken P1 {  get { return m_p1; } }
    private readonly ExpressionNode m_p2;
    public ExpressionNode P2 {  get { return m_p2; } }
    public OrExpressionNode(ExpressionNode p0, OrToken p1, ExpressionNode p2)
    {
        m_p0 = p0;
        m_p1 = p1;
        m_p2 = p2;
    }
    public override int Position { get { return m_p0.Position; } }
}

// OrToken
public sealed partial class OrToken : Token
{
}

// IdentifierExpressionNode: IdentifierToken
public sealed partial class IdentifierExpressionNode : ExpressionNode
{
    private readonly IdentifierToken m_p0;
    public IdentifierToken P0 {  get { return m_p0; } }
    public IdentifierExpressionNode(IdentifierToken p0)
    {
        m_p0 = p0;
    }
    public override int Position { get { return m_p0.Position; } }
}

// ParExpressionNode: OpeningParToken ExpressionNode ClosingParToken
public sealed partial class ParExpressionNode : ExpressionNode
{
    private readonly OpeningParToken m_p0;
    public OpeningParToken P0 {  get { return m_p0; } }
    private readonly ExpressionNode m_p1;
    public ExpressionNode P1 {  get { return m_p1; } }
    private readonly ClosingParToken m_p2;
    public ClosingParToken P2 {  get { return m_p2; } }
    public ParExpressionNode(OpeningParToken p0, ExpressionNode p1, ClosingParToken p2)
    {
        m_p0 = p0;
        m_p1 = p1;
        m_p2 = p2;
    }
    public override int Position { get { return m_p0.Position; } }
}

// ClosingParToken
public sealed partial class ClosingParToken : Token
{
}

// StringExpressionNode: StringToken
public sealed partial class StringExpressionNode : ExpressionNode
{
    private readonly StringToken m_p0;
    public StringToken P0 {  get { return m_p0; } }
    public StringExpressionNode(StringToken p0)
    {
        m_p0 = p0;
    }
    public override int Position { get { return m_p0.Position; } }
}

// StringToken
public sealed partial class StringToken : Token
{
}

// NumberExpressionNode: NumberToken
public sealed partial class NumberExpressionNode : ExpressionNode
{
    private readonly NumberToken m_p0;
    public NumberToken P0 {  get { return m_p0; } }
    public NumberExpressionNode(NumberToken p0)
    {
        m_p0 = p0;
    }
    public override int Position { get { return m_p0.Position; } }
}

// NumberToken
public sealed partial class NumberToken : Token
{
}

// TrueExpressionNode: TrueToken
public sealed partial class TrueExpressionNode : ExpressionNode
{
    private readonly TrueToken m_p0;
    public TrueToken P0 {  get { return m_p0; } }
    public TrueExpressionNode(TrueToken p0)
    {
        m_p0 = p0;
    }
    public override int Position { get { return m_p0.Position; } }
}

// TrueToken
public sealed partial class TrueToken : Token
{
}

// FalseExpressionNode: FalseToken
public sealed partial class FalseExpressionNode : ExpressionNode
{
    private readonly FalseToken m_p0;
    public FalseToken P0 {  get { return m_p0; } }
    public FalseExpressionNode(FalseToken p0)
    {
        m_p0 = p0;
    }
    public override int Position { get { return m_p0.Position; } }
}

// FalseToken
public sealed partial class FalseToken : Token
{
}

// NullExpressionNode: NullToken
public sealed partial class NullExpressionNode : ExpressionNode
{
    private readonly NullToken m_p0;
    public NullToken P0 {  get { return m_p0; } }
    public NullExpressionNode(NullToken p0)
    {
        m_p0 = p0;
    }
    public override int Position { get { return m_p0.Position; } }
}

// NullToken
public sealed partial class NullToken : Token
{
}

// TernaryExpressionNode: ExpressionNode QuestionMarkToken ExpressionNode ColonToken ExpressionNode
public sealed partial class TernaryExpressionNode : ExpressionNode
{
    private readonly ExpressionNode m_p0;
    public ExpressionNode P0 {  get { return m_p0; } }
    private readonly QuestionMarkToken m_p1;
    public QuestionMarkToken P1 {  get { return m_p1; } }
    private readonly ExpressionNode m_p2;
    public ExpressionNode P2 {  get { return m_p2; } }
    private readonly ColonToken m_p3;
    public ColonToken P3 {  get { return m_p3; } }
    private readonly ExpressionNode m_p4;
    public ExpressionNode P4 {  get { return m_p4; } }
    public TernaryExpressionNode(ExpressionNode p0, QuestionMarkToken p1, ExpressionNode p2, ColonToken p3, ExpressionNode p4)
    {
        m_p0 = p0;
        m_p1 = p1;
        m_p2 = p2;
        m_p3 = p3;
        m_p4 = p4;
    }
    public override int Position { get { return m_p0.Position; } }
}

// QuestionMarkToken
public sealed partial class QuestionMarkToken : Token
{
}

// ColonToken
public sealed partial class ColonToken : Token
{
}

// CallExpressionNode: ExpressionNode OpeningParToken ExpressionListNode ClosingParToken
public sealed partial class CallExpressionNode : ExpressionNode
{
    private readonly ExpressionNode m_p0;
    public ExpressionNode P0 {  get { return m_p0; } }
    private readonly OpeningParToken m_p1;
    public OpeningParToken P1 {  get { return m_p1; } }
    private readonly ExpressionListNode m_p2;
    public ExpressionListNode P2 {  get { return m_p2; } }
    private readonly ClosingParToken m_p3;
    public ClosingParToken P3 {  get { return m_p3; } }
    public CallExpressionNode(ExpressionNode p0, OpeningParToken p1, ExpressionListNode p2, ClosingParToken p3)
    {
        m_p0 = p0;
        m_p1 = p1;
        m_p2 = p2;
        m_p3 = p3;
    }
    public override int Position { get { return m_p0.Position; } }
}

// ExpressionListNode
public abstract partial class ExpressionListNode : Node
{
}

// EmptyExpressionListNode: 
public sealed partial class EmptyExpressionListNode : ExpressionListNode
{
    public EmptyExpressionListNode()
    {
    }
    public override int Position { get { return 0; } }
}

// RealExpressionListNode
public abstract partial class RealExpressionListNode : ExpressionListNode
{
}

// SingleExpressionListNode: ExpressionNode
public sealed partial class SingleExpressionListNode : RealExpressionListNode
{
    private readonly ExpressionNode m_p0;
    public ExpressionNode P0 {  get { return m_p0; } }
    public SingleExpressionListNode(ExpressionNode p0)
    {
        m_p0 = p0;
    }
    public override int Position { get { return m_p0.Position; } }
}

// MultipleExpressionListNode: ExpressionNode CommaToken RealExpressionListNode
public sealed partial class MultipleExpressionListNode : RealExpressionListNode
{
    private readonly ExpressionNode m_p0;
    public ExpressionNode P0 {  get { return m_p0; } }
    private readonly CommaToken m_p1;
    public CommaToken P1 {  get { return m_p1; } }
    private readonly RealExpressionListNode m_p2;
    public RealExpressionListNode P2 {  get { return m_p2; } }
    public MultipleExpressionListNode(ExpressionNode p0, CommaToken p1, RealExpressionListNode p2)
    {
        m_p0 = p0;
        m_p1 = p1;
        m_p2 = p2;
    }
    public override int Position { get { return m_p0.Position; } }
}

// CommaToken
public sealed partial class CommaToken : Token
{
}

// MultipleIdentifierListNode: ExpressionNode CommaToken RealIdentifierListNode
public sealed partial class MultipleIdentifierListNode : RealIdentifierListNode
{
    private readonly ExpressionNode m_p0;
    public ExpressionNode P0 {  get { return m_p0; } }
    private readonly CommaToken m_p1;
    public CommaToken P1 {  get { return m_p1; } }
    private readonly RealIdentifierListNode m_p2;
    public RealIdentifierListNode P2 {  get { return m_p2; } }
    public MultipleIdentifierListNode(ExpressionNode p0, CommaToken p1, RealIdentifierListNode p2)
    {
        m_p0 = p0;
        m_p1 = p1;
        m_p2 = p2;
    }
    public override int Position { get { return m_p0.Position; } }
}

// WithoutParenthesisLambdaParametersNode: IdentifierListNode
public sealed partial class WithoutParenthesisLambdaParametersNode : LambdaParametersNode
{
    private readonly IdentifierListNode m_p0;
    public IdentifierListNode P0 {  get { return m_p0; } }
    public WithoutParenthesisLambdaParametersNode(IdentifierListNode p0)
    {
        m_p0 = p0;
    }
    public override int Position { get { return m_p0.Position; } }
}

// ArrowToken
public sealed partial class ArrowToken : Token
{
}

// EndToken
public sealed partial class EndToken : Token
{
}



public static partial class Parser
{

    private static LambdaNode Parse(Tokenizer tokenizer)
    {

        int state = 0;
        var stack = new Stack<StackItem>();
        var input = new Stack<StackItem>();
        var tokens = tokenizer.Tokens;
        tokens.Reverse();

        foreach(var token in tokens)
        {
            input.Push(new StackItem(token, 0));
        }

        while(true)
        {
            switch(state)
            {
// ###################################
// # State 0
//
// LambdaNode                     : . LambdaParametersNode ArrowToken ExpressionNode EndToken
// WithParenthesisLambdaParametersNode : . OpeningParToken IdentifierListNode ClosingParToken
// WithoutParenthesisLambdaParametersNode : . IdentifierListNode
// EmptyIdentifierListNode        : .
// SingleIdentifierListNode       : . ExpressionNode
// DotExpressionNode              : . ExpressionNode DotToken IdentifierToken
// NegExpressionNode              : . SubToken ExpressionNode
// NotExpressionNode              : . NotToken ExpressionNode
// MulExpressionNode              : . ExpressionNode MulToken ExpressionNode
// DivExpressionNode              : . ExpressionNode DivToken ExpressionNode
// AddExpressionNode              : . ExpressionNode AddToken ExpressionNode
// SubExpressionNode              : . ExpressionNode SubToken ExpressionNode
// EqExpressionNode               : . ExpressionNode EqToken ExpressionNode
// NeqExpressionNode              : . ExpressionNode NeqToken ExpressionNode
// GtExpressionNode               : . ExpressionNode GtToken ExpressionNode
// GteqExpressionNode             : . ExpressionNode GteqToken ExpressionNode
// LtExpressionNode               : . ExpressionNode LtToken ExpressionNode
// LteqExpressionNode             : . ExpressionNode LteqToken ExpressionNode
// AndExpressionNode              : . ExpressionNode AndToken ExpressionNode
// OrExpressionNode               : . ExpressionNode OrToken ExpressionNode
// IdentifierExpressionNode       : . IdentifierToken
// ParExpressionNode              : . OpeningParToken ExpressionNode ClosingParToken
// StringExpressionNode           : . StringToken
// NumberExpressionNode           : . NumberToken
// TrueExpressionNode             : . TrueToken
// FalseExpressionNode            : . FalseToken
// NullExpressionNode             : . NullToken
// TernaryExpressionNode          : . ExpressionNode QuestionMarkToken ExpressionNode ColonToken ExpressionNode
// CallExpressionNode             : . ExpressionNode OpeningParToken ExpressionListNode ClosingParToken
// MultipleIdentifierListNode     : . ExpressionNode CommaToken RealIdentifierListNode
//
//  8: SubToken             -> 41
//  8: NotToken             -> 43
//  0: LambdaParametersNode -> 1
//  0: OpeningParToken      -> 54
//  0: IdentifierListNode   -> 60
//  0: ExpressionNode       -> 57
//  0: IdentifierToken      -> 45
//  0: StringToken          -> 49
//  0: NumberToken          -> 50
//  0: TrueToken            -> 51
//  0: FalseToken           -> 52
//  0: NullToken            -> 53
// -2: <- EmptyIdentifierListNode
//
//
                case 0:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 0));
                        state = 41;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 0));
                        state = 43;
                    }
                    else if(input.Peek().Node is LambdaParametersNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 0));
                        state = 1;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 0));
                        state = 54;
                    }
                    else if(input.Peek().Node is IdentifierListNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 0));
                        state = 60;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 0));
                        state = 57;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 0));
                        state = 45;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 0));
                        state = 49;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 0));
                        state = 50;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 0));
                        state = 51;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 0));
                        state = 52;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 0));
                        state = 53;
                    }
                    else
                    {
                        input.Push(new StackItem(new EmptyIdentifierListNode(), 0));
                    }
                    break;

// ###################################
// # State 1
//
// LambdaNode                     : LambdaParametersNode . ArrowToken ExpressionNode EndToken
//
//  0: ArrowToken           -> 2
//
//
                case 1:
                    if(input.Peek().Node is ArrowToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 1));
                        state = 2;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 2
//
// LambdaNode                     : LambdaParametersNode ArrowToken . ExpressionNode EndToken
// DotExpressionNode              : . ExpressionNode DotToken IdentifierToken
// NegExpressionNode              : . SubToken ExpressionNode
// NotExpressionNode              : . NotToken ExpressionNode
// MulExpressionNode              : . ExpressionNode MulToken ExpressionNode
// DivExpressionNode              : . ExpressionNode DivToken ExpressionNode
// AddExpressionNode              : . ExpressionNode AddToken ExpressionNode
// SubExpressionNode              : . ExpressionNode SubToken ExpressionNode
// EqExpressionNode               : . ExpressionNode EqToken ExpressionNode
// NeqExpressionNode              : . ExpressionNode NeqToken ExpressionNode
// GtExpressionNode               : . ExpressionNode GtToken ExpressionNode
// GteqExpressionNode             : . ExpressionNode GteqToken ExpressionNode
// LtExpressionNode               : . ExpressionNode LtToken ExpressionNode
// LteqExpressionNode             : . ExpressionNode LteqToken ExpressionNode
// AndExpressionNode              : . ExpressionNode AndToken ExpressionNode
// OrExpressionNode               : . ExpressionNode OrToken ExpressionNode
// IdentifierExpressionNode       : . IdentifierToken
// ParExpressionNode              : . OpeningParToken ExpressionNode ClosingParToken
// StringExpressionNode           : . StringToken
// NumberExpressionNode           : . NumberToken
// TrueExpressionNode             : . TrueToken
// FalseExpressionNode            : . FalseToken
// NullExpressionNode             : . NullToken
// TernaryExpressionNode          : . ExpressionNode QuestionMarkToken ExpressionNode ColonToken ExpressionNode
// CallExpressionNode             : . ExpressionNode OpeningParToken ExpressionListNode ClosingParToken
//
//  8: SubToken             -> 41
//  8: NotToken             -> 43
//  0: ExpressionNode       -> 3
//  0: IdentifierToken      -> 45
//  0: OpeningParToken      -> 46
//  0: StringToken          -> 49
//  0: NumberToken          -> 50
//  0: TrueToken            -> 51
//  0: FalseToken           -> 52
//  0: NullToken            -> 53
//
//
                case 2:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 2));
                        state = 41;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 2));
                        state = 43;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 2));
                        state = 3;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 2));
                        state = 45;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 2));
                        state = 46;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 2));
                        state = 49;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 2));
                        state = 50;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 2));
                        state = 51;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 2));
                        state = 52;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 2));
                        state = 53;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 3
//
// LambdaNode                     : LambdaParametersNode ArrowToken ExpressionNode . EndToken
// DotExpressionNode              : ExpressionNode . DotToken IdentifierToken
// MulExpressionNode              : ExpressionNode . MulToken ExpressionNode
// DivExpressionNode              : ExpressionNode . DivToken ExpressionNode
// AddExpressionNode              : ExpressionNode . AddToken ExpressionNode
// SubExpressionNode              : ExpressionNode . SubToken ExpressionNode
// EqExpressionNode               : ExpressionNode . EqToken ExpressionNode
// NeqExpressionNode              : ExpressionNode . NeqToken ExpressionNode
// GtExpressionNode               : ExpressionNode . GtToken ExpressionNode
// GteqExpressionNode             : ExpressionNode . GteqToken ExpressionNode
// LtExpressionNode               : ExpressionNode . LtToken ExpressionNode
// LteqExpressionNode             : ExpressionNode . LteqToken ExpressionNode
// AndExpressionNode              : ExpressionNode . AndToken ExpressionNode
// OrExpressionNode               : ExpressionNode . OrToken ExpressionNode
// TernaryExpressionNode          : ExpressionNode . QuestionMarkToken ExpressionNode ColonToken ExpressionNode
// CallExpressionNode             : ExpressionNode . OpeningParToken ExpressionListNode ClosingParToken
//
//  9: DotToken             -> 5
//  7: MulToken             -> 7
//  7: DivToken             -> 9
//  6: AddToken             -> 11
//  6: SubToken             -> 13
//  5: EqToken              -> 15
//  5: NeqToken             -> 17
//  5: GtToken              -> 19
//  5: GteqToken            -> 21
//  5: LtToken              -> 23
//  5: LteqToken            -> 25
//  4: AndToken             -> 27
//  3: OrToken              -> 29
//  2: QuestionMarkToken    -> 31
//  1: OpeningParToken      -> 35
//  0: EndToken             -> 4
//
//
                case 3:
                    if(input.Peek().Node is DotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 3));
                        state = 5;
                    }
                    else if(input.Peek().Node is MulToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 3));
                        state = 7;
                    }
                    else if(input.Peek().Node is DivToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 3));
                        state = 9;
                    }
                    else if(input.Peek().Node is AddToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 3));
                        state = 11;
                    }
                    else if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 3));
                        state = 13;
                    }
                    else if(input.Peek().Node is EqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 3));
                        state = 15;
                    }
                    else if(input.Peek().Node is NeqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 3));
                        state = 17;
                    }
                    else if(input.Peek().Node is GtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 3));
                        state = 19;
                    }
                    else if(input.Peek().Node is GteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 3));
                        state = 21;
                    }
                    else if(input.Peek().Node is LtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 3));
                        state = 23;
                    }
                    else if(input.Peek().Node is LteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 3));
                        state = 25;
                    }
                    else if(input.Peek().Node is AndToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 3));
                        state = 27;
                    }
                    else if(input.Peek().Node is OrToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 3));
                        state = 29;
                    }
                    else if(input.Peek().Node is QuestionMarkToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 3));
                        state = 31;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 3));
                        state = 35;
                    }
                    else if(input.Peek().Node is EndToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 3));
                        state = 4;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 4
//
// LambdaNode                     : LambdaParametersNode ArrowToken ExpressionNode EndToken .
//
//  0: <- LambdaNode
//
//
                case 4:
                    {
                        var p3 = stack.Pop();
                        var p2 = stack.Pop();
                        var p1 = stack.Pop();
                        var p0 = stack.Pop();
                        return new LambdaNode((LambdaParametersNode)p0.Node, (ArrowToken)p1.Node, (ExpressionNode)p2.Node, (EndToken)p3.Node);
                    }

// ###################################
// # State 5
//
// DotExpressionNode              : ExpressionNode DotToken . IdentifierToken
//
//  9: IdentifierToken      -> 6
//
//
                case 5:
                    if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 5));
                        state = 6;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 6
//
// DotExpressionNode              : ExpressionNode DotToken IdentifierToken .
//
//  9: <- DotExpressionNode
//
//
                case 6:
                    {
                        var p2 = stack.Pop();
                        var p1 = stack.Pop();
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new DotExpressionNode((ExpressionNode)p0.Node, (DotToken)p1.Node, (IdentifierToken)p2.Node), 6));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 7
//
// MulExpressionNode              : ExpressionNode MulToken . ExpressionNode
// DotExpressionNode              : . ExpressionNode DotToken IdentifierToken
// NegExpressionNode              : . SubToken ExpressionNode
// NotExpressionNode              : . NotToken ExpressionNode
// MulExpressionNode              : . ExpressionNode MulToken ExpressionNode
// DivExpressionNode              : . ExpressionNode DivToken ExpressionNode
// AddExpressionNode              : . ExpressionNode AddToken ExpressionNode
// SubExpressionNode              : . ExpressionNode SubToken ExpressionNode
// EqExpressionNode               : . ExpressionNode EqToken ExpressionNode
// NeqExpressionNode              : . ExpressionNode NeqToken ExpressionNode
// GtExpressionNode               : . ExpressionNode GtToken ExpressionNode
// GteqExpressionNode             : . ExpressionNode GteqToken ExpressionNode
// LtExpressionNode               : . ExpressionNode LtToken ExpressionNode
// LteqExpressionNode             : . ExpressionNode LteqToken ExpressionNode
// AndExpressionNode              : . ExpressionNode AndToken ExpressionNode
// OrExpressionNode               : . ExpressionNode OrToken ExpressionNode
// IdentifierExpressionNode       : . IdentifierToken
// ParExpressionNode              : . OpeningParToken ExpressionNode ClosingParToken
// StringExpressionNode           : . StringToken
// NumberExpressionNode           : . NumberToken
// TrueExpressionNode             : . TrueToken
// FalseExpressionNode            : . FalseToken
// NullExpressionNode             : . NullToken
// TernaryExpressionNode          : . ExpressionNode QuestionMarkToken ExpressionNode ColonToken ExpressionNode
// CallExpressionNode             : . ExpressionNode OpeningParToken ExpressionListNode ClosingParToken
//
//  8: SubToken             -> 41
//  8: NotToken             -> 43
//  0: ExpressionNode       -> 8
//  0: IdentifierToken      -> 45
//  0: OpeningParToken      -> 46
//  0: StringToken          -> 49
//  0: NumberToken          -> 50
//  0: TrueToken            -> 51
//  0: FalseToken           -> 52
//  0: NullToken            -> 53
//
//
                case 7:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 7));
                        state = 41;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 7));
                        state = 43;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 7));
                        state = 8;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 7));
                        state = 45;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 7));
                        state = 46;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 7));
                        state = 49;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 7));
                        state = 50;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 7));
                        state = 51;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 7));
                        state = 52;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 7));
                        state = 53;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 8
//
// MulExpressionNode              : ExpressionNode MulToken ExpressionNode .
// DotExpressionNode              : ExpressionNode . DotToken IdentifierToken
// MulExpressionNode              : ExpressionNode . MulToken ExpressionNode
// DivExpressionNode              : ExpressionNode . DivToken ExpressionNode
// AddExpressionNode              : ExpressionNode . AddToken ExpressionNode
// SubExpressionNode              : ExpressionNode . SubToken ExpressionNode
// EqExpressionNode               : ExpressionNode . EqToken ExpressionNode
// NeqExpressionNode              : ExpressionNode . NeqToken ExpressionNode
// GtExpressionNode               : ExpressionNode . GtToken ExpressionNode
// GteqExpressionNode             : ExpressionNode . GteqToken ExpressionNode
// LtExpressionNode               : ExpressionNode . LtToken ExpressionNode
// LteqExpressionNode             : ExpressionNode . LteqToken ExpressionNode
// AndExpressionNode              : ExpressionNode . AndToken ExpressionNode
// OrExpressionNode               : ExpressionNode . OrToken ExpressionNode
// TernaryExpressionNode          : ExpressionNode . QuestionMarkToken ExpressionNode ColonToken ExpressionNode
// CallExpressionNode             : ExpressionNode . OpeningParToken ExpressionListNode ClosingParToken
//
//  9: DotToken             -> 5
//  7: MulToken             -> 7
//  7: DivToken             -> 9
//  7: <- MulExpressionNode
//
//
                case 8:
                    if(input.Peek().Node is DotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 8));
                        state = 5;
                    }
                    else if(input.Peek().Node is MulToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 8));
                        state = 7;
                    }
                    else if(input.Peek().Node is DivToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 8));
                        state = 9;
                    }
                    else
                    {
                        var p2 = stack.Pop();
                        var p1 = stack.Pop();
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new MulExpressionNode((ExpressionNode)p0.Node, (MulToken)p1.Node, (ExpressionNode)p2.Node), 8));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 9
//
// DivExpressionNode              : ExpressionNode DivToken . ExpressionNode
// DotExpressionNode              : . ExpressionNode DotToken IdentifierToken
// NegExpressionNode              : . SubToken ExpressionNode
// NotExpressionNode              : . NotToken ExpressionNode
// MulExpressionNode              : . ExpressionNode MulToken ExpressionNode
// DivExpressionNode              : . ExpressionNode DivToken ExpressionNode
// AddExpressionNode              : . ExpressionNode AddToken ExpressionNode
// SubExpressionNode              : . ExpressionNode SubToken ExpressionNode
// EqExpressionNode               : . ExpressionNode EqToken ExpressionNode
// NeqExpressionNode              : . ExpressionNode NeqToken ExpressionNode
// GtExpressionNode               : . ExpressionNode GtToken ExpressionNode
// GteqExpressionNode             : . ExpressionNode GteqToken ExpressionNode
// LtExpressionNode               : . ExpressionNode LtToken ExpressionNode
// LteqExpressionNode             : . ExpressionNode LteqToken ExpressionNode
// AndExpressionNode              : . ExpressionNode AndToken ExpressionNode
// OrExpressionNode               : . ExpressionNode OrToken ExpressionNode
// IdentifierExpressionNode       : . IdentifierToken
// ParExpressionNode              : . OpeningParToken ExpressionNode ClosingParToken
// StringExpressionNode           : . StringToken
// NumberExpressionNode           : . NumberToken
// TrueExpressionNode             : . TrueToken
// FalseExpressionNode            : . FalseToken
// NullExpressionNode             : . NullToken
// TernaryExpressionNode          : . ExpressionNode QuestionMarkToken ExpressionNode ColonToken ExpressionNode
// CallExpressionNode             : . ExpressionNode OpeningParToken ExpressionListNode ClosingParToken
//
//  8: SubToken             -> 41
//  8: NotToken             -> 43
//  0: ExpressionNode       -> 10
//  0: IdentifierToken      -> 45
//  0: OpeningParToken      -> 46
//  0: StringToken          -> 49
//  0: NumberToken          -> 50
//  0: TrueToken            -> 51
//  0: FalseToken           -> 52
//  0: NullToken            -> 53
//
//
                case 9:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 9));
                        state = 41;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 9));
                        state = 43;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 9));
                        state = 10;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 9));
                        state = 45;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 9));
                        state = 46;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 9));
                        state = 49;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 9));
                        state = 50;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 9));
                        state = 51;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 9));
                        state = 52;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 9));
                        state = 53;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 10
//
// DivExpressionNode              : ExpressionNode DivToken ExpressionNode .
// DotExpressionNode              : ExpressionNode . DotToken IdentifierToken
// MulExpressionNode              : ExpressionNode . MulToken ExpressionNode
// DivExpressionNode              : ExpressionNode . DivToken ExpressionNode
// AddExpressionNode              : ExpressionNode . AddToken ExpressionNode
// SubExpressionNode              : ExpressionNode . SubToken ExpressionNode
// EqExpressionNode               : ExpressionNode . EqToken ExpressionNode
// NeqExpressionNode              : ExpressionNode . NeqToken ExpressionNode
// GtExpressionNode               : ExpressionNode . GtToken ExpressionNode
// GteqExpressionNode             : ExpressionNode . GteqToken ExpressionNode
// LtExpressionNode               : ExpressionNode . LtToken ExpressionNode
// LteqExpressionNode             : ExpressionNode . LteqToken ExpressionNode
// AndExpressionNode              : ExpressionNode . AndToken ExpressionNode
// OrExpressionNode               : ExpressionNode . OrToken ExpressionNode
// TernaryExpressionNode          : ExpressionNode . QuestionMarkToken ExpressionNode ColonToken ExpressionNode
// CallExpressionNode             : ExpressionNode . OpeningParToken ExpressionListNode ClosingParToken
//
//  9: DotToken             -> 5
//  7: MulToken             -> 7
//  7: DivToken             -> 9
//  7: <- DivExpressionNode
//
//
                case 10:
                    if(input.Peek().Node is DotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 10));
                        state = 5;
                    }
                    else if(input.Peek().Node is MulToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 10));
                        state = 7;
                    }
                    else if(input.Peek().Node is DivToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 10));
                        state = 9;
                    }
                    else
                    {
                        var p2 = stack.Pop();
                        var p1 = stack.Pop();
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new DivExpressionNode((ExpressionNode)p0.Node, (DivToken)p1.Node, (ExpressionNode)p2.Node), 10));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 11
//
// AddExpressionNode              : ExpressionNode AddToken . ExpressionNode
// DotExpressionNode              : . ExpressionNode DotToken IdentifierToken
// NegExpressionNode              : . SubToken ExpressionNode
// NotExpressionNode              : . NotToken ExpressionNode
// MulExpressionNode              : . ExpressionNode MulToken ExpressionNode
// DivExpressionNode              : . ExpressionNode DivToken ExpressionNode
// AddExpressionNode              : . ExpressionNode AddToken ExpressionNode
// SubExpressionNode              : . ExpressionNode SubToken ExpressionNode
// EqExpressionNode               : . ExpressionNode EqToken ExpressionNode
// NeqExpressionNode              : . ExpressionNode NeqToken ExpressionNode
// GtExpressionNode               : . ExpressionNode GtToken ExpressionNode
// GteqExpressionNode             : . ExpressionNode GteqToken ExpressionNode
// LtExpressionNode               : . ExpressionNode LtToken ExpressionNode
// LteqExpressionNode             : . ExpressionNode LteqToken ExpressionNode
// AndExpressionNode              : . ExpressionNode AndToken ExpressionNode
// OrExpressionNode               : . ExpressionNode OrToken ExpressionNode
// IdentifierExpressionNode       : . IdentifierToken
// ParExpressionNode              : . OpeningParToken ExpressionNode ClosingParToken
// StringExpressionNode           : . StringToken
// NumberExpressionNode           : . NumberToken
// TrueExpressionNode             : . TrueToken
// FalseExpressionNode            : . FalseToken
// NullExpressionNode             : . NullToken
// TernaryExpressionNode          : . ExpressionNode QuestionMarkToken ExpressionNode ColonToken ExpressionNode
// CallExpressionNode             : . ExpressionNode OpeningParToken ExpressionListNode ClosingParToken
//
//  8: SubToken             -> 41
//  8: NotToken             -> 43
//  0: ExpressionNode       -> 12
//  0: IdentifierToken      -> 45
//  0: OpeningParToken      -> 46
//  0: StringToken          -> 49
//  0: NumberToken          -> 50
//  0: TrueToken            -> 51
//  0: FalseToken           -> 52
//  0: NullToken            -> 53
//
//
                case 11:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 11));
                        state = 41;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 11));
                        state = 43;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 11));
                        state = 12;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 11));
                        state = 45;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 11));
                        state = 46;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 11));
                        state = 49;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 11));
                        state = 50;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 11));
                        state = 51;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 11));
                        state = 52;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 11));
                        state = 53;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 12
//
// AddExpressionNode              : ExpressionNode AddToken ExpressionNode .
// DotExpressionNode              : ExpressionNode . DotToken IdentifierToken
// MulExpressionNode              : ExpressionNode . MulToken ExpressionNode
// DivExpressionNode              : ExpressionNode . DivToken ExpressionNode
// AddExpressionNode              : ExpressionNode . AddToken ExpressionNode
// SubExpressionNode              : ExpressionNode . SubToken ExpressionNode
// EqExpressionNode               : ExpressionNode . EqToken ExpressionNode
// NeqExpressionNode              : ExpressionNode . NeqToken ExpressionNode
// GtExpressionNode               : ExpressionNode . GtToken ExpressionNode
// GteqExpressionNode             : ExpressionNode . GteqToken ExpressionNode
// LtExpressionNode               : ExpressionNode . LtToken ExpressionNode
// LteqExpressionNode             : ExpressionNode . LteqToken ExpressionNode
// AndExpressionNode              : ExpressionNode . AndToken ExpressionNode
// OrExpressionNode               : ExpressionNode . OrToken ExpressionNode
// TernaryExpressionNode          : ExpressionNode . QuestionMarkToken ExpressionNode ColonToken ExpressionNode
// CallExpressionNode             : ExpressionNode . OpeningParToken ExpressionListNode ClosingParToken
//
//  9: DotToken             -> 5
//  7: MulToken             -> 7
//  7: DivToken             -> 9
//  6: AddToken             -> 11
//  6: SubToken             -> 13
//  6: <- AddExpressionNode
//
//
                case 12:
                    if(input.Peek().Node is DotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 12));
                        state = 5;
                    }
                    else if(input.Peek().Node is MulToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 12));
                        state = 7;
                    }
                    else if(input.Peek().Node is DivToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 12));
                        state = 9;
                    }
                    else if(input.Peek().Node is AddToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 12));
                        state = 11;
                    }
                    else if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 12));
                        state = 13;
                    }
                    else
                    {
                        var p2 = stack.Pop();
                        var p1 = stack.Pop();
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new AddExpressionNode((ExpressionNode)p0.Node, (AddToken)p1.Node, (ExpressionNode)p2.Node), 12));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 13
//
// SubExpressionNode              : ExpressionNode SubToken . ExpressionNode
// DotExpressionNode              : . ExpressionNode DotToken IdentifierToken
// NegExpressionNode              : . SubToken ExpressionNode
// NotExpressionNode              : . NotToken ExpressionNode
// MulExpressionNode              : . ExpressionNode MulToken ExpressionNode
// DivExpressionNode              : . ExpressionNode DivToken ExpressionNode
// AddExpressionNode              : . ExpressionNode AddToken ExpressionNode
// SubExpressionNode              : . ExpressionNode SubToken ExpressionNode
// EqExpressionNode               : . ExpressionNode EqToken ExpressionNode
// NeqExpressionNode              : . ExpressionNode NeqToken ExpressionNode
// GtExpressionNode               : . ExpressionNode GtToken ExpressionNode
// GteqExpressionNode             : . ExpressionNode GteqToken ExpressionNode
// LtExpressionNode               : . ExpressionNode LtToken ExpressionNode
// LteqExpressionNode             : . ExpressionNode LteqToken ExpressionNode
// AndExpressionNode              : . ExpressionNode AndToken ExpressionNode
// OrExpressionNode               : . ExpressionNode OrToken ExpressionNode
// IdentifierExpressionNode       : . IdentifierToken
// ParExpressionNode              : . OpeningParToken ExpressionNode ClosingParToken
// StringExpressionNode           : . StringToken
// NumberExpressionNode           : . NumberToken
// TrueExpressionNode             : . TrueToken
// FalseExpressionNode            : . FalseToken
// NullExpressionNode             : . NullToken
// TernaryExpressionNode          : . ExpressionNode QuestionMarkToken ExpressionNode ColonToken ExpressionNode
// CallExpressionNode             : . ExpressionNode OpeningParToken ExpressionListNode ClosingParToken
//
//  8: SubToken             -> 41
//  8: NotToken             -> 43
//  0: ExpressionNode       -> 14
//  0: IdentifierToken      -> 45
//  0: OpeningParToken      -> 46
//  0: StringToken          -> 49
//  0: NumberToken          -> 50
//  0: TrueToken            -> 51
//  0: FalseToken           -> 52
//  0: NullToken            -> 53
//
//
                case 13:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 13));
                        state = 41;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 13));
                        state = 43;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 13));
                        state = 14;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 13));
                        state = 45;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 13));
                        state = 46;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 13));
                        state = 49;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 13));
                        state = 50;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 13));
                        state = 51;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 13));
                        state = 52;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 13));
                        state = 53;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 14
//
// SubExpressionNode              : ExpressionNode SubToken ExpressionNode .
// DotExpressionNode              : ExpressionNode . DotToken IdentifierToken
// MulExpressionNode              : ExpressionNode . MulToken ExpressionNode
// DivExpressionNode              : ExpressionNode . DivToken ExpressionNode
// AddExpressionNode              : ExpressionNode . AddToken ExpressionNode
// SubExpressionNode              : ExpressionNode . SubToken ExpressionNode
// EqExpressionNode               : ExpressionNode . EqToken ExpressionNode
// NeqExpressionNode              : ExpressionNode . NeqToken ExpressionNode
// GtExpressionNode               : ExpressionNode . GtToken ExpressionNode
// GteqExpressionNode             : ExpressionNode . GteqToken ExpressionNode
// LtExpressionNode               : ExpressionNode . LtToken ExpressionNode
// LteqExpressionNode             : ExpressionNode . LteqToken ExpressionNode
// AndExpressionNode              : ExpressionNode . AndToken ExpressionNode
// OrExpressionNode               : ExpressionNode . OrToken ExpressionNode
// TernaryExpressionNode          : ExpressionNode . QuestionMarkToken ExpressionNode ColonToken ExpressionNode
// CallExpressionNode             : ExpressionNode . OpeningParToken ExpressionListNode ClosingParToken
//
//  9: DotToken             -> 5
//  7: MulToken             -> 7
//  7: DivToken             -> 9
//  6: AddToken             -> 11
//  6: SubToken             -> 13
//  6: <- SubExpressionNode
//
//
                case 14:
                    if(input.Peek().Node is DotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 14));
                        state = 5;
                    }
                    else if(input.Peek().Node is MulToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 14));
                        state = 7;
                    }
                    else if(input.Peek().Node is DivToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 14));
                        state = 9;
                    }
                    else if(input.Peek().Node is AddToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 14));
                        state = 11;
                    }
                    else if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 14));
                        state = 13;
                    }
                    else
                    {
                        var p2 = stack.Pop();
                        var p1 = stack.Pop();
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new SubExpressionNode((ExpressionNode)p0.Node, (SubToken)p1.Node, (ExpressionNode)p2.Node), 14));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 15
//
// EqExpressionNode               : ExpressionNode EqToken . ExpressionNode
// DotExpressionNode              : . ExpressionNode DotToken IdentifierToken
// NegExpressionNode              : . SubToken ExpressionNode
// NotExpressionNode              : . NotToken ExpressionNode
// MulExpressionNode              : . ExpressionNode MulToken ExpressionNode
// DivExpressionNode              : . ExpressionNode DivToken ExpressionNode
// AddExpressionNode              : . ExpressionNode AddToken ExpressionNode
// SubExpressionNode              : . ExpressionNode SubToken ExpressionNode
// EqExpressionNode               : . ExpressionNode EqToken ExpressionNode
// NeqExpressionNode              : . ExpressionNode NeqToken ExpressionNode
// GtExpressionNode               : . ExpressionNode GtToken ExpressionNode
// GteqExpressionNode             : . ExpressionNode GteqToken ExpressionNode
// LtExpressionNode               : . ExpressionNode LtToken ExpressionNode
// LteqExpressionNode             : . ExpressionNode LteqToken ExpressionNode
// AndExpressionNode              : . ExpressionNode AndToken ExpressionNode
// OrExpressionNode               : . ExpressionNode OrToken ExpressionNode
// IdentifierExpressionNode       : . IdentifierToken
// ParExpressionNode              : . OpeningParToken ExpressionNode ClosingParToken
// StringExpressionNode           : . StringToken
// NumberExpressionNode           : . NumberToken
// TrueExpressionNode             : . TrueToken
// FalseExpressionNode            : . FalseToken
// NullExpressionNode             : . NullToken
// TernaryExpressionNode          : . ExpressionNode QuestionMarkToken ExpressionNode ColonToken ExpressionNode
// CallExpressionNode             : . ExpressionNode OpeningParToken ExpressionListNode ClosingParToken
//
//  8: SubToken             -> 41
//  8: NotToken             -> 43
//  0: ExpressionNode       -> 16
//  0: IdentifierToken      -> 45
//  0: OpeningParToken      -> 46
//  0: StringToken          -> 49
//  0: NumberToken          -> 50
//  0: TrueToken            -> 51
//  0: FalseToken           -> 52
//  0: NullToken            -> 53
//
//
                case 15:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 15));
                        state = 41;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 15));
                        state = 43;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 15));
                        state = 16;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 15));
                        state = 45;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 15));
                        state = 46;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 15));
                        state = 49;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 15));
                        state = 50;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 15));
                        state = 51;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 15));
                        state = 52;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 15));
                        state = 53;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 16
//
// EqExpressionNode               : ExpressionNode EqToken ExpressionNode .
// DotExpressionNode              : ExpressionNode . DotToken IdentifierToken
// MulExpressionNode              : ExpressionNode . MulToken ExpressionNode
// DivExpressionNode              : ExpressionNode . DivToken ExpressionNode
// AddExpressionNode              : ExpressionNode . AddToken ExpressionNode
// SubExpressionNode              : ExpressionNode . SubToken ExpressionNode
// EqExpressionNode               : ExpressionNode . EqToken ExpressionNode
// NeqExpressionNode              : ExpressionNode . NeqToken ExpressionNode
// GtExpressionNode               : ExpressionNode . GtToken ExpressionNode
// GteqExpressionNode             : ExpressionNode . GteqToken ExpressionNode
// LtExpressionNode               : ExpressionNode . LtToken ExpressionNode
// LteqExpressionNode             : ExpressionNode . LteqToken ExpressionNode
// AndExpressionNode              : ExpressionNode . AndToken ExpressionNode
// OrExpressionNode               : ExpressionNode . OrToken ExpressionNode
// TernaryExpressionNode          : ExpressionNode . QuestionMarkToken ExpressionNode ColonToken ExpressionNode
// CallExpressionNode             : ExpressionNode . OpeningParToken ExpressionListNode ClosingParToken
//
//  9: DotToken             -> 5
//  7: MulToken             -> 7
//  7: DivToken             -> 9
//  6: AddToken             -> 11
//  6: SubToken             -> 13
//  5: EqToken              -> 15
//  5: NeqToken             -> 17
//  5: GtToken              -> 19
//  5: GteqToken            -> 21
//  5: LtToken              -> 23
//  5: LteqToken            -> 25
//  5: <- EqExpressionNode
//
//
                case 16:
                    if(input.Peek().Node is DotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 16));
                        state = 5;
                    }
                    else if(input.Peek().Node is MulToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 16));
                        state = 7;
                    }
                    else if(input.Peek().Node is DivToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 16));
                        state = 9;
                    }
                    else if(input.Peek().Node is AddToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 16));
                        state = 11;
                    }
                    else if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 16));
                        state = 13;
                    }
                    else if(input.Peek().Node is EqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 16));
                        state = 15;
                    }
                    else if(input.Peek().Node is NeqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 16));
                        state = 17;
                    }
                    else if(input.Peek().Node is GtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 16));
                        state = 19;
                    }
                    else if(input.Peek().Node is GteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 16));
                        state = 21;
                    }
                    else if(input.Peek().Node is LtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 16));
                        state = 23;
                    }
                    else if(input.Peek().Node is LteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 16));
                        state = 25;
                    }
                    else
                    {
                        var p2 = stack.Pop();
                        var p1 = stack.Pop();
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new EqExpressionNode((ExpressionNode)p0.Node, (EqToken)p1.Node, (ExpressionNode)p2.Node), 16));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 17
//
// NeqExpressionNode              : ExpressionNode NeqToken . ExpressionNode
// DotExpressionNode              : . ExpressionNode DotToken IdentifierToken
// NegExpressionNode              : . SubToken ExpressionNode
// NotExpressionNode              : . NotToken ExpressionNode
// MulExpressionNode              : . ExpressionNode MulToken ExpressionNode
// DivExpressionNode              : . ExpressionNode DivToken ExpressionNode
// AddExpressionNode              : . ExpressionNode AddToken ExpressionNode
// SubExpressionNode              : . ExpressionNode SubToken ExpressionNode
// EqExpressionNode               : . ExpressionNode EqToken ExpressionNode
// NeqExpressionNode              : . ExpressionNode NeqToken ExpressionNode
// GtExpressionNode               : . ExpressionNode GtToken ExpressionNode
// GteqExpressionNode             : . ExpressionNode GteqToken ExpressionNode
// LtExpressionNode               : . ExpressionNode LtToken ExpressionNode
// LteqExpressionNode             : . ExpressionNode LteqToken ExpressionNode
// AndExpressionNode              : . ExpressionNode AndToken ExpressionNode
// OrExpressionNode               : . ExpressionNode OrToken ExpressionNode
// IdentifierExpressionNode       : . IdentifierToken
// ParExpressionNode              : . OpeningParToken ExpressionNode ClosingParToken
// StringExpressionNode           : . StringToken
// NumberExpressionNode           : . NumberToken
// TrueExpressionNode             : . TrueToken
// FalseExpressionNode            : . FalseToken
// NullExpressionNode             : . NullToken
// TernaryExpressionNode          : . ExpressionNode QuestionMarkToken ExpressionNode ColonToken ExpressionNode
// CallExpressionNode             : . ExpressionNode OpeningParToken ExpressionListNode ClosingParToken
//
//  8: SubToken             -> 41
//  8: NotToken             -> 43
//  0: ExpressionNode       -> 18
//  0: IdentifierToken      -> 45
//  0: OpeningParToken      -> 46
//  0: StringToken          -> 49
//  0: NumberToken          -> 50
//  0: TrueToken            -> 51
//  0: FalseToken           -> 52
//  0: NullToken            -> 53
//
//
                case 17:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 17));
                        state = 41;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 17));
                        state = 43;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 17));
                        state = 18;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 17));
                        state = 45;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 17));
                        state = 46;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 17));
                        state = 49;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 17));
                        state = 50;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 17));
                        state = 51;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 17));
                        state = 52;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 17));
                        state = 53;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 18
//
// NeqExpressionNode              : ExpressionNode NeqToken ExpressionNode .
// DotExpressionNode              : ExpressionNode . DotToken IdentifierToken
// MulExpressionNode              : ExpressionNode . MulToken ExpressionNode
// DivExpressionNode              : ExpressionNode . DivToken ExpressionNode
// AddExpressionNode              : ExpressionNode . AddToken ExpressionNode
// SubExpressionNode              : ExpressionNode . SubToken ExpressionNode
// EqExpressionNode               : ExpressionNode . EqToken ExpressionNode
// NeqExpressionNode              : ExpressionNode . NeqToken ExpressionNode
// GtExpressionNode               : ExpressionNode . GtToken ExpressionNode
// GteqExpressionNode             : ExpressionNode . GteqToken ExpressionNode
// LtExpressionNode               : ExpressionNode . LtToken ExpressionNode
// LteqExpressionNode             : ExpressionNode . LteqToken ExpressionNode
// AndExpressionNode              : ExpressionNode . AndToken ExpressionNode
// OrExpressionNode               : ExpressionNode . OrToken ExpressionNode
// TernaryExpressionNode          : ExpressionNode . QuestionMarkToken ExpressionNode ColonToken ExpressionNode
// CallExpressionNode             : ExpressionNode . OpeningParToken ExpressionListNode ClosingParToken
//
//  9: DotToken             -> 5
//  7: MulToken             -> 7
//  7: DivToken             -> 9
//  6: AddToken             -> 11
//  6: SubToken             -> 13
//  5: EqToken              -> 15
//  5: NeqToken             -> 17
//  5: GtToken              -> 19
//  5: GteqToken            -> 21
//  5: LtToken              -> 23
//  5: LteqToken            -> 25
//  5: <- NeqExpressionNode
//
//
                case 18:
                    if(input.Peek().Node is DotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 18));
                        state = 5;
                    }
                    else if(input.Peek().Node is MulToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 18));
                        state = 7;
                    }
                    else if(input.Peek().Node is DivToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 18));
                        state = 9;
                    }
                    else if(input.Peek().Node is AddToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 18));
                        state = 11;
                    }
                    else if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 18));
                        state = 13;
                    }
                    else if(input.Peek().Node is EqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 18));
                        state = 15;
                    }
                    else if(input.Peek().Node is NeqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 18));
                        state = 17;
                    }
                    else if(input.Peek().Node is GtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 18));
                        state = 19;
                    }
                    else if(input.Peek().Node is GteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 18));
                        state = 21;
                    }
                    else if(input.Peek().Node is LtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 18));
                        state = 23;
                    }
                    else if(input.Peek().Node is LteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 18));
                        state = 25;
                    }
                    else
                    {
                        var p2 = stack.Pop();
                        var p1 = stack.Pop();
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new NeqExpressionNode((ExpressionNode)p0.Node, (NeqToken)p1.Node, (ExpressionNode)p2.Node), 18));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 19
//
// GtExpressionNode               : ExpressionNode GtToken . ExpressionNode
// DotExpressionNode              : . ExpressionNode DotToken IdentifierToken
// NegExpressionNode              : . SubToken ExpressionNode
// NotExpressionNode              : . NotToken ExpressionNode
// MulExpressionNode              : . ExpressionNode MulToken ExpressionNode
// DivExpressionNode              : . ExpressionNode DivToken ExpressionNode
// AddExpressionNode              : . ExpressionNode AddToken ExpressionNode
// SubExpressionNode              : . ExpressionNode SubToken ExpressionNode
// EqExpressionNode               : . ExpressionNode EqToken ExpressionNode
// NeqExpressionNode              : . ExpressionNode NeqToken ExpressionNode
// GtExpressionNode               : . ExpressionNode GtToken ExpressionNode
// GteqExpressionNode             : . ExpressionNode GteqToken ExpressionNode
// LtExpressionNode               : . ExpressionNode LtToken ExpressionNode
// LteqExpressionNode             : . ExpressionNode LteqToken ExpressionNode
// AndExpressionNode              : . ExpressionNode AndToken ExpressionNode
// OrExpressionNode               : . ExpressionNode OrToken ExpressionNode
// IdentifierExpressionNode       : . IdentifierToken
// ParExpressionNode              : . OpeningParToken ExpressionNode ClosingParToken
// StringExpressionNode           : . StringToken
// NumberExpressionNode           : . NumberToken
// TrueExpressionNode             : . TrueToken
// FalseExpressionNode            : . FalseToken
// NullExpressionNode             : . NullToken
// TernaryExpressionNode          : . ExpressionNode QuestionMarkToken ExpressionNode ColonToken ExpressionNode
// CallExpressionNode             : . ExpressionNode OpeningParToken ExpressionListNode ClosingParToken
//
//  8: SubToken             -> 41
//  8: NotToken             -> 43
//  0: ExpressionNode       -> 20
//  0: IdentifierToken      -> 45
//  0: OpeningParToken      -> 46
//  0: StringToken          -> 49
//  0: NumberToken          -> 50
//  0: TrueToken            -> 51
//  0: FalseToken           -> 52
//  0: NullToken            -> 53
//
//
                case 19:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 19));
                        state = 41;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 19));
                        state = 43;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 19));
                        state = 20;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 19));
                        state = 45;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 19));
                        state = 46;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 19));
                        state = 49;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 19));
                        state = 50;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 19));
                        state = 51;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 19));
                        state = 52;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 19));
                        state = 53;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 20
//
// GtExpressionNode               : ExpressionNode GtToken ExpressionNode .
// DotExpressionNode              : ExpressionNode . DotToken IdentifierToken
// MulExpressionNode              : ExpressionNode . MulToken ExpressionNode
// DivExpressionNode              : ExpressionNode . DivToken ExpressionNode
// AddExpressionNode              : ExpressionNode . AddToken ExpressionNode
// SubExpressionNode              : ExpressionNode . SubToken ExpressionNode
// EqExpressionNode               : ExpressionNode . EqToken ExpressionNode
// NeqExpressionNode              : ExpressionNode . NeqToken ExpressionNode
// GtExpressionNode               : ExpressionNode . GtToken ExpressionNode
// GteqExpressionNode             : ExpressionNode . GteqToken ExpressionNode
// LtExpressionNode               : ExpressionNode . LtToken ExpressionNode
// LteqExpressionNode             : ExpressionNode . LteqToken ExpressionNode
// AndExpressionNode              : ExpressionNode . AndToken ExpressionNode
// OrExpressionNode               : ExpressionNode . OrToken ExpressionNode
// TernaryExpressionNode          : ExpressionNode . QuestionMarkToken ExpressionNode ColonToken ExpressionNode
// CallExpressionNode             : ExpressionNode . OpeningParToken ExpressionListNode ClosingParToken
//
//  9: DotToken             -> 5
//  7: MulToken             -> 7
//  7: DivToken             -> 9
//  6: AddToken             -> 11
//  6: SubToken             -> 13
//  5: EqToken              -> 15
//  5: NeqToken             -> 17
//  5: GtToken              -> 19
//  5: GteqToken            -> 21
//  5: LtToken              -> 23
//  5: LteqToken            -> 25
//  5: <- GtExpressionNode
//
//
                case 20:
                    if(input.Peek().Node is DotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 20));
                        state = 5;
                    }
                    else if(input.Peek().Node is MulToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 20));
                        state = 7;
                    }
                    else if(input.Peek().Node is DivToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 20));
                        state = 9;
                    }
                    else if(input.Peek().Node is AddToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 20));
                        state = 11;
                    }
                    else if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 20));
                        state = 13;
                    }
                    else if(input.Peek().Node is EqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 20));
                        state = 15;
                    }
                    else if(input.Peek().Node is NeqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 20));
                        state = 17;
                    }
                    else if(input.Peek().Node is GtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 20));
                        state = 19;
                    }
                    else if(input.Peek().Node is GteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 20));
                        state = 21;
                    }
                    else if(input.Peek().Node is LtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 20));
                        state = 23;
                    }
                    else if(input.Peek().Node is LteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 20));
                        state = 25;
                    }
                    else
                    {
                        var p2 = stack.Pop();
                        var p1 = stack.Pop();
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new GtExpressionNode((ExpressionNode)p0.Node, (GtToken)p1.Node, (ExpressionNode)p2.Node), 20));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 21
//
// GteqExpressionNode             : ExpressionNode GteqToken . ExpressionNode
// DotExpressionNode              : . ExpressionNode DotToken IdentifierToken
// NegExpressionNode              : . SubToken ExpressionNode
// NotExpressionNode              : . NotToken ExpressionNode
// MulExpressionNode              : . ExpressionNode MulToken ExpressionNode
// DivExpressionNode              : . ExpressionNode DivToken ExpressionNode
// AddExpressionNode              : . ExpressionNode AddToken ExpressionNode
// SubExpressionNode              : . ExpressionNode SubToken ExpressionNode
// EqExpressionNode               : . ExpressionNode EqToken ExpressionNode
// NeqExpressionNode              : . ExpressionNode NeqToken ExpressionNode
// GtExpressionNode               : . ExpressionNode GtToken ExpressionNode
// GteqExpressionNode             : . ExpressionNode GteqToken ExpressionNode
// LtExpressionNode               : . ExpressionNode LtToken ExpressionNode
// LteqExpressionNode             : . ExpressionNode LteqToken ExpressionNode
// AndExpressionNode              : . ExpressionNode AndToken ExpressionNode
// OrExpressionNode               : . ExpressionNode OrToken ExpressionNode
// IdentifierExpressionNode       : . IdentifierToken
// ParExpressionNode              : . OpeningParToken ExpressionNode ClosingParToken
// StringExpressionNode           : . StringToken
// NumberExpressionNode           : . NumberToken
// TrueExpressionNode             : . TrueToken
// FalseExpressionNode            : . FalseToken
// NullExpressionNode             : . NullToken
// TernaryExpressionNode          : . ExpressionNode QuestionMarkToken ExpressionNode ColonToken ExpressionNode
// CallExpressionNode             : . ExpressionNode OpeningParToken ExpressionListNode ClosingParToken
//
//  8: SubToken             -> 41
//  8: NotToken             -> 43
//  0: ExpressionNode       -> 22
//  0: IdentifierToken      -> 45
//  0: OpeningParToken      -> 46
//  0: StringToken          -> 49
//  0: NumberToken          -> 50
//  0: TrueToken            -> 51
//  0: FalseToken           -> 52
//  0: NullToken            -> 53
//
//
                case 21:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 21));
                        state = 41;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 21));
                        state = 43;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 21));
                        state = 22;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 21));
                        state = 45;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 21));
                        state = 46;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 21));
                        state = 49;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 21));
                        state = 50;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 21));
                        state = 51;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 21));
                        state = 52;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 21));
                        state = 53;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 22
//
// GteqExpressionNode             : ExpressionNode GteqToken ExpressionNode .
// DotExpressionNode              : ExpressionNode . DotToken IdentifierToken
// MulExpressionNode              : ExpressionNode . MulToken ExpressionNode
// DivExpressionNode              : ExpressionNode . DivToken ExpressionNode
// AddExpressionNode              : ExpressionNode . AddToken ExpressionNode
// SubExpressionNode              : ExpressionNode . SubToken ExpressionNode
// EqExpressionNode               : ExpressionNode . EqToken ExpressionNode
// NeqExpressionNode              : ExpressionNode . NeqToken ExpressionNode
// GtExpressionNode               : ExpressionNode . GtToken ExpressionNode
// GteqExpressionNode             : ExpressionNode . GteqToken ExpressionNode
// LtExpressionNode               : ExpressionNode . LtToken ExpressionNode
// LteqExpressionNode             : ExpressionNode . LteqToken ExpressionNode
// AndExpressionNode              : ExpressionNode . AndToken ExpressionNode
// OrExpressionNode               : ExpressionNode . OrToken ExpressionNode
// TernaryExpressionNode          : ExpressionNode . QuestionMarkToken ExpressionNode ColonToken ExpressionNode
// CallExpressionNode             : ExpressionNode . OpeningParToken ExpressionListNode ClosingParToken
//
//  9: DotToken             -> 5
//  7: MulToken             -> 7
//  7: DivToken             -> 9
//  6: AddToken             -> 11
//  6: SubToken             -> 13
//  5: EqToken              -> 15
//  5: NeqToken             -> 17
//  5: GtToken              -> 19
//  5: GteqToken            -> 21
//  5: LtToken              -> 23
//  5: LteqToken            -> 25
//  5: <- GteqExpressionNode
//
//
                case 22:
                    if(input.Peek().Node is DotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 22));
                        state = 5;
                    }
                    else if(input.Peek().Node is MulToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 22));
                        state = 7;
                    }
                    else if(input.Peek().Node is DivToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 22));
                        state = 9;
                    }
                    else if(input.Peek().Node is AddToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 22));
                        state = 11;
                    }
                    else if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 22));
                        state = 13;
                    }
                    else if(input.Peek().Node is EqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 22));
                        state = 15;
                    }
                    else if(input.Peek().Node is NeqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 22));
                        state = 17;
                    }
                    else if(input.Peek().Node is GtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 22));
                        state = 19;
                    }
                    else if(input.Peek().Node is GteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 22));
                        state = 21;
                    }
                    else if(input.Peek().Node is LtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 22));
                        state = 23;
                    }
                    else if(input.Peek().Node is LteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 22));
                        state = 25;
                    }
                    else
                    {
                        var p2 = stack.Pop();
                        var p1 = stack.Pop();
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new GteqExpressionNode((ExpressionNode)p0.Node, (GteqToken)p1.Node, (ExpressionNode)p2.Node), 22));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 23
//
// LtExpressionNode               : ExpressionNode LtToken . ExpressionNode
// DotExpressionNode              : . ExpressionNode DotToken IdentifierToken
// NegExpressionNode              : . SubToken ExpressionNode
// NotExpressionNode              : . NotToken ExpressionNode
// MulExpressionNode              : . ExpressionNode MulToken ExpressionNode
// DivExpressionNode              : . ExpressionNode DivToken ExpressionNode
// AddExpressionNode              : . ExpressionNode AddToken ExpressionNode
// SubExpressionNode              : . ExpressionNode SubToken ExpressionNode
// EqExpressionNode               : . ExpressionNode EqToken ExpressionNode
// NeqExpressionNode              : . ExpressionNode NeqToken ExpressionNode
// GtExpressionNode               : . ExpressionNode GtToken ExpressionNode
// GteqExpressionNode             : . ExpressionNode GteqToken ExpressionNode
// LtExpressionNode               : . ExpressionNode LtToken ExpressionNode
// LteqExpressionNode             : . ExpressionNode LteqToken ExpressionNode
// AndExpressionNode              : . ExpressionNode AndToken ExpressionNode
// OrExpressionNode               : . ExpressionNode OrToken ExpressionNode
// IdentifierExpressionNode       : . IdentifierToken
// ParExpressionNode              : . OpeningParToken ExpressionNode ClosingParToken
// StringExpressionNode           : . StringToken
// NumberExpressionNode           : . NumberToken
// TrueExpressionNode             : . TrueToken
// FalseExpressionNode            : . FalseToken
// NullExpressionNode             : . NullToken
// TernaryExpressionNode          : . ExpressionNode QuestionMarkToken ExpressionNode ColonToken ExpressionNode
// CallExpressionNode             : . ExpressionNode OpeningParToken ExpressionListNode ClosingParToken
//
//  8: SubToken             -> 41
//  8: NotToken             -> 43
//  0: ExpressionNode       -> 24
//  0: IdentifierToken      -> 45
//  0: OpeningParToken      -> 46
//  0: StringToken          -> 49
//  0: NumberToken          -> 50
//  0: TrueToken            -> 51
//  0: FalseToken           -> 52
//  0: NullToken            -> 53
//
//
                case 23:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 23));
                        state = 41;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 23));
                        state = 43;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 23));
                        state = 24;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 23));
                        state = 45;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 23));
                        state = 46;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 23));
                        state = 49;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 23));
                        state = 50;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 23));
                        state = 51;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 23));
                        state = 52;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 23));
                        state = 53;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 24
//
// LtExpressionNode               : ExpressionNode LtToken ExpressionNode .
// DotExpressionNode              : ExpressionNode . DotToken IdentifierToken
// MulExpressionNode              : ExpressionNode . MulToken ExpressionNode
// DivExpressionNode              : ExpressionNode . DivToken ExpressionNode
// AddExpressionNode              : ExpressionNode . AddToken ExpressionNode
// SubExpressionNode              : ExpressionNode . SubToken ExpressionNode
// EqExpressionNode               : ExpressionNode . EqToken ExpressionNode
// NeqExpressionNode              : ExpressionNode . NeqToken ExpressionNode
// GtExpressionNode               : ExpressionNode . GtToken ExpressionNode
// GteqExpressionNode             : ExpressionNode . GteqToken ExpressionNode
// LtExpressionNode               : ExpressionNode . LtToken ExpressionNode
// LteqExpressionNode             : ExpressionNode . LteqToken ExpressionNode
// AndExpressionNode              : ExpressionNode . AndToken ExpressionNode
// OrExpressionNode               : ExpressionNode . OrToken ExpressionNode
// TernaryExpressionNode          : ExpressionNode . QuestionMarkToken ExpressionNode ColonToken ExpressionNode
// CallExpressionNode             : ExpressionNode . OpeningParToken ExpressionListNode ClosingParToken
//
//  9: DotToken             -> 5
//  7: MulToken             -> 7
//  7: DivToken             -> 9
//  6: AddToken             -> 11
//  6: SubToken             -> 13
//  5: EqToken              -> 15
//  5: NeqToken             -> 17
//  5: GtToken              -> 19
//  5: GteqToken            -> 21
//  5: LtToken              -> 23
//  5: LteqToken            -> 25
//  5: <- LtExpressionNode
//
//
                case 24:
                    if(input.Peek().Node is DotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 24));
                        state = 5;
                    }
                    else if(input.Peek().Node is MulToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 24));
                        state = 7;
                    }
                    else if(input.Peek().Node is DivToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 24));
                        state = 9;
                    }
                    else if(input.Peek().Node is AddToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 24));
                        state = 11;
                    }
                    else if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 24));
                        state = 13;
                    }
                    else if(input.Peek().Node is EqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 24));
                        state = 15;
                    }
                    else if(input.Peek().Node is NeqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 24));
                        state = 17;
                    }
                    else if(input.Peek().Node is GtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 24));
                        state = 19;
                    }
                    else if(input.Peek().Node is GteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 24));
                        state = 21;
                    }
                    else if(input.Peek().Node is LtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 24));
                        state = 23;
                    }
                    else if(input.Peek().Node is LteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 24));
                        state = 25;
                    }
                    else
                    {
                        var p2 = stack.Pop();
                        var p1 = stack.Pop();
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new LtExpressionNode((ExpressionNode)p0.Node, (LtToken)p1.Node, (ExpressionNode)p2.Node), 24));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 25
//
// LteqExpressionNode             : ExpressionNode LteqToken . ExpressionNode
// DotExpressionNode              : . ExpressionNode DotToken IdentifierToken
// NegExpressionNode              : . SubToken ExpressionNode
// NotExpressionNode              : . NotToken ExpressionNode
// MulExpressionNode              : . ExpressionNode MulToken ExpressionNode
// DivExpressionNode              : . ExpressionNode DivToken ExpressionNode
// AddExpressionNode              : . ExpressionNode AddToken ExpressionNode
// SubExpressionNode              : . ExpressionNode SubToken ExpressionNode
// EqExpressionNode               : . ExpressionNode EqToken ExpressionNode
// NeqExpressionNode              : . ExpressionNode NeqToken ExpressionNode
// GtExpressionNode               : . ExpressionNode GtToken ExpressionNode
// GteqExpressionNode             : . ExpressionNode GteqToken ExpressionNode
// LtExpressionNode               : . ExpressionNode LtToken ExpressionNode
// LteqExpressionNode             : . ExpressionNode LteqToken ExpressionNode
// AndExpressionNode              : . ExpressionNode AndToken ExpressionNode
// OrExpressionNode               : . ExpressionNode OrToken ExpressionNode
// IdentifierExpressionNode       : . IdentifierToken
// ParExpressionNode              : . OpeningParToken ExpressionNode ClosingParToken
// StringExpressionNode           : . StringToken
// NumberExpressionNode           : . NumberToken
// TrueExpressionNode             : . TrueToken
// FalseExpressionNode            : . FalseToken
// NullExpressionNode             : . NullToken
// TernaryExpressionNode          : . ExpressionNode QuestionMarkToken ExpressionNode ColonToken ExpressionNode
// CallExpressionNode             : . ExpressionNode OpeningParToken ExpressionListNode ClosingParToken
//
//  8: SubToken             -> 41
//  8: NotToken             -> 43
//  0: ExpressionNode       -> 26
//  0: IdentifierToken      -> 45
//  0: OpeningParToken      -> 46
//  0: StringToken          -> 49
//  0: NumberToken          -> 50
//  0: TrueToken            -> 51
//  0: FalseToken           -> 52
//  0: NullToken            -> 53
//
//
                case 25:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 25));
                        state = 41;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 25));
                        state = 43;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 25));
                        state = 26;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 25));
                        state = 45;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 25));
                        state = 46;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 25));
                        state = 49;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 25));
                        state = 50;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 25));
                        state = 51;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 25));
                        state = 52;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 25));
                        state = 53;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 26
//
// LteqExpressionNode             : ExpressionNode LteqToken ExpressionNode .
// DotExpressionNode              : ExpressionNode . DotToken IdentifierToken
// MulExpressionNode              : ExpressionNode . MulToken ExpressionNode
// DivExpressionNode              : ExpressionNode . DivToken ExpressionNode
// AddExpressionNode              : ExpressionNode . AddToken ExpressionNode
// SubExpressionNode              : ExpressionNode . SubToken ExpressionNode
// EqExpressionNode               : ExpressionNode . EqToken ExpressionNode
// NeqExpressionNode              : ExpressionNode . NeqToken ExpressionNode
// GtExpressionNode               : ExpressionNode . GtToken ExpressionNode
// GteqExpressionNode             : ExpressionNode . GteqToken ExpressionNode
// LtExpressionNode               : ExpressionNode . LtToken ExpressionNode
// LteqExpressionNode             : ExpressionNode . LteqToken ExpressionNode
// AndExpressionNode              : ExpressionNode . AndToken ExpressionNode
// OrExpressionNode               : ExpressionNode . OrToken ExpressionNode
// TernaryExpressionNode          : ExpressionNode . QuestionMarkToken ExpressionNode ColonToken ExpressionNode
// CallExpressionNode             : ExpressionNode . OpeningParToken ExpressionListNode ClosingParToken
//
//  9: DotToken             -> 5
//  7: MulToken             -> 7
//  7: DivToken             -> 9
//  6: AddToken             -> 11
//  6: SubToken             -> 13
//  5: EqToken              -> 15
//  5: NeqToken             -> 17
//  5: GtToken              -> 19
//  5: GteqToken            -> 21
//  5: LtToken              -> 23
//  5: LteqToken            -> 25
//  5: <- LteqExpressionNode
//
//
                case 26:
                    if(input.Peek().Node is DotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 26));
                        state = 5;
                    }
                    else if(input.Peek().Node is MulToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 26));
                        state = 7;
                    }
                    else if(input.Peek().Node is DivToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 26));
                        state = 9;
                    }
                    else if(input.Peek().Node is AddToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 26));
                        state = 11;
                    }
                    else if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 26));
                        state = 13;
                    }
                    else if(input.Peek().Node is EqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 26));
                        state = 15;
                    }
                    else if(input.Peek().Node is NeqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 26));
                        state = 17;
                    }
                    else if(input.Peek().Node is GtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 26));
                        state = 19;
                    }
                    else if(input.Peek().Node is GteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 26));
                        state = 21;
                    }
                    else if(input.Peek().Node is LtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 26));
                        state = 23;
                    }
                    else if(input.Peek().Node is LteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 26));
                        state = 25;
                    }
                    else
                    {
                        var p2 = stack.Pop();
                        var p1 = stack.Pop();
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new LteqExpressionNode((ExpressionNode)p0.Node, (LteqToken)p1.Node, (ExpressionNode)p2.Node), 26));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 27
//
// AndExpressionNode              : ExpressionNode AndToken . ExpressionNode
// DotExpressionNode              : . ExpressionNode DotToken IdentifierToken
// NegExpressionNode              : . SubToken ExpressionNode
// NotExpressionNode              : . NotToken ExpressionNode
// MulExpressionNode              : . ExpressionNode MulToken ExpressionNode
// DivExpressionNode              : . ExpressionNode DivToken ExpressionNode
// AddExpressionNode              : . ExpressionNode AddToken ExpressionNode
// SubExpressionNode              : . ExpressionNode SubToken ExpressionNode
// EqExpressionNode               : . ExpressionNode EqToken ExpressionNode
// NeqExpressionNode              : . ExpressionNode NeqToken ExpressionNode
// GtExpressionNode               : . ExpressionNode GtToken ExpressionNode
// GteqExpressionNode             : . ExpressionNode GteqToken ExpressionNode
// LtExpressionNode               : . ExpressionNode LtToken ExpressionNode
// LteqExpressionNode             : . ExpressionNode LteqToken ExpressionNode
// AndExpressionNode              : . ExpressionNode AndToken ExpressionNode
// OrExpressionNode               : . ExpressionNode OrToken ExpressionNode
// IdentifierExpressionNode       : . IdentifierToken
// ParExpressionNode              : . OpeningParToken ExpressionNode ClosingParToken
// StringExpressionNode           : . StringToken
// NumberExpressionNode           : . NumberToken
// TrueExpressionNode             : . TrueToken
// FalseExpressionNode            : . FalseToken
// NullExpressionNode             : . NullToken
// TernaryExpressionNode          : . ExpressionNode QuestionMarkToken ExpressionNode ColonToken ExpressionNode
// CallExpressionNode             : . ExpressionNode OpeningParToken ExpressionListNode ClosingParToken
//
//  8: SubToken             -> 41
//  8: NotToken             -> 43
//  0: ExpressionNode       -> 28
//  0: IdentifierToken      -> 45
//  0: OpeningParToken      -> 46
//  0: StringToken          -> 49
//  0: NumberToken          -> 50
//  0: TrueToken            -> 51
//  0: FalseToken           -> 52
//  0: NullToken            -> 53
//
//
                case 27:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 27));
                        state = 41;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 27));
                        state = 43;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 27));
                        state = 28;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 27));
                        state = 45;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 27));
                        state = 46;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 27));
                        state = 49;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 27));
                        state = 50;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 27));
                        state = 51;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 27));
                        state = 52;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 27));
                        state = 53;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 28
//
// AndExpressionNode              : ExpressionNode AndToken ExpressionNode .
// DotExpressionNode              : ExpressionNode . DotToken IdentifierToken
// MulExpressionNode              : ExpressionNode . MulToken ExpressionNode
// DivExpressionNode              : ExpressionNode . DivToken ExpressionNode
// AddExpressionNode              : ExpressionNode . AddToken ExpressionNode
// SubExpressionNode              : ExpressionNode . SubToken ExpressionNode
// EqExpressionNode               : ExpressionNode . EqToken ExpressionNode
// NeqExpressionNode              : ExpressionNode . NeqToken ExpressionNode
// GtExpressionNode               : ExpressionNode . GtToken ExpressionNode
// GteqExpressionNode             : ExpressionNode . GteqToken ExpressionNode
// LtExpressionNode               : ExpressionNode . LtToken ExpressionNode
// LteqExpressionNode             : ExpressionNode . LteqToken ExpressionNode
// AndExpressionNode              : ExpressionNode . AndToken ExpressionNode
// OrExpressionNode               : ExpressionNode . OrToken ExpressionNode
// TernaryExpressionNode          : ExpressionNode . QuestionMarkToken ExpressionNode ColonToken ExpressionNode
// CallExpressionNode             : ExpressionNode . OpeningParToken ExpressionListNode ClosingParToken
//
//  9: DotToken             -> 5
//  7: MulToken             -> 7
//  7: DivToken             -> 9
//  6: AddToken             -> 11
//  6: SubToken             -> 13
//  5: EqToken              -> 15
//  5: NeqToken             -> 17
//  5: GtToken              -> 19
//  5: GteqToken            -> 21
//  5: LtToken              -> 23
//  5: LteqToken            -> 25
//  4: AndToken             -> 27
//  4: <- AndExpressionNode
//
//
                case 28:
                    if(input.Peek().Node is DotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 28));
                        state = 5;
                    }
                    else if(input.Peek().Node is MulToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 28));
                        state = 7;
                    }
                    else if(input.Peek().Node is DivToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 28));
                        state = 9;
                    }
                    else if(input.Peek().Node is AddToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 28));
                        state = 11;
                    }
                    else if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 28));
                        state = 13;
                    }
                    else if(input.Peek().Node is EqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 28));
                        state = 15;
                    }
                    else if(input.Peek().Node is NeqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 28));
                        state = 17;
                    }
                    else if(input.Peek().Node is GtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 28));
                        state = 19;
                    }
                    else if(input.Peek().Node is GteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 28));
                        state = 21;
                    }
                    else if(input.Peek().Node is LtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 28));
                        state = 23;
                    }
                    else if(input.Peek().Node is LteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 28));
                        state = 25;
                    }
                    else if(input.Peek().Node is AndToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 28));
                        state = 27;
                    }
                    else
                    {
                        var p2 = stack.Pop();
                        var p1 = stack.Pop();
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new AndExpressionNode((ExpressionNode)p0.Node, (AndToken)p1.Node, (ExpressionNode)p2.Node), 28));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 29
//
// OrExpressionNode               : ExpressionNode OrToken . ExpressionNode
// DotExpressionNode              : . ExpressionNode DotToken IdentifierToken
// NegExpressionNode              : . SubToken ExpressionNode
// NotExpressionNode              : . NotToken ExpressionNode
// MulExpressionNode              : . ExpressionNode MulToken ExpressionNode
// DivExpressionNode              : . ExpressionNode DivToken ExpressionNode
// AddExpressionNode              : . ExpressionNode AddToken ExpressionNode
// SubExpressionNode              : . ExpressionNode SubToken ExpressionNode
// EqExpressionNode               : . ExpressionNode EqToken ExpressionNode
// NeqExpressionNode              : . ExpressionNode NeqToken ExpressionNode
// GtExpressionNode               : . ExpressionNode GtToken ExpressionNode
// GteqExpressionNode             : . ExpressionNode GteqToken ExpressionNode
// LtExpressionNode               : . ExpressionNode LtToken ExpressionNode
// LteqExpressionNode             : . ExpressionNode LteqToken ExpressionNode
// AndExpressionNode              : . ExpressionNode AndToken ExpressionNode
// OrExpressionNode               : . ExpressionNode OrToken ExpressionNode
// IdentifierExpressionNode       : . IdentifierToken
// ParExpressionNode              : . OpeningParToken ExpressionNode ClosingParToken
// StringExpressionNode           : . StringToken
// NumberExpressionNode           : . NumberToken
// TrueExpressionNode             : . TrueToken
// FalseExpressionNode            : . FalseToken
// NullExpressionNode             : . NullToken
// TernaryExpressionNode          : . ExpressionNode QuestionMarkToken ExpressionNode ColonToken ExpressionNode
// CallExpressionNode             : . ExpressionNode OpeningParToken ExpressionListNode ClosingParToken
//
//  8: SubToken             -> 41
//  8: NotToken             -> 43
//  0: ExpressionNode       -> 30
//  0: IdentifierToken      -> 45
//  0: OpeningParToken      -> 46
//  0: StringToken          -> 49
//  0: NumberToken          -> 50
//  0: TrueToken            -> 51
//  0: FalseToken           -> 52
//  0: NullToken            -> 53
//
//
                case 29:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 29));
                        state = 41;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 29));
                        state = 43;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 29));
                        state = 30;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 29));
                        state = 45;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 29));
                        state = 46;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 29));
                        state = 49;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 29));
                        state = 50;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 29));
                        state = 51;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 29));
                        state = 52;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 29));
                        state = 53;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 30
//
// OrExpressionNode               : ExpressionNode OrToken ExpressionNode .
// DotExpressionNode              : ExpressionNode . DotToken IdentifierToken
// MulExpressionNode              : ExpressionNode . MulToken ExpressionNode
// DivExpressionNode              : ExpressionNode . DivToken ExpressionNode
// AddExpressionNode              : ExpressionNode . AddToken ExpressionNode
// SubExpressionNode              : ExpressionNode . SubToken ExpressionNode
// EqExpressionNode               : ExpressionNode . EqToken ExpressionNode
// NeqExpressionNode              : ExpressionNode . NeqToken ExpressionNode
// GtExpressionNode               : ExpressionNode . GtToken ExpressionNode
// GteqExpressionNode             : ExpressionNode . GteqToken ExpressionNode
// LtExpressionNode               : ExpressionNode . LtToken ExpressionNode
// LteqExpressionNode             : ExpressionNode . LteqToken ExpressionNode
// AndExpressionNode              : ExpressionNode . AndToken ExpressionNode
// OrExpressionNode               : ExpressionNode . OrToken ExpressionNode
// TernaryExpressionNode          : ExpressionNode . QuestionMarkToken ExpressionNode ColonToken ExpressionNode
// CallExpressionNode             : ExpressionNode . OpeningParToken ExpressionListNode ClosingParToken
//
//  9: DotToken             -> 5
//  7: MulToken             -> 7
//  7: DivToken             -> 9
//  6: AddToken             -> 11
//  6: SubToken             -> 13
//  5: EqToken              -> 15
//  5: NeqToken             -> 17
//  5: GtToken              -> 19
//  5: GteqToken            -> 21
//  5: LtToken              -> 23
//  5: LteqToken            -> 25
//  4: AndToken             -> 27
//  3: OrToken              -> 29
//  3: <- OrExpressionNode
//
//
                case 30:
                    if(input.Peek().Node is DotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 30));
                        state = 5;
                    }
                    else if(input.Peek().Node is MulToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 30));
                        state = 7;
                    }
                    else if(input.Peek().Node is DivToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 30));
                        state = 9;
                    }
                    else if(input.Peek().Node is AddToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 30));
                        state = 11;
                    }
                    else if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 30));
                        state = 13;
                    }
                    else if(input.Peek().Node is EqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 30));
                        state = 15;
                    }
                    else if(input.Peek().Node is NeqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 30));
                        state = 17;
                    }
                    else if(input.Peek().Node is GtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 30));
                        state = 19;
                    }
                    else if(input.Peek().Node is GteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 30));
                        state = 21;
                    }
                    else if(input.Peek().Node is LtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 30));
                        state = 23;
                    }
                    else if(input.Peek().Node is LteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 30));
                        state = 25;
                    }
                    else if(input.Peek().Node is AndToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 30));
                        state = 27;
                    }
                    else if(input.Peek().Node is OrToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 30));
                        state = 29;
                    }
                    else
                    {
                        var p2 = stack.Pop();
                        var p1 = stack.Pop();
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new OrExpressionNode((ExpressionNode)p0.Node, (OrToken)p1.Node, (ExpressionNode)p2.Node), 30));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 31
//
// TernaryExpressionNode          : ExpressionNode QuestionMarkToken . ExpressionNode ColonToken ExpressionNode
// DotExpressionNode              : . ExpressionNode DotToken IdentifierToken
// NegExpressionNode              : . SubToken ExpressionNode
// NotExpressionNode              : . NotToken ExpressionNode
// MulExpressionNode              : . ExpressionNode MulToken ExpressionNode
// DivExpressionNode              : . ExpressionNode DivToken ExpressionNode
// AddExpressionNode              : . ExpressionNode AddToken ExpressionNode
// SubExpressionNode              : . ExpressionNode SubToken ExpressionNode
// EqExpressionNode               : . ExpressionNode EqToken ExpressionNode
// NeqExpressionNode              : . ExpressionNode NeqToken ExpressionNode
// GtExpressionNode               : . ExpressionNode GtToken ExpressionNode
// GteqExpressionNode             : . ExpressionNode GteqToken ExpressionNode
// LtExpressionNode               : . ExpressionNode LtToken ExpressionNode
// LteqExpressionNode             : . ExpressionNode LteqToken ExpressionNode
// AndExpressionNode              : . ExpressionNode AndToken ExpressionNode
// OrExpressionNode               : . ExpressionNode OrToken ExpressionNode
// IdentifierExpressionNode       : . IdentifierToken
// ParExpressionNode              : . OpeningParToken ExpressionNode ClosingParToken
// StringExpressionNode           : . StringToken
// NumberExpressionNode           : . NumberToken
// TrueExpressionNode             : . TrueToken
// FalseExpressionNode            : . FalseToken
// NullExpressionNode             : . NullToken
// TernaryExpressionNode          : . ExpressionNode QuestionMarkToken ExpressionNode ColonToken ExpressionNode
// CallExpressionNode             : . ExpressionNode OpeningParToken ExpressionListNode ClosingParToken
//
//  8: SubToken             -> 41
//  8: NotToken             -> 43
//  0: ExpressionNode       -> 32
//  0: IdentifierToken      -> 45
//  0: OpeningParToken      -> 46
//  0: StringToken          -> 49
//  0: NumberToken          -> 50
//  0: TrueToken            -> 51
//  0: FalseToken           -> 52
//  0: NullToken            -> 53
//
//
                case 31:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 31));
                        state = 41;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 31));
                        state = 43;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 31));
                        state = 32;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 31));
                        state = 45;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 31));
                        state = 46;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 31));
                        state = 49;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 31));
                        state = 50;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 31));
                        state = 51;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 31));
                        state = 52;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 31));
                        state = 53;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 32
//
// TernaryExpressionNode          : ExpressionNode QuestionMarkToken ExpressionNode . ColonToken ExpressionNode
// DotExpressionNode              : ExpressionNode . DotToken IdentifierToken
// MulExpressionNode              : ExpressionNode . MulToken ExpressionNode
// DivExpressionNode              : ExpressionNode . DivToken ExpressionNode
// AddExpressionNode              : ExpressionNode . AddToken ExpressionNode
// SubExpressionNode              : ExpressionNode . SubToken ExpressionNode
// EqExpressionNode               : ExpressionNode . EqToken ExpressionNode
// NeqExpressionNode              : ExpressionNode . NeqToken ExpressionNode
// GtExpressionNode               : ExpressionNode . GtToken ExpressionNode
// GteqExpressionNode             : ExpressionNode . GteqToken ExpressionNode
// LtExpressionNode               : ExpressionNode . LtToken ExpressionNode
// LteqExpressionNode             : ExpressionNode . LteqToken ExpressionNode
// AndExpressionNode              : ExpressionNode . AndToken ExpressionNode
// OrExpressionNode               : ExpressionNode . OrToken ExpressionNode
// TernaryExpressionNode          : ExpressionNode . QuestionMarkToken ExpressionNode ColonToken ExpressionNode
// CallExpressionNode             : ExpressionNode . OpeningParToken ExpressionListNode ClosingParToken
//
//  9: DotToken             -> 5
//  7: MulToken             -> 7
//  7: DivToken             -> 9
//  6: AddToken             -> 11
//  6: SubToken             -> 13
//  5: EqToken              -> 15
//  5: NeqToken             -> 17
//  5: GtToken              -> 19
//  5: GteqToken            -> 21
//  5: LtToken              -> 23
//  5: LteqToken            -> 25
//  4: AndToken             -> 27
//  3: OrToken              -> 29
//  2: ColonToken           -> 33
//  2: QuestionMarkToken    -> 31
//  1: OpeningParToken      -> 35
//
//
                case 32:
                    if(input.Peek().Node is DotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 32));
                        state = 5;
                    }
                    else if(input.Peek().Node is MulToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 32));
                        state = 7;
                    }
                    else if(input.Peek().Node is DivToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 32));
                        state = 9;
                    }
                    else if(input.Peek().Node is AddToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 32));
                        state = 11;
                    }
                    else if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 32));
                        state = 13;
                    }
                    else if(input.Peek().Node is EqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 32));
                        state = 15;
                    }
                    else if(input.Peek().Node is NeqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 32));
                        state = 17;
                    }
                    else if(input.Peek().Node is GtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 32));
                        state = 19;
                    }
                    else if(input.Peek().Node is GteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 32));
                        state = 21;
                    }
                    else if(input.Peek().Node is LtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 32));
                        state = 23;
                    }
                    else if(input.Peek().Node is LteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 32));
                        state = 25;
                    }
                    else if(input.Peek().Node is AndToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 32));
                        state = 27;
                    }
                    else if(input.Peek().Node is OrToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 32));
                        state = 29;
                    }
                    else if(input.Peek().Node is ColonToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 32));
                        state = 33;
                    }
                    else if(input.Peek().Node is QuestionMarkToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 32));
                        state = 31;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 32));
                        state = 35;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 33
//
// TernaryExpressionNode          : ExpressionNode QuestionMarkToken ExpressionNode ColonToken . ExpressionNode
// DotExpressionNode              : . ExpressionNode DotToken IdentifierToken
// NegExpressionNode              : . SubToken ExpressionNode
// NotExpressionNode              : . NotToken ExpressionNode
// MulExpressionNode              : . ExpressionNode MulToken ExpressionNode
// DivExpressionNode              : . ExpressionNode DivToken ExpressionNode
// AddExpressionNode              : . ExpressionNode AddToken ExpressionNode
// SubExpressionNode              : . ExpressionNode SubToken ExpressionNode
// EqExpressionNode               : . ExpressionNode EqToken ExpressionNode
// NeqExpressionNode              : . ExpressionNode NeqToken ExpressionNode
// GtExpressionNode               : . ExpressionNode GtToken ExpressionNode
// GteqExpressionNode             : . ExpressionNode GteqToken ExpressionNode
// LtExpressionNode               : . ExpressionNode LtToken ExpressionNode
// LteqExpressionNode             : . ExpressionNode LteqToken ExpressionNode
// AndExpressionNode              : . ExpressionNode AndToken ExpressionNode
// OrExpressionNode               : . ExpressionNode OrToken ExpressionNode
// IdentifierExpressionNode       : . IdentifierToken
// ParExpressionNode              : . OpeningParToken ExpressionNode ClosingParToken
// StringExpressionNode           : . StringToken
// NumberExpressionNode           : . NumberToken
// TrueExpressionNode             : . TrueToken
// FalseExpressionNode            : . FalseToken
// NullExpressionNode             : . NullToken
// TernaryExpressionNode          : . ExpressionNode QuestionMarkToken ExpressionNode ColonToken ExpressionNode
// CallExpressionNode             : . ExpressionNode OpeningParToken ExpressionListNode ClosingParToken
//
//  8: SubToken             -> 41
//  8: NotToken             -> 43
//  0: ExpressionNode       -> 34
//  0: IdentifierToken      -> 45
//  0: OpeningParToken      -> 46
//  0: StringToken          -> 49
//  0: NumberToken          -> 50
//  0: TrueToken            -> 51
//  0: FalseToken           -> 52
//  0: NullToken            -> 53
//
//
                case 33:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 33));
                        state = 41;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 33));
                        state = 43;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 33));
                        state = 34;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 33));
                        state = 45;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 33));
                        state = 46;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 33));
                        state = 49;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 33));
                        state = 50;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 33));
                        state = 51;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 33));
                        state = 52;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 33));
                        state = 53;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 34
//
// TernaryExpressionNode          : ExpressionNode QuestionMarkToken ExpressionNode ColonToken ExpressionNode .
// DotExpressionNode              : ExpressionNode . DotToken IdentifierToken
// MulExpressionNode              : ExpressionNode . MulToken ExpressionNode
// DivExpressionNode              : ExpressionNode . DivToken ExpressionNode
// AddExpressionNode              : ExpressionNode . AddToken ExpressionNode
// SubExpressionNode              : ExpressionNode . SubToken ExpressionNode
// EqExpressionNode               : ExpressionNode . EqToken ExpressionNode
// NeqExpressionNode              : ExpressionNode . NeqToken ExpressionNode
// GtExpressionNode               : ExpressionNode . GtToken ExpressionNode
// GteqExpressionNode             : ExpressionNode . GteqToken ExpressionNode
// LtExpressionNode               : ExpressionNode . LtToken ExpressionNode
// LteqExpressionNode             : ExpressionNode . LteqToken ExpressionNode
// AndExpressionNode              : ExpressionNode . AndToken ExpressionNode
// OrExpressionNode               : ExpressionNode . OrToken ExpressionNode
// TernaryExpressionNode          : ExpressionNode . QuestionMarkToken ExpressionNode ColonToken ExpressionNode
// CallExpressionNode             : ExpressionNode . OpeningParToken ExpressionListNode ClosingParToken
//
//  9: DotToken             -> 5
//  7: MulToken             -> 7
//  7: DivToken             -> 9
//  6: AddToken             -> 11
//  6: SubToken             -> 13
//  5: EqToken              -> 15
//  5: NeqToken             -> 17
//  5: GtToken              -> 19
//  5: GteqToken            -> 21
//  5: LtToken              -> 23
//  5: LteqToken            -> 25
//  4: AndToken             -> 27
//  3: OrToken              -> 29
//  2: QuestionMarkToken    -> 31
//  2: <- TernaryExpressionNode
//
//
                case 34:
                    if(input.Peek().Node is DotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 34));
                        state = 5;
                    }
                    else if(input.Peek().Node is MulToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 34));
                        state = 7;
                    }
                    else if(input.Peek().Node is DivToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 34));
                        state = 9;
                    }
                    else if(input.Peek().Node is AddToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 34));
                        state = 11;
                    }
                    else if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 34));
                        state = 13;
                    }
                    else if(input.Peek().Node is EqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 34));
                        state = 15;
                    }
                    else if(input.Peek().Node is NeqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 34));
                        state = 17;
                    }
                    else if(input.Peek().Node is GtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 34));
                        state = 19;
                    }
                    else if(input.Peek().Node is GteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 34));
                        state = 21;
                    }
                    else if(input.Peek().Node is LtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 34));
                        state = 23;
                    }
                    else if(input.Peek().Node is LteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 34));
                        state = 25;
                    }
                    else if(input.Peek().Node is AndToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 34));
                        state = 27;
                    }
                    else if(input.Peek().Node is OrToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 34));
                        state = 29;
                    }
                    else if(input.Peek().Node is QuestionMarkToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 34));
                        state = 31;
                    }
                    else
                    {
                        var p4 = stack.Pop();
                        var p3 = stack.Pop();
                        var p2 = stack.Pop();
                        var p1 = stack.Pop();
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new TernaryExpressionNode((ExpressionNode)p0.Node, (QuestionMarkToken)p1.Node, (ExpressionNode)p2.Node, (ColonToken)p3.Node, (ExpressionNode)p4.Node), 34));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 35
//
// CallExpressionNode             : ExpressionNode OpeningParToken . ExpressionListNode ClosingParToken
// EmptyExpressionListNode        : .
// SingleExpressionListNode       : . ExpressionNode
// DotExpressionNode              : . ExpressionNode DotToken IdentifierToken
// NegExpressionNode              : . SubToken ExpressionNode
// NotExpressionNode              : . NotToken ExpressionNode
// MulExpressionNode              : . ExpressionNode MulToken ExpressionNode
// DivExpressionNode              : . ExpressionNode DivToken ExpressionNode
// AddExpressionNode              : . ExpressionNode AddToken ExpressionNode
// SubExpressionNode              : . ExpressionNode SubToken ExpressionNode
// EqExpressionNode               : . ExpressionNode EqToken ExpressionNode
// NeqExpressionNode              : . ExpressionNode NeqToken ExpressionNode
// GtExpressionNode               : . ExpressionNode GtToken ExpressionNode
// GteqExpressionNode             : . ExpressionNode GteqToken ExpressionNode
// LtExpressionNode               : . ExpressionNode LtToken ExpressionNode
// LteqExpressionNode             : . ExpressionNode LteqToken ExpressionNode
// AndExpressionNode              : . ExpressionNode AndToken ExpressionNode
// OrExpressionNode               : . ExpressionNode OrToken ExpressionNode
// IdentifierExpressionNode       : . IdentifierToken
// ParExpressionNode              : . OpeningParToken ExpressionNode ClosingParToken
// StringExpressionNode           : . StringToken
// NumberExpressionNode           : . NumberToken
// TrueExpressionNode             : . TrueToken
// FalseExpressionNode            : . FalseToken
// NullExpressionNode             : . NullToken
// TernaryExpressionNode          : . ExpressionNode QuestionMarkToken ExpressionNode ColonToken ExpressionNode
// CallExpressionNode             : . ExpressionNode OpeningParToken ExpressionListNode ClosingParToken
// MultipleExpressionListNode     : . ExpressionNode CommaToken RealExpressionListNode
//
//  8: SubToken             -> 41
//  8: NotToken             -> 43
//  1: ExpressionListNode   -> 36
//  0: ExpressionNode       -> 38
//  0: IdentifierToken      -> 45
//  0: OpeningParToken      -> 46
//  0: StringToken          -> 49
//  0: NumberToken          -> 50
//  0: TrueToken            -> 51
//  0: FalseToken           -> 52
//  0: NullToken            -> 53
// -2: <- EmptyExpressionListNode
//
//
                case 35:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 35));
                        state = 41;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 35));
                        state = 43;
                    }
                    else if(input.Peek().Node is ExpressionListNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 35));
                        state = 36;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 35));
                        state = 38;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 35));
                        state = 45;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 35));
                        state = 46;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 35));
                        state = 49;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 35));
                        state = 50;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 35));
                        state = 51;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 35));
                        state = 52;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 35));
                        state = 53;
                    }
                    else
                    {
                        input.Push(new StackItem(new EmptyExpressionListNode(), 35));
                    }
                    break;

// ###################################
// # State 36
//
// CallExpressionNode             : ExpressionNode OpeningParToken ExpressionListNode . ClosingParToken
//
//  1: ClosingParToken      -> 37
//
//
                case 36:
                    if(input.Peek().Node is ClosingParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 36));
                        state = 37;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 37
//
// CallExpressionNode             : ExpressionNode OpeningParToken ExpressionListNode ClosingParToken .
//
//  1: <- CallExpressionNode
//
//
                case 37:
                    {
                        var p3 = stack.Pop();
                        var p2 = stack.Pop();
                        var p1 = stack.Pop();
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new CallExpressionNode((ExpressionNode)p0.Node, (OpeningParToken)p1.Node, (ExpressionListNode)p2.Node, (ClosingParToken)p3.Node), 37));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 38
//
// SingleExpressionListNode       : ExpressionNode .
// DotExpressionNode              : ExpressionNode . DotToken IdentifierToken
// MulExpressionNode              : ExpressionNode . MulToken ExpressionNode
// DivExpressionNode              : ExpressionNode . DivToken ExpressionNode
// AddExpressionNode              : ExpressionNode . AddToken ExpressionNode
// SubExpressionNode              : ExpressionNode . SubToken ExpressionNode
// EqExpressionNode               : ExpressionNode . EqToken ExpressionNode
// NeqExpressionNode              : ExpressionNode . NeqToken ExpressionNode
// GtExpressionNode               : ExpressionNode . GtToken ExpressionNode
// GteqExpressionNode             : ExpressionNode . GteqToken ExpressionNode
// LtExpressionNode               : ExpressionNode . LtToken ExpressionNode
// LteqExpressionNode             : ExpressionNode . LteqToken ExpressionNode
// AndExpressionNode              : ExpressionNode . AndToken ExpressionNode
// OrExpressionNode               : ExpressionNode . OrToken ExpressionNode
// TernaryExpressionNode          : ExpressionNode . QuestionMarkToken ExpressionNode ColonToken ExpressionNode
// CallExpressionNode             : ExpressionNode . OpeningParToken ExpressionListNode ClosingParToken
// MultipleExpressionListNode     : ExpressionNode . CommaToken RealExpressionListNode
//
//  9: DotToken             -> 5
//  7: MulToken             -> 7
//  7: DivToken             -> 9
//  6: AddToken             -> 11
//  6: SubToken             -> 13
//  5: EqToken              -> 15
//  5: NeqToken             -> 17
//  5: GtToken              -> 19
//  5: GteqToken            -> 21
//  5: LtToken              -> 23
//  5: LteqToken            -> 25
//  4: AndToken             -> 27
//  3: OrToken              -> 29
//  2: QuestionMarkToken    -> 31
//  1: OpeningParToken      -> 35
//  0: CommaToken           -> 39
// -1: <- SingleExpressionListNode
//
//
                case 38:
                    if(input.Peek().Node is DotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 38));
                        state = 5;
                    }
                    else if(input.Peek().Node is MulToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 38));
                        state = 7;
                    }
                    else if(input.Peek().Node is DivToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 38));
                        state = 9;
                    }
                    else if(input.Peek().Node is AddToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 38));
                        state = 11;
                    }
                    else if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 38));
                        state = 13;
                    }
                    else if(input.Peek().Node is EqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 38));
                        state = 15;
                    }
                    else if(input.Peek().Node is NeqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 38));
                        state = 17;
                    }
                    else if(input.Peek().Node is GtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 38));
                        state = 19;
                    }
                    else if(input.Peek().Node is GteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 38));
                        state = 21;
                    }
                    else if(input.Peek().Node is LtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 38));
                        state = 23;
                    }
                    else if(input.Peek().Node is LteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 38));
                        state = 25;
                    }
                    else if(input.Peek().Node is AndToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 38));
                        state = 27;
                    }
                    else if(input.Peek().Node is OrToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 38));
                        state = 29;
                    }
                    else if(input.Peek().Node is QuestionMarkToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 38));
                        state = 31;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 38));
                        state = 35;
                    }
                    else if(input.Peek().Node is CommaToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 38));
                        state = 39;
                    }
                    else
                    {
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new SingleExpressionListNode((ExpressionNode)p0.Node), 38));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 39
//
// MultipleExpressionListNode     : ExpressionNode CommaToken . RealExpressionListNode
// SingleExpressionListNode       : . ExpressionNode
// DotExpressionNode              : . ExpressionNode DotToken IdentifierToken
// NegExpressionNode              : . SubToken ExpressionNode
// NotExpressionNode              : . NotToken ExpressionNode
// MulExpressionNode              : . ExpressionNode MulToken ExpressionNode
// DivExpressionNode              : . ExpressionNode DivToken ExpressionNode
// AddExpressionNode              : . ExpressionNode AddToken ExpressionNode
// SubExpressionNode              : . ExpressionNode SubToken ExpressionNode
// EqExpressionNode               : . ExpressionNode EqToken ExpressionNode
// NeqExpressionNode              : . ExpressionNode NeqToken ExpressionNode
// GtExpressionNode               : . ExpressionNode GtToken ExpressionNode
// GteqExpressionNode             : . ExpressionNode GteqToken ExpressionNode
// LtExpressionNode               : . ExpressionNode LtToken ExpressionNode
// LteqExpressionNode             : . ExpressionNode LteqToken ExpressionNode
// AndExpressionNode              : . ExpressionNode AndToken ExpressionNode
// OrExpressionNode               : . ExpressionNode OrToken ExpressionNode
// IdentifierExpressionNode       : . IdentifierToken
// ParExpressionNode              : . OpeningParToken ExpressionNode ClosingParToken
// StringExpressionNode           : . StringToken
// NumberExpressionNode           : . NumberToken
// TrueExpressionNode             : . TrueToken
// FalseExpressionNode            : . FalseToken
// NullExpressionNode             : . NullToken
// TernaryExpressionNode          : . ExpressionNode QuestionMarkToken ExpressionNode ColonToken ExpressionNode
// CallExpressionNode             : . ExpressionNode OpeningParToken ExpressionListNode ClosingParToken
// MultipleExpressionListNode     : . ExpressionNode CommaToken RealExpressionListNode
//
//  8: SubToken             -> 41
//  8: NotToken             -> 43
//  0: RealExpressionListNode -> 40
//  0: ExpressionNode       -> 38
//  0: IdentifierToken      -> 45
//  0: OpeningParToken      -> 46
//  0: StringToken          -> 49
//  0: NumberToken          -> 50
//  0: TrueToken            -> 51
//  0: FalseToken           -> 52
//  0: NullToken            -> 53
//
//
                case 39:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 39));
                        state = 41;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 39));
                        state = 43;
                    }
                    else if(input.Peek().Node is RealExpressionListNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 39));
                        state = 40;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 39));
                        state = 38;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 39));
                        state = 45;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 39));
                        state = 46;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 39));
                        state = 49;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 39));
                        state = 50;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 39));
                        state = 51;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 39));
                        state = 52;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 39));
                        state = 53;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 40
//
// MultipleExpressionListNode     : ExpressionNode CommaToken RealExpressionListNode .
//
//  0: <- MultipleExpressionListNode
//
//
                case 40:
                    {
                        var p2 = stack.Pop();
                        var p1 = stack.Pop();
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new MultipleExpressionListNode((ExpressionNode)p0.Node, (CommaToken)p1.Node, (RealExpressionListNode)p2.Node), 40));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 41
//
// NegExpressionNode              : SubToken . ExpressionNode
// DotExpressionNode              : . ExpressionNode DotToken IdentifierToken
// NegExpressionNode              : . SubToken ExpressionNode
// NotExpressionNode              : . NotToken ExpressionNode
// MulExpressionNode              : . ExpressionNode MulToken ExpressionNode
// DivExpressionNode              : . ExpressionNode DivToken ExpressionNode
// AddExpressionNode              : . ExpressionNode AddToken ExpressionNode
// SubExpressionNode              : . ExpressionNode SubToken ExpressionNode
// EqExpressionNode               : . ExpressionNode EqToken ExpressionNode
// NeqExpressionNode              : . ExpressionNode NeqToken ExpressionNode
// GtExpressionNode               : . ExpressionNode GtToken ExpressionNode
// GteqExpressionNode             : . ExpressionNode GteqToken ExpressionNode
// LtExpressionNode               : . ExpressionNode LtToken ExpressionNode
// LteqExpressionNode             : . ExpressionNode LteqToken ExpressionNode
// AndExpressionNode              : . ExpressionNode AndToken ExpressionNode
// OrExpressionNode               : . ExpressionNode OrToken ExpressionNode
// IdentifierExpressionNode       : . IdentifierToken
// ParExpressionNode              : . OpeningParToken ExpressionNode ClosingParToken
// StringExpressionNode           : . StringToken
// NumberExpressionNode           : . NumberToken
// TrueExpressionNode             : . TrueToken
// FalseExpressionNode            : . FalseToken
// NullExpressionNode             : . NullToken
// TernaryExpressionNode          : . ExpressionNode QuestionMarkToken ExpressionNode ColonToken ExpressionNode
// CallExpressionNode             : . ExpressionNode OpeningParToken ExpressionListNode ClosingParToken
//
//  8: SubToken             -> 41
//  8: NotToken             -> 43
//  0: ExpressionNode       -> 42
//  0: IdentifierToken      -> 45
//  0: OpeningParToken      -> 46
//  0: StringToken          -> 49
//  0: NumberToken          -> 50
//  0: TrueToken            -> 51
//  0: FalseToken           -> 52
//  0: NullToken            -> 53
//
//
                case 41:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 41));
                        state = 41;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 41));
                        state = 43;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 41));
                        state = 42;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 41));
                        state = 45;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 41));
                        state = 46;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 41));
                        state = 49;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 41));
                        state = 50;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 41));
                        state = 51;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 41));
                        state = 52;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 41));
                        state = 53;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 42
//
// NegExpressionNode              : SubToken ExpressionNode .
// DotExpressionNode              : ExpressionNode . DotToken IdentifierToken
// MulExpressionNode              : ExpressionNode . MulToken ExpressionNode
// DivExpressionNode              : ExpressionNode . DivToken ExpressionNode
// AddExpressionNode              : ExpressionNode . AddToken ExpressionNode
// SubExpressionNode              : ExpressionNode . SubToken ExpressionNode
// EqExpressionNode               : ExpressionNode . EqToken ExpressionNode
// NeqExpressionNode              : ExpressionNode . NeqToken ExpressionNode
// GtExpressionNode               : ExpressionNode . GtToken ExpressionNode
// GteqExpressionNode             : ExpressionNode . GteqToken ExpressionNode
// LtExpressionNode               : ExpressionNode . LtToken ExpressionNode
// LteqExpressionNode             : ExpressionNode . LteqToken ExpressionNode
// AndExpressionNode              : ExpressionNode . AndToken ExpressionNode
// OrExpressionNode               : ExpressionNode . OrToken ExpressionNode
// TernaryExpressionNode          : ExpressionNode . QuestionMarkToken ExpressionNode ColonToken ExpressionNode
// CallExpressionNode             : ExpressionNode . OpeningParToken ExpressionListNode ClosingParToken
//
//  9: DotToken             -> 5
//  8: <- NegExpressionNode
//
//
                case 42:
                    if(input.Peek().Node is DotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 42));
                        state = 5;
                    }
                    else
                    {
                        var p1 = stack.Pop();
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new NegExpressionNode((SubToken)p0.Node, (ExpressionNode)p1.Node), 42));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 43
//
// NotExpressionNode              : NotToken . ExpressionNode
// DotExpressionNode              : . ExpressionNode DotToken IdentifierToken
// NegExpressionNode              : . SubToken ExpressionNode
// NotExpressionNode              : . NotToken ExpressionNode
// MulExpressionNode              : . ExpressionNode MulToken ExpressionNode
// DivExpressionNode              : . ExpressionNode DivToken ExpressionNode
// AddExpressionNode              : . ExpressionNode AddToken ExpressionNode
// SubExpressionNode              : . ExpressionNode SubToken ExpressionNode
// EqExpressionNode               : . ExpressionNode EqToken ExpressionNode
// NeqExpressionNode              : . ExpressionNode NeqToken ExpressionNode
// GtExpressionNode               : . ExpressionNode GtToken ExpressionNode
// GteqExpressionNode             : . ExpressionNode GteqToken ExpressionNode
// LtExpressionNode               : . ExpressionNode LtToken ExpressionNode
// LteqExpressionNode             : . ExpressionNode LteqToken ExpressionNode
// AndExpressionNode              : . ExpressionNode AndToken ExpressionNode
// OrExpressionNode               : . ExpressionNode OrToken ExpressionNode
// IdentifierExpressionNode       : . IdentifierToken
// ParExpressionNode              : . OpeningParToken ExpressionNode ClosingParToken
// StringExpressionNode           : . StringToken
// NumberExpressionNode           : . NumberToken
// TrueExpressionNode             : . TrueToken
// FalseExpressionNode            : . FalseToken
// NullExpressionNode             : . NullToken
// TernaryExpressionNode          : . ExpressionNode QuestionMarkToken ExpressionNode ColonToken ExpressionNode
// CallExpressionNode             : . ExpressionNode OpeningParToken ExpressionListNode ClosingParToken
//
//  8: SubToken             -> 41
//  8: NotToken             -> 43
//  0: ExpressionNode       -> 44
//  0: IdentifierToken      -> 45
//  0: OpeningParToken      -> 46
//  0: StringToken          -> 49
//  0: NumberToken          -> 50
//  0: TrueToken            -> 51
//  0: FalseToken           -> 52
//  0: NullToken            -> 53
//
//
                case 43:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 43));
                        state = 41;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 43));
                        state = 43;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 43));
                        state = 44;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 43));
                        state = 45;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 43));
                        state = 46;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 43));
                        state = 49;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 43));
                        state = 50;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 43));
                        state = 51;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 43));
                        state = 52;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 43));
                        state = 53;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 44
//
// NotExpressionNode              : NotToken ExpressionNode .
// DotExpressionNode              : ExpressionNode . DotToken IdentifierToken
// MulExpressionNode              : ExpressionNode . MulToken ExpressionNode
// DivExpressionNode              : ExpressionNode . DivToken ExpressionNode
// AddExpressionNode              : ExpressionNode . AddToken ExpressionNode
// SubExpressionNode              : ExpressionNode . SubToken ExpressionNode
// EqExpressionNode               : ExpressionNode . EqToken ExpressionNode
// NeqExpressionNode              : ExpressionNode . NeqToken ExpressionNode
// GtExpressionNode               : ExpressionNode . GtToken ExpressionNode
// GteqExpressionNode             : ExpressionNode . GteqToken ExpressionNode
// LtExpressionNode               : ExpressionNode . LtToken ExpressionNode
// LteqExpressionNode             : ExpressionNode . LteqToken ExpressionNode
// AndExpressionNode              : ExpressionNode . AndToken ExpressionNode
// OrExpressionNode               : ExpressionNode . OrToken ExpressionNode
// TernaryExpressionNode          : ExpressionNode . QuestionMarkToken ExpressionNode ColonToken ExpressionNode
// CallExpressionNode             : ExpressionNode . OpeningParToken ExpressionListNode ClosingParToken
//
//  9: DotToken             -> 5
//  8: <- NotExpressionNode
//
//
                case 44:
                    if(input.Peek().Node is DotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 44));
                        state = 5;
                    }
                    else
                    {
                        var p1 = stack.Pop();
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new NotExpressionNode((NotToken)p0.Node, (ExpressionNode)p1.Node), 44));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 45
//
// IdentifierExpressionNode       : IdentifierToken .
//
//  0: <- IdentifierExpressionNode
//
//
                case 45:
                    {
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new IdentifierExpressionNode((IdentifierToken)p0.Node), 45));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 46
//
// ParExpressionNode              : OpeningParToken . ExpressionNode ClosingParToken
// DotExpressionNode              : . ExpressionNode DotToken IdentifierToken
// NegExpressionNode              : . SubToken ExpressionNode
// NotExpressionNode              : . NotToken ExpressionNode
// MulExpressionNode              : . ExpressionNode MulToken ExpressionNode
// DivExpressionNode              : . ExpressionNode DivToken ExpressionNode
// AddExpressionNode              : . ExpressionNode AddToken ExpressionNode
// SubExpressionNode              : . ExpressionNode SubToken ExpressionNode
// EqExpressionNode               : . ExpressionNode EqToken ExpressionNode
// NeqExpressionNode              : . ExpressionNode NeqToken ExpressionNode
// GtExpressionNode               : . ExpressionNode GtToken ExpressionNode
// GteqExpressionNode             : . ExpressionNode GteqToken ExpressionNode
// LtExpressionNode               : . ExpressionNode LtToken ExpressionNode
// LteqExpressionNode             : . ExpressionNode LteqToken ExpressionNode
// AndExpressionNode              : . ExpressionNode AndToken ExpressionNode
// OrExpressionNode               : . ExpressionNode OrToken ExpressionNode
// IdentifierExpressionNode       : . IdentifierToken
// ParExpressionNode              : . OpeningParToken ExpressionNode ClosingParToken
// StringExpressionNode           : . StringToken
// NumberExpressionNode           : . NumberToken
// TrueExpressionNode             : . TrueToken
// FalseExpressionNode            : . FalseToken
// NullExpressionNode             : . NullToken
// TernaryExpressionNode          : . ExpressionNode QuestionMarkToken ExpressionNode ColonToken ExpressionNode
// CallExpressionNode             : . ExpressionNode OpeningParToken ExpressionListNode ClosingParToken
//
//  8: SubToken             -> 41
//  8: NotToken             -> 43
//  0: ExpressionNode       -> 47
//  0: IdentifierToken      -> 45
//  0: OpeningParToken      -> 46
//  0: StringToken          -> 49
//  0: NumberToken          -> 50
//  0: TrueToken            -> 51
//  0: FalseToken           -> 52
//  0: NullToken            -> 53
//
//
                case 46:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 46));
                        state = 41;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 46));
                        state = 43;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 46));
                        state = 47;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 46));
                        state = 45;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 46));
                        state = 46;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 46));
                        state = 49;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 46));
                        state = 50;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 46));
                        state = 51;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 46));
                        state = 52;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 46));
                        state = 53;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 47
//
// ParExpressionNode              : OpeningParToken ExpressionNode . ClosingParToken
// DotExpressionNode              : ExpressionNode . DotToken IdentifierToken
// MulExpressionNode              : ExpressionNode . MulToken ExpressionNode
// DivExpressionNode              : ExpressionNode . DivToken ExpressionNode
// AddExpressionNode              : ExpressionNode . AddToken ExpressionNode
// SubExpressionNode              : ExpressionNode . SubToken ExpressionNode
// EqExpressionNode               : ExpressionNode . EqToken ExpressionNode
// NeqExpressionNode              : ExpressionNode . NeqToken ExpressionNode
// GtExpressionNode               : ExpressionNode . GtToken ExpressionNode
// GteqExpressionNode             : ExpressionNode . GteqToken ExpressionNode
// LtExpressionNode               : ExpressionNode . LtToken ExpressionNode
// LteqExpressionNode             : ExpressionNode . LteqToken ExpressionNode
// AndExpressionNode              : ExpressionNode . AndToken ExpressionNode
// OrExpressionNode               : ExpressionNode . OrToken ExpressionNode
// TernaryExpressionNode          : ExpressionNode . QuestionMarkToken ExpressionNode ColonToken ExpressionNode
// CallExpressionNode             : ExpressionNode . OpeningParToken ExpressionListNode ClosingParToken
//
//  9: DotToken             -> 5
//  7: MulToken             -> 7
//  7: DivToken             -> 9
//  6: AddToken             -> 11
//  6: SubToken             -> 13
//  5: EqToken              -> 15
//  5: NeqToken             -> 17
//  5: GtToken              -> 19
//  5: GteqToken            -> 21
//  5: LtToken              -> 23
//  5: LteqToken            -> 25
//  4: AndToken             -> 27
//  3: OrToken              -> 29
//  2: QuestionMarkToken    -> 31
//  1: OpeningParToken      -> 35
//  0: ClosingParToken      -> 48
//
//
                case 47:
                    if(input.Peek().Node is DotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 47));
                        state = 5;
                    }
                    else if(input.Peek().Node is MulToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 47));
                        state = 7;
                    }
                    else if(input.Peek().Node is DivToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 47));
                        state = 9;
                    }
                    else if(input.Peek().Node is AddToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 47));
                        state = 11;
                    }
                    else if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 47));
                        state = 13;
                    }
                    else if(input.Peek().Node is EqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 47));
                        state = 15;
                    }
                    else if(input.Peek().Node is NeqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 47));
                        state = 17;
                    }
                    else if(input.Peek().Node is GtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 47));
                        state = 19;
                    }
                    else if(input.Peek().Node is GteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 47));
                        state = 21;
                    }
                    else if(input.Peek().Node is LtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 47));
                        state = 23;
                    }
                    else if(input.Peek().Node is LteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 47));
                        state = 25;
                    }
                    else if(input.Peek().Node is AndToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 47));
                        state = 27;
                    }
                    else if(input.Peek().Node is OrToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 47));
                        state = 29;
                    }
                    else if(input.Peek().Node is QuestionMarkToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 47));
                        state = 31;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 47));
                        state = 35;
                    }
                    else if(input.Peek().Node is ClosingParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 47));
                        state = 48;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 48
//
// ParExpressionNode              : OpeningParToken ExpressionNode ClosingParToken .
//
//  0: <- ParExpressionNode
//
//
                case 48:
                    {
                        var p2 = stack.Pop();
                        var p1 = stack.Pop();
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new ParExpressionNode((OpeningParToken)p0.Node, (ExpressionNode)p1.Node, (ClosingParToken)p2.Node), 48));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 49
//
// StringExpressionNode           : StringToken .
//
//  0: <- StringExpressionNode
//
//
                case 49:
                    {
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new StringExpressionNode((StringToken)p0.Node), 49));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 50
//
// NumberExpressionNode           : NumberToken .
//
//  0: <- NumberExpressionNode
//
//
                case 50:
                    {
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new NumberExpressionNode((NumberToken)p0.Node), 50));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 51
//
// TrueExpressionNode             : TrueToken .
//
//  0: <- TrueExpressionNode
//
//
                case 51:
                    {
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new TrueExpressionNode((TrueToken)p0.Node), 51));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 52
//
// FalseExpressionNode            : FalseToken .
//
//  0: <- FalseExpressionNode
//
//
                case 52:
                    {
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new FalseExpressionNode((FalseToken)p0.Node), 52));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 53
//
// NullExpressionNode             : NullToken .
//
//  0: <- NullExpressionNode
//
//
                case 53:
                    {
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new NullExpressionNode((NullToken)p0.Node), 53));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 54
//
// WithParenthesisLambdaParametersNode : OpeningParToken . IdentifierListNode ClosingParToken
// EmptyIdentifierListNode        : .
// SingleIdentifierListNode       : . ExpressionNode
// DotExpressionNode              : . ExpressionNode DotToken IdentifierToken
// NegExpressionNode              : . SubToken ExpressionNode
// NotExpressionNode              : . NotToken ExpressionNode
// MulExpressionNode              : . ExpressionNode MulToken ExpressionNode
// DivExpressionNode              : . ExpressionNode DivToken ExpressionNode
// AddExpressionNode              : . ExpressionNode AddToken ExpressionNode
// SubExpressionNode              : . ExpressionNode SubToken ExpressionNode
// EqExpressionNode               : . ExpressionNode EqToken ExpressionNode
// NeqExpressionNode              : . ExpressionNode NeqToken ExpressionNode
// GtExpressionNode               : . ExpressionNode GtToken ExpressionNode
// GteqExpressionNode             : . ExpressionNode GteqToken ExpressionNode
// LtExpressionNode               : . ExpressionNode LtToken ExpressionNode
// LteqExpressionNode             : . ExpressionNode LteqToken ExpressionNode
// AndExpressionNode              : . ExpressionNode AndToken ExpressionNode
// OrExpressionNode               : . ExpressionNode OrToken ExpressionNode
// IdentifierExpressionNode       : . IdentifierToken
// ParExpressionNode              : . OpeningParToken ExpressionNode ClosingParToken
// StringExpressionNode           : . StringToken
// NumberExpressionNode           : . NumberToken
// TrueExpressionNode             : . TrueToken
// FalseExpressionNode            : . FalseToken
// NullExpressionNode             : . NullToken
// TernaryExpressionNode          : . ExpressionNode QuestionMarkToken ExpressionNode ColonToken ExpressionNode
// CallExpressionNode             : . ExpressionNode OpeningParToken ExpressionListNode ClosingParToken
// MultipleIdentifierListNode     : . ExpressionNode CommaToken RealIdentifierListNode
// ParExpressionNode              : OpeningParToken . ExpressionNode ClosingParToken
//
//  8: SubToken             -> 41
//  8: NotToken             -> 43
//  0: IdentifierListNode   -> 55
//  0: ExpressionNode       -> 57
//  0: IdentifierToken      -> 45
//  0: OpeningParToken      -> 46
//  0: StringToken          -> 49
//  0: NumberToken          -> 50
//  0: TrueToken            -> 51
//  0: FalseToken           -> 52
//  0: NullToken            -> 53
// -2: <- EmptyIdentifierListNode
//
//
                case 54:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 54));
                        state = 41;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 54));
                        state = 43;
                    }
                    else if(input.Peek().Node is IdentifierListNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 54));
                        state = 55;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 54));
                        state = 57;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 54));
                        state = 45;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 54));
                        state = 46;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 54));
                        state = 49;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 54));
                        state = 50;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 54));
                        state = 51;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 54));
                        state = 52;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 54));
                        state = 53;
                    }
                    else
                    {
                        input.Push(new StackItem(new EmptyIdentifierListNode(), 54));
                    }
                    break;

// ###################################
// # State 55
//
// WithParenthesisLambdaParametersNode : OpeningParToken IdentifierListNode . ClosingParToken
//
//  0: ClosingParToken      -> 56
//
//
                case 55:
                    if(input.Peek().Node is ClosingParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 55));
                        state = 56;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 56
//
// WithParenthesisLambdaParametersNode : OpeningParToken IdentifierListNode ClosingParToken .
//
//  0: <- WithParenthesisLambdaParametersNode
//
//
                case 56:
                    {
                        var p2 = stack.Pop();
                        var p1 = stack.Pop();
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new WithParenthesisLambdaParametersNode((OpeningParToken)p0.Node, (IdentifierListNode)p1.Node, (ClosingParToken)p2.Node), 56));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 57
//
// SingleIdentifierListNode       : ExpressionNode .
// DotExpressionNode              : ExpressionNode . DotToken IdentifierToken
// MulExpressionNode              : ExpressionNode . MulToken ExpressionNode
// DivExpressionNode              : ExpressionNode . DivToken ExpressionNode
// AddExpressionNode              : ExpressionNode . AddToken ExpressionNode
// SubExpressionNode              : ExpressionNode . SubToken ExpressionNode
// EqExpressionNode               : ExpressionNode . EqToken ExpressionNode
// NeqExpressionNode              : ExpressionNode . NeqToken ExpressionNode
// GtExpressionNode               : ExpressionNode . GtToken ExpressionNode
// GteqExpressionNode             : ExpressionNode . GteqToken ExpressionNode
// LtExpressionNode               : ExpressionNode . LtToken ExpressionNode
// LteqExpressionNode             : ExpressionNode . LteqToken ExpressionNode
// AndExpressionNode              : ExpressionNode . AndToken ExpressionNode
// OrExpressionNode               : ExpressionNode . OrToken ExpressionNode
// TernaryExpressionNode          : ExpressionNode . QuestionMarkToken ExpressionNode ColonToken ExpressionNode
// CallExpressionNode             : ExpressionNode . OpeningParToken ExpressionListNode ClosingParToken
// MultipleIdentifierListNode     : ExpressionNode . CommaToken RealIdentifierListNode
// ParExpressionNode              : OpeningParToken ExpressionNode . ClosingParToken
//
//  9: DotToken             -> 5
//  7: MulToken             -> 7
//  7: DivToken             -> 9
//  6: AddToken             -> 11
//  6: SubToken             -> 13
//  5: EqToken              -> 15
//  5: NeqToken             -> 17
//  5: GtToken              -> 19
//  5: GteqToken            -> 21
//  5: LtToken              -> 23
//  5: LteqToken            -> 25
//  4: AndToken             -> 27
//  3: OrToken              -> 29
//  2: QuestionMarkToken    -> 31
//  1: OpeningParToken      -> 35
//  0: CommaToken           -> 58
//  0: ClosingParToken      -> 48
// -1: <- SingleIdentifierListNode
//
//
                case 57:
                    if(input.Peek().Node is DotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 57));
                        state = 5;
                    }
                    else if(input.Peek().Node is MulToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 57));
                        state = 7;
                    }
                    else if(input.Peek().Node is DivToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 57));
                        state = 9;
                    }
                    else if(input.Peek().Node is AddToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 57));
                        state = 11;
                    }
                    else if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 57));
                        state = 13;
                    }
                    else if(input.Peek().Node is EqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 57));
                        state = 15;
                    }
                    else if(input.Peek().Node is NeqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 57));
                        state = 17;
                    }
                    else if(input.Peek().Node is GtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 57));
                        state = 19;
                    }
                    else if(input.Peek().Node is GteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 57));
                        state = 21;
                    }
                    else if(input.Peek().Node is LtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 57));
                        state = 23;
                    }
                    else if(input.Peek().Node is LteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 57));
                        state = 25;
                    }
                    else if(input.Peek().Node is AndToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 57));
                        state = 27;
                    }
                    else if(input.Peek().Node is OrToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 57));
                        state = 29;
                    }
                    else if(input.Peek().Node is QuestionMarkToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 57));
                        state = 31;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 57));
                        state = 35;
                    }
                    else if(input.Peek().Node is CommaToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 57));
                        state = 58;
                    }
                    else if(input.Peek().Node is ClosingParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 57));
                        state = 48;
                    }
                    else
                    {
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new SingleIdentifierListNode((ExpressionNode)p0.Node), 57));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 58
//
// MultipleIdentifierListNode     : ExpressionNode CommaToken . RealIdentifierListNode
// SingleIdentifierListNode       : . ExpressionNode
// DotExpressionNode              : . ExpressionNode DotToken IdentifierToken
// NegExpressionNode              : . SubToken ExpressionNode
// NotExpressionNode              : . NotToken ExpressionNode
// MulExpressionNode              : . ExpressionNode MulToken ExpressionNode
// DivExpressionNode              : . ExpressionNode DivToken ExpressionNode
// AddExpressionNode              : . ExpressionNode AddToken ExpressionNode
// SubExpressionNode              : . ExpressionNode SubToken ExpressionNode
// EqExpressionNode               : . ExpressionNode EqToken ExpressionNode
// NeqExpressionNode              : . ExpressionNode NeqToken ExpressionNode
// GtExpressionNode               : . ExpressionNode GtToken ExpressionNode
// GteqExpressionNode             : . ExpressionNode GteqToken ExpressionNode
// LtExpressionNode               : . ExpressionNode LtToken ExpressionNode
// LteqExpressionNode             : . ExpressionNode LteqToken ExpressionNode
// AndExpressionNode              : . ExpressionNode AndToken ExpressionNode
// OrExpressionNode               : . ExpressionNode OrToken ExpressionNode
// IdentifierExpressionNode       : . IdentifierToken
// ParExpressionNode              : . OpeningParToken ExpressionNode ClosingParToken
// StringExpressionNode           : . StringToken
// NumberExpressionNode           : . NumberToken
// TrueExpressionNode             : . TrueToken
// FalseExpressionNode            : . FalseToken
// NullExpressionNode             : . NullToken
// TernaryExpressionNode          : . ExpressionNode QuestionMarkToken ExpressionNode ColonToken ExpressionNode
// CallExpressionNode             : . ExpressionNode OpeningParToken ExpressionListNode ClosingParToken
// MultipleIdentifierListNode     : . ExpressionNode CommaToken RealIdentifierListNode
//
//  8: SubToken             -> 41
//  8: NotToken             -> 43
//  0: RealIdentifierListNode -> 59
//  0: ExpressionNode       -> 57
//  0: IdentifierToken      -> 45
//  0: OpeningParToken      -> 46
//  0: StringToken          -> 49
//  0: NumberToken          -> 50
//  0: TrueToken            -> 51
//  0: FalseToken           -> 52
//  0: NullToken            -> 53
//
//
                case 58:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 58));
                        state = 41;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 58));
                        state = 43;
                    }
                    else if(input.Peek().Node is RealIdentifierListNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 58));
                        state = 59;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 58));
                        state = 57;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 58));
                        state = 45;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 58));
                        state = 46;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 58));
                        state = 49;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 58));
                        state = 50;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 58));
                        state = 51;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 58));
                        state = 52;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 58));
                        state = 53;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 59
//
// MultipleIdentifierListNode     : ExpressionNode CommaToken RealIdentifierListNode .
//
//  0: <- MultipleIdentifierListNode
//
//
                case 59:
                    {
                        var p2 = stack.Pop();
                        var p1 = stack.Pop();
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new MultipleIdentifierListNode((ExpressionNode)p0.Node, (CommaToken)p1.Node, (RealIdentifierListNode)p2.Node), 59));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 60
//
// WithoutParenthesisLambdaParametersNode : IdentifierListNode .
//
//  0: <- WithoutParenthesisLambdaParametersNode
//
//
                case 60:
                    {
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new WithoutParenthesisLambdaParametersNode((IdentifierListNode)p0.Node), 60));
                        state = p0.State;
                    }
                    break;

            }
        }
    }
}
}

