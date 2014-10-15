#version 330
	
uniform sampler2D texture;	

in vec4 color;
in vec2 textureCoord;

out vec4 gl_FragColor;

void main(void)
{   
	vec4 v = texture2D(texture, textureCoord);
	gl_FragColor = v;
	//gl_FragColor = vec4(0, 0, 1, 1); 
	//gl_FragColor = color; 

}