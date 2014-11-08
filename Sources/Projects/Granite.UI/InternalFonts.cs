using Granite.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;

namespace Granite.UI
{
    public static partial class InternalFonts
    {
        private static readonly Lazy<Texture2D> s_texture;

        private static readonly Lazy<Font> s_regularSmallVariableWidthFont;
        private static readonly Lazy<Font> s_boldSmallVariableWidthFont;
        private static readonly Lazy<Font> s_italicSmallVariableWidthFont;
        private static readonly Lazy<Font> s_regularBigVariableWidthFont;

        private static readonly Lazy<Font> s_regularSmallFixedWidthFont;
        private static readonly Lazy<Font> s_boldSmallFixedWidthFont;
        private static readonly Lazy<Font> s_italicSmallFixedWidthFont;
        private static readonly Lazy<Font> s_regularBigFixedWidthFont;

        public static Font RegularSmallVariableWidthFont { get { return s_regularSmallVariableWidthFont.Value; } }
        public static Font BoldSmallVariableWidthFont { get { return s_boldSmallVariableWidthFont.Value; } }
        public static Font ItalicSmallVariableWidthFont { get { return s_italicSmallVariableWidthFont.Value; } }
        public static Font RegularBigVariableWidthFont { get { return s_regularBigVariableWidthFont.Value; } }

        public static Font RegularSmallFixedWidthFont { get { return s_regularSmallFixedWidthFont.Value; } }
        public static Font BoldSmallFixedWidthFont { get { return s_boldSmallFixedWidthFont.Value; } }
        public static Font ItalicSmallFixedWidthFont { get { return s_italicSmallFixedWidthFont.Value; } }
        public static Font RegularBigFixedWidthFont { get { return s_regularBigFixedWidthFont.Value; } }

        static InternalFonts()
        {
            s_texture = new Lazy<Texture2D>(() =>
            {
                var bytes = new byte[c_width * c_height];

                using (var mstream = new MemoryStream(s_bytes))
                {
                    using (var cstream = new GZipStream(mstream, CompressionMode.Decompress))
                    {
                        cstream.Read(bytes, 0, bytes.Length);
                    }
                }

                var texture = new Texture2D();
                texture.SetData(c_width, c_height, bytes);
                return texture;
            });

            s_regularSmallVariableWidthFont = new Lazy<Font>(() =>
            {
                var font = new Font(s_texture.Value, s_regularSmallVariableWidthFontGlyphs);
                
                return font;
            });

            s_boldSmallVariableWidthFont = new Lazy<Font>(() =>
            {
                var font = new Font(s_texture.Value, s_boldSmallVariableWidthFontGlyphs);

                return font;
            });

            s_italicSmallVariableWidthFont = new Lazy<Font>(() =>
            {
                var font = new Font(s_texture.Value, s_italicSmallVariableWidthFontGlyphs);

                return font;
            });

            s_regularBigVariableWidthFont = new Lazy<Font>(() =>
            {
                var font = new Font(s_texture.Value, s_regularBigVariableWidthFontGlyphs);

                return font;
            });

            s_regularSmallFixedWidthFont = new Lazy<Font>(() =>
            {
                var font = new Font(s_texture.Value, s_regularSmallFixedWidthFontGlyphs);

                return font;
            });

            s_boldSmallFixedWidthFont = new Lazy<Font>(() =>
            {
                var font = new Font(s_texture.Value, s_boldSmallFixedWidthFontGlyphs);

                return font;
            });

            s_italicSmallFixedWidthFont = new Lazy<Font>(() =>
            {
                var font = new Font(s_texture.Value, s_italicSmallFixedWidthFontGlyphs);

                return font;
            });

            s_regularBigFixedWidthFont = new Lazy<Font>(() =>
            {
                var font = new Font(s_texture.Value, s_regularBigFixedWidthFontGlyphs);

                return font;
            });

        }
    }
}
