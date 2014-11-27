#version 330

uniform sampler2D texture0;
uniform sampler2D texture1;
uniform sampler2D texture2;
uniform sampler2D texture3;
uniform sampler2D texture4;
uniform sampler2D texture5;
uniform sampler2D texture6;
uniform sampler2D texture7;

flat in vec4 f_color;
flat in int f_texture;

in vec2 f_texture_coordinates;

out vec4 fragment;

void main()
{
	if(f_texture == -1) 
	{
		fragment = f_color;
	} 
	else if(f_texture == 0)
	{
		fragment = texture2D(texture0, f_texture_coordinates) * f_color;
	}
	else if(f_texture == 1)
	{
		fragment = texture2D(texture1, f_texture_coordinates) * f_color;
	}
	else if(f_texture == 2)
	{
		fragment = texture2D(texture2, f_texture_coordinates) * f_color;
	}
	else if(f_texture == 3)
	{
		fragment = texture2D(texture3, f_texture_coordinates) * f_color;
	}
	else if(f_texture == 4)
	{
		fragment = texture2D(texture4, f_texture_coordinates) * f_color;
	}
	else if(f_texture == 5)
	{
		fragment = texture2D(texture5, f_texture_coordinates) * f_color;
	}
	else if(f_texture == 6)
	{
		fragment = texture2D(texture6, f_texture_coordinates) * f_color;
	}
	else if(f_texture == 7)
	{
		fragment = texture2D(texture7, f_texture_coordinates) * f_color;
	}
}
