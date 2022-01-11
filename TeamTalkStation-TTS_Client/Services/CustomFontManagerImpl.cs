using Avalonia.Media;
using Avalonia.Platform;
using Avalonia.Skia;
using SkiaSharp;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace TeamTalkStation_TTS_Client.Services
{
    public class CustomFontManagerImpl : IFontManagerImpl
    {
        private readonly Typeface[] _customTypefaces;
        private readonly string _defaultFamilyName;

      
        public CustomFontManagerImpl()
        {
            
            _defaultFamilyName = SKTypeface.Default.FamilyName;
        }

        public string GetDefaultFontFamilyName()
        {
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


            System.Reflection.Assembly thisAssembly = GetType().Assembly;
            System.Reflection.Assembly thisAssembly2 = GetType().Assembly;

            //System.Console.WriteLine(thisAssembly.FullName);

            Stream trueTypeFontFileStream0 = thisAssembly.GetManifestResourceStream("TeamTalkStation-TTS_Client.Assets.Fonts.NotoSansCJKsc-VF.ttf");
            //Stream trueTypeFontFileStream1 = thisAssembly2.GetManifestResourceStream("TeamTalkStation-TTS_Client.Assets.Fonts.TwitterColorEmoji-SVGinOT.ttf");
            //Stream trueTypeFontFileStream0 = thisAssembly.GetManifestResourceStream("TeamTalkStation-TTS_Client.Assets.Fonts.wqy-micro-hei.ttf");
            

            

            //SKStreamAsset streamAsset = SKTypeface.FromStream(trueTypeFontFileStream0);

            System.Console.WriteLine("Test Complete");


            //skTypeface.OpenStream(trueTypeFontFileStream1);
            //skTypeface.OpenStream(trueTypeFontFileStream2);
            //skTypeface.OpenStream(trueTypeFontFileStream3);
            //skTypeface.OpenStream(trueTypeFontFileStream7);
            //skTypeface.OpenStream(trueTypeFontFileStream5);
            //skTypeface.OpenStream(trueTypeFontFileStream6);


            //switch (typeface.FontFamily.Name)
            //{
            //    //case "Twitter Color Emoji":
            //    //    skTypeface = SKTypeface.FromStream(trueTypeFontFileStream1);
            //    //    return new GlyphTypefaceImpl(skTypeface);
            //    //    break;

            //    //default:
            //    //    skTypeface = SKTypeface.FromStream(trueTypeFontFileStream0);
            //    //    return new GlyphTypefaceImpl(skTypeface);
            //    //    break;


            //    case FontFamily.DefaultFontFamilyName:
            //    case "Noto Sans CJK SC":  //font family name
            //        skTypeface = SKTypeface.FromStream(trueTypeFontFileStream0); break;
            //    //case "Twitter Color Emoji":  //font family name
            //    //    skTypeface = SKTypeface.FromStream(trueTypeFontFileStream1); break;
            //    default:
            //        skTypeface = SKTypeface.FromStream(trueTypeFontFileStream0);
            //        break;
            //}

            skTypeface = SKTypeface.FromStream(trueTypeFontFileStream0);

            return new GlyphTypefaceImpl(skTypeface);
        }
    }

}
