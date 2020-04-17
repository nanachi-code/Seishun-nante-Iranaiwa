using OpenTK;
using OpenTK.Graphics;
using StorybrewCommon.Mapset;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Storyboarding.Util;
using StorybrewCommon.Subtitles;
using StorybrewCommon.Util;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;

namespace StorybrewScripts
{
    public class SceneManager : StoryboardObjectGenerator
    {
        private delegate void AdditionalCommands(OsbSprite sprite);
        private Color4 whiteColor = new Color4(229, 225, 226, 255);
        private Color4 redColor = new Color4(236, 80, 83, 255);
        private Color4 blueMarineColor = new Color4(15, 155, 178, 255);
        private Color4 magentaColor = new Color4(198, 110, 118, 255);
        private Color4 blueColor = new Color4(50, 98, 144, 255);
        private Color4 violetColor = new Color4(150, 115, 179, 255);

        /*=============================================
        //*               Scene 1
        =============================================*/
        private void Scene1(FontGenerator font)
        {
            generateCinematicBars();

            /*=============================================
            //*               Line 1
            =============================================*/
            //* Background
            generateBackgroundColor(965, 1888, whiteColor);
            generateBackgroundColor(1888, 2811, redColor);
            generateBackgroundColor(2811, 3272, whiteColor);
            generateBackgroundColor(3272, 4195, blueMarineColor);

            //* Lyrics
            // 小さく
            AdditionalCommands line1word1 = (sprite) =>
            {
                sprite.Color(965, redColor);
                sprite.Color(1888, Color4.White);
                sprite.MoveX(1888, 320 + 107);
                sprite.MoveX(2811, 320 + 854 / 4);
                sprite.Color(2811, blueMarineColor);
                sprite.Color(3272, Color4.White);
                sprite.MoveX(3272, 320 + 107 + 854 / 4);
            };
            generateVeritcalText("小さく", font, 0.1f, 320, 965, 4195, line1word1);

            // 遠くで
            AdditionalCommands line1word2 = (sprite) =>
            {
                sprite.Color(1888, Color4.White);
                sprite.MoveX(2811, 320);
                sprite.Color(2811, blueMarineColor);
                sprite.Color(3272, Color4.White);
                sprite.MoveX(3272, 320 + 107);
            };
            generateVeritcalText("遠くで", font, 0.1f, 320 - 107, 1888, 4195, line1word2);

            // 何かが
            AdditionalCommands line1word3 = (sprite) =>
            {
                sprite.Color(2811, blueMarineColor);
                sprite.Color(3272, Color4.White);
                sprite.MoveX(3272, 320 - 107);
            };
            generateVeritcalText("何かが", font, 0.1f, 320 - 854 / 4, 2811, 4195, line1word3);

            // 鳴った
            generateVeritcalText("鳴った", font, 0.1f, 320 - 107 - 854 / 4, 3272, 4195);

            /*=============================================
            //*                Line 2
            =============================================*/
            //* Background
            generateBackgroundColor(4195, 4657, whiteColor);
            generateBackgroundColor(4657, 5118, magentaColor);
            generateBackgroundColor(5118, 6041, whiteColor);
            generateBackgroundColor(6041, 6965, violetColor);
            generateBackgroundColor(6965, 8349, whiteColor);

            //* Lyrics
            // 君の
            AdditionalCommands line2word1 = (sprite) =>
            {
                sprite.Color(4195, magentaColor);
                sprite.Color(4657, Color4.White);
                sprite.MoveX(4657, 320 + 107);
                sprite.MoveX(5118, 320 + 854 / 4);
                sprite.Color(5118, violetColor);
                sprite.Color(6041, Color4.White);
                sprite.MoveX(6041, 320 + 107 + 854 / 4);
                sprite.Color(6965, blueMarineColor);
            };
            generateVeritcalText("君の", font, 0.1f, 320, 4195, 7426, line2word1);

            // 横顔を
            AdditionalCommands line2word2 = (sprite) =>
            {
                sprite.Color(4657, Color4.White);
                sprite.MoveX(5118, 320);
                sprite.Color(5118, violetColor);
                sprite.Color(6041, Color4.White);
                sprite.MoveX(6041, 320 + 107);
                sprite.Color(6965, blueMarineColor);
            };
            generateVeritcalText("横顔を", font, 0.1f, 320 - 107, 4657, 7426, line2word2);

            // 追った
            AdditionalCommands line2word3 = (sprite) =>
            {
                sprite.Color(5118, violetColor);
                sprite.Color(6041, Color4.White);
                sprite.MoveX(6041, 320 - 107);
                sprite.Color(6965, blueMarineColor);
            };
            generateVeritcalText("追った", font, 0.1f, 320 - 854 / 4, 5118, 7426, line2word3);

            // 一瞬、
            AdditionalCommands line2word4 = (sprite) =>
            {
                sprite.Color(6041, Color4.White);
                sprite.Color(6965, blueMarineColor);
            };
            generateVeritcalText("一瞬、", font, 0.1f, 320 - 107 - 854 / 4, 6041, 7426, line2word4);

            // もう一瞬
            AdditionalCommands line2word5 = (sprite) =>
            {
                sprite.Color(7888, blueMarineColor);
            };
            generateHorizontalText("もう一瞬", font, 0.7f, 140, 7888, 8349, line2word5);
        }

        /*=============================================
        //*               Scene 2
        =============================================*/
        private void Scene2()
        {
            var girl = GetLayer("elements").CreateSprite("sb/elements/no-bg.png", OsbOrigin.Centre);
            girl.Scale(8349, 0.4);
            girl.Fade(8349, 1);
            girl.Fade(23118, 0);
            girl.Move(8349, 23118, new Vector2(127, 376), new Vector2(415, 108));
        }

        /*=============================================
        //*             Helper Methods
        =============================================*/
        private void generateCinematicBars()
        {
            var upperBar = GetLayer("cinematic-bar").CreateSprite("sb/common/pixel.png", OsbOrigin.TopCentre, new Vector2(320, 0));
            upperBar.ScaleVec(965, 8349, new Vector2(854, 60), new Vector2(854, 60));
            upperBar.Color(965, Color4.Black);

            var lowerBar = GetLayer("cinematic-bar").CreateSprite("sb/common/pixel.png", OsbOrigin.BottomCentre, new Vector2(320, 480));
            lowerBar.ScaleVec(965, 8349, new Vector2(854, 60), new Vector2(854, 60));
            lowerBar.Color(965, Color4.Black);

            var vig = GetLayer("vig").CreateSprite("sb/common/vig.png", OsbOrigin.Centre);
            vig.Fade(965, 0.9);
            vig.Fade(8349, 0);
            vig.Scale(965, 854.0 / 1920.0);
        }

        private void generateVeritcalText(string text, FontGenerator font, float fontScale, float initPositionX, double startTime, double endTime, AdditionalCommands callback = null)
        {
            var lineHeight = 0f;
            var letterX = initPositionX;
            foreach (var letter in text)
            {
                var texture = font.GetTexture(letter.ToString());
                lineHeight += texture.BaseHeight * fontScale;
            }

            var letterY = 240 - lineHeight * 0.5f;
            foreach (var letter in text)
            {
                var texture = font.GetTexture(letter.ToString());
                if (!texture.IsEmpty)
                {
                    var position = new Vector2(letterX, letterY) + texture.OffsetFor(OsbOrigin.Centre) * fontScale;
                    var sprite = GetLayer("lyrics").CreateSprite(texture.Path, OsbOrigin.Centre, position);
                    sprite.MoveX(startTime, position.X);
                    sprite.Scale(startTime, fontScale);
                    sprite.Fade(startTime, 1);
                    sprite.Fade(endTime, 0);
                    if (callback != null)
                    {
                        callback(sprite);
                    }
                }

                letterY += texture.BaseHeight * fontScale;
            }
        }

        private void generateHorizontalText(string text, FontGenerator font, float fontScale, float initPositionY, double startTime, double endTime, AdditionalCommands callback = null)
        {
            var lineWidth = 0f;
            var letterY = initPositionY;
            foreach (var letter in text)
            {
                var texture = font.GetTexture(letter.ToString());
                lineWidth += texture.BaseWidth * fontScale;
            }

            var letterX = 320 - lineWidth * 0.5f;
            foreach (var letter in text)
            {
                var texture = font.GetTexture(letter.ToString());
                if (!texture.IsEmpty)
                {
                    var position = new Vector2(letterX, letterY) + texture.OffsetFor(OsbOrigin.Centre) * fontScale;
                    var sprite = GetLayer("lyrics").CreateSprite(texture.Path, OsbOrigin.Centre, position);
                    sprite.MoveY(startTime, position.Y);
                    sprite.Scale(startTime, fontScale);
                    sprite.Fade(startTime, 1);
                    sprite.Fade(endTime, 0);
                    if (callback != null)
                    {
                        callback(sprite);
                    }
                }

                letterX += texture.BaseWidth * fontScale;
            }
        }

        private void generateBackgroundColor(double startTime, double endTime, Color4 color)
        {
            var sprite = GetLayer("bg").CreateSprite("sb/common/pixel.png", OsbOrigin.Centre);
            sprite.ScaleVec(startTime, new Vector2(854, 480));
            sprite.Color(startTime, color);
            sprite.Fade(startTime, 1);
            sprite.Fade(endTime, 0);
        }

        private void generateStripe(double startTime, double endTime, Color4 color)
        {

        }

        /*=============================================
        //*                 Main
        =============================================*/
        public override void Generate()
        {
            var fontSoukouMincho = LoadFont("sb/lyrics/SoukouMincho", new FontDescription()
            {
                FontPath = "SoukouMincho.ttf",
                FontSize = 200,
                Color = Color4.White,
                Padding = Vector2.Zero,
                FontStyle = FontStyle.Regular,
                TrimTransparency = true
            });

            Scene1(fontSoukouMincho);
            Scene2();
        }
    }
}
