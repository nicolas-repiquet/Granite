#version 330

in vec4 color;

out vec4 gl_FragColor;

void main(void)
{   
	//gl_FragColor = v;
	//gl_FragColor = vec4(1, 0, 0, 1); 
	gl_FragColor = color; 

}