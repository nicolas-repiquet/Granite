//using System;
//using System.Collections.Generic;
//using System.Text;
//using Granite.Core;

//namespace Zombie.Game.Entities.Tools
//{
//    public class FboRenderTexture : IDisposable
//    {
//        public uint textureId = 0;
//        public uint fboId = 0;

//        public Vector2i textureSize;

//        public FboRenderTexture(int width, int height)
//        {
//            this.textureSize = new Vector2i(width, height);

//            Init();
//        }

//        public FboRenderTexture(Vector2i size)
//        {
//            this.textureSize = size;

//            Init();
//        }

//        private void Init()
//        {
//            var texture = new Texture2D();

//            texture.Size = new Texture2D(bitmap.Width, bitmap.Height);

//            var data = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

//            GL.BindTexture(GL.TEXTURE_2D, texture.Name);

//            GL.TexParameteri(GL.TEXTURE_2D, GL.TEXTURE_MIN_FILTER, (int)GL.NEAREST);
//            GL.TexParameteri(GL.TEXTURE_2D, GL.TEXTURE_MAG_FILTER, (int)GL.NEAREST);
//            //GL.TexParameteri(GL.TEXTURE_2D, GL.TEXTURE_MIN_FILTER, (int)GL.LINEAR);
//            //GL.TexParameteri(GL.TEXTURE_2D, GL.TEXTURE_MAG_FILTER, (int)GL.LINEAR);
//            GL.TexParameteri(GL.TEXTURE_2D, GL.TEXTURE_WRAP_S, (int)GL.CLAMP_TO_EDGE);
//            GL.TexParameteri(GL.TEXTURE_2D, GL.TEXTURE_WRAP_T, (int)GL.CLAMP_TO_EDGE);

//            GL.TexImage2D(GL.TEXTURE_2D, 0, (int)GL.RGBA8, bitmap.Width, bitmap.Height, 0, GL.BGRA, GL.UNSIGNED_BYTE, data.Scan0);

//            GL.BindTexture(GL.TEXTURE_2D, 0);

//            bitmap.UnlockBits(data);
//        }

//        // Track whether Dispose has been called.
//        private bool disposed = false;

//        public void Dispose()
//        {
//            Dispose(true);

//            GC.SuppressFinalize(this);
//        }

//        private void Dispose(bool disposing)
//        {
//            if (!this.disposed)
//            {
//                if (disposing)
//                {
//                    // Clean up what we allocated before exiting
//                    //if (textureId != 0)
//                    //    GL.DeleteTextures(1, ref textureId);

//                    if (fboId != 0)
//                        GL.DeleteFramebuffers(1, ref fboId);

//                    disposed = true;
//                }
//            }
//        }

//        public void BeginDrawing(bool clear = true, float r = 0f, float g = 0f, float b = 0f, float a = 0f)
//        {
//            //GL.ColorMask(false, false, false, false);

//            // Attach the framebuffer.
//            GL.BindFramebuffer(GL.FRAMEBUFFER, fboId);

//            if (clear)
//            {
//                //GL.ColorMask(false, false, false, true);
//                //GL.DrawBuffer(DrawBufferMode.ColorAttachment0);


//                GL.Clear(GL.COLOR_BUFFER_BIT);
//                var color = new Color4(r, g, b, a);
//                GL.ClearBufferfv(GL.COLOR, 0, ref color);


//            }

//        }

//        public void EndDrawing()
//        {

//            GL.BindFramebuffer(GL.FRAMEBUFFER, 0); // disable rendering into the FBO
//            //GL.ColorMask(true, true, true, true);

//        }

//        public uint GetTexture()
//        {
//            return textureId;
//        }

//        private void CheckErrors()
//        {
//            switch (GL.CheckFramebufferStatus(GL.FRAMEBUFFER))
//            {
//                case GL.FRAMEBUFFER_COMPLETE:
//                    {
//                        Console.WriteLine("FBO: The framebuffer is complete and valid for rendering.");
//                        break;
//                    }
//                case GL.FRAMEBUFFER_INCOMPLETE_ATTACHMENT:
//                    {
//                        Console.WriteLine("FBO: One or more attachment points are not framebuffer attachment complete. This could mean there’s no texture attached or the format isn’t renderable. For color textures this means the base format must be RGB or RGBA and for depth textures it must be a DEPTH_COMPONENT format. Other causes of this error are that the width or height is zero or the z-offset is out of range in case of render to volume.");
//                        break;
//                    }
//                case GL.FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT:
//                    {
//                        Console.WriteLine("FBO: There are no attachments.");
//                        break;
//                    }
//                /* case  FramebufferErrorCode.GL_FRAMEBUFFER_INCOMPLETE_DUPLICATE_ATTACHMENT_EXT: 
//                     {
//                         Console.WriteLine("FBO: An object has been attached to more than one attachment point.");
//                         break;
//                     }*/
//                //case GL.FRAMEBUFFER_INCOMPLETE_DIMENSIONS:
//                //    {
//                //        Console.WriteLine("FBO: Attachments are of different size. All attachments must have the same width and height.");
//                //        break;
//                //    }
//                //case GL.FRAMEBUFFER_INCOMPLETE_:
//                //    {
//                //        Console.WriteLine("FBO: The color attachments have different format. All color attachments must have the same format.");
//                //        break;
//                //    }
//                //case FramebufferErrorCode.FramebufferIncompleteDrawBufferExt:
//                //    {
//                //        Console.WriteLine("FBO: An attachment point referenced by GL.DrawBuffers() doesn’t have an attachment.");
//                //        break;
//                //    }
//                //case FramebufferErrorCode.FramebufferIncompleteReadBufferExt:
//                //    {
//                //        Console.WriteLine("FBO: The attachment point referenced by GL.ReadBuffers() doesn’t have an attachment.");
//                //        break;
//                //    }
//                //case FramebufferErrorCode.FramebufferUnsupportedExt:
//                //    {
//                //        Console.WriteLine("FBO: This particular FBO configuration is not supported by the implementation.");
//                //        break;
//                //    }
//                default:
//                    {
//                        Console.WriteLine("FBO: Status unknown. (yes, this is really bad.)");
//                        break;
//                    }
//            }

//            // using FBO might have changed states, e.g. the FBO might not support stereoscopic views or double buffering
//            //int[] queryinfo = new int[6];
//            //GL.GetInteger(GetPName.MaxColorAttachmentsExt, out queryinfo[0]);
//            ////GL.GetInteger(GetPName.AuxBuffers, out queryinfo[1]);
//            //queryinfo[1] = -1;
//            //GL.GetInteger(GetPName.MaxDrawBuffers, out queryinfo[2]);
//            //GL.GetInteger(GetPName.Stereo, out queryinfo[3]);
//            //GL.GetInteger(GetPName.Samples, out queryinfo[4]);
//            //GL.GetInteger(GetPName.Doublebuffer, out queryinfo[5]);
//            //Console.WriteLine("max. ColorBuffers: " + queryinfo[0] + " max. AuxBuffers: " + queryinfo[1] + " max. DrawBuffers: " + queryinfo[2] +
//            //                   "\nStereo: " + queryinfo[3] + " Samples: " + queryinfo[4] + " DoubleBuffer: " + queryinfo[5]);

//            //Console.WriteLine("Last GL Error: " + GL.GetError());
//        }
//    }
//}