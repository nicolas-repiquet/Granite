#version 330

in vec2 vertex;
in mat3x2 transform;
in vec4 color;
in vec2 texture_coordinates0;
in vec2 texture_coordinates1;
in int texture;

flat out vec4 f_color;
flat out int f_texture;
out vec2 f_texture_coordinates;

void main()
{
	f_color = color;
	f_texture = texture;

	f_texture_coordinates = mix(texture_coordinates0, texture_coordinates1, vertex);

    gl_Position = vec4((transform * vec3(vertex, 1)).xy, 0, 1);
}