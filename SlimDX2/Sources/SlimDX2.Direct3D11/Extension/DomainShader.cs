﻿// Copyright (c) 2007-2010 SlimDX Group
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;
using SlimDX2.D3DCompiler;

namespace SlimDX2.Direct3D11
{
    public partial class DomainShader
    {
        /// <summary>
        ///   Initializes a new instance of the <see cref = "T:SlimDX2.Direct3D11.DomainShader" /> class.
        /// </summary>
        /// <param name = "device">The device used to create the shader.</param>
        /// <param name = "shaderBytecode">The compiled shader bytecode.</param>
        public DomainShader(Device device, ShaderBytecode shaderBytecode)
            : this(device, shaderBytecode, null)
        {
        }

        /// <summary>
        ///   Initializes a new instance of the <see cref = "T:SlimDX2.Direct3D11.DomainShader" /> class.
        /// </summary>
        /// <param name = "device">The device used to create the shader.</param>
        /// <param name = "shaderBytecode">The compiled shader bytecode.</param>
        /// <param name = "linkage">A dynamic class linkage interface.</param>
        public DomainShader(Device device, ShaderBytecode shaderBytecode, ClassLinkage linkage)
            : base(IntPtr.Zero)
        {
            DomainShader temp;
            device.CreateDomainShader(shaderBytecode.GetBufferPointer(),
                                      shaderBytecode.GetBufferSize(), linkage, out temp);
            NativePointer = temp.NativePointer;
        }
    }
}