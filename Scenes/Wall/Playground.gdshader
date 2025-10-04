// shader_type canvas_item;

// uniform vec2 player_pos; // sẽ set từ code
// uniform float radius = 32.0;
// uniform float fade_alpha = 0.4;

// void fragment() {
//     vec4 tex = texture(TEXTURE, UV);
    
//     float dist = distance(SCREEN_UV * SCREEN_PIXEL_SIZE, player_pos);
    
//     if (dist < radius) {
//         // Làm mờ khi player lại gần
//         float alpha = mix(fade_alpha, 1.0, dist / radius);
//         COLOR = vec4(tex.rgb, tex.a * alpha);
//     } else {
//         COLOR = tex;
//     }
// }
