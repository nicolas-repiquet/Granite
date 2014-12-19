#version 330
	
//uniform sampler2D texture;	

in vec4 colorOut;
in vec2 textureCoordOut;

out vec4 gl_FragColor;

void main(void)
{   
	//vec4 v = texture2D(texture, textureCoordOut);

	gl_FragColor = colorOut;
}