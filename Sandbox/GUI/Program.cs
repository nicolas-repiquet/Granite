using Granite.Core;
using Granite.UI;
using GUI.Sprites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GUI
{
    public class Program : ApplicationLogicBase
    {
        public static void Main(string[] args)
        {
            Engine.Run(new Program(), new ApplicationSettings()
            {
                DisplayStyle = DisplayStyle.ResizeableWithTitle
            });
        }

        private Theme_01 m_theme;
        private Graphics m_graphics;

        public override void Start()
        {
            m_graphics = new Graphics(10000);
            m_theme = Theme_01.Instance;
        }

        public override void Render(TimeSpan elapsed)
        {
            Engine.Display.SetTitle(string.Format("{0:0} FPS", Engine.Display.FramesPerSecond));

            var size = Engine.Display.GetSize();

            GL.Viewport(size);
            GL.ClearColor(0.3f, 0.3f, 0.3f, 1f);
            GL.Clear(GL.COLOR_BUFFER_BIT | GL.DEPTH_BUFFER_BIT);
            GL.Enable_BLEND();
            GL.BlendFunc(GL.SRC_ALPHA, GL.ONE_MINUS_SRC_ALPHA);

            m_graphics.Clear();
            m_graphics.Translate(new Vector2(-1, 1));
            m_graphics.Scale(new Vector2(2f / size.X, -2f / size.Y));

  
            m_graphics.Draw(
                new Box2(100f, 100f, 180f, 180f),
                new Color4ub(0xFF, 0x00, 0xFF, 0xFF)
            );

            m_graphics.Draw(
                new Box2(300f, 100f, 180f, 180f),
                new Color4ub(0xFF, 0xFF, 0x00, 0xFF)
            );

            m_graphics.Draw(
                new Box2(100f, 300f, 180f, 180f),
                new Color4ub(0x00, 0xFF, 0xFF, 0xFF)
            );

            m_graphics.Draw(
                new Box2(300f, 300f, 180f, 180f),
                m_theme.Texture,
                new Vector2(0, 0),
                new Vector2(1, 1)
            );

            m_graphics.Draw(
                new Vector2(100f, 500f),
                InternalFonts.RegularSmallVariableWidthFont,
                @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla fringilla, ipsum a ornare tristique, nunc nisi eleifend lacus, ut pellentesque lacus lectus eu mi. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Suspendisse massa arcu, vestibulum sit amet pellentesque sed, ornare non leo. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Etiam ac dolor diam. Nunc dignissim ante a felis tristique, sit amet viverra nunc ullamcorper. Mauris faucibus, libero id faucibus pharetra, ex libero venenatis nulla, in suscipit nisl elit non metus. Integer aliquam eget velit nec porta. Pellentesque ultrices vel diam ut rhoncus. Sed dictum, magna sed tincidunt egestas, urna ex ullamcorper est, condimentum molestie nibh erat at diam.

Vestibulum consectetur elementum risus vel molestie. Vivamus id tincidunt ipsum. Donec varius diam imperdiet augue posuere vulputate. Sed bibendum massa vitae imperdiet tincidunt. Quisque dictum, augue ut porttitor tincidunt, diam libero viverra ante, vel pulvinar ex est a mi. Maecenas nec elementum orci, sit amet lobortis nulla. Mauris tincidunt molestie turpis eu semper. Suspendisse in nunc eleifend, aliquet sem mattis, aliquet felis. Proin placerat massa suscipit libero volutpat, nec vehicula sem mollis. Nulla commodo sapien a leo condimentum eleifend. Nunc viverra lacus risus, vitae sollicitudin orci placerat eget. Donec justo diam, porttitor in ipsum ac, consequat consectetur dui. Nullam laoreet elit ac libero convallis, vitae ornare elit egestas. Curabitur pretium dignissim auctor.

Sed et urna eu enim commodo sollicitudin. Aliquam cursus finibus tellus gravida scelerisque. Duis ornare a dui at luctus. Ut pulvinar pellentesque libero et vestibulum. Suspendisse libero quam, tempus in congue vehicula, tincidunt quis nisi. Aliquam consectetur lacinia pretium. Duis sed pharetra odio. Integer lobortis commodo arcu, ut convallis mi pretium eget. Cras varius dui lorem, molestie dictum arcu iaculis faucibus. Donec egestas enim sit amet vehicula scelerisque. Nam eleifend feugiat bibendum. Maecenas nec felis non enim posuere lobortis et at urna. Maecenas euismod facilisis ultricies. Nulla urna mi, sollicitudin vitae euismod ac, venenatis sed risus. Nulla facilisi.

Pellentesque dolor erat, consequat in nunc quis, dapibus bibendum lorem. Nulla sed tempus orci, at feugiat magna. Cras bibendum turpis id ligula semper imperdiet. Curabitur iaculis pellentesque libero. Vestibulum posuere volutpat lorem. Sed sit amet mattis elit, vitae aliquam odio. Etiam varius, lorem ac venenatis tristique, libero libero vulputate tortor, eget auctor ipsum justo suscipit est.

Etiam eleifend sed sem sed laoreet. In finibus diam elit, sed pulvinar dui pharetra eu. In eget ultrices dui. Phasellus lobortis in diam eu fringilla. Proin eu dignissim odio. Curabitur ante quam, accumsan vel condimentum sed, malesuada sed turpis. Mauris nec aliquet felis."
            );

            m_graphics.Flush();

            GL.Finish();

            Engine.Display.Invalidate();
        }
    }
}
