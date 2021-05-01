#version 330 core

uniform mat4 transform;
in vec3 position;

void main()
{
    gl_Position = transform * vec4(position.x, position.y, position.z, 1f);
}
