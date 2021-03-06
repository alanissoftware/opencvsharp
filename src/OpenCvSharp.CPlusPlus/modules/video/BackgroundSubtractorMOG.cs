﻿using System;
using OpenCvSharp.Utilities;

namespace OpenCvSharp.CPlusPlus
{
    /// <summary>
    /// The Base Class for Background/Foreground Segmentation.
    /// The class is only used to define the common interface for
    /// the whole family of background/foreground segmentation algorithms.
    /// </summary>
    public class BackgroundSubtractorMOG : BackgroundSubtractor
    {
        /// <summary>
        /// sizeof(BackgroundSubtractorMOG)
        /// </summary>
        public static new readonly int SizeOf = CppInvoke.video_BackgroundSubtractorMOG_sizeof().ToInt32();

        #region Init
        /// <summary>
        /// the default constructor
        /// </summary>
        public BackgroundSubtractorMOG()
        {
            ptr = CppInvoke.video_BackgroundSubtractorMOG_new1();
            if (ptr == IntPtr.Zero)
                throw new OpenCvSharpException();
        }
        /// <summary>
        /// the full constructor that takes the length of the history, the number of gaussian mixtures, the background ratio parameter and the noise strength
        /// </summary>
        /// <param name="history"></param>
        /// <param name="nmixtures"></param>
        /// <param name="backgroundRatio"></param>
        /// <param name="noiseSigma"></param>
        public BackgroundSubtractorMOG(int history, int nmixtures, double backgroundRatio, double noiseSigma=0)
        {
            ptr = CppInvoke.video_BackgroundSubtractorMOG_new2(history, nmixtures, backgroundRatio, noiseSigma);
            if (ptr == IntPtr.Zero)
                throw new OpenCvSharpException();
        }
        #endregion
        #region Dispose
#if LANG_JP
    /// <summary>
    /// リソースの解放
    /// </summary>
#else
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
#endif
        public void Release()
        {
            Dispose(true);
        }
#if LANG_JP
    /// <summary>
    /// リソースの解放
    /// </summary>
    /// <param name="disposing">
    /// trueの場合は、このメソッドがユーザコードから直接が呼ばれたことを示す。マネージ・アンマネージ双方のリソースが解放される。
    /// falseの場合は、このメソッドはランタイムからファイナライザによって呼ばれ、もうほかのオブジェクトから参照されていないことを示す。アンマネージリソースのみ解放される。
    ///</param>
#else
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">
        /// If disposing equals true, the method has been called directly or indirectly by a user's code. Managed and unmanaged resources can be disposed.
        /// If false, the method has been called by the runtime from inside the finalizer and you should not reference other objects. Only unmanaged resources can be disposed.
        /// </param>
#endif
        protected override void Dispose(bool disposing)
        {
            if (!disposed)
            {
                // 継承したクラス独自の解放処理
                try
                {
                    if (disposing)
                    {                        
                    }
                    if (IsEnabledDispose)
                    {
                        CppInvoke.video_BackgroundSubtractorMOG_delete(ptr);
                    }
                    disposed = true;
                }
                finally
                {
                    // 親の解放処理
                    base.Dispose(disposing);
                }
            }
        }
        #endregion

        /// <summary>
        /// the update operator
        /// </summary>
        /// <param name="image"></param>
        /// <param name="fgmask"></param>
        /// <param name="learningRate"></param>
        public override void Run(InputArray image, OutputArray fgmask, double learningRate = 0)
        {
            if (image == null)
                throw new ArgumentNullException("image");
            if (fgmask == null)
                throw new ArgumentNullException("fgmask");
            image.ThrowIfDisposed();
            fgmask.ThrowIfNotReady();
            CppInvoke.video_BackgroundSubtractorMOG_operator(ptr, image.CvPtr, fgmask.CvPtr, learningRate);
            fgmask.Fix();
        }
    
        /// <summary>
        /// re-initiaization method
        /// </summary>
        /// <param name="frameSize"></param>
        /// <param name="frameType"></param>
        public virtual void Initialize(Size frameSize, int frameType)
        {
            CppInvoke.video_BackgroundSubtractorMOG_initialize(ptr, frameSize, frameType);
        }
        
        #region Properties
        /*
        /// <summary>
        /// 
        /// </summary>
        public CvSize FrameSize
        {
            get
            {
                return CppInvoke.BackgroundSubtractorMOG_frameSize_get(_ptr);
            }
            set
            {
                CppInvoke.BackgroundSubtractorMOG_frameSize_set(_ptr, value);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int FrameType
        {
            get
            {
                unsafe
                {
                    return *CppInvoke.BackgroundSubtractorMOG_frameType(_ptr);
                }
            }
            set
            {
                unsafe
                {
                    *CppInvoke.BackgroundSubtractorMOG_frameType(_ptr) = value;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public Mat BgModel
        {
            get
            {
                unsafe
                {
                    return new Mat(CppInvoke.BackgroundSubtractorMOG_bgmodel(_ptr));
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Nframes
        {
            get
            {
                unsafe
                {
                    return *CppInvoke.BackgroundSubtractorMOG_nframes(_ptr);
                }
            }
            set
            {
                unsafe
                {
                    *CppInvoke.BackgroundSubtractorMOG_nframes(_ptr) = value;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int History
        {
            get
            {
                unsafe
                {
                    return *CppInvoke.BackgroundSubtractorMOG_history(_ptr);
                }
            }
            set
            {
                unsafe
                {
                    *CppInvoke.BackgroundSubtractorMOG_history(_ptr) = value;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Nmixtures
        {
            get
            {
                unsafe
                {
                    return *CppInvoke.BackgroundSubtractorMOG_nmixtures(_ptr);
                }
            }
            set
            {
                unsafe
                {
                    *CppInvoke.BackgroundSubtractorMOG_nmixtures(_ptr) = value;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public double VarThreshold
        {
            get
            {
                unsafe
                {
                    return *CppInvoke.BackgroundSubtractorMOG_varThreshold(_ptr);
                }
            }
            set
            {
                unsafe
                {
                    *CppInvoke.BackgroundSubtractorMOG_varThreshold(_ptr) = value;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public double BackgroundRatio
        {
            get
            {
                unsafe
                {
                    return *CppInvoke.BackgroundSubtractorMOG_backgroundRatio(_ptr);
                }
            }
            set
            {
                unsafe
                {
                    *CppInvoke.BackgroundSubtractorMOG_backgroundRatio(_ptr) = value;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public double NoiseSigma
        {
            get
            {
                unsafe
                {
                    return *CppInvoke.BackgroundSubtractorMOG_noiseSigma(_ptr);
                }
            }
            set
            {
                unsafe
                {
                    *CppInvoke.BackgroundSubtractorMOG_noiseSigma(_ptr) = value;
                }
            }
        }
        //*/
        #endregion
        
    }
}