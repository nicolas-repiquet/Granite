#version 110

uniform mat4 transform;

attribute vec2 position;
attribute vec2 texcoord;

varying vec2 uv;

void main()
{
	uv = texcoord;
    gl_Position = transform * vec4(position, 0.0, 1.0);
}
