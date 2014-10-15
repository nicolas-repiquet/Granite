#version 330

uniform ivec2 screen_size;

in vec2 vertex;
in vec2 size;
in vec2 position;

out vec2 relative_position;

flat out vec2 quad_size;

const vec2 factor = vec2(0.5, 0.5);

void main()
{
	relative_position = vertex * size;
	quad_size = size;

    gl_Position = new vec4(
		(position + relative_position) / (screen_size * factor) - 1,
		0,
		1
	);
}