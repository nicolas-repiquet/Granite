#version 330

flat in int f_border_thickness;
flat in int f_corner_radius;
flat in vec2 f_size;
flat in vec4 f_color;

in vec2 relative_position;

out vec4 fragment;

void main()
{
	fragment = f_color;
}
