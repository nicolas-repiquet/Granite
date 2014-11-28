#version 330

uniform mat4 projection;

in vec3 positionAttrib;
in vec4 colorAttrib;

out vec4 color;

void main(void)
{
	color = colorAttrib;

	vec4 pos =  projection * (vec4(positionAttrib, 1));

    gl_Position = pos;

}
