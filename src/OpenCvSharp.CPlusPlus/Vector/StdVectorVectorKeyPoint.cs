﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using OpenCvSharp.Utilities;

namespace OpenCvSharp.CPlusPlus
{
    /// <summary>
    /// 
    /// </summary>
    internal class StdVectorVectorKeyPoint : DisposableCvObject, IStdVector
    {
        /// <summary>
        /// Track whether Dispose has been called
        /// </summary>
        private bool disposed = false;

        #region Init and Dispose
        /// <summary>
        /// 
        /// </summary>
        public StdVectorVectorKeyPoint()
        {
            ptr = CppInvoke.vector_vector_KeyPoint_new1();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="size"></param>
        public StdVectorVectorKeyPoint(int size)
        {
            if (size < 0)
                throw new ArgumentOutOfRangeException("size");
            ptr = CppInvoke.vector_vector_KeyPoint_new2(new IntPtr(size));
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">
        /// If disposing equals true, the method has been called directly or indirectly by a user's code. Managed and unmanaged resources can be disposed.
        /// If false, the method has been called by the runtime from inside the finalizer and you should not reference other objects. Only unmanaged resources can be disposed.
        /// </param>
        protected override void Dispose(bool disposing)
        {
            if (!disposed)
            {
                try
                {
                    if (IsEnabledDispose)
                    {
                        CppInvoke.vector_vector_KeyPoint_delete(ptr);
                    }
                    disposed = true;
                }
                finally
                {
                    base.Dispose(disposing);
                }
            }
        }
        #endregion

        #region Properties
        /// <summary>
        /// vector.size()
        /// </summary>
        public int Size1
        {
            get { return CppInvoke.vector_vector_KeyPoint_getSize1(ptr).ToInt32(); }
        }
        public int Size { get { return Size1; } }
        /// <summary>
        /// vector.size()
        /// </summary>
        public int[] Size2
        {
            get
            {
                int size1 = Size1;
                IntPtr[] size2Org = new IntPtr[size1];
                CppInvoke.vector_vector_KeyPoint_getSize2(ptr, size2Org);
                int[] size2 = new int[size1];
                for (int i = 0; i < size1; i++)
                {
                    size2[i] = size2Org[i].ToInt32();
                }
                return size2;
            }
        }
        

        /// <summary>
        /// &amp;vector[0]
        /// </summary>
        public IntPtr ElemPtr
        {
            get { return CppInvoke.vector_vector_KeyPoint_getPointer(ptr); }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Converts std::vector to managed array
        /// </summary>
        /// <returns></returns>
        public KeyPoint[][] ToArray()
        {
            int size1 = Size1;
            if (size1 == 0)
                return new KeyPoint[0][];
            int[] size2 = Size2;

            KeyPoint[][] ret = new KeyPoint[size1][];
            for (int i = 0; i < size1; i++)
            {
                ret[i] = new KeyPoint[size2[i]];
            }
            using (ArrayAddress2<KeyPoint> retPtr = new ArrayAddress2<KeyPoint>(ret))
            {
                CppInvoke.vector_vector_KeyPoint_copy(ptr, retPtr);
            }
            return ret;
        }
        #endregion
    }
}
