﻿/*
The MIT License (MIT)
Copyright (c) 2018 Helix Toolkit contributors
*/
using System;
using SharpDX.Direct3D;
using SharpDX.Direct3D11;

#if !NETFX_CORE
namespace HelixToolkit.Wpf.SharpDX
#else
namespace HelixToolkit.UWP
#endif
{
    using Utilities;
    /// <summary>
    /// 
    /// </summary>
    public interface IGeometryBufferModel : IGUID, IDisposable
    {
        /// <summary>
        /// Gets or sets the geometry.
        /// </summary>
        /// <value>
        /// The geometry.
        /// </value>
        Geometry3D Geometry { get; set; }
        /// <summary>
        /// Gets or sets the topology.
        /// </summary>
        /// <value>
        /// The topology.
        /// </value>
        PrimitiveTopology Topology { set; get; }

        /// <summary>
        /// Occurs when [invalidate renderer].
        /// </summary>
        event EventHandler<bool> InvalidateRenderer;
        /// <summary>
        /// Gets the vertex buffer.
        /// </summary>
        /// <value>
        /// The vertex buffer.
        /// </value>
        IElementsBufferProxy VertexBuffer { get; }
        /// <summary>
        /// Gets the index buffer.
        /// </summary>
        /// <value>
        /// The index buffer.
        /// </value>
        IElementsBufferProxy IndexBuffer { get; }
        /// <summary>
        /// Attaches the buffers.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="vertexLayout">The vertex layout.</param>
        /// <param name="vertexBufferSlot">The vertex buffer slot.</param>
        /// <returns></returns>
        bool AttachBuffers(DeviceContext context, InputLayout vertexLayout, int vertexBufferSlot);
    }
    /// <summary>
    /// 
    /// </summary>
    public interface IBillboardBufferModel : IDisposable
    {
        /// <summary>
        /// Gets the texture view.
        /// </summary>
        /// <value>
        /// The texture view.
        /// </value>
        ShaderResourceView TextureView { get; }
        /// <summary>
        /// Gets the billboard type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        BillboardType Type { get; }
    }
}