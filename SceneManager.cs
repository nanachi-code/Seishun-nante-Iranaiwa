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
            generateVeritcalText("小さく", font, 0.1f, 320, 240, "lyrics", 965, 4195, line1word1);

            // 遠くで
            AdditionalCommands line1word2 = (sprite) =>
            {
                sprite.Color(1888, Color4.White);
                sprite.MoveX(2811, 320);
                sprite.Color(2811, blueMarineColor);
                sprite.Color(3272, Color4.White);
                sprite.MoveX(3272, 320 + 107);
            };
            generateVeritcalText("遠くで", font, 0.1f, 320 - 107, 240, "lyrics", 1888, 4195, line1word2);

            // 何かが
            AdditionalCommands line1word3 = (sprite) =>
            {
                sprite.Color(2811, blueMarineColor);
                sprite.Color(3272, Color4.White);
                sprite.MoveX(3272, 320 - 107);
            };
            generateVeritcalText("何かが", font, 0.1f, 320 - 854 / 4, 240, "lyrics", 2811, 4195, line1word3);

            // 鳴った
            generateVeritcalText("鳴った", font, 0.1f, 320 - 107 - 854 / 4, 240, "lyrics", 3272, 4195);

            /*=============================================
            //*                Line 2
            =============================================*/
            //* Background
            generateBackgroundColor(4195, 4657, whiteColor);
            generateBackgroundColor(4657, 5118, magentaColor);
            generateBackgroundColor(5118, 6272, whiteColor);
            generateBackgroundColor(6272, 6965, violetColor);
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
                sprite.Color(6272, Color4.White);
                sprite.MoveX(6272, 320 + 107 + 854 / 4);
                sprite.Color(6965, blueMarineColor);
            };
            generateVeritcalText("君の", font, 0.1f, 320, 240, "lyrics", 4195, 7426, line2word1);

            // 横顔を
            AdditionalCommands line2word2 = (sprite) =>
            {
                sprite.Color(4657, Color4.White);
                sprite.MoveX(5118, 320);
                sprite.Color(5118, violetColor);
                sprite.Color(6272, Color4.White);
                sprite.MoveX(6272, 320 + 107);
                sprite.Color(6965, blueMarineColor);
            };
            generateVeritcalText("横顔を", font, 0.1f, 320 - 107, 240, "lyrics", 4657, 7426, line2word2);

            // 追った
            AdditionalCommands line2word3 = (sprite) =>
            {
                sprite.Color(5118, violetColor);
                sprite.Color(6272, Color4.White);
                sprite.MoveX(6272, 320 - 107);
                sprite.Color(6965, blueMarineColor);
            };
            generateVeritcalText("追った", font, 0.1f, 320 - 854 / 4, 240, "lyrics", 5118, 7426, line2word3);

            // 一瞬、
            AdditionalCommands line2word4 = (sprite) =>
            {
                sprite.Color(6272, Color4.White);
                sprite.Color(6965, blueMarineColor);
            };
            generateVeritcalText("一瞬、", font, 0.1f, 320 - 107 - 854 / 4, 240, "lyrics", 6272, 7426, line2word4);

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
            generateHorizontalStripeBackground(21272, 23118, 60, blueMarineColor, true, false);
            generateVerticalStripeTransition(22657, 60, whiteColor, 45, true);

            // Girl
            var girl = GetLayer("elements").CreateSprite("sb/elements/s-girl.png", OsbOrigin.Centre);
            girl.Scale(8349, 0.5);
            girl.Fade(8349, 1);
            girl.Fade(23118, 0);
            girl.Move(8349, 23118, new Vector2(150, 480), new Vector2(415, 320));
        }

        private void Scene3(FontGenerator font)
        {
            /*=============================================
            //*               1st half
            =============================================*/
            generateBackgroundColor(23118, 24503, yellowColor);
            generateVerticalStripeBackground(24041, 25426, 60, blueColor, -60, true, false);
            generateVerticalStripeBackground(24965, 27272, 45, magentaColor, 45, false, false);
            generateHorizontalStripeBackground(26811, 28195, 60, blueMarineColor, false, false);
            generateVerticalStripeBackground(27734, 29118, 45, yellowColor, 30, true, false);
            generateVerticalStripeBackground(28657, 29580, 60, redColor, 0, true, false);
            generateBackgroundColor(29580, 30041, blueMarineColor);
            generateBackgroundColor(30041, 30272, magentaColor);
            generateBackgroundColor(30272, 30964, yellowColor);

            //* Lyrics
            generateScrollUpTiltedRightAlignedText(23118, 29580, "もうちょっとだけ\n大人でいたくて\n夏際くるぶしに\n少し掠るくらいで\n歩いている", 0.2f, new Vector2(270, 170), 228, -30, font, whiteColor);

            //* Sleeping girl
            var girl = GetLayer("elements").CreateSprite("sb/elements/s-girl.png", OsbOrigin.Centre);
            girl.Scale(23118, 0.5);
            girl.Fade(23118, 1);
            girl.Fade(30272, 0);
            girl.Move(23118, 30964, new Vector2(754, 480), new Vector2(615, 240));

            //* Ice cream
            var icecreamW = GetLayer("elements-w").CreateSprite("sb/elements/ice-cream-w.png", OsbOrigin.Centre);
            icecreamW.Scale(23118, 0.5);
            icecreamW.Fade(23118, 0);
            icecreamW.Fade(29811, 1);
            icecreamW.Fade(30964, 0);
            icecreamW.Color(29811, yellowColor);
            icecreamW.Color(30041, blueMarineColor);
            icecreamW.Color(30272, magentaColor);
            icecreamW.Move(23118, 30964, new Vector2(754, 480), new Vector2(615, 240));

            //* Girl white 2
            var girlW2 = GetLayer("elements-w").CreateSprite("sb/elements/s-girl-w-2.png", OsbOrigin.Centre);
            girlW2.Scale(23118, 0.5);
            girlW2.Fade(23118, 0);
            girlW2.Fade(30041, 1);
            girlW2.Fade(30964, 0);
            girlW2.Color(30041, yellowColor);
            girlW2.Color(30272, redColor);
            girlW2.Move(23118, 30964, new Vector2(754, 480), new Vector2(615, 240));

            //* Bubble
            var bubbleW = GetLayer("elements-w").CreateSprite("sb/elements/bubble-w.png", OsbOrigin.Centre);
            bubbleW.Scale(23118, 0.5);
            bubbleW.Color(30272, blueColor);
            bubbleW.Fade(23118, 0);
            bubbleW.Fade(30272, 1);
            bubbleW.Fade(30964, 0);
            bubbleW.Move(23118, 30964, new Vector2(754, 480), new Vector2(615, 240));

            /*=============================================
            //*              2nd half
            =============================================*/
            var mask = GetLayer("dropdown-element").CreateSprite("sb/elements/mask.png", OsbOrigin.BottomCentre);
            mask.Scale(30503, 0.2);
            generateDropdownTextAndElement(30503, 31426, "小さく", font, blueColor, mask);

            var fan = GetLayer("dropdown-element").CreateSprite("sb/elements/fan.png", OsbOrigin.BottomCentre);
            fan.Scale(31426, 0.2);
            generateDropdownTextAndElement(31426, 32349, "遠くで", font, yellowColor, fan);

            var bubble = GetLayer("dropdown-element").CreateSprite("sb/elements/bubble.png", OsbOrigin.BottomCentre);
            bubble.Scale(32349, 0.3);
            generateDropdownTextAndElement(32349, 33272, "何かが\n鳴った", font, redColor, bubble);

            var bg = GetLayer("dropdown-bg").CreateSprite("sb/common/pixel.png", OsbOrigin.TopLeft, new Vector2(-107, 0));
            bg.ScaleVec(OsbEasing.OutCirc, 33272, 33734, new Vector2(854, 0), new Vector2(854, 480));
            bg.Color(33272, blueMarineColor);
            bg.Fade(33272, 1);
            bg.Fade(37426, 0);

            //* Circles + elements
            var bigCircle = GetLayer("circle").CreateSprite("sb/common/circle.png", OsbOrigin.Centre);
            bigCircle.Scale(OsbEasing.OutCirc, 33272, 33734, 0.2, 1.05);
            bigCircle.Color(33272, yellowColor);
            bigCircle.Fade(33272, 1);
            bigCircle.Fade(37426, 0);

            var innerCircle = GetLayer("circle").CreateSprite("sb/common/circle.png", OsbOrigin.Centre);
            innerCircle.Scale(OsbEasing.OutCirc, 33272, 33734, 0, 0.95);
            innerCircle.Color(33272, whiteColor);
            innerCircle.Fade(33272, 1);
            innerCircle.Fade(37426, 0);

            var girlShadow = GetLayer("girl-on-circle").CreateSprite("sb/elements/s-girl-w.png", OsbOrigin.Centre, new Vector2(315, 243));
            girlShadow.Color(33734, yellowColor);
            girlShadow.Scale(OsbEasing.OutCirc, 33734, 34195, 0.0, 0.2);
            girlShadow.Scale(34195, 37426, 0.2, 0.17);
            girlShadow.Rotate(33734, 37426, 0, MathHelper.DegreesToRadians(-15));
            girlShadow.Fade(33734, 1);

            girl = GetLayer("girl-on-circle").CreateSprite("sb/elements/s-girl.png", OsbOrigin.Centre);
            girl.Scale(OsbEasing.OutCirc, 33734, 34195, 0.0, 0.2);
            girl.Scale(34195, 37426, 0.2, 0.17);
            girl.Rotate(33734, 37426, 0, MathHelper.DegreesToRadians(-15));
            girl.Fade(33734, 1);
            girl.Fade(37426, 0);

            //* Particle pool
            using (var pool = new OsbSpritePool(GetLayer("particles-on-circle"), "sb/common/circle.png", OsbOrigin.Centre, (sprite, startTime, endTime) =>
            {
                var rScale = Random(0.002, 0.006);
                var rColor = Random(0, 2);

                sprite.Scale(33272, rScale);
                sprite.Color(33272, rColor == 0 ? blueMarineColor : yellowColor);
            }))
            {
                var particleAmount = 500;
                for (int i = 0; i < particleAmount; i++)
                {
                    var sprite = pool.Get(33734, 37426);
                    var startX = Random(-107, 747);
                    var startY = Random(0, 480);

                    sprite.Move(33272, 37426, new Vector2(startX, startY), new Vector2(startX + Random(-50, 50), startY + Random(-50, 50)));
                    sprite.Fade(33272, 33734, 0, 1);
                    sprite.Fade(37426, 0);
                }
            }

            //* Lyrics
            generateRotatingSplitText(33734, 37426, 36964, "いつも横顔を", "追っていたんだ", 0.2f, 20, 100, 50, font);

            // Transition
            generateCentreRectangleTransition(36964, 37657, blueColor);
            generateCentreRectangleTransition(37426, 37888, blueMarineColor);
        }

        private void Scene4(FontGenerator font)
        {
            generateBackgroundColor(37657, 52657, whiteColor);
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

        private void generateVeritcalText(string text, FontGenerator font, float fontScale, float initPositionX, float initPositionY, string layer, double startTime, double endTime, AdditionalCommands callback = null)
        {
            var lineHeight = 0f;
            var letterX = initPositionX;
            foreach (var letter in text)
            {
                var texture = font.GetTexture(letter.ToString());
                lineHeight += texture.BaseHeight * fontScale;
            }

            var letterY = initPositionY - lineHeight * 0.5f;
            foreach (var letter in text)
            {
                var texture = font.GetTexture(letter.ToString());
                if (!texture.IsEmpty)
                {
                    var position = new Vector2(letterX, letterY);
                    var sprite = GetLayer(layer).CreateSprite(texture.Path, OsbOrigin.Centre, position);
                    sprite.MoveX(startTime, position.X);
                    sprite.Scale(startTime, fontScale);
                    sprite.Fade(startTime, 1);
                    sprite.Fade(endTime, 0);
                    if (callback != null)
                    {
                        callback(sprite);
                    }

                    letterY += texture.BaseHeight * fontScale;
                }
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

                    letterX += texture.BaseWidth * fontScale;
                }
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

        private void generateVerticalStripeBackground(double startTime, double endTime, int thickness, Color4 color, int angle, bool rightToLeft = false, bool withClosing = true)
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

                    if (withClosing)
                    {
                        openSprite.Fade(endTime - beat, 0);

                        var closeSprite = GetLayer("close-stripe").CreateSprite("sb/common/pixel.png", closeOrigin, new Vector2(closeX, closeY));
                        closeSprite.Color(endTime - beat, color);
                        closeSprite.Rotate(endTime - beat, MathHelper.DegreesToRadians(angle));
                        closeSprite.ScaleVec(OsbEasing.InCirc, endTime - beat, endTime, new Vector2(thickness, spriteLength), new Vector2(0, spriteLength));
                        closeSprite.Fade(endTime - beat, 1);
                        closeSprite.Fade(endTime, 0);

                    }
                    else
                    {
                        openSprite.Fade(endTime, 0);
                    }

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

                    if (withClosing)
                    {
                        openSprite.Fade(endTime - beat, 0);

                        var closeSprite = GetLayer("close-stripe").CreateSprite("sb/common/pixel.png", closeOrigin, new Vector2(closeX, closeY));
                        closeSprite.Color(endTime - beat, color);
                        closeSprite.Rotate(endTime - beat, MathHelper.DegreesToRadians(angle));
                        closeSprite.ScaleVec(OsbEasing.InCirc, endTime - beat, endTime, new Vector2(thickness, spriteLength), new Vector2(0, spriteLength));
                        closeSprite.Fade(endTime - beat, 1);
                        closeSprite.Fade(endTime, 0);
                    }
                    else
                    {
                        openSprite.Fade(endTime, 0);
                    }


                    openX += (float)(thickness / Math.Cos(MathHelper.DegreesToRadians(angle)));
                    closeX += (float)(thickness / Math.Cos(MathHelper.DegreesToRadians(angle)));
                }
            }
        }

        private void generateHorizontalStripeBackground(double startTime, double endTime, int thickness, Color4 color, bool bottomToTop = false, bool withClosing = true)
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

                if (withClosing)
                {
                    openSprite.Fade(endTime - beat, 0);

                    var closeSprite = GetLayer("close-stripe").CreateSprite("sb/common/pixel.png", closeOrigin, new Vector2(closeX, closeY));
                    closeSprite.Color(endTime - beat, color);
                    closeSprite.ScaleVec(OsbEasing.InCirc, endTime - beat, endTime, new Vector2(854, thickness), new Vector2(854, 0));
                    closeSprite.Fade(endTime - beat, 1);
                    closeSprite.Fade(endTime, 0);
                }
                else
                {
                    openSprite.Fade(endTime, 0);
                }


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

        private void generateDropdownTextAndElement(double startTime, double endTime, string text, FontGenerator font, Color4 color, OsbSprite element)
        {
            var beat = Beatmap.GetTimingPointAt(965).BeatDuration;

            var bg = GetLayer("dropdown-bg").CreateSprite("sb/common/pixel.png", OsbOrigin.TopLeft, new Vector2(-107, 0));
            bg.ScaleVec(OsbEasing.OutCirc, startTime, startTime + beat, new Vector2(854, 0), new Vector2(854, 480));
            bg.Color(startTime, color);
            bg.Fade(startTime, 1);
            bg.Fade(endTime + beat, 0);

            element.MoveY(OsbEasing.OutCirc, startTime, startTime + beat, 0, 200);
            element.MoveY(OsbEasing.InCirc, endTime - beat, endTime, 200, 560);
            element.Fade(startTime, 1);
            element.Fade(endTime, 0);

            var numberOfLine = (float)text.Split('\n').Length;
            var posX = 0f;
            var lineWidth = 0f;
            var lineHeight = 0f;
            var textPadding = 20;
            foreach (var line in text.Split('\n'))
            {
                lineHeight = 0f;
                foreach (var letter in line)
                {
                    var texture = font.GetTexture(letter.ToString());
                    lineWidth = Math.Max(lineWidth, texture.BaseWidth * 0.3f);
                    lineHeight += texture.BaseHeight * 0.3f;
                    posX = (float)(numberOfLine % 2 == 0 ? 320f - ((numberOfLine - 1) / 2) * (lineWidth + textPadding) : 320f - ((numberOfLine - 1) / 2) * (lineWidth + textPadding));
                }
            }
            foreach (var line in text.Split('\n'))
            {
                var letterX = posX;
                var letterY = 0 - lineHeight;
                foreach (var letter in line)
                {
                    var texture = font.GetTexture(letter.ToString());
                    if (!texture.IsEmpty)
                    {
                        var position = new Vector2(letterX, letterY);
                        var sprite = GetLayer("dropdown-text").CreateSprite(texture.Path, OsbOrigin.Centre, position);
                        sprite.MoveY(OsbEasing.OutCirc, startTime, startTime + beat, letterY, letterY + 340);
                        sprite.MoveY(OsbEasing.InCirc, endTime - beat, endTime, letterY + 340, letterY + 700);
                        sprite.Scale(startTime, 0.3f);
                        sprite.Fade(startTime, 1);
                        sprite.Fade(endTime, 0);

                        letterY += texture.BaseHeight * 0.3f;
                    }
                }
                posX += (lineWidth + textPadding);
            }

        }

        private void generateScrollUpTiltedRightAlignedText(double startTime, double endTime, string text, float fontScale, Vector2 startPosition, float distance, int angle, FontGenerator font, Color4 color)
        {
            var beat = Beatmap.GetTimingPointAt(965).BeatDuration;

            // startPosition is actually the top right coordinate of the last letter of the first line.
            var currentPosition = startPosition;
            var time = startTime;
            var numberOfLetters = text.Replace("\n", "").Length;
            var textPadding = 10;
            foreach (var line in text.Split('\n'))
            {
                var lineWidth = 0f;
                var lineHeight = 0f;
                foreach (var letter in line)
                {
                    var texture = font.GetTexture(letter.ToString());
                    lineWidth += texture.BaseWidth * fontScale + textPadding;
                    lineHeight = Math.Max(texture.BaseHeight * fontScale, lineHeight);
                }

                var letterX = currentPosition.X - lineWidth * (float)Math.Cos(MathHelper.DegreesToRadians(Math.Abs(angle)));
                var letterY = currentPosition.Y + lineWidth * (float)Math.Sin(MathHelper.DegreesToRadians(Math.Abs(angle)));
                foreach (var letter in line)
                {
                    var texture = font.GetTexture(letter.ToString());
                    if (!texture.IsEmpty)
                    {
                        var position = new Vector2(letterX, letterY) + texture.OffsetFor(OsbOrigin.TopRight) * fontScale;
                        var sprite = GetLayer("lyrics").CreateSprite(texture.Path, OsbOrigin.Centre, position);
                        sprite.Rotate(startTime, MathHelper.DegreesToRadians(angle));
                        sprite.Scale(startTime, fontScale);
                        sprite.Fade(startTime, 0);
                        sprite.Fade(time, 1);
                        sprite.Fade(endTime, 0);
                        sprite.MoveX(startTime, endTime, letterX, letterX - distance * (float)Math.Sin(MathHelper.DegreesToRadians(Math.Abs(angle))));
                        sprite.MoveY(startTime, endTime, letterY, letterY - distance * (float)Math.Cos(MathHelper.DegreesToRadians(Math.Abs(angle))));

                        letterX += (texture.BaseWidth * fontScale + textPadding) * (float)Math.Cos(MathHelper.DegreesToRadians(Math.Abs(angle)));
                        letterY -= (texture.BaseWidth * fontScale + textPadding) * (float)Math.Sin(MathHelper.DegreesToRadians(Math.Abs(angle)));
                        time += (double)((endTime - startTime - beat / 2) / numberOfLetters);
                    }
                }

                currentPosition.X += (lineHeight + textPadding) * (float)Math.Sin(MathHelper.DegreesToRadians(Math.Abs(angle)));
                currentPosition.Y += (lineHeight + textPadding) * (float)Math.Cos(MathHelper.DegreesToRadians(Math.Abs(angle)));
            }
        }

        private void generateRotatingSplitText(double startTime, double endTime, double textEndTime, string text1, string text2, float fontScale, int angle, int offsetTopY, int offsetBottomY, FontGenerator font)
        {
            // preconfigured options
            var beat = Beatmap.GetTimingPointAt(965).BeatDuration;
            var timeStep = beat / 8;
            var radius = 150;
            var angleStep = angle / ((endTime - startTime) / timeStep);
            var t = (int)((endTime - startTime) / timeStep);
            var textPadding = 10;

            // text1
            var text1Postition = new Vector2(320, 240) - new Vector2(radius, offsetTopY);
            var time = startTime;
            var numberOfLetters = text1.Replace("\n", "").Length;
            int lineOrder = 0;
            foreach (var line in text1.Split('\n'))
            {
                var lineWidth = 0f;
                var lineHeight = 0f;
                int letterOrder = line.Length;
                var textureWidth = 0f;
                foreach (var letter in line)
                {
                    var texture = font.GetTexture(letter.ToString());
                    textureWidth = texture.BaseWidth * fontScale;
                    lineWidth += texture.BaseWidth * fontScale + textPadding;
                    lineHeight = Math.Max(texture.BaseHeight * fontScale, lineHeight);
                }

                var letterX = text1Postition.X - lineWidth - textureWidth;
                var letterY = text1Postition.Y;
                foreach (var letter in line)
                {
                    var texture = font.GetTexture(letter.ToString());
                    if (!texture.IsEmpty)
                    {
                        var position = new Vector2(letterX, letterY) + texture.OffsetFor(OsbOrigin.CentreRight) * fontScale;
                        var sprite = GetLayer("lyrics-on-circle").CreateSprite(texture.Path, OsbOrigin.CentreRight, position);
                        sprite.Scale(startTime, fontScale);
                        if (time != startTime)
                        {
                            sprite.Fade(startTime, 0);
                        }
                        sprite.Fade(time, 1);
                        sprite.Fade(endTime, 0);
                        sprite.Color(startTime, Random(0, 2) == 0 ? redColor : blueColor);
                        // loop
                        var currentTime = startTime;
                        var currentAngle = 0 + angleStep;
                        var currentPosition = position;

                        for (int i = 0; i < t; i++)
                        {
                            var targetPosition = new Vector2();
                            targetPosition.X = (float)(320 - (radius + letterOrder * (20 + textPadding)) * Math.Cos(MathHelper.DegreesToRadians(currentAngle)) + (lineOrder * (20 + textPadding)) * Math.Sin(MathHelper.DegreesToRadians(currentAngle)));
                            targetPosition.Y = (float)((240 - offsetTopY) + (radius + letterOrder * (20 + textPadding)) * Math.Sin(MathHelper.DegreesToRadians(currentAngle)) + (lineOrder * (20 + textPadding)) * Math.Cos(MathHelper.DegreesToRadians(currentAngle)));
                            sprite.Move(currentTime, currentTime + timeStep, currentPosition, targetPosition);
                            sprite.Rotate(currentTime, MathHelper.DegreesToRadians(-currentAngle));

                            currentTime += timeStep;
                            currentAngle += angleStep;
                            currentPosition = targetPosition;
                        }

                        letterX -= (texture.BaseWidth * fontScale + textPadding);
                        time += (double)(((textEndTime - startTime) / 2 - beat / 2) / numberOfLetters);
                        letterOrder--;
                    }
                }

                text1Postition.Y += (lineHeight + textPadding);

                lineOrder++;
            }

            // text2
            var text2Postition = new Vector2(320, 240) + new Vector2(radius, offsetBottomY);
            numberOfLetters = text2.Replace("\n", "").Length;
            lineOrder = 0;
            foreach (var line in text2.Split('\n'))
            {
                var lineWidth = 0f;
                var lineHeight = 0f;
                int letterOrder = 0;
                foreach (var letter in line)
                {
                    var texture = font.GetTexture(letter.ToString());
                    lineWidth += texture.BaseWidth * fontScale + textPadding;
                    lineHeight = Math.Max(texture.BaseHeight * fontScale, lineHeight);
                }

                var letterX = text2Postition.X;
                var letterY = text2Postition.Y;
                foreach (var letter in line)
                {
                    var texture = font.GetTexture(letter.ToString());
                    if (!texture.IsEmpty)
                    {
                        var position = new Vector2(letterX, letterY) + texture.OffsetFor(OsbOrigin.CentreLeft) * fontScale;
                        var sprite = GetLayer("lyrics-on-circle").CreateSprite(texture.Path, OsbOrigin.CentreLeft, position);
                        sprite.Scale(startTime, fontScale);
                        sprite.Fade(startTime, 0);
                        sprite.Fade(time, 1);
                        sprite.Fade(endTime, 0);
                        sprite.Color(startTime, Random(0, 2) == 0 ? redColor : blueColor);
                        // loop
                        var currentTime = startTime;
                        var currentAngle = 0 + angleStep;
                        var currentPosition = position;

                        for (int i = 0; i < t; i++)
                        {
                            var targetPosition = new Vector2();
                            targetPosition.X = (float)(320 + (radius + letterOrder * (20 + textPadding)) * Math.Cos(MathHelper.DegreesToRadians(currentAngle)) + (lineOrder * (20 + textPadding)) * Math.Sin(MathHelper.DegreesToRadians(currentAngle)));
                            targetPosition.Y = (float)((240 + offsetBottomY) - (radius + letterOrder * (20 + textPadding)) * Math.Sin(MathHelper.DegreesToRadians(currentAngle)) + (lineOrder * (20 + textPadding)) * Math.Cos(MathHelper.DegreesToRadians(currentAngle)));
                            sprite.Move(currentTime, currentTime + timeStep, currentPosition, targetPosition);
                            sprite.Rotate(currentTime, MathHelper.DegreesToRadians(-currentAngle));

                            currentTime += timeStep;
                            currentAngle += angleStep;
                            currentPosition = targetPosition;
                        }
                        Log(letterY.ToString());
                        letterX += (texture.BaseWidth * fontScale + textPadding);
                        time += (double)(((textEndTime - startTime) / 2 - beat / 2) / numberOfLetters);
                        letterOrder++;
                    }
                }

                text2Postition.Y += (lineHeight + textPadding);

                lineOrder++;
            }
        }

        private void generateCentreRectangleTransition(double startTime, double endTime, Color4 color)
        {
            var beat = Beatmap.GetTimingPointAt(965).BeatDuration;
            var leftSprite1 = GetLayer("transition").CreateSprite("sb/common/pixel.png", OsbOrigin.CentreRight, new Vector2(320, 240));
            leftSprite1.ScaleVec(OsbEasing.OutCirc, startTime, startTime + beat / 2, new Vector2(0, 480), new Vector2(427, 480));
            leftSprite1.Fade(startTime, 1);
            leftSprite1.Fade(endTime - beat / 2, 0);
            leftSprite1.Color(startTime, color);
            var rightSprite1 = GetLayer("transition").CreateSprite("sb/common/pixel.png", OsbOrigin.CentreLeft, new Vector2(320, 240));
            rightSprite1.ScaleVec(OsbEasing.OutCirc, startTime, startTime + beat / 2, new Vector2(0, 480), new Vector2(427, 480));
            rightSprite1.Fade(startTime, 1);
            rightSprite1.Fade(endTime - beat / 2, 0);
            rightSprite1.Color(startTime, color);

            var leftSprite2 = GetLayer("transition").CreateSprite("sb/common/pixel.png", OsbOrigin.CentreLeft, new Vector2(-107, 240));
            leftSprite2.ScaleVec(OsbEasing.InQuad, endTime - beat / 2, endTime, new Vector2(427, 480), new Vector2(0, 480));
            leftSprite2.Fade(endTime - beat / 2, 1);
            leftSprite2.Fade(endTime, 0);
            leftSprite2.Color(endTime - beat / 2, color);
            var rightSprite2 = GetLayer("transition").CreateSprite("sb/common/pixel.png", OsbOrigin.CentreRight, new Vector2(747, 240));
            rightSprite2.ScaleVec(OsbEasing.InQuad, endTime - beat / 2, endTime, new Vector2(427, 480), new Vector2(0, 480));
            rightSprite2.Fade(endTime - beat / 2, 1);
            rightSprite2.Fade(endTime, 0);
            rightSprite2.Color(endTime - beat / 2, color);
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
            var fontYasashisaAntique = LoadFont("sb/lyrics/YasashisaAntique", new FontDescription()
            {
                FontPath = "YasashisaAntique.otf",
                FontSize = 70,
                Color = Color4.White,
                Padding = Vector2.Zero,
                FontStyle = FontStyle.Regular,
                TrimTransparency = true
            });
            Scene1(fontSoukouMincho);
            Scene2();
            Scene3(fontYasashisaAntique);
            Scene4(fontYasashisaAntique);
        }
    }
}
