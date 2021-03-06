﻿/*
 * (C) 2008-2014 shimat
 * This code is licenced under the LGPL.
 */

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Text;
using OpenCvSharp;
using OpenCvSharp.Utilities;

#pragma warning disable 1591

namespace OpenCvSharp.CPlusPlus
{
    /// <summary>
    /// P/Invoke methods of OpenCV 2.x C++ interface
    /// </summary>
    [SuppressUnmanagedCodeSecurity]
    internal static partial class CppInvoke
    {
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr imgproc_getGaborKernel(Size ksize, double sigma, double theta, double lambd, double gamma, double psi, int ktype);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr imgproc_getStructuringElement(int shape, Size ksize, Point anchor);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void imgproc_cvtColor(IntPtr src, IntPtr dst, int code, int dstCn);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void imgproc_copyMakeBorder(IntPtr src, IntPtr dst, int top, int bottom, int left,
                                                         int right, int borderType, CvScalar value);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void imgproc_medianBlur(IntPtr src, IntPtr dst, int ksize);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void imgproc_GaussianBlur(IntPtr src, IntPtr dst, CvSize ksize, double sigmaX,
                                                       double sigmaY, int borderType);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void imgproc_bilateralFilter(IntPtr src, IntPtr dst, int d, double sigmaColor,
                                                          double sigmaSpace, int borderType);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void imgproc_adaptiveBilateralFilter(IntPtr src, IntPtr dst, Size ksize,
            double sigmaSpace, double maxSigmaColor, CvPoint anchor, int borderType);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void imgproc_boxFilter(IntPtr src, IntPtr dst, int ddepth, Size ksize, Point anchor,
                                                    int normalize, int borderType);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void imgproc_blur(IntPtr src, IntPtr dst, Size ksize, Point anchor, int borderType);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void imgproc_filter2D(IntPtr src, IntPtr dst, int ddepth, IntPtr kernel, Point anchor, double delta, int borderType);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void imgproc_sepFilter2D(IntPtr src, IntPtr dst, int ddepth, IntPtr kernelX, IntPtr kernelY, Point anchor, double delta, int borderType);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void imgproc_Sobel(IntPtr src, IntPtr dst, int ddepth,
            int dx, int dy, int ksize, double scale, double delta, int borderType);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void imgproc_Scharr(IntPtr src, IntPtr dst, int ddepth,
            int dx, int dy, double scale, double delta, int borderType);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void imgproc_Laplacian(IntPtr src, IntPtr dst, int ddepth,
            int ksize, double scale, double delta, int borderType);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void imgproc_Canny(IntPtr src, IntPtr edges,
            double threshold1, double threshold2, int apertureSize, int L2gradient);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void imgproc_eigen2x2([In] float[,] a, [Out] float[,] e, int n);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void imgproc_cornerEigenValsAndVecs(IntPtr src, IntPtr dst,int blockSize, int ksize, int borderType);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void imgproc_preCornerDetect(IntPtr src, IntPtr dst, int ksize, int borderType);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void imgproc_cornerSubPix(IntPtr image, IntPtr corners,
            Size winSize, Size zeroZone, CvTermCriteria criteria);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void imgproc_goodFeaturesToTrack(IntPtr src, IntPtr corners,
            int maxCorners, double qualityLevel, double minDistance, IntPtr mask, int blockSize, int useHarrisDetector, double k);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void imgproc_HoughLines(IntPtr src, IntPtr lines,
            double rho, double theta, int threshold, double srn, double stn);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void imgproc_HoughLinesP(IntPtr src, IntPtr lines,
            double rho, double theta, int threshold, double minLineLength, double maxLineG);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void imgproc_HoughCircles(IntPtr src, IntPtr circles,
            int method, double dp, double minDist, double param1, double param2, int minRadius, int maxRadius);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void imgproc_erode(IntPtr src, IntPtr dst, IntPtr kernel, Point anchor, int iterations, int borderType, CvScalar borderValue);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void imgproc_dilate(IntPtr src, IntPtr dst, IntPtr kernel, Point anchor, int iterations, int borderType, CvScalar borderValue);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void imgproc_morphologyEx(IntPtr src, IntPtr dst, int op, IntPtr kernel, Point anchor, int iterations, int borderType, CvScalar borderValue);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void imgproc_resize(IntPtr src, IntPtr dst, CvSize dsize, double fx, double fy, int interpolation);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void imgproc_warpAffine(IntPtr src, IntPtr dst, IntPtr M, CvSize dsize, int flags, int borderMode, CvScalar borderValue);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void imgproc_warpPerspective(IntPtr src, IntPtr dst, IntPtr M, CvSize dsize, int flags, int borderMode, CvScalar borderValue);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void imgproc_remap(IntPtr src, IntPtr dst, IntPtr map1, IntPtr map2, int interpolation, int borderMode, CvScalar borderValue);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void imgproc_convertMaps(IntPtr map1, IntPtr map2, IntPtr dstmap1, IntPtr dstmap2, int dstmap1Type, int nninterpolation);
        
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr imgproc_getRotationMatrix2D(CvPoint2D32f center, double angle, double scale);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void imgproc_invertAffineTransform(IntPtr M, IntPtr iM);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, EntryPoint = "imgproc_getPerspectiveTransform1")]
        public static extern IntPtr imgproc_getPerspectiveTransform(Point2f[] src, Point2f[] dst);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, EntryPoint = "imgproc_getPerspectiveTransform1")]
        public static extern IntPtr imgproc_getPerspectiveTransform(IntPtr src, IntPtr dst);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, EntryPoint = "imgproc_getAffineTransform1")]
        public static extern IntPtr imgproc_getAffineTransform(Point2f[] src, Point2f[] dst);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, EntryPoint = "imgproc_getAffineTransform2")]
        public static extern IntPtr imgproc_getAffineTransform(IntPtr src, IntPtr dst);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void imgproc_getRectSubPix(IntPtr image, Size patchSize, Point2f center, IntPtr patch, int patchType);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, EntryPoint = "imgproc_integral1")]
        public static extern void imgproc_integral(IntPtr src, IntPtr sum, int sdepth);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, EntryPoint = "imgproc_integral2")]
        public static extern void imgproc_integral(IntPtr src, IntPtr sum, IntPtr sqsum, int sdepth);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, EntryPoint = "imgproc_integral3")]
        public static extern void imgproc_integral(IntPtr src, IntPtr sum, IntPtr sqsum, IntPtr tilted, int sdepth);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void imgproc_accumulate(IntPtr src, IntPtr dst, IntPtr mask);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void imgproc_accumulateSquare(IntPtr src, IntPtr dst, IntPtr mask);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void imgproc_accumulateProduct(IntPtr src1, IntPtr src2, IntPtr dst, IntPtr mask);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void imgproc_accumulateWeighted(IntPtr src, IntPtr dst, double alpha, IntPtr mask);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern double imgproc_PSNR(IntPtr src1, IntPtr src2);

    }
}