#version 330
	
uniform sampler2D texture;	
uniform sampler2D texture2;	

in vec4 color;
in float progress;
in vec2 textureCoord;

out vec4 gl_FragColor;

void main(void)
{   
	vec4 v = texture2D(texture, textureCoord);
	vec4 colorText = texture2D(texture2, vec2(progress, 0));
	//gl_FragColor = v;
	//gl_FragColor = vec4(1, 0.2, 0.1, v.r);
	gl_FragColor = vec4(colorText.r, colorText.g, colorText.b, colorText.a * v.r);
	//gl_FragColor = vec4(0, 0, 1, 1); 
	//gl_FragColor = color; 

}