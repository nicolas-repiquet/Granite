#version 330

uniform mat4 projection;

in vec2 position;
in vec4 color;
in vec2 textCoordinates;

out vec4 colorOut;
out vec2 textureCoordOut;

void main(void)
{
	colorOut = color;
	textureCoordOut = textCoordinates;

	vec4 pos =  projection * vec4(position, 0, 1);

    gl_Position = pos;
}
