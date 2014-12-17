using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.UI.ExpressionParser
{
    public sealed class Tokenizer
    {
        private enum State
        {
            Default,
            InString,
            InStringEscape,
            InIdentifier,
            InNumber
        }

        private readonly string m_input;

        public Tokenizer(string input)
        {
            m_input = input;
        }

        public List<Token> Tokens
        {
            get
            {
                var tokens = new List<Token>();
                var builder = new StringBuilder();
                var state = State.Default;
                var start = 0;
                var position = 0;

                while (position <= m_input.Length)
                {
                    var c = position == m_input.Length ? (char)0 : m_input[position];

                    switch (state)
                    {
                        // ##############################################
                        // # Default
                        case State.Default:
                            switch (c)
                            {
                                case '\u0000': tokens.Add(new EndToken(position)); return tokens;
                                case '+': tokens.Add(new AddToken(position)); break;
                                case '-': tokens.Add(new SubToken(position)); break;
                                case '*': tokens.Add(new MulToken(position)); break;
                                case '/': tokens.Add(new DivToken(position)); break;
                                case '.': tokens.Add(new DotToken(position)); break;
                                case '(': tokens.Add(new OpeningParToken(position)); break;
                                case ')': tokens.Add(new ClosingParToken(position)); break;
                                case ',': tokens.Add(new CommaToken(position)); break;
                                case ':': tokens.Add(new ColonToken(position)); break;
                                case '?': tokens.Add(new QuestionMarkToken(position)); break;
                                //case ';': tokens.Add(new SemicolonToken(position)); break;
                                case '!':
                                    if ((position + 1) < m_input.Length && m_input[position + 1] == '=') // !=
                                    {
                                        position++;
                                        tokens.Add(new NeqToken(position));
                                    }
                                    else // !
                                    {
                                        tokens.Add(new NotToken(position));
                                    }
                                    break;
                                case '=':
                                    if ((position + 1) < m_input.Length && m_input[position + 1] == '>') // =>
                                    {
                                        position++;
                                        tokens.Add(new ArrowToken(position));
                                    }
                                    else if ((position + 1) < m_input.Length && m_input[position + 1] == '=') // ==
                                    {
                                        position++;
                                        tokens.Add(new EqToken(position));
                                    }
                                    else
                                    {
                                        throw new ParseException(position + 1, string.Format("Unexpected character \"{0}\"", c));
                                    }
                                    break;
                                case '>':
                                    if ((position + 1) < m_input.Length && m_input[position + 1] == '=') // >=
                                    {
                                        position++;
                                        tokens.Add(new GteqToken(position));
                                    }
                                    else // >
                                    {
                                        tokens.Add(new GtToken(position));
                                    }
                                    break;
                                case '<':
                                    if ((position + 1) < m_input.Length && m_input[position + 1] == '=') // <=
                                    {
                                        position++;
                                        tokens.Add(new LteqToken(position));
                                    }
                                    else // <
                                    {
                                        tokens.Add(new LtToken(position));
                                    }
                                    break;
                                case '"':
                                    state = State.InString;
                                    start = position;
                                    break;
                                default:
                                    if (char.IsLetter(c) || c == '_')
                                    {
                                        builder.Append(c);
                                        state = State.InIdentifier;
                                        start = position;
                                    }
                                    else if (char.IsDigit(c))
                                    {
                                        builder.Append(c);
                                        state = State.InNumber;
                                        start = position;
                                    }
                                    else
                                    {
                                        if (!char.IsWhiteSpace(c))
                                        {
                                            throw new ParseException(position, string.Format("Unexpected character \"{0}\"", c));
                                        }
                                    }
                                    break;
                            }
                            break;

                        // ##############################################
                        // # InString
                        case State.InString:
                            if (c == '"')
                            {
                                tokens.Add(new StringToken(start, builder.ToString()));
                                state = State.Default;
                                builder.Length = 0;
                            }
                            else if (c == '\\')
                            {
                                state = State.InStringEscape;
                            }
                            else if (c == '\u0000' || c == '\r' || c == '\n')
                            {
                                throw new ParseException(start, "Unexpected end of string");
                            }
                            else
                            {
                                builder.Append(c);
                            }
                            break;

                        // ##############################################
                        // # InStringEscape
                        case State.InStringEscape:
                            switch (c)
                            {
                                case '"':
                                case '\\':
                                    builder.Append(c);
                                    state = State.InString;
                                    break;

                                case 'r':
                                    builder.Append('\r');
                                    state = State.InString;
                                    break;

                                case 'n':
                                    builder.Append('\n');
                                    state = State.InString;
                                    break;

                                case 't':
                                    builder.Append('\t');
                                    state = State.InString;
                                    break;

                                default:
                                    throw new ParseException(position - 1, "Unknown escape sequence");
                                    break;

                            }
                            break;

                        // ##############################################
                        // # InIdentifier
                        case State.InIdentifier:
                            if (char.IsLetterOrDigit(c) || c == '_')
                            {
                                builder.Append(c);
                            }
                            else
                            {
                                tokens.Add(new IdentifierToken(start, builder.ToString()));
                                position--;
                                state = State.Default;
                                builder.Length = 0;
                            }
                            break;

                        // ##############################################
                        // # InNumber
                        case State.InNumber:
                            if (char.IsDigit(c) || c == '.')
                            {
                                builder.Append(c);
                            }
                            else
                            {
                                tokens.Add(new NumberToken(start, builder.ToString()));
                                position--;
                                state = State.Default;
                                builder.Length = 0;
                            }
                            break;
                    }

                    position++;
                }

                return null;
            }
        }
    }

}
