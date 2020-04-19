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
        private Color4 blueColor = new Color4(1, 104, 195, 255);
        private Color4 violetColor = new Color4(150, 115, 179, 255);
        private Color4 yellowColor = new Color4(248, 200, 93, 255);

        /*=============================================
        //*               Scenes
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

        private void Scene2()
        {
            generateBackgroundColor(8349, 23118, whiteColor);
            generateVerticalStripeBackground(10195, 11580, 60, blueColor, -60, true);
            generateVerticalStripeBackground(12041, 13426, 45, magentaColor, 45, false);
            generateHorizontalStripeBackground(13888, 15272, 60, blueMarineColor, false);
            generateVerticalStripeBackground(15734, 17118, 45, yellowColor, 30, true);
            generateVerticalStripeBackground(17580, 18965, 45, redColor, 0, true);
            generateVerticalStripeBackground(19426, 20811, 60, blueColor, 60, false);
            generateHorizontalStripeBackground(21272, 23118, 60, blueMarineColor, true);
            generateVerticalStripeTransition(22657, 60, whiteColor, 45, true);

            // Girl
            var girl = GetLayer("elements").CreateSprite("sb/elements/no-bg.png", OsbOrigin.Centre);
            girl.Scale(8349, 0.5);
            girl.Fade(8349, 1);
            girl.Fade(23118, 0);
            girl.Move(8349, 23118, new Vector2(150, 480), new Vector2(415, 320));
        }

        private void Scene3(FontGenerator font)
        {
            generateBackgroundColor(23118, 24041, yellowColor);
            // Girl
            var girl = GetLayer("elements").CreateSprite("sb/elements/no-bg.png", OsbOrigin.Centre);
            girl.Scale(23118, 0.5);
            girl.Fade(23118, 1);
            girl.Fade(30503, 0);
            girl.Move(23118, 30503, new Vector2(854, 480), new Vector2(715, 240));
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

        private void generateVerticalStripeBackground(double startTime, double endTime, int thickness, Color4 color, int angle, bool rightToLeft = false)
        {
            Assert((angle < 90 && angle >= 0) || (angle > -90 && angle <= 0), "Parameter angle of generateVerticalStripeBackground() can only accept value from -90 to 90 degree.");

            var beat = Beatmap.GetTimingPointAt(965).BeatDuration;
            var actualLength = 854 + 480 * Math.Tan(MathHelper.DegreesToRadians(Math.Abs(angle)));
            var spriteLength = (float)(Math.Sqrt(Math.Pow(854, 2) + Math.Pow(480, 2)) + thickness * Math.Tan(MathHelper.DegreesToRadians(Math.Abs(angle))));

            if (angle < 90 && angle >= 0)
            {
                var openOrigin = rightToLeft ? OsbOrigin.TopRight : OsbOrigin.TopLeft;
                var closeOrigin = rightToLeft ? OsbOrigin.TopLeft : OsbOrigin.TopRight;
                var openX = rightToLeft
                            ? (float)(-107 + thickness / Math.Cos(MathHelper.DegreesToRadians(angle)))
                            : (float)(-107 + thickness * (1 / Math.Sin(MathHelper.DegreesToRadians(angle)) - Math.Cos(MathHelper.DegreesToRadians(angle))));
                var openY = rightToLeft
                            ? 0f
                            : (float)(0 - thickness * Math.Sin(MathHelper.DegreesToRadians(angle)));
                var closeX = rightToLeft
                            ? (float)(openX - thickness * Math.Cos(MathHelper.DegreesToRadians(angle)))
                            : (float)(-107 + thickness / Math.Cos(MathHelper.DegreesToRadians(angle)));
                var closeY = rightToLeft
                            ? (float)(0 - thickness * Math.Sin(MathHelper.DegreesToRadians(angle)))
                            : 0f;
                for (int i = 0; i <= (int)(actualLength / (thickness / Math.Cos(MathHelper.DegreesToRadians(angle)))); i++)
                {
                    var openSprite = GetLayer("open-stripe").CreateSprite("sb/common/pixel.png", openOrigin, new Vector2(openX, openY));
                    openSprite.Color(startTime, color);
                    openSprite.Rotate(startTime, MathHelper.DegreesToRadians(angle));
                    openSprite.ScaleVec(OsbEasing.OutCirc, startTime, startTime + beat, new Vector2(0, spriteLength), new Vector2(thickness, spriteLength));
                    openSprite.Fade(startTime, 1);
                    openSprite.Fade(endTime - beat, 0);

                    var closeSprite = GetLayer("close-stripe").CreateSprite("sb/common/pixel.png", closeOrigin, new Vector2(closeX, closeY));
                    closeSprite.Color(endTime - beat, color);
                    closeSprite.Rotate(endTime - beat, MathHelper.DegreesToRadians(angle));
                    closeSprite.ScaleVec(OsbEasing.InCirc, endTime - beat, endTime, new Vector2(thickness, spriteLength), new Vector2(0, spriteLength));
                    closeSprite.Fade(endTime - beat, 1);
                    closeSprite.Fade(endTime, 0);

                    openX += (float)(thickness / Math.Cos(MathHelper.DegreesToRadians(angle)));
                    closeX += (float)(thickness / Math.Cos(MathHelper.DegreesToRadians(angle)));
                }
            }
            else if (angle > -90 && angle <= 0)
            {
                var openOrigin = rightToLeft ? OsbOrigin.BottomRight : OsbOrigin.BottomLeft;
                var closeOrigin = rightToLeft ? OsbOrigin.BottomLeft : OsbOrigin.BottomRight;
                var openX = rightToLeft
                            ? (float)(-107 + thickness / Math.Cos(MathHelper.DegreesToRadians(angle)))
                            : (float)(-107 + thickness * (1 / Math.Sin(MathHelper.DegreesToRadians(Math.Abs(angle))) - Math.Cos(MathHelper.DegreesToRadians(angle))));
                var openY = rightToLeft
                            ? 480f
                            : (float)(480 + thickness * Math.Sin(MathHelper.DegreesToRadians(Math.Abs(angle))));
                var closeX = rightToLeft
                            ? (float)(openX - thickness * Math.Cos(MathHelper.DegreesToRadians(angle)))
                            : (float)(-107 + thickness / Math.Cos(MathHelper.DegreesToRadians(angle)));
                var closeY = rightToLeft
                            ? (float)(480 + thickness * Math.Sin(MathHelper.DegreesToRadians(Math.Abs(angle))))
                            : 480f;
                for (int i = 0; i <= (int)(actualLength / (thickness / Math.Cos(MathHelper.DegreesToRadians(angle)))); i++)
                {
                    var openSprite = GetLayer("open-stripe").CreateSprite("sb/common/pixel.png", openOrigin, new Vector2(openX, openY));
                    openSprite.Color(startTime, color);
                    openSprite.Rotate(startTime, MathHelper.DegreesToRadians(angle));
                    openSprite.ScaleVec(OsbEasing.OutCirc, startTime, startTime + beat, new Vector2(0, spriteLength), new Vector2(thickness, spriteLength));
                    openSprite.Fade(startTime, 1);
                    openSprite.Fade(endTime - beat, 0);

                    var closeSprite = GetLayer("close-stripe").CreateSprite("sb/common/pixel.png", closeOrigin, new Vector2(closeX, closeY));
                    closeSprite.Color(endTime - beat, color);
                    closeSprite.Rotate(endTime - beat, MathHelper.DegreesToRadians(angle));
                    closeSprite.ScaleVec(OsbEasing.InCirc, endTime - beat, endTime, new Vector2(thickness, spriteLength), new Vector2(0, spriteLength));
                    closeSprite.Fade(endTime - beat, 1);
                    closeSprite.Fade(endTime, 0);

                    openX += (float)(thickness / Math.Cos(MathHelper.DegreesToRadians(angle)));
                    closeX += (float)(thickness / Math.Cos(MathHelper.DegreesToRadians(angle)));
                }
            }
        }

        private void generateHorizontalStripeBackground(double startTime, double endTime, int thickness, Color4 color, bool bottomToTop = false)
        {
            var beat = Beatmap.GetTimingPointAt(965).BeatDuration;

            var openOrigin = bottomToTop ? OsbOrigin.BottomLeft : OsbOrigin.TopLeft;
            var closeOrigin = bottomToTop ? OsbOrigin.TopLeft : OsbOrigin.BottomLeft;
            var openX = -107f;
            var openY = bottomToTop
                        ? 0 + thickness
                        : 0;
            var closeX = openX;
            var closeY = bottomToTop
                        ? 0
                        : 0 + thickness;
            for (int i = 0; i <= (int)(480 / thickness); i++)
            {
                var openSprite = GetLayer("open-stripe").CreateSprite("sb/common/pixel.png", openOrigin, new Vector2(openX, openY));
                openSprite.Color(startTime, color);
                openSprite.ScaleVec(OsbEasing.OutCirc, startTime, startTime + beat, new Vector2(854, 0), new Vector2(854, thickness));
                openSprite.Fade(startTime, 1);
                openSprite.Fade(endTime - beat, 0);

                var closeSprite = GetLayer("close-stripe").CreateSprite("sb/common/pixel.png", closeOrigin, new Vector2(closeX, closeY));
                closeSprite.Color(endTime - beat, color);
                closeSprite.ScaleVec(OsbEasing.InCirc, endTime - beat, endTime, new Vector2(854, thickness), new Vector2(854, 0));
                closeSprite.Fade(endTime - beat, 1);
                closeSprite.Fade(endTime, 0);

                openY += thickness;
                closeY += thickness;
            }
        }

        private void generateVerticalStripeTransition(double startTime, int thickness, Color4 color, int angle, bool rightToLeft = false)
        {
            Assert((angle < 90 && angle >= 0) || (angle > -90 && angle <= 0), "Parameter angle of generateVerticalStripeTransition() can only accept value from -90 to 90 degree.");

            var beat = Beatmap.GetTimingPointAt(965).BeatDuration;
            var actualLength = 854 + 480 * Math.Tan(MathHelper.DegreesToRadians(Math.Abs(angle)));
            var spriteLength = (float)(Math.Sqrt(Math.Pow(854, 2) + Math.Pow(480, 2)) + thickness * Math.Tan(MathHelper.DegreesToRadians(Math.Abs(angle))));

            if (angle < 90 && angle >= 0)
            {
                var openOrigin = rightToLeft ? OsbOrigin.TopRight : OsbOrigin.TopLeft;
                var closeOrigin = rightToLeft ? OsbOrigin.TopLeft : OsbOrigin.TopRight;
                var openX = rightToLeft
                            ? (float)(-107 + thickness / Math.Cos(MathHelper.DegreesToRadians(angle)))
                            : (float)(-107 + thickness * (1 / Math.Sin(MathHelper.DegreesToRadians(angle)) - Math.Cos(MathHelper.DegreesToRadians(angle))));
                var openY = rightToLeft
                            ? 0f
                            : (float)(0 - thickness * Math.Sin(MathHelper.DegreesToRadians(angle)));
                var closeX = rightToLeft
                            ? (float)(openX - thickness * Math.Cos(MathHelper.DegreesToRadians(angle)))
                            : (float)(-107 + thickness / Math.Cos(MathHelper.DegreesToRadians(angle)));
                var closeY = rightToLeft
                            ? (float)(0 - thickness * Math.Sin(MathHelper.DegreesToRadians(angle)))
                            : 0f;
                for (int i = 0; i <= (int)(actualLength / (thickness / Math.Cos(MathHelper.DegreesToRadians(angle)))); i++)
                {
                    var openSprite = GetLayer("transition").CreateSprite("sb/common/pixel.png", openOrigin, new Vector2(openX, openY));
                    openSprite.Color(startTime, color);
                    openSprite.Rotate(startTime, MathHelper.DegreesToRadians(angle));
                    openSprite.ScaleVec(OsbEasing.OutExpo, startTime, startTime + beat, new Vector2(0, spriteLength), new Vector2(thickness, spriteLength));
                    openSprite.Fade(startTime, 1);
                    openSprite.Fade(startTime + beat, 0);

                    var closeSprite = GetLayer("transition").CreateSprite("sb/common/pixel.png", closeOrigin, new Vector2(closeX, closeY));
                    closeSprite.Color(startTime + beat, color);
                    closeSprite.Rotate(startTime + beat, MathHelper.DegreesToRadians(angle));
                    closeSprite.ScaleVec(OsbEasing.OutCirc, startTime + beat, startTime + beat * 2, new Vector2(thickness, spriteLength), new Vector2(0, spriteLength));
                    closeSprite.Fade(startTime + beat, 1);
                    closeSprite.Fade(startTime + beat * 2, 0);

                    openX += (float)(thickness / Math.Cos(MathHelper.DegreesToRadians(angle)));
                    closeX += (float)(thickness / Math.Cos(MathHelper.DegreesToRadians(angle)));
                }
            }
            else if (angle > -90 && angle <= 0)
            {
                var openOrigin = rightToLeft ? OsbOrigin.BottomRight : OsbOrigin.BottomLeft;
                var closeOrigin = rightToLeft ? OsbOrigin.BottomLeft : OsbOrigin.BottomRight;
                var openX = rightToLeft
                            ? (float)(-107 + thickness / Math.Cos(MathHelper.DegreesToRadians(angle)))
                            : (float)(-107 + thickness * (1 / Math.Sin(MathHelper.DegreesToRadians(Math.Abs(angle))) - Math.Cos(MathHelper.DegreesToRadians(angle))));
                var openY = rightToLeft
                            ? 480f
                            : (float)(480 + thickness * Math.Sin(MathHelper.DegreesToRadians(Math.Abs(angle))));
                var closeX = rightToLeft
                            ? (float)(openX - thickness * Math.Cos(MathHelper.DegreesToRadians(angle)))
                            : (float)(-107 + thickness / Math.Cos(MathHelper.DegreesToRadians(angle)));
                var closeY = rightToLeft
                            ? (float)(480 + thickness * Math.Sin(MathHelper.DegreesToRadians(Math.Abs(angle))))
                            : 480f;
                for (int i = 0; i <= (int)(actualLength / (thickness / Math.Cos(MathHelper.DegreesToRadians(angle)))); i++)
                {
                    var openSprite = GetLayer("open-stripe").CreateSprite("sb/common/pixel.png", openOrigin, new Vector2(openX, openY));
                    openSprite.Color(startTime, color);
                    openSprite.Rotate(startTime, MathHelper.DegreesToRadians(angle));
                    openSprite.ScaleVec(OsbEasing.OutExpo, startTime, startTime + beat, new Vector2(0, spriteLength), new Vector2(thickness, spriteLength));
                    openSprite.Fade(startTime, 1);
                    openSprite.Fade(startTime + beat, 0);

                    var closeSprite = GetLayer("close-stripe").CreateSprite("sb/common/pixel.png", closeOrigin, new Vector2(closeX, closeY));
                    closeSprite.Color(startTime + beat, color);
                    closeSprite.Rotate(startTime + beat, MathHelper.DegreesToRadians(angle));
                    closeSprite.ScaleVec(OsbEasing.OutCirc, startTime + beat, startTime + beat * 2, new Vector2(thickness, spriteLength), new Vector2(0, spriteLength));
                    closeSprite.Fade(startTime + beat, 1);
                    closeSprite.Fade(startTime + beat * 2, 0);

                    openX += (float)(thickness / Math.Cos(MathHelper.DegreesToRadians(angle)));
                    closeX += (float)(thickness / Math.Cos(MathHelper.DegreesToRadians(angle)));
                }
            }
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
            var fontHonokaMincho = LoadFont("sb/lyrics/HonokaMincho", new FontDescription()
            {
                FontPath = "HonokaMincho.ttf",
                FontSize = 72,
                Color = Color4.White,
                Padding = Vector2.Zero,
                FontStyle = FontStyle.Regular,
                TrimTransparency = true
            });

            Scene1(fontSoukouMincho);
            Scene2();
            Scene3(fontSoukouMincho);
        }
    }
}
