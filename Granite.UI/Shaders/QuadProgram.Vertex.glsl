#version 330

uniform ivec2 screen_size;

in vec2 vertex;
in vec2 size;
in vec2 position;
in vec4 color;
in int border_thickness;
in int corner_radius;

flat out int f_border_thickness;
flat out int f_corner_radius;
flat out vec2 f_size;
flat out vec4 f_color;

out vec2 relative_position;

const vec2 factor = vec2(0.5, 0.5);

void main()
{
	f_border_thickness = border_thickness;
	f_corner_radius = corner_radius;
	f_size = size;
	f_color = color;

	relative_position = vertex * size;

    gl_Position = new vec4(
		(position.x + vertex.x * size.x) / screen_size.x * 2 - 1, 
		(position.y + vertex.y * size.y) / screen_size.y * 2 - 1, 
		0,
		1
	);
}