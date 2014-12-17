
namespace Granite.UI.ExpressionParser
{


using System.Collections.Generic;
using System.Linq;


// LambdaNode: OpeningParToken IdentifierListNode ClosingParToken ArrowToken ExpressionNode EndToken
public sealed partial class LambdaNode : Node
{
    private readonly OpeningParToken m_p0;
    public OpeningParToken P0 {  get { return m_p0; } }
    private readonly IdentifierListNode m_p1;
    public IdentifierListNode P1 {  get { return m_p1; } }
    private readonly ClosingParToken m_p2;
    public ClosingParToken P2 {  get { return m_p2; } }
    private readonly ArrowToken m_p3;
    public ArrowToken P3 {  get { return m_p3; } }
    private readonly ExpressionNode m_p4;
    public ExpressionNode P4 {  get { return m_p4; } }
    private readonly EndToken m_p5;
    public EndToken P5 {  get { return m_p5; } }
    public LambdaNode(OpeningParToken p0, IdentifierListNode p1, ClosingParToken p2, ArrowToken p3, ExpressionNode p4, EndToken p5)
    {
        m_p0 = p0;
        m_p1 = p1;
        m_p2 = p2;
        m_p3 = p3;
        m_p4 = p4;
        m_p5 = p5;
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
// LambdaNode                     : . OpeningParToken IdentifierListNode ClosingParToken ArrowToken ExpressionNode EndToken
//
//  0: OpeningParToken      -> 1
//
//
                case 0:
                    if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 0));
                        state = 1;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 1
//
// LambdaNode                     : OpeningParToken . IdentifierListNode ClosingParToken ArrowToken ExpressionNode EndToken
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
//  8: SubToken             -> 43
//  8: NotToken             -> 45
//  0: IdentifierListNode   -> 2
//  0: ExpressionNode       -> 56
//  0: IdentifierToken      -> 47
//  0: OpeningParToken      -> 48
//  0: StringToken          -> 51
//  0: NumberToken          -> 52
//  0: TrueToken            -> 53
//  0: FalseToken           -> 54
//  0: NullToken            -> 55
// -2: <- EmptyIdentifierListNode
//
//
                case 1:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 1));
                        state = 43;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 1));
                        state = 45;
                    }
                    else if(input.Peek().Node is IdentifierListNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 1));
                        state = 2;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 1));
                        state = 56;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 1));
                        state = 47;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 1));
                        state = 48;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 1));
                        state = 51;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 1));
                        state = 52;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 1));
                        state = 53;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 1));
                        state = 54;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 1));
                        state = 55;
                    }
                    else
                    {
                        input.Push(new StackItem(new EmptyIdentifierListNode(), 1));
                    }
                    break;

// ###################################
// # State 2
//
// LambdaNode                     : OpeningParToken IdentifierListNode . ClosingParToken ArrowToken ExpressionNode EndToken
//
//  0: ClosingParToken      -> 3
//
//
                case 2:
                    if(input.Peek().Node is ClosingParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 2));
                        state = 3;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 3
//
// LambdaNode                     : OpeningParToken IdentifierListNode ClosingParToken . ArrowToken ExpressionNode EndToken
//
//  0: ArrowToken           -> 4
//
//
                case 3:
                    if(input.Peek().Node is ArrowToken)
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
// LambdaNode                     : OpeningParToken IdentifierListNode ClosingParToken ArrowToken . ExpressionNode EndToken
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
//  8: SubToken             -> 43
//  8: NotToken             -> 45
//  0: ExpressionNode       -> 5
//  0: IdentifierToken      -> 47
//  0: OpeningParToken      -> 48
//  0: StringToken          -> 51
//  0: NumberToken          -> 52
//  0: TrueToken            -> 53
//  0: FalseToken           -> 54
//  0: NullToken            -> 55
//
//
                case 4:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 4));
                        state = 43;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 4));
                        state = 45;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 4));
                        state = 5;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 4));
                        state = 47;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 4));
                        state = 48;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 4));
                        state = 51;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 4));
                        state = 52;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 4));
                        state = 53;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 4));
                        state = 54;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 4));
                        state = 55;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 5
//
// LambdaNode                     : OpeningParToken IdentifierListNode ClosingParToken ArrowToken ExpressionNode . EndToken
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
//  9: DotToken             -> 7
//  7: MulToken             -> 9
//  7: DivToken             -> 11
//  6: AddToken             -> 13
//  6: SubToken             -> 15
//  5: EqToken              -> 17
//  5: NeqToken             -> 19
//  5: GtToken              -> 21
//  5: GteqToken            -> 23
//  5: LtToken              -> 25
//  5: LteqToken            -> 27
//  4: AndToken             -> 29
//  3: OrToken              -> 31
//  2: QuestionMarkToken    -> 33
//  1: OpeningParToken      -> 37
//  0: EndToken             -> 6
//
//
                case 5:
                    if(input.Peek().Node is DotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 5));
                        state = 7;
                    }
                    else if(input.Peek().Node is MulToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 5));
                        state = 9;
                    }
                    else if(input.Peek().Node is DivToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 5));
                        state = 11;
                    }
                    else if(input.Peek().Node is AddToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 5));
                        state = 13;
                    }
                    else if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 5));
                        state = 15;
                    }
                    else if(input.Peek().Node is EqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 5));
                        state = 17;
                    }
                    else if(input.Peek().Node is NeqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 5));
                        state = 19;
                    }
                    else if(input.Peek().Node is GtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 5));
                        state = 21;
                    }
                    else if(input.Peek().Node is GteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 5));
                        state = 23;
                    }
                    else if(input.Peek().Node is LtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 5));
                        state = 25;
                    }
                    else if(input.Peek().Node is LteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 5));
                        state = 27;
                    }
                    else if(input.Peek().Node is AndToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 5));
                        state = 29;
                    }
                    else if(input.Peek().Node is OrToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 5));
                        state = 31;
                    }
                    else if(input.Peek().Node is QuestionMarkToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 5));
                        state = 33;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 5));
                        state = 37;
                    }
                    else if(input.Peek().Node is EndToken)
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
// LambdaNode                     : OpeningParToken IdentifierListNode ClosingParToken ArrowToken ExpressionNode EndToken .
//
//  0: <- LambdaNode
//
//
                case 6:
                    {
                        var p5 = stack.Pop();
                        var p4 = stack.Pop();
                        var p3 = stack.Pop();
                        var p2 = stack.Pop();
                        var p1 = stack.Pop();
                        var p0 = stack.Pop();
                        return new LambdaNode((OpeningParToken)p0.Node, (IdentifierListNode)p1.Node, (ClosingParToken)p2.Node, (ArrowToken)p3.Node, (ExpressionNode)p4.Node, (EndToken)p5.Node);
                    }

// ###################################
// # State 7
//
// DotExpressionNode              : ExpressionNode DotToken . IdentifierToken
//
//  9: IdentifierToken      -> 8
//
//
                case 7:
                    if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 7));
                        state = 8;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 8
//
// DotExpressionNode              : ExpressionNode DotToken IdentifierToken .
//
//  9: <- DotExpressionNode
//
//
                case 8:
                    {
                        var p2 = stack.Pop();
                        var p1 = stack.Pop();
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new DotExpressionNode((ExpressionNode)p0.Node, (DotToken)p1.Node, (IdentifierToken)p2.Node), 8));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 9
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
//  8: SubToken             -> 43
//  8: NotToken             -> 45
//  0: ExpressionNode       -> 10
//  0: IdentifierToken      -> 47
//  0: OpeningParToken      -> 48
//  0: StringToken          -> 51
//  0: NumberToken          -> 52
//  0: TrueToken            -> 53
//  0: FalseToken           -> 54
//  0: NullToken            -> 55
//
//
                case 9:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 9));
                        state = 43;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 9));
                        state = 45;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 9));
                        state = 10;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 9));
                        state = 47;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 9));
                        state = 48;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 9));
                        state = 51;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 9));
                        state = 52;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 9));
                        state = 53;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 9));
                        state = 54;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 9));
                        state = 55;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 10
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
//  9: DotToken             -> 7
//  7: MulToken             -> 9
//  7: DivToken             -> 11
//  7: <- MulExpressionNode
//
//
                case 10:
                    if(input.Peek().Node is DotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 10));
                        state = 7;
                    }
                    else if(input.Peek().Node is MulToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 10));
                        state = 9;
                    }
                    else if(input.Peek().Node is DivToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 10));
                        state = 11;
                    }
                    else
                    {
                        var p2 = stack.Pop();
                        var p1 = stack.Pop();
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new MulExpressionNode((ExpressionNode)p0.Node, (MulToken)p1.Node, (ExpressionNode)p2.Node), 10));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 11
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
//  8: SubToken             -> 43
//  8: NotToken             -> 45
//  0: ExpressionNode       -> 12
//  0: IdentifierToken      -> 47
//  0: OpeningParToken      -> 48
//  0: StringToken          -> 51
//  0: NumberToken          -> 52
//  0: TrueToken            -> 53
//  0: FalseToken           -> 54
//  0: NullToken            -> 55
//
//
                case 11:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 11));
                        state = 43;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 11));
                        state = 45;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 11));
                        state = 12;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 11));
                        state = 47;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 11));
                        state = 48;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 11));
                        state = 51;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 11));
                        state = 52;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 11));
                        state = 53;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 11));
                        state = 54;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 11));
                        state = 55;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 12
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
//  9: DotToken             -> 7
//  7: MulToken             -> 9
//  7: DivToken             -> 11
//  7: <- DivExpressionNode
//
//
                case 12:
                    if(input.Peek().Node is DotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 12));
                        state = 7;
                    }
                    else if(input.Peek().Node is MulToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 12));
                        state = 9;
                    }
                    else if(input.Peek().Node is DivToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 12));
                        state = 11;
                    }
                    else
                    {
                        var p2 = stack.Pop();
                        var p1 = stack.Pop();
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new DivExpressionNode((ExpressionNode)p0.Node, (DivToken)p1.Node, (ExpressionNode)p2.Node), 12));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 13
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
//  8: SubToken             -> 43
//  8: NotToken             -> 45
//  0: ExpressionNode       -> 14
//  0: IdentifierToken      -> 47
//  0: OpeningParToken      -> 48
//  0: StringToken          -> 51
//  0: NumberToken          -> 52
//  0: TrueToken            -> 53
//  0: FalseToken           -> 54
//  0: NullToken            -> 55
//
//
                case 13:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 13));
                        state = 43;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 13));
                        state = 45;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 13));
                        state = 14;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 13));
                        state = 47;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 13));
                        state = 48;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 13));
                        state = 51;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 13));
                        state = 52;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 13));
                        state = 53;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 13));
                        state = 54;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 13));
                        state = 55;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 14
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
//  9: DotToken             -> 7
//  7: MulToken             -> 9
//  7: DivToken             -> 11
//  6: AddToken             -> 13
//  6: SubToken             -> 15
//  6: <- AddExpressionNode
//
//
                case 14:
                    if(input.Peek().Node is DotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 14));
                        state = 7;
                    }
                    else if(input.Peek().Node is MulToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 14));
                        state = 9;
                    }
                    else if(input.Peek().Node is DivToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 14));
                        state = 11;
                    }
                    else if(input.Peek().Node is AddToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 14));
                        state = 13;
                    }
                    else if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 14));
                        state = 15;
                    }
                    else
                    {
                        var p2 = stack.Pop();
                        var p1 = stack.Pop();
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new AddExpressionNode((ExpressionNode)p0.Node, (AddToken)p1.Node, (ExpressionNode)p2.Node), 14));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 15
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
//  8: SubToken             -> 43
//  8: NotToken             -> 45
//  0: ExpressionNode       -> 16
//  0: IdentifierToken      -> 47
//  0: OpeningParToken      -> 48
//  0: StringToken          -> 51
//  0: NumberToken          -> 52
//  0: TrueToken            -> 53
//  0: FalseToken           -> 54
//  0: NullToken            -> 55
//
//
                case 15:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 15));
                        state = 43;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 15));
                        state = 45;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 15));
                        state = 16;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 15));
                        state = 47;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 15));
                        state = 48;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 15));
                        state = 51;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 15));
                        state = 52;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 15));
                        state = 53;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 15));
                        state = 54;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 15));
                        state = 55;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 16
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
//  9: DotToken             -> 7
//  7: MulToken             -> 9
//  7: DivToken             -> 11
//  6: AddToken             -> 13
//  6: SubToken             -> 15
//  6: <- SubExpressionNode
//
//
                case 16:
                    if(input.Peek().Node is DotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 16));
                        state = 7;
                    }
                    else if(input.Peek().Node is MulToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 16));
                        state = 9;
                    }
                    else if(input.Peek().Node is DivToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 16));
                        state = 11;
                    }
                    else if(input.Peek().Node is AddToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 16));
                        state = 13;
                    }
                    else if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 16));
                        state = 15;
                    }
                    else
                    {
                        var p2 = stack.Pop();
                        var p1 = stack.Pop();
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new SubExpressionNode((ExpressionNode)p0.Node, (SubToken)p1.Node, (ExpressionNode)p2.Node), 16));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 17
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
//  8: SubToken             -> 43
//  8: NotToken             -> 45
//  0: ExpressionNode       -> 18
//  0: IdentifierToken      -> 47
//  0: OpeningParToken      -> 48
//  0: StringToken          -> 51
//  0: NumberToken          -> 52
//  0: TrueToken            -> 53
//  0: FalseToken           -> 54
//  0: NullToken            -> 55
//
//
                case 17:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 17));
                        state = 43;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 17));
                        state = 45;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 17));
                        state = 18;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 17));
                        state = 47;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 17));
                        state = 48;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 17));
                        state = 51;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 17));
                        state = 52;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 17));
                        state = 53;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 17));
                        state = 54;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 17));
                        state = 55;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 18
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
//  9: DotToken             -> 7
//  7: MulToken             -> 9
//  7: DivToken             -> 11
//  6: AddToken             -> 13
//  6: SubToken             -> 15
//  5: EqToken              -> 17
//  5: NeqToken             -> 19
//  5: GtToken              -> 21
//  5: GteqToken            -> 23
//  5: LtToken              -> 25
//  5: LteqToken            -> 27
//  5: <- EqExpressionNode
//
//
                case 18:
                    if(input.Peek().Node is DotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 18));
                        state = 7;
                    }
                    else if(input.Peek().Node is MulToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 18));
                        state = 9;
                    }
                    else if(input.Peek().Node is DivToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 18));
                        state = 11;
                    }
                    else if(input.Peek().Node is AddToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 18));
                        state = 13;
                    }
                    else if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 18));
                        state = 15;
                    }
                    else if(input.Peek().Node is EqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 18));
                        state = 17;
                    }
                    else if(input.Peek().Node is NeqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 18));
                        state = 19;
                    }
                    else if(input.Peek().Node is GtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 18));
                        state = 21;
                    }
                    else if(input.Peek().Node is GteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 18));
                        state = 23;
                    }
                    else if(input.Peek().Node is LtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 18));
                        state = 25;
                    }
                    else if(input.Peek().Node is LteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 18));
                        state = 27;
                    }
                    else
                    {
                        var p2 = stack.Pop();
                        var p1 = stack.Pop();
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new EqExpressionNode((ExpressionNode)p0.Node, (EqToken)p1.Node, (ExpressionNode)p2.Node), 18));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 19
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
//  8: SubToken             -> 43
//  8: NotToken             -> 45
//  0: ExpressionNode       -> 20
//  0: IdentifierToken      -> 47
//  0: OpeningParToken      -> 48
//  0: StringToken          -> 51
//  0: NumberToken          -> 52
//  0: TrueToken            -> 53
//  0: FalseToken           -> 54
//  0: NullToken            -> 55
//
//
                case 19:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 19));
                        state = 43;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 19));
                        state = 45;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 19));
                        state = 20;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 19));
                        state = 47;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 19));
                        state = 48;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 19));
                        state = 51;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 19));
                        state = 52;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 19));
                        state = 53;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 19));
                        state = 54;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 19));
                        state = 55;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 20
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
//  9: DotToken             -> 7
//  7: MulToken             -> 9
//  7: DivToken             -> 11
//  6: AddToken             -> 13
//  6: SubToken             -> 15
//  5: EqToken              -> 17
//  5: NeqToken             -> 19
//  5: GtToken              -> 21
//  5: GteqToken            -> 23
//  5: LtToken              -> 25
//  5: LteqToken            -> 27
//  5: <- NeqExpressionNode
//
//
                case 20:
                    if(input.Peek().Node is DotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 20));
                        state = 7;
                    }
                    else if(input.Peek().Node is MulToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 20));
                        state = 9;
                    }
                    else if(input.Peek().Node is DivToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 20));
                        state = 11;
                    }
                    else if(input.Peek().Node is AddToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 20));
                        state = 13;
                    }
                    else if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 20));
                        state = 15;
                    }
                    else if(input.Peek().Node is EqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 20));
                        state = 17;
                    }
                    else if(input.Peek().Node is NeqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 20));
                        state = 19;
                    }
                    else if(input.Peek().Node is GtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 20));
                        state = 21;
                    }
                    else if(input.Peek().Node is GteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 20));
                        state = 23;
                    }
                    else if(input.Peek().Node is LtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 20));
                        state = 25;
                    }
                    else if(input.Peek().Node is LteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 20));
                        state = 27;
                    }
                    else
                    {
                        var p2 = stack.Pop();
                        var p1 = stack.Pop();
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new NeqExpressionNode((ExpressionNode)p0.Node, (NeqToken)p1.Node, (ExpressionNode)p2.Node), 20));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 21
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
//  8: SubToken             -> 43
//  8: NotToken             -> 45
//  0: ExpressionNode       -> 22
//  0: IdentifierToken      -> 47
//  0: OpeningParToken      -> 48
//  0: StringToken          -> 51
//  0: NumberToken          -> 52
//  0: TrueToken            -> 53
//  0: FalseToken           -> 54
//  0: NullToken            -> 55
//
//
                case 21:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 21));
                        state = 43;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 21));
                        state = 45;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 21));
                        state = 22;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 21));
                        state = 47;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 21));
                        state = 48;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 21));
                        state = 51;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 21));
                        state = 52;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 21));
                        state = 53;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 21));
                        state = 54;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 21));
                        state = 55;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 22
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
//  9: DotToken             -> 7
//  7: MulToken             -> 9
//  7: DivToken             -> 11
//  6: AddToken             -> 13
//  6: SubToken             -> 15
//  5: EqToken              -> 17
//  5: NeqToken             -> 19
//  5: GtToken              -> 21
//  5: GteqToken            -> 23
//  5: LtToken              -> 25
//  5: LteqToken            -> 27
//  5: <- GtExpressionNode
//
//
                case 22:
                    if(input.Peek().Node is DotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 22));
                        state = 7;
                    }
                    else if(input.Peek().Node is MulToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 22));
                        state = 9;
                    }
                    else if(input.Peek().Node is DivToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 22));
                        state = 11;
                    }
                    else if(input.Peek().Node is AddToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 22));
                        state = 13;
                    }
                    else if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 22));
                        state = 15;
                    }
                    else if(input.Peek().Node is EqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 22));
                        state = 17;
                    }
                    else if(input.Peek().Node is NeqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 22));
                        state = 19;
                    }
                    else if(input.Peek().Node is GtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 22));
                        state = 21;
                    }
                    else if(input.Peek().Node is GteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 22));
                        state = 23;
                    }
                    else if(input.Peek().Node is LtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 22));
                        state = 25;
                    }
                    else if(input.Peek().Node is LteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 22));
                        state = 27;
                    }
                    else
                    {
                        var p2 = stack.Pop();
                        var p1 = stack.Pop();
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new GtExpressionNode((ExpressionNode)p0.Node, (GtToken)p1.Node, (ExpressionNode)p2.Node), 22));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 23
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
//  8: SubToken             -> 43
//  8: NotToken             -> 45
//  0: ExpressionNode       -> 24
//  0: IdentifierToken      -> 47
//  0: OpeningParToken      -> 48
//  0: StringToken          -> 51
//  0: NumberToken          -> 52
//  0: TrueToken            -> 53
//  0: FalseToken           -> 54
//  0: NullToken            -> 55
//
//
                case 23:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 23));
                        state = 43;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 23));
                        state = 45;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 23));
                        state = 24;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 23));
                        state = 47;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 23));
                        state = 48;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 23));
                        state = 51;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 23));
                        state = 52;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 23));
                        state = 53;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 23));
                        state = 54;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 23));
                        state = 55;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 24
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
//  9: DotToken             -> 7
//  7: MulToken             -> 9
//  7: DivToken             -> 11
//  6: AddToken             -> 13
//  6: SubToken             -> 15
//  5: EqToken              -> 17
//  5: NeqToken             -> 19
//  5: GtToken              -> 21
//  5: GteqToken            -> 23
//  5: LtToken              -> 25
//  5: LteqToken            -> 27
//  5: <- GteqExpressionNode
//
//
                case 24:
                    if(input.Peek().Node is DotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 24));
                        state = 7;
                    }
                    else if(input.Peek().Node is MulToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 24));
                        state = 9;
                    }
                    else if(input.Peek().Node is DivToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 24));
                        state = 11;
                    }
                    else if(input.Peek().Node is AddToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 24));
                        state = 13;
                    }
                    else if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 24));
                        state = 15;
                    }
                    else if(input.Peek().Node is EqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 24));
                        state = 17;
                    }
                    else if(input.Peek().Node is NeqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 24));
                        state = 19;
                    }
                    else if(input.Peek().Node is GtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 24));
                        state = 21;
                    }
                    else if(input.Peek().Node is GteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 24));
                        state = 23;
                    }
                    else if(input.Peek().Node is LtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 24));
                        state = 25;
                    }
                    else if(input.Peek().Node is LteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 24));
                        state = 27;
                    }
                    else
                    {
                        var p2 = stack.Pop();
                        var p1 = stack.Pop();
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new GteqExpressionNode((ExpressionNode)p0.Node, (GteqToken)p1.Node, (ExpressionNode)p2.Node), 24));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 25
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
//  8: SubToken             -> 43
//  8: NotToken             -> 45
//  0: ExpressionNode       -> 26
//  0: IdentifierToken      -> 47
//  0: OpeningParToken      -> 48
//  0: StringToken          -> 51
//  0: NumberToken          -> 52
//  0: TrueToken            -> 53
//  0: FalseToken           -> 54
//  0: NullToken            -> 55
//
//
                case 25:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 25));
                        state = 43;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 25));
                        state = 45;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 25));
                        state = 26;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 25));
                        state = 47;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 25));
                        state = 48;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 25));
                        state = 51;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 25));
                        state = 52;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 25));
                        state = 53;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 25));
                        state = 54;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 25));
                        state = 55;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 26
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
//  9: DotToken             -> 7
//  7: MulToken             -> 9
//  7: DivToken             -> 11
//  6: AddToken             -> 13
//  6: SubToken             -> 15
//  5: EqToken              -> 17
//  5: NeqToken             -> 19
//  5: GtToken              -> 21
//  5: GteqToken            -> 23
//  5: LtToken              -> 25
//  5: LteqToken            -> 27
//  5: <- LtExpressionNode
//
//
                case 26:
                    if(input.Peek().Node is DotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 26));
                        state = 7;
                    }
                    else if(input.Peek().Node is MulToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 26));
                        state = 9;
                    }
                    else if(input.Peek().Node is DivToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 26));
                        state = 11;
                    }
                    else if(input.Peek().Node is AddToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 26));
                        state = 13;
                    }
                    else if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 26));
                        state = 15;
                    }
                    else if(input.Peek().Node is EqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 26));
                        state = 17;
                    }
                    else if(input.Peek().Node is NeqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 26));
                        state = 19;
                    }
                    else if(input.Peek().Node is GtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 26));
                        state = 21;
                    }
                    else if(input.Peek().Node is GteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 26));
                        state = 23;
                    }
                    else if(input.Peek().Node is LtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 26));
                        state = 25;
                    }
                    else if(input.Peek().Node is LteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 26));
                        state = 27;
                    }
                    else
                    {
                        var p2 = stack.Pop();
                        var p1 = stack.Pop();
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new LtExpressionNode((ExpressionNode)p0.Node, (LtToken)p1.Node, (ExpressionNode)p2.Node), 26));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 27
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
//  8: SubToken             -> 43
//  8: NotToken             -> 45
//  0: ExpressionNode       -> 28
//  0: IdentifierToken      -> 47
//  0: OpeningParToken      -> 48
//  0: StringToken          -> 51
//  0: NumberToken          -> 52
//  0: TrueToken            -> 53
//  0: FalseToken           -> 54
//  0: NullToken            -> 55
//
//
                case 27:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 27));
                        state = 43;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 27));
                        state = 45;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 27));
                        state = 28;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 27));
                        state = 47;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 27));
                        state = 48;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 27));
                        state = 51;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 27));
                        state = 52;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 27));
                        state = 53;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 27));
                        state = 54;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 27));
                        state = 55;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 28
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
//  9: DotToken             -> 7
//  7: MulToken             -> 9
//  7: DivToken             -> 11
//  6: AddToken             -> 13
//  6: SubToken             -> 15
//  5: EqToken              -> 17
//  5: NeqToken             -> 19
//  5: GtToken              -> 21
//  5: GteqToken            -> 23
//  5: LtToken              -> 25
//  5: LteqToken            -> 27
//  5: <- LteqExpressionNode
//
//
                case 28:
                    if(input.Peek().Node is DotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 28));
                        state = 7;
                    }
                    else if(input.Peek().Node is MulToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 28));
                        state = 9;
                    }
                    else if(input.Peek().Node is DivToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 28));
                        state = 11;
                    }
                    else if(input.Peek().Node is AddToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 28));
                        state = 13;
                    }
                    else if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 28));
                        state = 15;
                    }
                    else if(input.Peek().Node is EqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 28));
                        state = 17;
                    }
                    else if(input.Peek().Node is NeqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 28));
                        state = 19;
                    }
                    else if(input.Peek().Node is GtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 28));
                        state = 21;
                    }
                    else if(input.Peek().Node is GteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 28));
                        state = 23;
                    }
                    else if(input.Peek().Node is LtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 28));
                        state = 25;
                    }
                    else if(input.Peek().Node is LteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 28));
                        state = 27;
                    }
                    else
                    {
                        var p2 = stack.Pop();
                        var p1 = stack.Pop();
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new LteqExpressionNode((ExpressionNode)p0.Node, (LteqToken)p1.Node, (ExpressionNode)p2.Node), 28));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 29
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
//  8: SubToken             -> 43
//  8: NotToken             -> 45
//  0: ExpressionNode       -> 30
//  0: IdentifierToken      -> 47
//  0: OpeningParToken      -> 48
//  0: StringToken          -> 51
//  0: NumberToken          -> 52
//  0: TrueToken            -> 53
//  0: FalseToken           -> 54
//  0: NullToken            -> 55
//
//
                case 29:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 29));
                        state = 43;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 29));
                        state = 45;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 29));
                        state = 30;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 29));
                        state = 47;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 29));
                        state = 48;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 29));
                        state = 51;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 29));
                        state = 52;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 29));
                        state = 53;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 29));
                        state = 54;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 29));
                        state = 55;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 30
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
//  9: DotToken             -> 7
//  7: MulToken             -> 9
//  7: DivToken             -> 11
//  6: AddToken             -> 13
//  6: SubToken             -> 15
//  5: EqToken              -> 17
//  5: NeqToken             -> 19
//  5: GtToken              -> 21
//  5: GteqToken            -> 23
//  5: LtToken              -> 25
//  5: LteqToken            -> 27
//  4: AndToken             -> 29
//  4: <- AndExpressionNode
//
//
                case 30:
                    if(input.Peek().Node is DotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 30));
                        state = 7;
                    }
                    else if(input.Peek().Node is MulToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 30));
                        state = 9;
                    }
                    else if(input.Peek().Node is DivToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 30));
                        state = 11;
                    }
                    else if(input.Peek().Node is AddToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 30));
                        state = 13;
                    }
                    else if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 30));
                        state = 15;
                    }
                    else if(input.Peek().Node is EqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 30));
                        state = 17;
                    }
                    else if(input.Peek().Node is NeqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 30));
                        state = 19;
                    }
                    else if(input.Peek().Node is GtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 30));
                        state = 21;
                    }
                    else if(input.Peek().Node is GteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 30));
                        state = 23;
                    }
                    else if(input.Peek().Node is LtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 30));
                        state = 25;
                    }
                    else if(input.Peek().Node is LteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 30));
                        state = 27;
                    }
                    else if(input.Peek().Node is AndToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 30));
                        state = 29;
                    }
                    else
                    {
                        var p2 = stack.Pop();
                        var p1 = stack.Pop();
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new AndExpressionNode((ExpressionNode)p0.Node, (AndToken)p1.Node, (ExpressionNode)p2.Node), 30));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 31
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
//  8: SubToken             -> 43
//  8: NotToken             -> 45
//  0: ExpressionNode       -> 32
//  0: IdentifierToken      -> 47
//  0: OpeningParToken      -> 48
//  0: StringToken          -> 51
//  0: NumberToken          -> 52
//  0: TrueToken            -> 53
//  0: FalseToken           -> 54
//  0: NullToken            -> 55
//
//
                case 31:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 31));
                        state = 43;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 31));
                        state = 45;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 31));
                        state = 32;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 31));
                        state = 47;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 31));
                        state = 48;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 31));
                        state = 51;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 31));
                        state = 52;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 31));
                        state = 53;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 31));
                        state = 54;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 31));
                        state = 55;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 32
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
//  9: DotToken             -> 7
//  7: MulToken             -> 9
//  7: DivToken             -> 11
//  6: AddToken             -> 13
//  6: SubToken             -> 15
//  5: EqToken              -> 17
//  5: NeqToken             -> 19
//  5: GtToken              -> 21
//  5: GteqToken            -> 23
//  5: LtToken              -> 25
//  5: LteqToken            -> 27
//  4: AndToken             -> 29
//  3: OrToken              -> 31
//  3: <- OrExpressionNode
//
//
                case 32:
                    if(input.Peek().Node is DotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 32));
                        state = 7;
                    }
                    else if(input.Peek().Node is MulToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 32));
                        state = 9;
                    }
                    else if(input.Peek().Node is DivToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 32));
                        state = 11;
                    }
                    else if(input.Peek().Node is AddToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 32));
                        state = 13;
                    }
                    else if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 32));
                        state = 15;
                    }
                    else if(input.Peek().Node is EqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 32));
                        state = 17;
                    }
                    else if(input.Peek().Node is NeqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 32));
                        state = 19;
                    }
                    else if(input.Peek().Node is GtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 32));
                        state = 21;
                    }
                    else if(input.Peek().Node is GteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 32));
                        state = 23;
                    }
                    else if(input.Peek().Node is LtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 32));
                        state = 25;
                    }
                    else if(input.Peek().Node is LteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 32));
                        state = 27;
                    }
                    else if(input.Peek().Node is AndToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 32));
                        state = 29;
                    }
                    else if(input.Peek().Node is OrToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 32));
                        state = 31;
                    }
                    else
                    {
                        var p2 = stack.Pop();
                        var p1 = stack.Pop();
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new OrExpressionNode((ExpressionNode)p0.Node, (OrToken)p1.Node, (ExpressionNode)p2.Node), 32));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 33
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
//  8: SubToken             -> 43
//  8: NotToken             -> 45
//  0: ExpressionNode       -> 34
//  0: IdentifierToken      -> 47
//  0: OpeningParToken      -> 48
//  0: StringToken          -> 51
//  0: NumberToken          -> 52
//  0: TrueToken            -> 53
//  0: FalseToken           -> 54
//  0: NullToken            -> 55
//
//
                case 33:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 33));
                        state = 43;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 33));
                        state = 45;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 33));
                        state = 34;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 33));
                        state = 47;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 33));
                        state = 48;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 33));
                        state = 51;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 33));
                        state = 52;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 33));
                        state = 53;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 33));
                        state = 54;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 33));
                        state = 55;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 34
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
//  9: DotToken             -> 7
//  7: MulToken             -> 9
//  7: DivToken             -> 11
//  6: AddToken             -> 13
//  6: SubToken             -> 15
//  5: EqToken              -> 17
//  5: NeqToken             -> 19
//  5: GtToken              -> 21
//  5: GteqToken            -> 23
//  5: LtToken              -> 25
//  5: LteqToken            -> 27
//  4: AndToken             -> 29
//  3: OrToken              -> 31
//  2: ColonToken           -> 35
//  2: QuestionMarkToken    -> 33
//  1: OpeningParToken      -> 37
//
//
                case 34:
                    if(input.Peek().Node is DotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 34));
                        state = 7;
                    }
                    else if(input.Peek().Node is MulToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 34));
                        state = 9;
                    }
                    else if(input.Peek().Node is DivToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 34));
                        state = 11;
                    }
                    else if(input.Peek().Node is AddToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 34));
                        state = 13;
                    }
                    else if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 34));
                        state = 15;
                    }
                    else if(input.Peek().Node is EqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 34));
                        state = 17;
                    }
                    else if(input.Peek().Node is NeqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 34));
                        state = 19;
                    }
                    else if(input.Peek().Node is GtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 34));
                        state = 21;
                    }
                    else if(input.Peek().Node is GteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 34));
                        state = 23;
                    }
                    else if(input.Peek().Node is LtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 34));
                        state = 25;
                    }
                    else if(input.Peek().Node is LteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 34));
                        state = 27;
                    }
                    else if(input.Peek().Node is AndToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 34));
                        state = 29;
                    }
                    else if(input.Peek().Node is OrToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 34));
                        state = 31;
                    }
                    else if(input.Peek().Node is ColonToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 34));
                        state = 35;
                    }
                    else if(input.Peek().Node is QuestionMarkToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 34));
                        state = 33;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 34));
                        state = 37;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 35
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
//  8: SubToken             -> 43
//  8: NotToken             -> 45
//  0: ExpressionNode       -> 36
//  0: IdentifierToken      -> 47
//  0: OpeningParToken      -> 48
//  0: StringToken          -> 51
//  0: NumberToken          -> 52
//  0: TrueToken            -> 53
//  0: FalseToken           -> 54
//  0: NullToken            -> 55
//
//
                case 35:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 35));
                        state = 43;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 35));
                        state = 45;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 35));
                        state = 36;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 35));
                        state = 47;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 35));
                        state = 48;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 35));
                        state = 51;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 35));
                        state = 52;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 35));
                        state = 53;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 35));
                        state = 54;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 35));
                        state = 55;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 36
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
//  9: DotToken             -> 7
//  7: MulToken             -> 9
//  7: DivToken             -> 11
//  6: AddToken             -> 13
//  6: SubToken             -> 15
//  5: EqToken              -> 17
//  5: NeqToken             -> 19
//  5: GtToken              -> 21
//  5: GteqToken            -> 23
//  5: LtToken              -> 25
//  5: LteqToken            -> 27
//  4: AndToken             -> 29
//  3: OrToken              -> 31
//  2: QuestionMarkToken    -> 33
//  2: <- TernaryExpressionNode
//
//
                case 36:
                    if(input.Peek().Node is DotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 36));
                        state = 7;
                    }
                    else if(input.Peek().Node is MulToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 36));
                        state = 9;
                    }
                    else if(input.Peek().Node is DivToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 36));
                        state = 11;
                    }
                    else if(input.Peek().Node is AddToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 36));
                        state = 13;
                    }
                    else if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 36));
                        state = 15;
                    }
                    else if(input.Peek().Node is EqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 36));
                        state = 17;
                    }
                    else if(input.Peek().Node is NeqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 36));
                        state = 19;
                    }
                    else if(input.Peek().Node is GtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 36));
                        state = 21;
                    }
                    else if(input.Peek().Node is GteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 36));
                        state = 23;
                    }
                    else if(input.Peek().Node is LtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 36));
                        state = 25;
                    }
                    else if(input.Peek().Node is LteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 36));
                        state = 27;
                    }
                    else if(input.Peek().Node is AndToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 36));
                        state = 29;
                    }
                    else if(input.Peek().Node is OrToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 36));
                        state = 31;
                    }
                    else if(input.Peek().Node is QuestionMarkToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 36));
                        state = 33;
                    }
                    else
                    {
                        var p4 = stack.Pop();
                        var p3 = stack.Pop();
                        var p2 = stack.Pop();
                        var p1 = stack.Pop();
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new TernaryExpressionNode((ExpressionNode)p0.Node, (QuestionMarkToken)p1.Node, (ExpressionNode)p2.Node, (ColonToken)p3.Node, (ExpressionNode)p4.Node), 36));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 37
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
//  8: SubToken             -> 43
//  8: NotToken             -> 45
//  1: ExpressionListNode   -> 38
//  0: ExpressionNode       -> 40
//  0: IdentifierToken      -> 47
//  0: OpeningParToken      -> 48
//  0: StringToken          -> 51
//  0: NumberToken          -> 52
//  0: TrueToken            -> 53
//  0: FalseToken           -> 54
//  0: NullToken            -> 55
// -2: <- EmptyExpressionListNode
//
//
                case 37:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 37));
                        state = 43;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 37));
                        state = 45;
                    }
                    else if(input.Peek().Node is ExpressionListNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 37));
                        state = 38;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 37));
                        state = 40;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 37));
                        state = 47;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 37));
                        state = 48;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 37));
                        state = 51;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 37));
                        state = 52;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 37));
                        state = 53;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 37));
                        state = 54;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 37));
                        state = 55;
                    }
                    else
                    {
                        input.Push(new StackItem(new EmptyExpressionListNode(), 37));
                    }
                    break;

// ###################################
// # State 38
//
// CallExpressionNode             : ExpressionNode OpeningParToken ExpressionListNode . ClosingParToken
//
//  1: ClosingParToken      -> 39
//
//
                case 38:
                    if(input.Peek().Node is ClosingParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 38));
                        state = 39;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 39
//
// CallExpressionNode             : ExpressionNode OpeningParToken ExpressionListNode ClosingParToken .
//
//  1: <- CallExpressionNode
//
//
                case 39:
                    {
                        var p3 = stack.Pop();
                        var p2 = stack.Pop();
                        var p1 = stack.Pop();
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new CallExpressionNode((ExpressionNode)p0.Node, (OpeningParToken)p1.Node, (ExpressionListNode)p2.Node, (ClosingParToken)p3.Node), 39));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 40
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
//  9: DotToken             -> 7
//  7: MulToken             -> 9
//  7: DivToken             -> 11
//  6: AddToken             -> 13
//  6: SubToken             -> 15
//  5: EqToken              -> 17
//  5: NeqToken             -> 19
//  5: GtToken              -> 21
//  5: GteqToken            -> 23
//  5: LtToken              -> 25
//  5: LteqToken            -> 27
//  4: AndToken             -> 29
//  3: OrToken              -> 31
//  2: QuestionMarkToken    -> 33
//  1: OpeningParToken      -> 37
//  0: CommaToken           -> 41
// -1: <- SingleExpressionListNode
//
//
                case 40:
                    if(input.Peek().Node is DotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 40));
                        state = 7;
                    }
                    else if(input.Peek().Node is MulToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 40));
                        state = 9;
                    }
                    else if(input.Peek().Node is DivToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 40));
                        state = 11;
                    }
                    else if(input.Peek().Node is AddToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 40));
                        state = 13;
                    }
                    else if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 40));
                        state = 15;
                    }
                    else if(input.Peek().Node is EqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 40));
                        state = 17;
                    }
                    else if(input.Peek().Node is NeqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 40));
                        state = 19;
                    }
                    else if(input.Peek().Node is GtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 40));
                        state = 21;
                    }
                    else if(input.Peek().Node is GteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 40));
                        state = 23;
                    }
                    else if(input.Peek().Node is LtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 40));
                        state = 25;
                    }
                    else if(input.Peek().Node is LteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 40));
                        state = 27;
                    }
                    else if(input.Peek().Node is AndToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 40));
                        state = 29;
                    }
                    else if(input.Peek().Node is OrToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 40));
                        state = 31;
                    }
                    else if(input.Peek().Node is QuestionMarkToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 40));
                        state = 33;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 40));
                        state = 37;
                    }
                    else if(input.Peek().Node is CommaToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 40));
                        state = 41;
                    }
                    else
                    {
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new SingleExpressionListNode((ExpressionNode)p0.Node), 40));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 41
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
//  8: SubToken             -> 43
//  8: NotToken             -> 45
//  0: RealExpressionListNode -> 42
//  0: ExpressionNode       -> 40
//  0: IdentifierToken      -> 47
//  0: OpeningParToken      -> 48
//  0: StringToken          -> 51
//  0: NumberToken          -> 52
//  0: TrueToken            -> 53
//  0: FalseToken           -> 54
//  0: NullToken            -> 55
//
//
                case 41:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 41));
                        state = 43;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 41));
                        state = 45;
                    }
                    else if(input.Peek().Node is RealExpressionListNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 41));
                        state = 42;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 41));
                        state = 40;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 41));
                        state = 47;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 41));
                        state = 48;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 41));
                        state = 51;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 41));
                        state = 52;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 41));
                        state = 53;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 41));
                        state = 54;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 41));
                        state = 55;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 42
//
// MultipleExpressionListNode     : ExpressionNode CommaToken RealExpressionListNode .
//
//  0: <- MultipleExpressionListNode
//
//
                case 42:
                    {
                        var p2 = stack.Pop();
                        var p1 = stack.Pop();
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new MultipleExpressionListNode((ExpressionNode)p0.Node, (CommaToken)p1.Node, (RealExpressionListNode)p2.Node), 42));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 43
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
//  8: SubToken             -> 43
//  8: NotToken             -> 45
//  0: ExpressionNode       -> 44
//  0: IdentifierToken      -> 47
//  0: OpeningParToken      -> 48
//  0: StringToken          -> 51
//  0: NumberToken          -> 52
//  0: TrueToken            -> 53
//  0: FalseToken           -> 54
//  0: NullToken            -> 55
//
//
                case 43:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 43));
                        state = 43;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 43));
                        state = 45;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 43));
                        state = 44;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 43));
                        state = 47;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 43));
                        state = 48;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 43));
                        state = 51;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 43));
                        state = 52;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 43));
                        state = 53;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 43));
                        state = 54;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 43));
                        state = 55;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 44
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
//  9: DotToken             -> 7
//  8: <- NegExpressionNode
//
//
                case 44:
                    if(input.Peek().Node is DotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 44));
                        state = 7;
                    }
                    else
                    {
                        var p1 = stack.Pop();
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new NegExpressionNode((SubToken)p0.Node, (ExpressionNode)p1.Node), 44));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 45
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
//  8: SubToken             -> 43
//  8: NotToken             -> 45
//  0: ExpressionNode       -> 46
//  0: IdentifierToken      -> 47
//  0: OpeningParToken      -> 48
//  0: StringToken          -> 51
//  0: NumberToken          -> 52
//  0: TrueToken            -> 53
//  0: FalseToken           -> 54
//  0: NullToken            -> 55
//
//
                case 45:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 45));
                        state = 43;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 45));
                        state = 45;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 45));
                        state = 46;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 45));
                        state = 47;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 45));
                        state = 48;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 45));
                        state = 51;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 45));
                        state = 52;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 45));
                        state = 53;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 45));
                        state = 54;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 45));
                        state = 55;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 46
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
//  9: DotToken             -> 7
//  8: <- NotExpressionNode
//
//
                case 46:
                    if(input.Peek().Node is DotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 46));
                        state = 7;
                    }
                    else
                    {
                        var p1 = stack.Pop();
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new NotExpressionNode((NotToken)p0.Node, (ExpressionNode)p1.Node), 46));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 47
//
// IdentifierExpressionNode       : IdentifierToken .
//
//  0: <- IdentifierExpressionNode
//
//
                case 47:
                    {
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new IdentifierExpressionNode((IdentifierToken)p0.Node), 47));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 48
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
//  8: SubToken             -> 43
//  8: NotToken             -> 45
//  0: ExpressionNode       -> 49
//  0: IdentifierToken      -> 47
//  0: OpeningParToken      -> 48
//  0: StringToken          -> 51
//  0: NumberToken          -> 52
//  0: TrueToken            -> 53
//  0: FalseToken           -> 54
//  0: NullToken            -> 55
//
//
                case 48:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 48));
                        state = 43;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 48));
                        state = 45;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 48));
                        state = 49;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 48));
                        state = 47;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 48));
                        state = 48;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 48));
                        state = 51;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 48));
                        state = 52;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 48));
                        state = 53;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 48));
                        state = 54;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 48));
                        state = 55;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 49
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
//  9: DotToken             -> 7
//  7: MulToken             -> 9
//  7: DivToken             -> 11
//  6: AddToken             -> 13
//  6: SubToken             -> 15
//  5: EqToken              -> 17
//  5: NeqToken             -> 19
//  5: GtToken              -> 21
//  5: GteqToken            -> 23
//  5: LtToken              -> 25
//  5: LteqToken            -> 27
//  4: AndToken             -> 29
//  3: OrToken              -> 31
//  2: QuestionMarkToken    -> 33
//  1: OpeningParToken      -> 37
//  0: ClosingParToken      -> 50
//
//
                case 49:
                    if(input.Peek().Node is DotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 49));
                        state = 7;
                    }
                    else if(input.Peek().Node is MulToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 49));
                        state = 9;
                    }
                    else if(input.Peek().Node is DivToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 49));
                        state = 11;
                    }
                    else if(input.Peek().Node is AddToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 49));
                        state = 13;
                    }
                    else if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 49));
                        state = 15;
                    }
                    else if(input.Peek().Node is EqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 49));
                        state = 17;
                    }
                    else if(input.Peek().Node is NeqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 49));
                        state = 19;
                    }
                    else if(input.Peek().Node is GtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 49));
                        state = 21;
                    }
                    else if(input.Peek().Node is GteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 49));
                        state = 23;
                    }
                    else if(input.Peek().Node is LtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 49));
                        state = 25;
                    }
                    else if(input.Peek().Node is LteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 49));
                        state = 27;
                    }
                    else if(input.Peek().Node is AndToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 49));
                        state = 29;
                    }
                    else if(input.Peek().Node is OrToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 49));
                        state = 31;
                    }
                    else if(input.Peek().Node is QuestionMarkToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 49));
                        state = 33;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 49));
                        state = 37;
                    }
                    else if(input.Peek().Node is ClosingParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 49));
                        state = 50;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 50
//
// ParExpressionNode              : OpeningParToken ExpressionNode ClosingParToken .
//
//  0: <- ParExpressionNode
//
//
                case 50:
                    {
                        var p2 = stack.Pop();
                        var p1 = stack.Pop();
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new ParExpressionNode((OpeningParToken)p0.Node, (ExpressionNode)p1.Node, (ClosingParToken)p2.Node), 50));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 51
//
// StringExpressionNode           : StringToken .
//
//  0: <- StringExpressionNode
//
//
                case 51:
                    {
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new StringExpressionNode((StringToken)p0.Node), 51));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 52
//
// NumberExpressionNode           : NumberToken .
//
//  0: <- NumberExpressionNode
//
//
                case 52:
                    {
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new NumberExpressionNode((NumberToken)p0.Node), 52));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 53
//
// TrueExpressionNode             : TrueToken .
//
//  0: <- TrueExpressionNode
//
//
                case 53:
                    {
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new TrueExpressionNode((TrueToken)p0.Node), 53));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 54
//
// FalseExpressionNode            : FalseToken .
//
//  0: <- FalseExpressionNode
//
//
                case 54:
                    {
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new FalseExpressionNode((FalseToken)p0.Node), 54));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 55
//
// NullExpressionNode             : NullToken .
//
//  0: <- NullExpressionNode
//
//
                case 55:
                    {
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new NullExpressionNode((NullToken)p0.Node), 55));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 56
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
//
//  9: DotToken             -> 7
//  7: MulToken             -> 9
//  7: DivToken             -> 11
//  6: AddToken             -> 13
//  6: SubToken             -> 15
//  5: EqToken              -> 17
//  5: NeqToken             -> 19
//  5: GtToken              -> 21
//  5: GteqToken            -> 23
//  5: LtToken              -> 25
//  5: LteqToken            -> 27
//  4: AndToken             -> 29
//  3: OrToken              -> 31
//  2: QuestionMarkToken    -> 33
//  1: OpeningParToken      -> 37
//  0: CommaToken           -> 57
// -1: <- SingleIdentifierListNode
//
//
                case 56:
                    if(input.Peek().Node is DotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 56));
                        state = 7;
                    }
                    else if(input.Peek().Node is MulToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 56));
                        state = 9;
                    }
                    else if(input.Peek().Node is DivToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 56));
                        state = 11;
                    }
                    else if(input.Peek().Node is AddToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 56));
                        state = 13;
                    }
                    else if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 56));
                        state = 15;
                    }
                    else if(input.Peek().Node is EqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 56));
                        state = 17;
                    }
                    else if(input.Peek().Node is NeqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 56));
                        state = 19;
                    }
                    else if(input.Peek().Node is GtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 56));
                        state = 21;
                    }
                    else if(input.Peek().Node is GteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 56));
                        state = 23;
                    }
                    else if(input.Peek().Node is LtToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 56));
                        state = 25;
                    }
                    else if(input.Peek().Node is LteqToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 56));
                        state = 27;
                    }
                    else if(input.Peek().Node is AndToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 56));
                        state = 29;
                    }
                    else if(input.Peek().Node is OrToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 56));
                        state = 31;
                    }
                    else if(input.Peek().Node is QuestionMarkToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 56));
                        state = 33;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 56));
                        state = 37;
                    }
                    else if(input.Peek().Node is CommaToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 56));
                        state = 57;
                    }
                    else
                    {
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new SingleIdentifierListNode((ExpressionNode)p0.Node), 56));
                        state = p0.State;
                    }
                    break;

// ###################################
// # State 57
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
//  8: SubToken             -> 43
//  8: NotToken             -> 45
//  0: RealIdentifierListNode -> 58
//  0: ExpressionNode       -> 56
//  0: IdentifierToken      -> 47
//  0: OpeningParToken      -> 48
//  0: StringToken          -> 51
//  0: NumberToken          -> 52
//  0: TrueToken            -> 53
//  0: FalseToken           -> 54
//  0: NullToken            -> 55
//
//
                case 57:
                    if(input.Peek().Node is SubToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 57));
                        state = 43;
                    }
                    else if(input.Peek().Node is NotToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 57));
                        state = 45;
                    }
                    else if(input.Peek().Node is RealIdentifierListNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 57));
                        state = 58;
                    }
                    else if(input.Peek().Node is ExpressionNode)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 57));
                        state = 56;
                    }
                    else if(input.Peek().Node is IdentifierToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 57));
                        state = 47;
                    }
                    else if(input.Peek().Node is OpeningParToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 57));
                        state = 48;
                    }
                    else if(input.Peek().Node is StringToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 57));
                        state = 51;
                    }
                    else if(input.Peek().Node is NumberToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 57));
                        state = 52;
                    }
                    else if(input.Peek().Node is TrueToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 57));
                        state = 53;
                    }
                    else if(input.Peek().Node is FalseToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 57));
                        state = 54;
                    }
                    else if(input.Peek().Node is NullToken)
                    {
                        stack.Push(new StackItem(input.Pop().Node, 57));
                        state = 55;
                    }
                    else
                    {
                        throw new ParseException(input.Peek().Node.Position, string.Format("Element {0} inattendu", input.Peek().Node));
                    }
                    break;

// ###################################
// # State 58
//
// MultipleIdentifierListNode     : ExpressionNode CommaToken RealIdentifierListNode .
//
//  0: <- MultipleIdentifierListNode
//
//
                case 58:
                    {
                        var p2 = stack.Pop();
                        var p1 = stack.Pop();
                        var p0 = stack.Pop();
                        input.Push(new StackItem(new MultipleIdentifierListNode((ExpressionNode)p0.Node, (CommaToken)p1.Node, (RealIdentifierListNode)p2.Node), 58));
                        state = p0.State;
                    }
                    break;

            }
        }
    }
}
}

