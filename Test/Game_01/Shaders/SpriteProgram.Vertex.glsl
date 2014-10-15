#version 330

uniform mat4 projection;

in vec3 positionAttrib;
in vec4 colorAttrib;
in mat4 transformAttrib;
in vec2 textCoordAttrib0;
in vec2 textCoordAttrib1;
in vec2 textCoordAttrib2;
in vec2 textCoordAttrib3;

out vec4 color;
out vec2 textureCoord;

void main(void)
{
	color = colorAttrib;

	if(gl_VertexID == 0)
	{
		textureCoord = textCoordAttrib0;
	}
	else if(gl_VertexID == 1)
	{
		textureCoord = textCoordAttrib1;
	}
	else if(gl_VertexID == 2)
	{
		textureCoord = textCoordAttrib2;
	}
	else if(gl_VertexID == 3)
	{
		textureCoord = textCoordAttrib3;
	}
	vec4 pos =  projection * (transformAttrib * vec4(positionAttrib, 1));
	//pos = vec4(textureCoord, 0, 1);
    gl_Position = pos;

}
