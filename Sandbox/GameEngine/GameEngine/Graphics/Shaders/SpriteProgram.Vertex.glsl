#version 330

uniform mat4 projection;

in vec3 positionAttrib;
in vec4 colorAttrib;
in mat4 transformAttrib;
in vec2 textOriginAttrib;
in vec2 textTargetAttrib;

out vec4 color;
out vec2 textureCoord;

void main(void)
{
	color = colorAttrib;

	if(gl_VertexID == 0)
	{
		textureCoord = vec2(textOriginAttrib.x, textTargetAttrib.y);
	}
	else if(gl_VertexID == 1)
	{
		textureCoord = vec2(textOriginAttrib.x, textOriginAttrib.y);
	}
	else if(gl_VertexID == 2)
	{
		textureCoord = vec2(textTargetAttrib.x, textOriginAttrib.y);
	}
	else if(gl_VertexID == 3)
	{
		textureCoord = vec2(textTargetAttrib.x, textTargetAttrib.y);
	}

	vec4 pos =  projection * (transformAttrib * vec4(positionAttrib, 1));
    gl_Position = pos;

}
