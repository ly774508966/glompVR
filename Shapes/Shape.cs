﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;
using OpenTK;

public abstract class Shape
{
    private Vector3[] vertices, normals;
    private Vector2[] texcoords;
    private int[] indices;
    private int[] colors;
	private float[] vertexData;

    public Vector3[] Vertices
    {
        get { return vertices; }
        protected set
        {
            vertices = value;
        }
    }

    public Vector3[] Normals
    {
        get { return normals; }
        protected set
        {
            normals = value;
        }
    }

    public Vector2[] Texcoords
    {
        get { return texcoords; }
        protected set
        {
            texcoords = value;
        }
    }

    public int[] Indices
    {
        get { return indices; }
        protected set
        {
            indices = value;
        }
    }

    public int[] Colors
    {
        get { return colors; }
        protected set
        {
            colors = value;
        }
    }

	public float[] VertexData
	{
		get { return vertexData; }
		protected set
		{
			vertexData = value;
		}
	}
}