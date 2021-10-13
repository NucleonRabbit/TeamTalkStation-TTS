using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Avalonia.Media;
using Avalonia.Platform;
using Avalonia.Skia;
using SkiaSharp;

namespace TeamTalkStation_TTS_Client
{
    public class CustomFontManagerImpl : IFontManagerImpl
    {
        private readonly Typeface[] _customTypefaces;
        private readonly string _defaultFamilyName;

        //Load font resources in the project, you can load multiple font resources
        private readonly Typeface _defaultTypeface =
            new Typeface("resm:TeamTalkStation_TTS_Client.Assets.PingFang.ttf#PF");

        public CustomFontManagerImpl()
        {
            _customTypefaces = new[] { _defaultTypeface };
            _defaultFamilyName = _defaultTypeface.FontFamily.FamilyNames.PrimaryFamilyName;
            Console.WriteLine(_defaultTypeface.FontFamily.FamilyNames.PrimaryFamilyName);
        }

        public string GetDefaultFontFamilyName()
        {
            Console.WriteLine(_defaultFamilyName);
            return _defaultFamilyName;
        }

        public IEnumerable<string> GetInstalledFontFamilyNames(bool checkForUpdates = false)
        {
            return _customTypefaces.Select(x => x.FontFamily.Name);
        }

        private readonly string[] _bcp47 = { CultureInfo.CurrentCulture.ThreeLetterISOLanguageName, CultureInfo.CurrentCulture.TwoLetterISOLanguageName };

        public bool TryMatchCharacter(int codepoint, FontStyle fontStyle, FontWeight fontWeight, FontFamily fontFamily,
            CultureInfo culture, out Typeface typeface)
        {
            foreach (var customTypeface in _customTypefaces)
            {
                if (customTypeface.GlyphTypeface.GetGlyph((uint)codepoint) == 0)
                {
                    continue;
                }

                typeface = new Typeface(customTypeface.FontFamily.Name, fontStyle, fontWeight);

                return true;
            }

            var fallback = SKFontManager.Default.MatchCharacter(fontFamily?.Name, (SKFontStyleWeight)fontWeight,
                SKFontStyleWidth.Normal, (SKFontStyleSlant)fontStyle, _bcp47, codepoint);

            typeface = new Typeface(fallback?.FamilyName ?? _defaultFamilyName, fontStyle, fontWeight);

            return true;
        }

        public IGlyphTypefaceImpl CreateGlyphTypeface(Typeface typeface)
        {
            SKTypeface skTypeface;

            switch (typeface.FontFamily.Name)
            {
                case FontFamily.DefaultFontFamilyName:
                case "PF":  //font family name
                    skTypeface = SKTypeface.FromFamilyName(_defaultTypeface.FontFamily.Name);
                    Console.WriteLine(_defaultTypeface.FontFamily.Name);
                    break;
                default:
                    skTypeface = SKTypeface.FromFamilyName("PingFang SC",
                        (SKFontStyleWeight)typeface.Weight, SKFontStyleWidth.Normal, (SKFontStyleSlant)typeface.Style);
                        Console.WriteLine(typeface.FontFamily.Name);
                        Console.WriteLine(typeface.Weight);
                        Console.WriteLine(typeface.Style);
                    break;
            }


            SKTypeface SKT = SKTypeface.FromFamilyName("DejaVu Sans");

            return new GlyphTypefaceImpl(SKT);
        }
    }
}