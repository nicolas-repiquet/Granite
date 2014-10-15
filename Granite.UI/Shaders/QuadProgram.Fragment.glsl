#version 330

in vec2 relative_position;
flat in vec2 quad_size;

out vec4 fragment;

void main()
{
	fragment = vec4(relative_position / quad_size, 0, 1);
}
