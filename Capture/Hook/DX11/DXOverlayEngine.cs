﻿using System;
using System.Collections.Generic;
using Capture.Hook.Common;
using SharpDX.Direct3D11;
using SharpDX;

namespace Capture.Hook.DX11
{
    internal class DXOverlayEngine: Component
    {
        public IOverlay Overlay { get; set; }
        public bool DeferredContext
        {
            get
            {
                return _deviceContext.TypeInfo == DeviceContextType.Deferred;
            }
        }

        bool _initialised = false;
        bool _initialising = false;

        Device _device;
        DeviceContext _deviceContext;
        Texture2D _renderTarget;
        RenderTargetView _renderTargetView;
        DXSprite _spriteEngine;
        readonly Dictionary<string, DXFont> _fontCache = new Dictionary<string, DXFont>();
        readonly Dictionary<Element, DXImage> _imageCache = new Dictionary<Element, DXImage>();

        public DXOverlayEngine()
        {
        }

        private void EnsureInitiliased()
        {
            if (!_initialised)
                throw new InvalidOperationException("DXOverlayEngine must be initialised.");
        }

        public bool Initialise(SharpDX.DXGI.SwapChain swapChain)
        {
            return Initialise(swapChain.GetDevice<Device>(), swapChain.GetBackBuffer<Texture2D>(0));
        }

        public bool Initialise(Device device, Texture2D renderTarget)
        {
            if (_initialising)
                return false;

            _initialising = true;
            
            try
            {

                _device = device;
                _renderTarget = renderTarget;
                try
                {
                    _deviceContext = ToDispose(new DeviceContext(_device));
                }
                catch (SharpDXException)
                {
                    _deviceContext = _device.ImmediateContext;
                }

                _renderTargetView = ToDispose(new RenderTargetView(_device, _renderTarget));

                //if (DeferredContext)
                //{
                //    ViewportF[] viewportf = { new ViewportF(0, 0, _renderTarget.Description.Width, _renderTarget.Description.Height, 0, 1) };
                //    _deviceContext.Rasterizer.SetViewports(viewportf);
                //    _deviceContext.OutputMerger.SetTargets(_renderTargetView);
                //}

                _spriteEngine = new DXSprite(_device, _deviceContext);
                if (!_spriteEngine.Initialize())
                    return false;

                // Initialise any resources required for overlay elements
                InitialiseElementResources();

                _initialised = true;
                return true;
            }
            finally
            {
                _initialising = false;
            }
        }

        void InitialiseElementResources()
        {
            if (Overlay != null)
            {
                foreach (var element in Overlay.Elements)
                {
                    if (element is TextElement textElement)
                    {
                        GetFontForTextElement(textElement);
                    }
                    else if (element is ImageElement imageElement)
                    {
                        GetImageForImageElement(imageElement);
                    }
                }
            }
        }

        private void Begin()
        {
            //if (!DeferredContext)
            //{
                SharpDX.Mathematics.Interop.RawViewportF[] viewportf = { new ViewportF(0, 0, _renderTarget.Description.Width, _renderTarget.Description.Height, 0, 1) };
                _deviceContext.Rasterizer.SetViewports(viewportf);
                _deviceContext.OutputMerger.SetTargets(_renderTargetView);
            //}
        }

        /// <summary>
        /// Draw the overlay(s)
        /// </summary>
        public void Draw()
        {
            EnsureInitiliased();

            Begin();

            if (Overlay != null && !Overlay.Hidden)
            {

                foreach (var element in Overlay.Elements)
                {
                    if (element.Hidden)
                        continue;


                    if (element is TextElement textElement)
                    {
                        DXFont font = GetFontForTextElement(textElement);
                        if (font != null && !String.IsNullOrEmpty(textElement.Text))
                            _spriteEngine.DrawString(textElement.Location.X, textElement.Location.Y, textElement.Text, textElement.Color, font);
                    }
                    else if (element is ImageElement imageElement)
                    {
                        DXImage image = GetImageForImageElement(imageElement);
                        if (image != null)
                            _spriteEngine.DrawImage(imageElement.Location.X, imageElement.Location.Y, imageElement.Scale, imageElement.Angle, imageElement.Tint, image);
                    }
                }
            }

            End();
        }

        private void End()
        {
            if (DeferredContext)
            {
                var commandList = _deviceContext.FinishCommandList(true);
                _device.ImmediateContext.ExecuteCommandList(commandList, true);
                commandList.Dispose();
            }
        }

        DXFont GetFontForTextElement(TextElement element)
        {
            string fontKey = String.Format("{0}{1}{2}{3}", element.Font.Name, element.Font.Size, element.Font.Style, element.AntiAliased);

            if (!_fontCache.TryGetValue(fontKey, out DXFont result))
            {
                result = ToDispose(new DXFont(_device));
                result.Initialize(element.Font.Name, element.Font.Size, element.Font.Style, element.AntiAliased);
                _fontCache[fontKey] = result;
            }
            return result;
        }

        DXImage GetImageForImageElement(ImageElement element)
        {

            if (!_imageCache.TryGetValue(element, out DXImage result))
            {
                result = ToDispose(new DXImage(_device));
                result.Initialise(element.Bitmap);
                _imageCache[element] = result;
            }

            return result;
        }

        /// <summary>
        /// Releases unmanaged and optionally managed resources
        /// </summary>
        /// <param name="disposing">true if disposing both unmanaged and managed</param>
        protected override void Dispose(bool disposing)
        {
            if (true)
            {
                _device = null;
            }
        }
    }
}
