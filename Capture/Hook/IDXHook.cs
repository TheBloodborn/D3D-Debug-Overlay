using System;
using Capture.Interface;

namespace Capture.Hook
{
    internal interface IDXHook: IDisposable
    {
        CaptureInterface Interface
        {
            get;
            set;
        }
        CaptureConfig Config
        {
            get;
            set;
        }

        void Hook();

        void Cleanup();
    }
}
