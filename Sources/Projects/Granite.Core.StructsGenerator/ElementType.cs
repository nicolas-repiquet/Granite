using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.Code.StructsGenerator
{
    class ElementType
    {
        public static ElementType ByteType = new ElementType("sbyte", 1, true, false, "0", "1", "2");
        public static ElementType UByteType = new ElementType("byte", 1, false, false, "0", "1", "2");
        public static ElementType ShortType = new ElementType("short", 2, true, false, "0", "1", "2");
        public static ElementType UShortType = new ElementType("ushort", 2, false, false, "0", "1", "2");
        public static ElementType IntType = new ElementType("int", 4, true, false, "0", "1", "2");
        public static ElementType UIntType = new ElementType("uint", 4, false, false, "0u", "1u", "2u");
        public static ElementType FloatType = new ElementType("float", 4, true, true, "0f", "1f", "2f");
        public static ElementType DoubleType = new ElementType("double", 8, true, true, "0d", "1d", "2d");

        public static IEnumerable<ElementType> Types
        {
            get
            {
                yield return ByteType;
                yield return UByteType;
                yield return ShortType;
                yield return UShortType;
                yield return IntType;
                yield return UIntType;
                yield return FloatType;
                yield return DoubleType;
            }
        }

        // *****************************************

        public string Name { get; private set; }
        public int Size { get; private set; }
        public bool Signed { get; private set; }
        public bool Real { get; private set; }
        public string Zero { get; private set; }
        public string One { get; private set; }
        public string Two { get; private set; }

        private ElementType(string name, int size, bool signed, bool real, string zero, string one, string two)
        {
            Name = name;
            Size = size;
            Signed = signed;
            Real = real;
            Zero = zero;
            One = one;
            Two = two;
        }

        public ElementType ArithmeticType
        {
            get
            {
                if (this == UIntType)
                {
                    return UIntType;
                }
                else if (this == FloatType)
                {
                    return FloatType;
                }
                else if (this == DoubleType)
                {
                    return DoubleType;
                }
                else
                {
                    return IntType;
                }
            }
        }

        public ElementType PrecisionType
        {
            get
            {
                if (this == DoubleType)
                {
                    return DoubleType;
                }
                else
                {
                    return FloatType;
                }
            }
        }

        public bool CanConvertImplicitlyTo(ElementType type)
        {
            if (type == this)
            {
                return true;
            }
            else
            {
                if (Real)
                {
                    if (!type.Real)
                    {
                        return false;
                    }
                    else
                    {
                        return type.Size > Size;
                    }
                }
                else
                {
                    if (type.Real)
                    {
                        return true;
                    }
                    else
                    {
                        if (Signed && !type.Signed)
                        {
                            return false;
                        }
                        else
                        {
                            return type.Size > Size;
                        }
                    }
                }
            }
        }
    }
}
