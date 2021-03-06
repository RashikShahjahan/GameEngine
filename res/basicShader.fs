#version 330

in vec2 texCoord0;
in vec3 normal0;
out vec4 fragColor;

uniform sampler2D u_diffuse;
uniform vec3 u_ambientLight;

void main () {
    vec4 totalLight = vec4(u_ambientLight, 1);
    fragColor = texture2D(u_diffuse, texCoord0.xy) * clamp(dot(-vec3(1,1,1), normal0), 0.2, 1.0);
}
