﻿#version 330 core

uniform vec3 color;

out vec4 FragColor;

void main()
{
    FragColor = vec4(color.r, color.g, color.b, 1.0f);
}